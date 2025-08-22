using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerDeProgramacion2.Práctico_2
{
    public partial class Pequeño_Formulario : Form
    {
        public Pequeño_Formulario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask;

            if (string.IsNullOrEmpty(TApellido.Text) || string.IsNullOrEmpty(TNombre.Text) || string.IsNullOrEmpty(TDni.Text) || string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("Debe completar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ask = (MsgBoxResult)MessageBox.Show("Seguro que desea insertar un nuevo Cliente?", "Confirmar insercion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

            if (ask == MsgBoxResult.No)
            {
                return;
            }
            else
            {
                Lmodificar.Text = TApellido.Text + " " + TNombre.Text;
                MessageBox.Show("El cliente: " + Lmodificar.Text + " se insertó correctamente", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {
            if (TDni == null)
            {
                MessageBox.Show("Debe ingresar un dni");
            }
        }

        private void onlyDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingresen caracteres no numéricos
            }
        }

        private void onlyLetters_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true; // Evita que se ingresen caracteres no alfabéticos
            }
        }

        private void TEleminar_Click(object sender, EventArgs e)
        {
            MsgBoxResult ask;

            ask = (MsgBoxResult)MessageBox.Show("Está apunto de eliminar el Cliente: " + Lmodificar.Text, "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

            if (ask == MsgBoxResult.No)
            {
                return;
            }
            else
            {
                TDni.Clear();
                TNombre.Clear();
                TApellido.Clear();
                txtTelefono.Clear();
                MessageBox.Show("El cliente: " + Lmodificar.Text + " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Lmodificar.Text = "modificar";
            }

        }

        private void RBVaron_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Practico3.Properties.Resources.maleUser;
        }

        private void RBMujer_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Practico3.Properties.Resources.femaleUser;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
