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
    public partial class Form3 : Form
    {
        CompanyDBDataContext db = new CompanyDBDataContext();

        // Employee obj = new Employee();//create object of table

        public Form3()
        {
            InitializeComponent();
        }

      
        private void loadData()
        {
            CompanyDBDataContext db = new CompanyDBDataContext();
            dbView.DataSource = db.Employees;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
            loadData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (dbView.SelectedRows.Count>0) {
                Form4 f = new Form4();
                //we have to modifiy access specifier as public before accessing textbook
                f.textBox1.ReadOnly = true;//if you dont allow to modify eNo
                f.btnClear.Enabled = false;
                f.btnsave.Text = "Update";
                f.textBox1.Text = dbView.SelectedRows[0].Cells[0].Value.ToString();//return type object hence tostring
                f.textBox2.Text = dbView.SelectedRows[0].Cells[1].Value.ToString();
                f.textBox3.Text = dbView.SelectedRows[0].Cells[2].Value.ToString();
                f.textBox4.Text = dbView.SelectedRows[0].Cells[3].Value.ToString();
                f.textBox5.Text = dbView.SelectedRows[0].Cells[4].Value.ToString();
                f.ShowDialog();
                loadData();
            }
            else
            {
                MessageBox.Show($"Please select record for updation:{MessageBoxButtons.OK}, {MessageBoxIcon.Information}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            

            if (dbView.SelectedRows.Count>0)
            {
                if (MessageBox.Show("Are you sure of deleting the selected record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                {
                    int Eno =Convert.ToInt32( dbView.SelectedRows[0].Cells[0].Value);
                    Employee obj = db.Employees.SingleOrDefault(E => E.Eno == Eno);
                   db.Employees.DeleteOnSubmit(obj);//delete i pedidig state
                    db.SubmitChanges();//commit delete
                    loadData();
                }
            }
            else
            {
                MessageBox.Show($"Please select record for deleting:{MessageBoxButtons.OK}, {MessageBoxIcon.Information}");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
