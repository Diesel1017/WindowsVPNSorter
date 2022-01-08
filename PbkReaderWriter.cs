using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsVPNSorter
{
    public class PbkReaderWriter
    {
        private static readonly string DefaultFullPathRasphonePbk = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Microsoft\\Network\\Connections\\Pbk\\rasphone.pbk");

        public List<VPNEntry> VPNEntries = new List<VPNEntry>();

        public PbkReaderWriter()
        {
        }

        public PbkReaderWriter(List<VPNEntry> vpnEntries)
        {
            VPNEntries = vpnEntries;
        }

        public bool ReadFile(string? fullPath = null)
        {
            if (fullPath == null)
                fullPath = DefaultFullPathRasphonePbk;

            if (!File.Exists(fullPath))
                throw new FileNotFoundException("Rasphone pbk file not found!", DefaultFullPathRasphonePbk);


            string fileContent = System.IO.File.ReadAllText(fullPath);

            ParseFileContent(fileContent);

            return true;
        }

        private void ParseFileContent(string fileContent)
        {
            using (StringReader reader = new StringReader(fileContent))
            {
                VPNEntry? entry = null;
                while (reader.ReadLine() is String lineContent)
                {
                    if (lineContent.StartsWith("["))
                    {
                        entry = new VPNEntry(lineContent.Substring(1, lineContent.IndexOf("]") - 1));
                        VPNEntries.Add(entry);
                        continue;
                    }

                    if (entry != null)
                        entry.ConfigurationLines.Add(lineContent);
                }
            }
        }


        public bool WriteFile(string? fullPath = null)
        {
            StringBuilder sbOutput = new StringBuilder();
            foreach (VPNEntry oneEntry in VPNEntries)
                sbOutput.Append(oneEntry.GetFullEntryString());

            if (fullPath == null)
                fullPath = DefaultFullPathRasphonePbk;

            File.WriteAllText(fullPath, sbOutput.ToString());

            return true;
        }
    }
}