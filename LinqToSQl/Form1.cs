﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CompanyDBDataContext dc = new CompanyDBDataContext();
            dataGridView1.DataSource = dc.Employees;
            //Table<Employee> tab = dc.Employees;
            //dataGridView1.DataSource = tab;

        }
    }
}
