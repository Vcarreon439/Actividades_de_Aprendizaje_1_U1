﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividades_de_Aprendizaje_1_U1
{
    public partial class prog3 : Form
    {
        public prog3()
        {
            InitializeComponent();
        }

        private void btnDibujar_Click(object sender, EventArgs e)
        {
            Dibujo db = new Dibujo();
            db.Dibujar_Diana(ref pictureBox1, 5, 5);
        }

        private void btnDibujar_Click2(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                int[] valores = { int.Parse(txtCoordX.Text), int.Parse(txtCoordY.Text), int.Parse(txtSize.Text)};

                Dibujo db = new Dibujo();
                db.Dibujar_Diana(ref pictureBox1, valores[0], valores[1], null,valores[2]);
            }
            
        }

        private bool ValidarCampos() 
        {
            bool compro = false;

            try
            {
                if (txtCoordX.Text==""|txtCoordY.Text==""|txtSize.Text=="")
                    compro = false;
                else
                    compro = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return compro;
        }

        private void CambiarVisible()
        {
            if (tabAvanzado.Visible)
            {
                tabAvanzado.Visible = false;

                btnDibujar.Click -= new EventHandler(btnDibujar_Click2);
                btnDibujar.Click += new EventHandler(btnDibujar_Click);

                btnAvanzado.Text = "Modo Avanzado";
            }
            else
            { 
                tabAvanzado.Visible = true;
                btnDibujar.Click -= new EventHandler(btnDibujar_Click);
                btnDibujar.Click += new EventHandler(btnDibujar_Click2);
                btnAvanzado.Text = "Modo Básico";
            }

        }

        private void btnAvanzado_Click(object sender, EventArgs e)
        {
            CambiarVisible();
        }
    }
}