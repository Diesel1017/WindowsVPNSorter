using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsVPNSorter
{
    public static class VpnSorter
    {
        private static string FullPathRasphonePBK = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft\\Network\\Connections\\Pbk\\rasphone.pbk");
        private static string FullPathBackupDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft\\Network\\Connections\\Pbk_Backup");
        private static string FileNameBackup = $"rasphone_{DateTime.Now:yyyyMMdd_HHmmss}.backup";

        public static void OpenPBKDirectory()
        {
            System.Diagnostics.Process.Start("explorer.exe", "/select," + FullPathRasphonePBK);
        }
        public static void OpenPBKBackupDirectory()
        {
            System.Diagnostics.Process.Start("explorer.exe", "/open," + FullPathBackupDirectory);
        }

        public static bool CreatePBKBackup()
        {
            System.IO.Directory.CreateDirectory(FullPathBackupDirectory);
            string fullbackupPath = Path.Combine(FullPathBackupDirectory, FileNameBackup);
            File.Copy(FullPathRasphonePBK, fullbackupPath, true);
            return true;
        }
    }
}