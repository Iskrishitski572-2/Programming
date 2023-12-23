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
            customersTab1.RefreshData();


            itemsTab1.Items = _store.Items;
            itemsTab1.RefreshData();


            cartsTab1.Customers = _store.Customers;
            cartsTab1.Items = _store.Items;
            cartsTab1.RefreshData();

            priorityOrdersTab1.Customers = _store.Customers;
            priorityOrdersTab1.Items = _store.Items;
            priorityOrdersTab1.UpdateOrders();

            ordersTab1.Customer = _store.Customers;
            priorityOrdersTab1.UpdateTextBox();
        }

        /// <summary>
        /// Событие переключение страниц.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControlSelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (ordersTabControl.SelectedIndex)
            {
                case 2:
                    cartsTab1.RefreshData();
                    break;
                case 3:
                    ordersTab1.UpdateOrders();
                    ordersTab1.UpdateOrdersDataGridView();
                    break;
                default:
                    cartsTab1.IndexComboBox();
                    break;
            }
        }


    }
}
