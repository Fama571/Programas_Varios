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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            var newform = new Charter.Menu();
            newform.Show();
            Visible = false;
        }
    }
}
