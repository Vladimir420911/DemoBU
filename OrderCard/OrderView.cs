using System;
using System.Windows.Forms;
using ClassLib;

namespace OrderCard
{
    public partial class OrderView: UserControl
    {
        Order currentOrder;

        public OrderView()
        {
            InitializeComponent();
        }

        public void ShowOrderInfo(Order order)
        {
            currentOrder = order;

            ArticleLabel.Text = Convert.ToString(order.Id);
            StatusLabel.Text = order.Status;
            AddressLabel.Text = order.AddressName;
            OrderDate.Text = Convert.ToString(order.OrderDate);
            ArrivalDate.Text = Convert.ToString(order.ArrivalDate);
        }
    }
}
