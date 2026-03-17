using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClassLib;

namespace DemoBU
{
    public partial class MainForm : Form
    {
        MySqlModel model_;
        User currentUser_;

        bool sortSet = false;
        bool filterSet = false;
        

        int managerUserId = 2;
        int clientUserId = 3;

        List<string> manufacturers;
        List<string> suppliers;
        List<string> categories;

        List<Product> allProducts;

        public MainForm(MySqlModel model, User currentUser)
        {
            InitializeComponent();
            model_ = model;
            currentUser_ = currentUser;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                FillLists();
                RefreshListBox();
                ConfigureUIBasedOnRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshListBox()
        {
            try
            {
                allProducts = model_.GetAllProducts();
                ShowProducts(allProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowProducts(List<Product> products)
        {
            ProductList.DataSource = null;
            ProductList.DataSource = products;
            ProductList.DisplayMember = "Name";
        }

        private void FillLists()
        {
            manufacturers = model_.GetManufacturers();
            suppliers = model_.GetSuppliers();
            categories = model_.GetCategories();
        }
        private void ConfigureUIBasedOnRole()
        {
            if (currentUser_ == null)
            {
                UserFIOLabel.Text = "Гость";
                AddProductButton.Visible = false;
                EditProductButton.Visible = false;
                DeleteProductButton.Visible = false;
                toolStripLabel1.Visible = false;
                SortDropDownButton.Visible = false;
                OrderFormButton.Visible = false;
                SearchTextBox.Visible = false;
                FilterDropDownButton.Visible = false;
            }
            else if (currentUser_.RoleId == clientUserId)
            {
                UserFIOLabel.Text = currentUser_.Name;
                AddProductButton.Visible = false;
                EditProductButton.Visible = false;
                DeleteProductButton.Visible = false;
                toolStripLabel1.Visible = false;
                SortDropDownButton.Visible = false;
                FilterDropDownButton.Visible = false;
            }
            else if (currentUser_.RoleId == managerUserId)
            {
                UserFIOLabel.Text = currentUser_.Name;
                AddProductButton.Visible = false;
                EditProductButton.Visible = false;
                DeleteProductButton.Visible = false;
            }
            else
            {
                UserFIOLabel.Text = currentUser_.Name;
            }

        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ProductList.SelectedItem;
            if (item == null)
            {
                return;
            }

            Product product = item as Product;

            if (product == null)
            {
                return;
            }

            ProductCard.ShowProductInfo(product, manufacturers, categories, suppliers);

        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProductForm form = new AddProductForm(model_);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshListBox();
                MessageBox.Show("Товар добавлен");
            }
        }

        private void EditProductButton_Click(object sender, EventArgs e)
        {
            var item = ProductList.SelectedItem;
            if (item == null)
            {
                return;
            }
            Product selectedProduct = item as Product;
            if (selectedProduct == null)
            {
                return;
            }

            AddProductForm form = new AddProductForm(model_, selectedProduct);
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshListBox();
                MessageBox.Show("Товар обновлен");
            }
        }

        private void SearchByTemplate(string template)
        {
            var items = ProductList.Items;

            //List<Product> result = new List<Product>();
            allProducts.Clear();

            foreach (var item in items)
            {
                Product product = item as Product;
                if (product.Name.ToLower().Contains(template.ToLower()))
                {
                    allProducts.Add(product);
                }
            }

            ShowProducts(allProducts);
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string template = SearchTextBox.Text;

            if (!string.IsNullOrEmpty(template))
            {
                SearchByTemplate(template);
            }
            else
            {
                RefreshListBox();
            }
        } 

        private void AscendingSortButton_Click(object sender, EventArgs e)
        {
            sortSet = true;
            List<Product> sorted = allProducts.OrderBy(product => product.Amount).ToList();
            ShowProducts(sorted);
        }

        private void DescendingSortButton_Click(object sender, EventArgs e)
        {
            sortSet = true;
            List<Product> sorted = allProducts.OrderByDescending(product => product.Amount).ToList();
            ShowProducts(sorted);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                sortSet = false;
                RefreshListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void KariFilterButton_Click(object sender, EventArgs e)
        {
            List<Product> filtered = new List<Product>();

            foreach (Product product in allProducts)
            {
                if (product.SupplierId == 1)
                {
                    filtered.Add(product);
                }
            }

            ShowProducts(filtered);
        }

        private void BootsFotYouFilterButton_Click(object sender, EventArgs e)
        {
            List<Product> filtered = new List<Product>();

            foreach (Product product in allProducts)
            {
                if (product.SupplierId == 2)
                {
                    filtered.Add(product);
                }
            }

            ShowProducts(filtered);
        }

        private void AllSuppliersFilterButton_Click(object sender, EventArgs e)
        {
            ShowProducts(allProducts);
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        {
            var item = ProductList.SelectedItem;
            if (item == null)
            {
                return;
            }
            Product selectedProduct = item as Product;
            if (selectedProduct == null)
            {
                return;
            }

            try
            {
                model_.DeleteProduct(selectedProduct.Article);
                RefreshListBox();
                MessageBox.Show("Товар удален");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderFormButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(model_);
            orderForm.Show();
        }
    }
}
