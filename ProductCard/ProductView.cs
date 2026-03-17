using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ClassLib;

namespace ProductCard
{
    public partial class ProductView : UserControl
    {
        public ProductView()
        {
            InitializeComponent();
        }

        public void ShowProductInfo(Product product, List<string> manufacturers, List<string> categories, List<string> suppliers)
        {
            CategoryLabel.Text = categories[product.CategoryId-1];
            NameLabel.Text = product.Name;
            DescriptionLabel.Text = product.Description;
            ManufacturerLabel.Text = manufacturers[product.ManufacturerId-1];
            SupplierLabel.Text = suppliers[product.SupplierId-1];
            PriceLabel.Text = Convert.ToString(product.Price);
            UnitLabel.Text = product.Unit;
            AmountLabel.Text = Convert.ToString(product.Amount);
            DiscountLabel.Text = "Скидка: " + Convert.ToString(product.Discount) + "%";
            ImageBox.Load($"../../../import/{product.ImagePath}");
        }
    }
}
