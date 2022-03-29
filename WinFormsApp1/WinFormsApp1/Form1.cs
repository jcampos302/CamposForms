using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FORM : Form
    {
        private UnitController unitController;
        private MenuStrip mainMenu;
        public FORM(UnitController unitController)
        {
            InitializeComponent();
            this.unitController = unitController;
            mainMenu = new MenuStrip();
            this.MainMenuStrip = mainMenu;
            this.Controls.Add(mainMenu);
            ToolStripMenuItem mnuExport = new ToolStripMenuItem("Export");
            this.MainMenuStrip.Items.Add(mnuExport);
            ToolStripMenuItem miBinnary = new ToolStripMenuItem("Binnary");
            ToolStripMenuItem miXML = new ToolStripMenuItem("XML");
            ToolStripMenuItem miJSON = new ToolStripMenuItem("JSON");
            mnuExport.DropDownItems.Add(miBinnary);
            mnuExport.DropDownItems.Add(miXML);
            mnuExport.DropDownItems.Add(miJSON);

            ToolStripMenuItem mnuHelp = new ToolStripMenuItem("Help");
            this.MainMenuStrip.Items.Add(mnuHelp);
            ToolStripMenuItem miAbout = new ToolStripMenuItem("About");
            mnuHelp.DropDownItems.Add(miAbout);
            
            miBinnary.Click += MiBinnary_Click;
            miXML.Click += MiXML_Click;
            miJSON.Click += MiJSON_Click;
            miAbout.Click += MiAbout_Click;
        }
        private void MiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a .Net Programming Assignment that\n allows a user to save a unit's info.");
        }

        private void MiBinnary_Click(object sender, EventArgs e)
        {
            UnitController unitController = this.unitController;
            DataSerializer ds = new DataSerializer();
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.InitialDirectory = "c:\\temp";
            dlgSave.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.RestoreDirectory = true;
            String fname;
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                fname = dlgSave.FileName;

                if (unitController.GetUnitsAsString() != null)
                {
                    ds.BinarySerialize(unitController.getUnits(), fname);
                    MessageBox.Show("Successfully exported file: {}", fname);
                }
                else
                {
                    MessageBox.Show("Failed to export file...");
                }
            }
        }

        private void MiXML_Click(object sender, EventArgs e)
        {
            UnitController unitController = this.unitController;
            DataSerializer ds = new DataSerializer();
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.InitialDirectory = "c:\\temp";
            dlgSave.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.RestoreDirectory = true;
            String fname;
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                fname = dlgSave.FileName;

                if (unitController.GetUnitsAsString() != null)
                {
                    ds.XmlSerialize(typeof(Unit),unitController.getUnits(), fname);
                    MessageBox.Show("Successfully exported file: {}", fname);
                }
                else
                {
                    MessageBox.Show("Failed to export file...");
                }
            }
        }

        private void MiJSON_Click(object sender, EventArgs e)
        {
            UnitController unitController = this.unitController;
            DataSerializer ds = new DataSerializer();
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.InitialDirectory = "c:\\temp";
            dlgSave.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            dlgSave.FilterIndex = 1;
            dlgSave.RestoreDirectory = true;
            String fname;
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                fname = dlgSave.FileName;

                if (unitController.GetUnitsAsString() != null) 
                {
                    ds.JsonSerialize(unitController.getUnits(), fname);
                    MessageBox.Show("Successfully exported file: {}", fname);
                }
                else
                {
                    MessageBox.Show("Failed to export file...");
                }

            }
        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            UnitController unitController = this.unitController;
            string osInfo = "";
            string hostName = "";
            List<string> ipAddresses = new List<string>();
            List<string> users = new List<string>();

            if (CKBX1.Checked)
            {
                osInfo = unitController.getOsInfo();
            }
            if (CKBX2.Checked)
            {
                hostName = unitController.getHostname();
                ipAddresses = unitController.getIpAddresses(hostName);
            }
            if (CKBX3.Checked)
            {
                users = unitController.getUsernames();
            }
            
            unitController.addUnit(osInfo,hostName,ipAddresses,users);

            string start = "STARTING PROGRAM\n\n";
            string end = "\n\nPROGRAM FINISHED";
            RTXTBX1.Text = start + unitController.GetUnitsAsString() + end;
            
        }
      
    }
}
