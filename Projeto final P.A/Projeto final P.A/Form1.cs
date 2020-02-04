using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_final_P.A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 outroform = new Form3();
            outroform.ShowDialog();
            this.Close();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 cliente = new Form2();
            cliente.ShowDialog();
            this.Close();

        }
    }
}
