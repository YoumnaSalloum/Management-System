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
    public partial class projectf : Form
    {
        public projectf()
        {
            InitializeComponent();
        }
        db1DataContext db = new db1DataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|data.mdf;Integrated Security=True;User Instance=True");
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Project n = new Project();
                 int tol = t1.Text.Length;
                 if (tol <= 8)
                 {
                     n.PNo = int.Parse(t1.Text);
                 }
                 else { MessageBox.Show("you are reject"); }
                n.Name = t2.Text;
                 int tol3 = t3.Text.Length;
                 if (tol3 <= 2)
                 {
                     n.SupNo = int.Parse(t3.Text);
                 }
                 else { MessageBox.Show("Enter correct lengths for supno"); }
                   int tol2 = t4.Text.Length;
                   if (tol2 <= 2)
                   {
                       n.StNo = int.Parse(t4.Text);
                   }
                   else { MessageBox.Show("Enter correct lengths for stno"); }
                db.Projects.InsertOnSubmit(n);
                db.SubmitChanges();
                //this.Hide();
                projectf_Load(null, null);
                t1.Text = "";
                t2.Text = "";
                t3.Text = "";
                t4.Text = "";
            }
            catch
            {
                MessageBox.Show("enter a valid data");
                t1.Text = "";
                t2.Text = "";
                t3.Text = "";
                t4.Text = "";
            }
        }

        private void projectf_Load(object sender, EventArgs e)
        {
            projectBindingSource.DataSource = from x in db.Projects
                                              orderby x.PNo
                                              select x;
        }

        private void projectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            projectBindingSource.EndEdit();
            db.SubmitChanges();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
