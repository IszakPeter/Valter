using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasierWay;

namespace _2020_01_17
{
    public partial class Form1 : Form
    {

     //   SQLite conect = new SQLite();

        public Form1()
        {
            InitializeComponent();
        }


        private void tablak_menu_Click(object sender, EventArgs e)
        {
            new tablak().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kapcs.kapcsolodik("emberek.db");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            kapcs.lecsatlakoik();
        }

        private void magyaesnem_Click(object sender, EventArgs e)
        {
            new megyeesnem().ShowDialog();
        }

        private void személyesAdatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new megyes().ShowDialog();
        }

        private void mIAPÖCSÖMÖCSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Rendszamos().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(String.Format("{0:x}", 10));
        }
    }
}
