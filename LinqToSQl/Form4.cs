using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqToSQl
{
    public partial class Form4 : Form
    {
        CompanyDBDataContext db = new CompanyDBDataContext();
        Employee obj = new Employee();//create object of table
        public Form4()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            if (textBox1.ReadOnly==false)//means insert operation
            {
               
                obj.Eno = int.Parse(textBox1.Text);
                obj.Ename = textBox2.Text;
                obj.Job = textBox3.Text;
                obj.Salary = decimal.Parse(textBox4.Text);
                obj.Dname = textBox5.Text;

                //add record to the table
                db.Employees.InsertOnSubmit(obj);//pending insert state..inserted but not commited
                db.SubmitChanges();//will commit the data
                MessageBox.Show("Records inserted in the table");
            }
            else
            {
                Employee obj = db.Employees.SingleOrDefault(E=>E.Eno == int.Parse(textBox1.Text));
                //identifies the record and provide reference to the record obj is reference to existing records
                obj.Ename = textBox2.Text;
                obj.Job = textBox3.Text;
                obj.Salary = decimal.Parse(textBox4.Text);
                obj.Dname = textBox5.Text;
                db.SubmitChanges();
                MessageBox.Show("Records updated in the table");

            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)//we get all controls in form
            {
              if(ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }
         
            }
            textBox1.Focus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
