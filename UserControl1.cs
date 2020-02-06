using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_01_17
{
    public partial class ember : UserControl
    {
        string[] t;
        int x = 3, y = 5;
        int maxHeight = 0;
        static int sorszam = 1;
        

        public ember(string[] tomb)
        {
            t = tomb;
            InitializeComponent();            
            if (sorszam % 2 == 0) this.BackColor = Color.Chocolate;
            else this.BackColor = Color.Green;
            sorszam++;
            if (t[1] == "f") addLable(t[0], new Point(x, y),Color.Brown,false);
            else addLable(t[0], new Point(x, y), Color.RoyalBlue, false);
            addLable("született: "+t[2], new Point(3, y+15));
            if (t[3] != "")
            {
                addLable("Meghalt: " + t[3], new Point(3, y + 30), false);
             //   MinimumSize.Height = 90;
            }
            kerdez("Szakmái", " select szakma from szakmak inner join  szakmaja on szakmak.id=szakmaja.szakmaid inner join  emberek on szakmaja.emberid=emberek.id where emberek.nev='"+t[0]+"'");
            kerdez("Hobbijai", "select hobbi from hobbik inner join hobbija on hobbik.id=hobbija.hobbiid inner join emberek on hobbija.emberid=emberek.id where emberek.nev='" + t[0] + "' ");
            kerdez("Autoi" , "select auto, autoja.rendszam, autoja.szin  from autok inner join autoja on autok.id = autoja.autoid inner join emberek on autoja.emberid = emberek.id where emberek.nev = '"+t[0]+"'");
            kerdez("Állatai", "select kutyaja.nev, kutyaja.nem as kutynem, kutyak.kutyafaj  from kutyak inner join kutyaja on kutyak.id = kutyaja.kutyafajtaid inner join emberek on kutyaja.emberid = emberek.id where emberek.nev = '"+t[0]+"'");
            // select kutyaja.nev, kutyaja.nem, kutyak.kutyafaj  from kutyak inner join kutyaja on kutyak.id=kutyaja.kutyafajid inner join emberek on kutyaja.emberid=emberek.id where emberek.nev='"+t[0]+"'";
            if (maxHeight + 15 < 60) maxHeight += 20;
                this.Height=maxHeight+15;
        
        }
        private void addLable(string content, Point position) {

            Label cella = new Label(); 
            cella.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            cella.Text = content;
            cella.AutoSize = true;
            cella.Location = position;
            this.Controls.Add(cella);
            x +=cella.Width+1;
            maxHeight = (cella.Height > maxHeight ? cella.Height : maxHeight);    
            
        }
        private void addLable(string content, Point position, bool push)
        {
            Label cella = new Label();
            cella.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            cella.Text = content;
            cella.AutoSize = true;
            cella.Location = position;
            this.Controls.Add(cella);
            if (push)
            {
                x += cella.Width + 1;
            }
            maxHeight = (cella.Height > maxHeight ? cella.Height : maxHeight);
        }
        private void addLable(string content, Point position, Color setForColor)
        {
            Label cella = new Label();
            cella.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            cella.Text = content;
            cella.AutoSize = true;
            cella.Location = position;
            cella.ForeColor = setForColor;
            this.Controls.Add(cella);
            x +=cella.Width+1;
            maxHeight = (cella.Height > maxHeight ? cella.Height : maxHeight);
        }
        private void addLable(string content, Point position, Color setForColor, bool push)
        {
            Label cella = new Label();
            cella.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            cella.Text = content;
            cella.AutoSize = true;
            cella.Location = position;
            cella.ForeColor = setForColor;
            this.Controls.Add(cella);
            if (push)
            {
                x += cella.Width + 2;
            }
            maxHeight = (cella.Height > maxHeight ? cella.Height : maxHeight);
        }

        private void ember_Load(object sender, EventArgs e)
        {

        }

        private void kerdez(string head, string SQL) {
            kapcs.parancs_b.CommandText = SQL;
            kapcs.eredmeny_b = kapcs.parancs_b.ExecuteReader();
            string c = "";
            int db = kapcs.eredmeny_b.FieldCount;
            while (kapcs.eredmeny_b.Read())
            {

                for (int i = 0; i < db; i++)
                {
                    if (head == "Autoja") {
                        if (kapcs.eredmeny_b[i].ToString() == kapcs.eredmeny_b["rendszam"].ToString())
                            c += "Rsz.: "+ kapcs.eredmeny_b[i].ToString() + "  ";
                        else c += kapcs.eredmeny_b[i].ToString() + "  ";
                    }
                    else if (head == "Állatai") {
                        if (kapcs.eredmeny_b[i].ToString() == kapcs.eredmeny_b["kutynem"].ToString()) 
                            c += (kapcs.eredmeny_b[i].ToString() == "k" ? " kan " : " szuka ");
                        else  c += kapcs.eredmeny_b[i].ToString() + "  ";

                    }
                    else { c += kapcs.eredmeny_b[i].ToString() + "  "; }
                }
                c +="\r\n";
            }
            kapcs.eredmeny_b.Close();
            if (c == "") { addLable("Nincenek neki "+ head, new Point(x, y)); }
            else addLable(head+":\r\n"+c, new Point(x, y));

        }

    }
}
