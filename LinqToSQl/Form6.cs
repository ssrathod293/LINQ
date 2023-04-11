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
    public partial class Form6 : Form
    {
        CompanyDBDataContext db;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            db = new CompanyDBDataContext();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int? Eno = null;
            db.Employee_Insert(textBox2.Text, textBox3.Text, decimal.Parse(textBox4.Text), textBox5.Text, ref Eno);
            textBox1.Text = Eno.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)//we get all controls in form
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }

            }
            textBox2.Focus();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
