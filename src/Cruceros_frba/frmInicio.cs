﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FrbaCrucero.UserLogin;
using FrbaCrucero.FormsPrincipales;
using CapaDatos;

namespace FrbaCrucero
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPrincipalCliente frm = new frmPrincipalCliente();
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            
        }
    }
}
