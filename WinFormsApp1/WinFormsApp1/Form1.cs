using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public FORM(UnitController unitController)
        {
            InitializeComponent();
            this.unitController = unitController;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BTN1_Click(object sender, EventArgs e)
        {
            UnitController unitController = this.unitController;
            string osInfo = "";
            string hostName = "";
            string path = "C:\\temp\\unit.";
            List<string> ipAddresses = new List<string>();
            List<string> users = new List<string>();
            DataSerializer ds = new DataSerializer();

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
            
            RTXTBX1.Text = unitController.addUnit(osInfo, hostName, ipAddresses, users);

            if (CKBX4.Checked)
            {
                ds.BinarySerialize(unitController.addUnit(osInfo, hostName, ipAddresses, users), path + "bin");
            }
            if (CKBX4.Checked)
            {
                ds.XmlSerialize(typeof(string), RTXTBX1.Text, path + "xml");
            }
            if (CKBX5.Checked)
            {
                ds.JsonSerialize(unitController.addUnit(osInfo, hostName, ipAddresses, users), path + "json");
            }

            
            
            
        }
    }
}
