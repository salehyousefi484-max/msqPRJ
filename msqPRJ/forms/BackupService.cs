using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace msqPRJ.forms
{
    public static class BackupService
    {
        private static string Q(string name)
        {
            return "[" + name.Replace("]", "]]") + "]";
        }

        private static void BackupTo(string file)
        {
            using (var con = new SqlConnection(AppPaths.ConnString))
            using (var cmd = new SqlCommand(
                "BACKUP DATABASE " + Q(AppPaths.DbName) + " TO DISK = @path WITH INIT, CHECKSUM", con))
            {
                cmd.Parameters.AddWithValue("@path", file);
                cmd.CommandTimeout = 300;
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public static string CreateBackup(string folder, int keepCount)
        {
            Directory.CreateDirectory(folder);

            DateTime now = DateTime.Now;
            string name = "backup-"
                + DateHelper.ToShamsi(now).Replace("/", "-")
                + "_" + now.ToString("HH-mm-ss") + ".bak";
            string dst = Path.Combine(folder, name);

            BackupTo(dst);
            DeleteOldBackups(folder, keepCount);
            return dst;
        }

        private static void DeleteOldBackups(string folder, int keepCount)
        {
            var old = new DirectoryInfo(folder)
                .GetFiles("backup-*.bak")
                .OrderByDescending(f => f.CreationTime)
                .Skip(keepCount);

            foreach (var f in old)
                f.Delete();
        }

        public static void Restore(string backupFile, string safetyFolder)
        {
            if (string.IsNullOrWhiteSpace(safetyFolder))
                throw new InvalidOperationException("اول پوشه‌ی بکاپ را در تنظیمات انتخاب کنید.");

            Directory.CreateDirectory(safetyFolder);
            BackupTo(Path.Combine(safetyFolder,
                "before-restore-" + DateTime.Now.ToString("yyyyMMdd-HHmmss") + ".bak"));

            SqlConnection.ClearAllPools();
            string db = Q(AppPaths.DbName);

            using (var con = new SqlConnection(AppPaths.MasterConnString))
            {
                con.Open();

                using (var cmd = new SqlCommand(
                    "ALTER DATABASE " + db + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE", con))
                {
                    cmd.ExecuteNonQuery();
                }

                try
                {
                    using (var cmd = new SqlCommand(
                        "RESTORE DATABASE " + db + " FROM DISK = @path WITH REPLACE", con))
                    {
                        cmd.Parameters.AddWithValue("@path", backupFile);
                        cmd.CommandTimeout = 300;
                        cmd.ExecuteNonQuery();
                    }
                }
                finally
                {
                    using (var cmd = new SqlCommand(
                        "ALTER DATABASE " + db + " SET MULTI_USER", con))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
