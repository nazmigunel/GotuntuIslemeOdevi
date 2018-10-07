using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void renkGetirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 renkformu = new Form2();
            renkformu.ShowDialog();
        }

        private void ortalamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ortalamaformu = new Form3();
            ortalamaformu.ShowDialog();
        }

        private void kanalSıralamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 kanalsıralamaformu = new Form4();
            kanalsıralamaformu.ShowDialog();
        }

        private void bT709ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 BT709formu = new Form5();
            BT709formu.ShowDialog();
        }

        private void lumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 lumaformu = new Form6();
            lumaformu.ShowDialog();
        }

        private void açıklıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 acıklıkformu = new Form7();
            acıklıkformu.ShowDialog();
        }
    }
}
