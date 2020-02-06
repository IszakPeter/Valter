using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
namespace _2020_01_17
{
    public partial class megyes : Form
    {
        
        public megyes()
        {
            InitializeComponent();
        }
        int proc = 0;
        private void megyes_Load(object sender, EventArgs e)
        {
            kapcs.parancs_a.CommandText = "select megye from megyek";
            kapcs.eredmeny_a = kapcs.parancs_a.ExecuteReader();
            while (kapcs.eredmeny_a.Read())
            {
                listBox1.Items.Add(kapcs.eredmeny_a[0]);
            }
            kapcs.eredmeny_a.Close();
            listBox1.Height = (listBox1.Items.Count+1) * listBox1.ItemHeight;
            /*   int y = 0;
               for (int i = 0; i < 56; i++)
               {
                   ember sor = new ember();
                   panel1.Controls.Add(sor);
                   sor.Location=new Point(0, y);
                   y += sor.Height;
               }*/

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            listBox1.Enabled = false;
            panel1.Controls.Clear();
            int index = listBox1.SelectedIndex;
            Debug.WriteLine("választott"+index);
            if (index != -1)
            {
                panel2.Visible = true;
                int y = 0;
                string megye = listBox1.SelectedItem.ToString();
                kapcs.parancs_a.CommandText = "select nev, nem, szulido, halido " +
                    " from emberek where megyeid= ( select id from megyek where megye='" + megye + "') order by nev";
                kapcs.eredmeny_a = kapcs.parancs_a.ExecuteReader();
                int n = kapcs.eredmeny_a.FieldCount;

                kapcs.parancs_b.CommandText = "select count(*) " +
                    " from emberek where megyeid= ( select id from megyek where megye='" + megye + "') group by megyeid ";
                string iz = kapcs.parancs_b.ExecuteScalar().ToString();

                int db= kapcs.eredmeny_a.StepCount;
               db = int.Parse(iz);
                setSize(db);
                setPositions();
                while (kapcs.eredmeny_a.Read() || proc < db)
                {
                    if (kapcs.eredmeny_a.Read())
                    {
                        string[] tomb = new string[n];
                        for (int i = 0; i < n; i++) { tomb[i] = kapcs.eredmeny_a[i].ToString(); }
                        ember sor = new ember(tomb);
                        panel1.Controls.Add(sor);
                        sor.Location = new Point(0, y);
                        y += sor.Height + 1;
                    }
                    else { Thread.Sleep(50); }
                    setBarValue(proc);
                    proc++;
                    Application.DoEvents();
                }
                kapcs.eredmeny_a.Close();
                if (proc == db)
                {
                    panel2.Visible = false;
                    proc = 0;
                }
            }
            listBox1.Enabled = true;
        }
        void setBarValue(int value)
        {
            bar.Value = value;
        }
        void setPositions() {
        //    barText.Location = new Point((barPanel.Width - barText.Width) / 2, barText.Location.Y+100);
            barPanel.Location = new Point((panel2.Width - barPanel.Width) / 2, (panel2.Height - barPanel.Height) / 2);

        }
        void setSize( int length)
        {
            bar.Maximum = length;
            bar.Size = new Size(length, 23);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
