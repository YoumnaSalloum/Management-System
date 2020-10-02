using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Newproj
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        db1DataContext db = new db1DataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|data.mdf;Integrated Security=True;User Instance=True");
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void projectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            projectf p = new projectf();
            p.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Studentf s = new Studentf();
            s.Show();
        }

        private void supervisorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supervisorf su = new Supervisorf();
            su.Show();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBf d = new DBf();
            d.Show();
        }

        private void uSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usf u = new Usf();
            u.Show();
        }

        private void projectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            projectq pq = new projectq();
            pq.Show();
        }

       

      

      




    }
}
