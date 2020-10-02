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
    public partial class Studentf : Form
    {
        public Studentf()
        {
            InitializeComponent();
        }
        db1DataContext db = new db1DataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|data.mdf;Integrated Security=True;User Instance=True");
        private void button1_Click(object sender, EventArgs e)
        {

            if (int.Parse(t5.Text) >= 66 && int.Parse(t6.Text) >= 70)
            {

                try
                {
                    Student n = new Student();
                    int tol = t1.Text.Length;
                    if (tol <= 8)
                    {
                        n.StNo = int.Parse(t1.Text);
                    }
                    else { MessageBox.Show("you are reject"); }
                    n.Name = t2.Text;
                      int tol2 = t3.Text.Length;
                      if (tol <= 2)
                      {
                          n.Dep = int.Parse(t3.Text);
                      }
                      else { MessageBox.Show("Enter correct lengths for dep"); }
                    db.Students.InsertOnSubmit(n);
                    db.SubmitChanges();

                    Studentf_Load(null, null);
                    t1.Text = "";
                    t2.Text = "";
                    t3.Text = "";

                }

                catch
                {
                    MessageBox.Show("enter a valid data");
                    t1.Text = "";
                    t2.Text = "";
                    t3.Text = "";
                }
            }
            else {
                MessageBox.Show("your avarage less than 66 and your hours Reg less than 70");
                t1.Text = "";
                t2.Text = "";
                t3.Text = "";
                t5.Text = "";
                t6.Text = "";
            
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtStNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDep_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            studentBindingSource.EndEdit();
            db.SubmitChanges();
        }

        private void Studentf_Load(object sender, EventArgs e)
        {
            stg.DataSource = from x in db.Students
                             orderby x.StNo
                             select x;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void stg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
