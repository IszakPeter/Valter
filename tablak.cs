using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_01_17
{
    public partial class tablak : Form
    {
        public tablak()
        {
            InitializeComponent();
        }

        private void tablak_Load(object sender, EventArgs e)
        {
            string sql = "select name from sqlite_master where type='table'";
            kapcs.parancs_a.CommandText = sql;
            kapcs.eredmeny_a = kapcs.parancs_a.ExecuteReader();
            while (kapcs.eredmeny_a.Read())
            {
                listBox1.Items.Add(kapcs.eredmeny_a[0]);
            }
            kapcs.eredmeny_a.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tabla_name = listBox1.SelectedItem.ToString();
            string sql = "select * from " + tabla_name;
            kapcs.set_adapter(sql);
            DataTable tabla = new DataTable();
            kapcs.adapter.Fill(tabla);
            dataGridView1.DataSource = tabla;
                }

        private void button1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.RowsDefaultCellStyle.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK )
            {
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = colorDialog1.Color;
            }
        }
    }
    
}
