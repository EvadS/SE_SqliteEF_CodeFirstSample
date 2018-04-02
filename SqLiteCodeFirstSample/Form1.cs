
using SqLiteCodeFirstSample.Properties.DataSources;
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
        Model _entities;


        public Form1()
        {
            InitializeComponent();


            //if (_entities != null)
            //    _entities.Dispose();

            _entities = new Model();
            _entities.customers.Load();        

            dataGridView1.DataSource = _entities.customers.Local;
        }
    }
}
