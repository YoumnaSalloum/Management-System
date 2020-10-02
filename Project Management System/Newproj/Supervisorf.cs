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
    public partial class Supervisorf : Form
    {
        public Supervisorf()
        {
            InitializeComponent();
        }
        db1DataContext db = new db1DataContext(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|data.mdf;Integrated Security=True;User Instance=True");
        private void Supervisorf_Load(object sender, EventArgs e)
        {
            supg.DataSource = from x in db.Supervisors
                              orderby x.SupNo
                              select x;
            comboBox1.Items.Add("Doctor");//0
            comboBox1.Items.Add("Professor");
            comboBox1.Items.Add("Teacher");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox1.SelectedIndex == 1)
            {
                try
                {

                    Supervisor n = new Supervisor();
                       int tol = t1.Text.Length;
                       if (tol <= 2)
                       {
                           n.SupNo = int.Parse(t1.Text);
                       }
                       else { MessageBox.Show("you are reject"); }
                    n.Name = t2.Text;
                      int tol2 = t3.Text.Length;
                      if (tol2 <= 4)
                      {
                          n.Salary = int.Parse(t3.Text);
                      }
                      else { MessageBox.Show("Enter correct lengths for salary"); }
                    db.Supervisors.InsertOnSubmit(n);
                    db.SubmitChanges();
                    // this.Hide();
                    Supervisorf_Load(null, null);
                    t1.Text = "";
                    t2.Text = "";
                    t3.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show("enter a valid data" + ex.ToString());
                    t1.Text = "";
                    t2.Text = "";
                    t3.Text = "";
                }
            }
            else {
                MessageBox.Show("Not allow to select Teacher here ");
                t1.Text = "";
                t2.Text = "";
                t3.Text = "";
            }
        }

        private void supervisorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            supg.EndEdit();
            db.SubmitChanges();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
