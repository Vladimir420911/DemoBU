using System;
using System.Windows.Forms;
using ClassLib;

namespace DemoBU
{
    public partial class AddProductForm : Form
    {
        string pictureName;
        bool isEditMode;

        MySqlModel model_;
        Product currentProduct_;
        public AddProductForm(MySqlModel model)
        {
            InitializeComponent();
            isEditMode = false;
            model_ = model;
            FillComboBoxes();
        }

        public AddProductForm(MySqlModel model, Product currentProduct)
        {
            InitializeComponent();
            isEditMode = true;
            model_ = model;
            currentProduct_ = currentProduct;
            FillComboBoxes();
        }

        private void ChoosePictureButton_Click(object sender, EventArgs e)
        {
            if(PictureFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureName = PictureFileDialog.SafeFileName;
                ProductPictureBox.ImageLocation = $"../../../import/{pictureName}";
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(NameTextBox.Text) || string.IsNullOrEmpty(DescriptionRichTextBox.Text) || string.IsNullOrEmpty(UnitTextBox.Text) 
                || PriceNumericUpDown.Value == 0 || AmountNumericUpDown.Value == 0 || string.IsNullOrEmpty(ArticleTextBox.Text))
            {
                MessageBox.Show("Поля не могут быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product product = new Product(
                ArticleTextBox.Text,
                NameTextBox.Text,
                UnitTextBox.Text,
                (double)PriceNumericUpDown.Value,
                SupplierComboBox.SelectedIndex + 1,
                ManufacturerComboBox.SelectedIndex + 1,
                CategoryComboBox.SelectedIndex + 1,
                (int)DiscountNumericUpDown.Value,
                (int)AmountNumericUpDown.Value,
                DescriptionRichTextBox.Text,
                pictureName
            );

            try
            {
                if(isEditMode)
                {
                    model_.UpdateProduct(product);
                }
                else
                {
                    model_.AddProduct(product);
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FillComboBoxes()
        {
            try
            {
                CategoryComboBox.Items.Clear();
                CategoryComboBox.DataSource = model_.GetCategories();

                ManufacturerComboBox.Items.Clear();
                ManufacturerComboBox.DataSource = model_.GetManufacturers();

                SupplierComboBox.Items.Clear();
                SupplierComboBox.DataSource = model_.GetSuppliers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            if(isEditMode)
            {
                ArticleTextBox.Text = currentProduct_.Article;
                ArticleTextBox.Enabled = false;

                NameTextBox.Text = currentProduct_.Name;
                UnitTextBox.Text = currentProduct_.Unit;
                PriceNumericUpDown.Value = (decimal)currentProduct_.Price;
                SupplierComboBox.SelectedIndex = currentProduct_.SupplierId - 1;
                ManufacturerComboBox.SelectedIndex = currentProduct_.ManufacturerId - 1;
                CategoryComboBox.SelectedIndex = currentProduct_.CategoryId - 1;
                DiscountNumericUpDown.Value = currentProduct_.Discount;
                AmountNumericUpDown.Value = currentProduct_.Amount;
                DescriptionRichTextBox.Text = currentProduct_.Description;
                pictureName = currentProduct_.ImagePath;
                ProductPictureBox.ImageLocation = $"../../../import/{pictureName}";
            }
        }
    }
}
