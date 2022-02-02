using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCifrado
{
    public partial class FormCifrado : Form
    {
        public FormCifrado()
        {
            InitializeComponent();
        }

        private void btn_Cifrar_Click(object sender, EventArgs e)
        {
            string Texto, Password, Vector;
            int interaccion;
            try
            {
                Texto = txt_TextoaCifrar.Text;
                Password = txt_Password.Text;
                Vector = txt_Vector.Text;
                interaccion = int.Parse(txt_Saltos.Text);
                var Cifrado = new ClasePrincipal.ClaseCrypto();
                txt_TextoCifrado.Text = Cifrado.Cifrado(Texto, Password, Vector, interaccion);
                btn_Guardar.Enabled = true;
            }
            catch (Exception X)
            {
                MessageBox.Show(X.Message);
            }
        }

        private void btn_otraVentana_Click(object sender, EventArgs e)
        {
            AppDescifrado.FormDescifrado Ventana = new AppDescifrado.FormDescifrado();
            Ventana.Show();
            this.Visible = false;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string Texto, Password, Vector, TextoCifrado;
            int interaccion;
            try
            {
                Texto = txt_TextoaCifrar.Text;
                Password = txt_Password.Text;
                Vector = txt_Vector.Text;
                interaccion = int.Parse(txt_Saltos.Text);
                TextoCifrado = txt_TextoCifrado.Text;
                if(TextoCifrado != null || TextoCifrado != "")
                {
                    var Guardar = new ClasePrincipal.ClaseSQL();
                    if (Guardar.Guardar(TextoCifrado, Password, Vector, interaccion))
                        MessageBox.Show("Se ha guardado");
                    else
                        MessageBox.Show("No se ha podido guardar");
                }
                btn_Guardar.Enabled = false;
            }
            catch (Exception X)
            {
                MessageBox.Show(X.Message);
            }
        }

        private void FormCifrado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
