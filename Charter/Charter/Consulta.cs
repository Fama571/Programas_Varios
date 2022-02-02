using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Charter
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void Consultar_Click(object sender, EventArgs e)
        { 
            int clave = 0;
            try 
            {
                clave = int.Parse(TextbClave.Text);
                var DLL = new DLLBasedeDatos.Consulta();
                var conjunto = new DataSet();
                conjunto = DLL.ConsultaMesta(clave);
                GridConsulta.DataSource = conjunto.Tables["Inventario"];
                
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Consulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            var NewForm = new Charter.Menu();
            NewForm.Visible = true;
        }

        private void TextbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TextbClave_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int clave;
                clave = int.Parse(TextbClave.Text);
                var DLL = new DLLBasedeDatos.Consulta();
                var conjunto = new DataSet();
                conjunto = DLL.ConsultaMesta(clave);
                DataRow Nombre;
                Nombre = conjunto.Tables["Inventario"].Rows[0];
                TextboxDes.Text = Nombre["Descripcion"].ToString();
            }
            catch
            {
                TextboxDes.Text = "---";
            }
        }
    }
}
