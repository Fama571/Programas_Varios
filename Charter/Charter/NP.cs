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
    public partial class NP : Form
    {
        public NP()
        {
            InitializeComponent();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            string  descripcion = "";
            int clave = 0, cantidad = 0;
            double precio = 0;
            try
            {
                clave = int.Parse(txtbox_clave.Text.ToString());
                descripcion = txtbox_des.Text;
                cantidad = int.Parse(txtbox_cantidad.Text);
                precio = double.Parse(TxtPrecio.Text);
                if (clave > 0 && descripcion != "" || descripcion != " " && cantidad <= 0)
                {
                    var AddInventory = new DLLBasedeDatos.Agregar();
                    if(AddInventory.AgregarP(clave, descripcion, cantidad, precio))
                    {
                        MessageBox.Show("Los datos se almacenaron correctamente", "¡Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Hubo un error al intentar ingresar los datos", "¡No Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Verifique que los datos sean correctos o que las casillas esten llenas", "Cuidado Usuario",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
            
        }

        private void txtbox_cantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void NP_FormClosed(object sender, FormClosedEventArgs e)
        {
            var NewForm = new Charter.Menu();
            NewForm.Visible = true;
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtbox_clave_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int clave;
                clave = int.Parse(txtbox_clave.Text);
                var DLL = new DLLBasedeDatos.Consulta();
                var conjunto = new DataSet();
                conjunto = DLL.ConsultaMesta(clave);
                DataRow Nombre;
                Nombre = conjunto.Tables["Inventario"].Rows[0];
                txtbox_des.Text = Nombre["Descripcion"].ToString();
            }
            catch
            {
                txtbox_des.Text = "---";
            }
        }

        private void txtbox_clave_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
