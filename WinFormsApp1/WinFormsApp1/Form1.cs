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

            
            RTXTBX1.Text = String.Format("" +
                "*****************************************************************************\n" +
                "*               \t                    Unit Info                  \t\t         *\n" +
                "*****************************************************************************\n\n" +
                "OS Infomation:\n{0}\n" +
                "Network Information:\n" +
                "Hostname - {1}\n" +
                "Ip Addresses: {2}\n" +
                "User Information:\n{3}" 
               , osInfo, hostName, unitController.printList(ipAddresses), unitController.printList(users));

        }
    }
}
