using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Conversao
{
    public partial class Conversao : Form
    {
        public Conversao()
        {
            InitializeComponent();
        }

        private void blocaliza_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Title = "Buscar planilha";

            if(open.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = (open.FileName);
            }
            open.Dispose();
        }

        private void bconveter_Click(object sender, EventArgs e)
        {

        }
    }
}
