using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _2020_01_17
{
    public partial class Rendszamos : Form
    {
        public Rendszamos()
        {
            InitializeComponent();
        }

        int index = 0;
        string[] k = { "_", "_", "_", "_", "_", "_", };
        private void Nyomi(object sender, KeyEventArgs e)
        {
            TextBox box = (TextBox)sender;
            index = int.Parse(box.Name[box.Name.Length - 1] + "") - 1;
            k[index] = (box.Text == "" ? "_" : box.Text);
            //string rsz = (Box1.Text == "" ? "_" : Box1.Text) + (Box2.Text == "" ? "_" : Box2.Text) + (Box3.Text == "" ? "_" : Box3.Text) + " " + (Box4.Text == "" ? "_" : Box4.Text) + (Box5.Text == "" ? "_" : Box5.Text) + (Box6.Text == "" ? "_" : Box6.Text);
            string rsz = "";
            for (int i = 0; i < k.Length; i++) { rsz += k[i]; if(i==2)rsz+=" "; } 
            string sql = "select * from  autok inner join autoja on autok.id=autoja.autoid inner join emberek on autoja.emberid = emberek.id where autoja.rendszam like '" + rsz + "'";
            kapcs.set_adapter(sql);
            DataTable tabla = new DataTable();
            kapcs.adapter.Fill(tabla);
            dataGridView1.DataSource = tabla;

        }
    }
}
