using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMTech.EnviarEmail.UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void enviarEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var envioEmail = new Envio();
            envioEmail.MdiParent = this;
            envioEmail.Show();
        }
    }
}
