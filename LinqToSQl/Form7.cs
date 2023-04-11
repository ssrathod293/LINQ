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
    public partial class Form7 : Form
    {
        CompanyDBDataContext db;
        bool flag = false;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            db = new  CompanyDBDataContext();
             dataGridView1.DataSource=from E in db.Employes orderby E.Salary descending select E;
            //dataGridView1.DataSource = tab; no need becase table direlty bind to gridview
            var tab = from E in db.Employes select new { E.Job };
            comboBox1.DataSource = tab.Distinct();
            comboBox1.DisplayMember = "Job";
            comboBox1.SelectedIndex = -1;
            flag = true;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag==true) {
                dataGridView1.DataSource = from E in db.Employes where E.Job == comboBox1.Text select E;
            }
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView1.DataSource = from E in db.Employes where E.Job.Contains(comboBox1.Text)  select E;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Employes orderby E.Salary select E;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Employes orderby E.Ename descending select E;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Employes select new {E.EmpNo,E.Ename,E.Job,sal=E.Salary,E.Department } ;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Employes group E by E.EDept into G select new { DeptNo=G.Key,EmpCount=G.Count()};

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Employes group E by E.Job into G select new { Emp = G.Key, EmpCount = G.Count() };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Employes group E by E.EDept into G where G.Count()>3 select new { DeptNo = G.Key, EmpCount = G.Count() };

        }

        private void button7_Click(object sender, EventArgs e)
        {
          dataGridView1.DataSource = from E in db.Employes group E by E.Job into G where G.Count()<3 select new { Emp = G.Key, EmpCount = G.Count() };

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Employes where E.Job == "engg" group E by E.EDept into G where G.Count()>1 orderby G.Key descending select new { deptNo = G.Key, engCount = G.Count() };
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Employes group E by E.EDept into G select new {deptNo=G.Key,MaxSal=G.Max(E=>E.Salary) };
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Employes group E by E.Job into G select new {Job=G.Key,MinSal=G.Min(E=>E.Salary) };
        }
    }
}
