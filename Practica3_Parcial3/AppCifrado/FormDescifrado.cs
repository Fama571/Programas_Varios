using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDescifrado
{
    public partial class FormDescifrado : Form
    {
        public FormDescifrado()
        {
            InitializeComponent();
            var DLL = new ClasePrincipal.ClaseSQL();
            var Conjunto = new DataSet();
            Conjunto = DLL.ConsultarTodo();
            Visor.DataSource = Conjunto.Tables["Cifrado"];
        }

        private void btn_Descifrar_Click(object sender, EventArgs e)
        {
            string texto;
            texto = txt_Text.Text;
            try
            {
                var Consultar = new ClasePrincipal.ClaseSQL();
                var Conjunto = new DataSet();
                Conjunto = Consultar.Consultar(texto);
                DataRow renglon;
                renglon = Conjunto.Tables["Cifrado"].Rows[0];
                txt_Password.Text = renglon["Password"].ToString();
                txt_Saltos.Text = renglon["Interaccion"].ToString();
                txt_Vector.Text = renglon["Vector"].ToString();

                string Password, Vector;
                int interaccion;
                Password = txt_Password.Text;
                Vector = txt_Vector.Text;
                interaccion = int.Parse(txt_Saltos.Text);
                var Cifrado = new ClasePrincipal.ClaseCrypto();
                txt_Desencriptar.Text = Cifrado.Descifrado(texto, Password, Vector, interaccion);
            }
            catch (Exception X)
            {
                MessageBox.Show(X.Message);
            }
        }

        private void btn_Cifrar_Click(object sender, EventArgs e)
        {
            AppCifrado.FormCifrado Ventana = new AppCifrado.FormCifrado();
            Ventana.Visible = true;
            this.Visible = false;
        }

        private void FormDescifrado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
