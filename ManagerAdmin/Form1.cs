﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLExit_Click(object sender, EventArgs e)
        {  
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            MainManager frm = new MainManager();
            frm.Show();
            this.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
