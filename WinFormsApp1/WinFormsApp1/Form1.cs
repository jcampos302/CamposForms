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
        public frmUserInfo(UnitController unitController)
        {
            InitializeComponent();
            this.unitController = unitController;
            LoadUsersDropDown();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CKBX1_Click(object sender, EventArgs e)
        {
             
            
        }
    }
}
