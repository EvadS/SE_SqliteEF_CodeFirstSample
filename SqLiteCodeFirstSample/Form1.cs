using SqLiteCodeFirstSample.DataBase.context;
using SqLiteCodeFirstSample.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace SqLiteCodeFirstSample
{
    public partial class Form1 : Form
    {
        CustomerModel context;


        public Form1()
        {
            InitializeComponent();



            try
            {

                using (CustomerModel context = new CustomerModel())
                {
                    //var cust1 = new customer() { name = "test customer name", salary = 1000 };
                    //customer cust2 = new customer() { name = "test customer name", salary = 1000 };

                    //context.customers.Add(cust1);
                    //context.customers.Add(cust2);
                    //context.SaveChanges();


                    var data = context.customers.Select(x => new CustomerVm() { id = x.id, name = x.name, salary = x.salary }).ToList();
                    dataGridView1.DataSource = data;

                }
            }
            catch (Exception exc)
            {
                var test = 10;
                MessageBox.Show(exc.StackTrace, exc.Message);
            }
        }
    }
}
