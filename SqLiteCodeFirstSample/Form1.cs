using SqLiteCodeFirstSample.DataBase.context;
using System;
using System.Data.Entity;
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

                  
                var cust1 = new customer() { name = "test customer name", salary = 1000 };
                customer cust2 = new customer() { name = "test customer name", salary = 1000 };

                _entities.customer.Add(cust1);
                _entities.customer.Add(cust2);
     

                _entities.SaveChanges();

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
