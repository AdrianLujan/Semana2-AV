﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string[] users = { "Adrian" };

            string usuario = "adrian";
            string pass = "tecsup123";

            if (txtUsuario.Text.Equals(usuario) && txtPassword.Text.Equals(pass))
            {
                PrincipalMDI principal = new PrincipalMDI();
                principal.Show();
                this.Hide();
            } 
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
