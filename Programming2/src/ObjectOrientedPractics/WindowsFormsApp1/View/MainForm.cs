using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        private Store _store = new Store();


        public MainForm()
        {
            InitializeComponent();

            customersTab1.Customers = _store.Customers;


        }

        
    }
}
