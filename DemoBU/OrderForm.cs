using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLib;

namespace DemoBU
{
    public partial class OrderForm : Form
    {
        MySqlModel model_;
        List<Order> allOrders;
        public OrderForm(MySqlModel model)
        {
            InitializeComponent();
            model_ = model;
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        public void RefreshListBox()
        {
            try
            {
                allOrders = model_.GetAllOrders();
                ShowOrders(allOrders);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ShowOrders(List<Order> orders)
        {
            OrderList.DataSource = null;
            OrderList.DataSource = orders;
            OrderList.DisplayMember = "Id";
        }


        private void OrderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order order = OrderList.SelectedItem as Order;

            if(order == null)
            {
                return;
            }

            OrderCard.ShowOrderInfo(order);
        }
    }
}
