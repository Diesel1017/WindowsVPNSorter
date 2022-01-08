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
    public class VPNEntry
    {
        public string Name { get; set; }
        public List<string> ConfigurationLines { get; set; } = new List<string>();

        public VPNEntry(string name)
        {
            Name = name;
        }

        public string GetFullEntryString()
        { 
            StringBuilder sbEntry = new StringBuilder();
            sbEntry.Append("[").Append(Name).AppendLine("]");
            foreach (string? oneConfigLine in ConfigurationLines)
                sbEntry.AppendLine(oneConfigLine);

            return sbEntry.ToString();
        }
    }
}