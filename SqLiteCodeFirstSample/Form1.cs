
using SqLiteCodeFirstSample.context;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqLiteCodeFirstSample
{
    public partial class Form1 : Form
    {
        CustomerModel _entities;


        public Form1()
        {
            InitializeComponent();

           if (_entities != null)
                _entities.Dispose();

            try
            {
                _entities = new CustomerModel();

                var cust1 = new context.customer() { name = "test customer name", salary = 1000 };
                context.customer cust2 = new context.customer() { name = "test customer name", salary = 1000 };
                _entities.customer.Add(cust1);
                _entities.customer.Add(cust2);


                _entities.customer.Load();
                dataGridView1.DataSource = _entities.customer.Local;
            }
            catch (Exception exc)
            {
                var test = 10;
                MessageBox.Show(exc.StackTrace, exc.Message);
            }
        }
    }
}
