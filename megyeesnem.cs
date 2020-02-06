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
    public partial class megyeesnem : Form
    {
        public megyeesnem()
        {
            InitializeComponent();
        }

        private void megyeesnem_Load(object sender, EventArgs e)
        {
            string sql = "select * from megyek";
            kapcs.parancs_a.CommandText = sql;
            kapcs.eredmeny_a = kapcs.parancs_a.ExecuteReader();
            
            while (kapcs.eredmeny_a.Read())
            {
                megyek.Items.Add(kapcs.eredmeny_a[1]);
            }
            kapcs.eredmeny_a.Close();

             sql = "select * from teltipusok";
            kapcs.parancs_a.CommandText = sql;
            kapcs.eredmeny_a = kapcs.parancs_a.ExecuteReader();

            while (kapcs.eredmeny_a.Read())
            {
                teleptip.Items.Add(kapcs.eredmeny_a[1]);
            }
            kapcs.eredmeny_a.Close();


           // string s = (true == true ? "asd" : "gas");

            /*
            string tabla_name = listBox1.SelectedItem.ToString();
            string sql = "select * from " + tabla_name;
            kapcs.set_adapter(sql);
            DataTable tabla = new DataTable();
            kapcs.adapter.Fill(tabla);
            dataGridView1.DataSource = tabla;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked || radioButton3.Checked && megyek.SelectedIndex != -1 && teleptip.SelectedIndex != -1) {

                string teltipus =  teleptip.SelectedItem.ToString();
                string megye = megyek.SelectedItem.ToString();
                char nem = radioButton1.Checked ? 'f' : radioButton2.Checked ? 'n' : '*';
                string sql = "select * from emberek  where 1 ";
                if (!(teltipus == "mind" && megye == "mind" && radioButton3.Checked)) {
                    if (teltipus != "mind") { sql += " and teltipusid = (select id from teltipusok where tip = '" + teltipus + "') "; }
                    if (megye != "mind") { sql += " and megyeid = (select id from megyek where megye = '" + megye + "') "; }
                    if (nem != '*') { sql += " and nem = '" + nem + "'"; }
                }
                
                kapcs.set_adapter(sql);
                DataTable tabla = new DataTable();
                kapcs.adapter.Fill(tabla);
                dataGridView1.DataSource = tabla;


            }
            else MessageBox.Show("valami nem oké");
        }


    }
}
/*
 teltipusid = (select id from telripus where tip ="comboBox2.selecteditem ")
     
     */
