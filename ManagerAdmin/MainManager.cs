using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagerAdmin
{
    public partial class MainManager : Form
    {
        public MainManager()
        {
            InitializeComponent();
        }

        private void p_User_MouseClick(object sender, MouseEventArgs e)
        {
            frm_User frm = new frm_User();
            frm.Show();
        }

        private void p_Product_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Product frm = new frm_Product();
            frm.Show();
        }

        private void p_Cate_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Cate frm = new frm_Cate();
            frm.Show();
        }

        private void p_Sub_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Sub frm = new frm_Sub();
            frm.Show();
        }

        private void p_Bill_MouseClick(object sender, MouseEventArgs e)
        {
            frm_Bill frm = new frm_Bill();
            frm.Show();
        }

        private void MainManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
