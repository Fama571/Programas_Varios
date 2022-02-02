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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_np_Click(object sender, EventArgs e)
        {
            var newform = new Charter.NP();
            newform.Show();
            Visible = false;
        }

        private void btn_pe_Click(object sender, EventArgs e)
        {
            var newform = new Charter.PE();
            newform.Show();
            Visible = false;;
        }

        private void btn_sp_Click(object sender, EventArgs e)
        {
            var newform = new Charter.SP();
            newform.Show();
            Visible = false;;
        }

        private void btn_ti_Click(object sender, EventArgs e)
        {
            var newform = new Charter.Total_de_inventario();
            newform.Show();
            Visible = false;;
        }

        private void btn_ci_Click(object sender, EventArgs e)
        {
            var newform = new Charter.Consulta();
            newform.Show();
            Visible = false;;
        }
    }
}
