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
    public partial class FormWindowsVPNSorter : Form
    {
        public List<VPNEntry> LoadedVPNEntries { get; set; } = new List<VPNEntry>();
        public FormWindowsVPNSorter() => InitializeComponent();

        private void FormWindowsVPNSorter_Shown(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            LoadVPNEntrys();
        }

        private void btnSortAZ_Click(object sender, EventArgs e) => GetAndSortVPNEntrys();
        private void btnOpenDirectory_Click(object sender, EventArgs e) => VpnSorter.OpenPBKDirectory();
        private void btnOpenBackupDirectory_Click(object sender, EventArgs e) => VpnSorter.OpenPBKBackupDirectory();
        private void btnMoveUp_Click(object sender, EventArgs e) => lbOutputVPNList.MoveSelectedItemUp();
        private void btnMoveDown_Click(object sender, EventArgs e) => lbOutputVPNList.MoveSelectedItemDown();
        private void btnSave_Click(object sender, EventArgs e) => SaveOutputListToPbk();
        private void lbVPNList_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is VPNEntry sectionData)
                e.Value = sectionData.Name;
        }

        private void LoadVPNEntrys()
        {
            try
            {
                PbkReaderWriter reader = new PbkReaderWriter();
                if (!reader.ReadFile())
                {
                    MessageBox.Show("Error on file opening or vpn phone book entry parsing!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Enabled = false;
                    return;
                }

                lbInputVPNList.BeginUpdate();
                LoadedVPNEntries = reader.VPNEntries;
                foreach (VPNEntry? oneEntry in reader.VPNEntries)
                    lbInputVPNList.Items.Add(oneEntry);
                lbInputVPNList.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error on file opening or vpn phone book entry parsing!\nError:\n{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetAndSortVPNEntrys()
        {
            try
            {
                lbOutputVPNList.BeginUpdate();
                lbOutputVPNList.Items.Clear();
                List<VPNEntry>? orderedVPNList = LoadedVPNEntries.OrderBy(x => x.Name).ToList();
                foreach (VPNEntry? oneEntry in orderedVPNList)
                    lbOutputVPNList.Items.Add(oneEntry);
                lbOutputVPNList.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error on sort vpn phone book entrys!\nError:\n{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            btnSave.Enabled = true;
        }
        private void SaveOutputListToPbk()
        {
            try
            {
                if (VpnSorter.CreatePBKBackup())
                {
                    PbkReaderWriter writer = new PbkReaderWriter(lbOutputVPNList.Items.OfType<VPNEntry>().ToList());
                    writer.WriteFile();
                    
                    if (MessageBox.Show("Save successed!\n\nYou want to open the vpn list?", "Save successed", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        OpenVPNNetworkList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error on sort save phone book entrys!\nError:\n{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void OpenVPNNetworkList()
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = "ms-settings:network-vpn";
            System.Diagnostics.Process.Start(psi);
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();
    }
}