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
        // Private Objs
        private UnitController unitController;
        private MenuStrip mainMenu;

        // Form Window
        public FORM(UnitController unitController)
        {
            InitializeComponent();
            this.unitController = unitController;
            mainMenu = new MenuStrip();
            this.MainMenuStrip = mainMenu;
            this.Controls.Add(mainMenu);
            ToolStripMenuItem mnuExport = new ToolStripMenuItem("Export");
            this.MainMenuStrip.Items.Add(mnuExport);
            ToolStripMenuItem miBinary = new ToolStripMenuItem("Binnary");
            ToolStripMenuItem miXML = new ToolStripMenuItem("XML");
            ToolStripMenuItem miJSON = new ToolStripMenuItem("JSON");
            mnuExport.DropDownItems.Add(miBinary);
            mnuExport.DropDownItems.Add(miXML);
            mnuExport.DropDownItems.Add(miJSON);

            ToolStripMenuItem mnuHelp = new ToolStripMenuItem("Help");
            this.MainMenuStrip.Items.Add(mnuHelp);
            ToolStripMenuItem miAbout = new ToolStripMenuItem("About");
            mnuHelp.DropDownItems.Add(miAbout);
            
            miBinary.Click += MiBinary_Click;
            miXML.Click += MiXML_Click;
            miJSON.Click += MiJSON_Click;
            miAbout.Click += MiAbout_Click;
        }
        
        // About Window
        private void MiAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a .Net Programming Assignment that\n allows a user to save a unit's info.");
        }

        // Exports to Binary 
        private void MiBinary_Click(object sender, EventArgs e)
        {
            if (!CKBX1.Checked && !CKBX2.Checked && !CKBX3.Checked)
            {
                MessageBox.Show("Please Enter an Option in Settings");
            }
            else
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

                    // Checks if object is created
                    if (unitController.GetUnit() != null)
                    {
                        ds.BinarySerialize(unitController.GetUnit(), fname);
                        MessageBox.Show("Successfully exported file: " + fname);
                    }
                    else
                    {
                        MessageBox.Show("Failed to export file...");
                    }
                }
            }

            
        }

        private void MiXML_Click(object sender, EventArgs e)
        {
            if (!CKBX1.Checked && !CKBX2.Checked && !CKBX3.Checked)
            {
                MessageBox.Show("Please Enter an Option in Settings");
            }
            else
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

                    // Checks if Obj Created
                    if (unitController.GetUnit() != null)
                    {
                        ds.XmlSerialize(typeof(Unit), unitController.GetUnit(), fname);
                        MessageBox.Show("Successfully exported file: " + fname);
                    }
                    else
                    {
                        MessageBox.Show("Failed to export file...");
                    }
                }
            }

            
        }

        private void MiJSON_Click(object sender, EventArgs e)
        {
            if (!CKBX1.Checked && !CKBX2.Checked && !CKBX3.Checked)
            {
                MessageBox.Show("Please Enter an Option in Settings");
            }
            else
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

                    // Checks if obj created
                    if (unitController.GetUnit() != null)
                    {
                        ds.JsonSerialize(unitController.GetUnit(), fname);
                        MessageBox.Show("Successfully exported file: " + fname);
                    }
                    else
                    {
                        MessageBox.Show("Failed to export file...");
                    }

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
                users = unitController.GetUsernames();
            }
            
            if (!CKBX1.Checked && !CKBX2.Checked && !CKBX3.Checked)
            {
                MessageBox.Show("Please Enter an Option in Settings");
            }
            else
            {
                // Creates Obj
                unitController.CreateUnit(osInfo, hostName, ipAddresses, users);

                // Text box dialog
                string start = "STARTING PROGRAM\n\n";
                string end = "\n\nPROGRAM FINISHED";
                RTXTBX1.Text = start + unitController.GetUnit() + end;

            }
            
            
        }
      
    }
}
