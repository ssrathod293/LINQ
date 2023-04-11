using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace LinqToSQl
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CompanyDBDataContext db = new CompanyDBDataContext();
            ISingleResult<Employee_selectResult> results=db.Employee_select("production");
            dataGridView1.DataSource = results;
        }
    }
}
     
