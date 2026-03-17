namespace DemoBU
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ProductList = new System.Windows.Forms.ListBox();
            this.MenuStrip = new System.Windows.Forms.ToolStrip();
            this.AddProductButton = new System.Windows.Forms.ToolStripButton();
            this.EditProductButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteProductButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.SearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.SortDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AscendingSortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.DescendingSortButton = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshButton = new System.Windows.Forms.ToolStripMenuItem();
            this.FilterDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.AllSuppliersFilterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.KariFilterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BootsFotYouFilterButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormButton = new System.Windows.Forms.ToolStripButton();
            this.UserFIOLabel = new System.Windows.Forms.Label();
            this.CardPanel = new System.Windows.Forms.Panel();
            this.ProductCard = new ProductCard.ProductView();
            this.MenuStrip.SuspendLayout();
            this.CardPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(12, 31);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(188, 251);
            this.ProductList.TabIndex = 0;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProductButton,
            this.EditProductButton,
            this.DeleteProductButton,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.SearchTextBox,
            this.SortDropDownButton,
            this.FilterDropDownButton,
            this.OrderFormButton});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(976, 35);
            this.MenuStrip.TabIndex = 1;
            this.MenuStrip.Text = "Редактировать";
            // 
            // AddProductButton
            // 
            this.AddProductButton.AutoSize = false;
            this.AddProductButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddProductButton.Image = ((System.Drawing.Image)(resources.GetObject("AddProductButton.Image")));
            this.AddProductButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(32, 32);
            this.AddProductButton.Text = "Добавить";
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // EditProductButton
            // 
            this.EditProductButton.AutoSize = false;
            this.EditProductButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditProductButton.Image = ((System.Drawing.Image)(resources.GetObject("EditProductButton.Image")));
            this.EditProductButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditProductButton.Name = "EditProductButton";
            this.EditProductButton.Size = new System.Drawing.Size(32, 32);
            this.EditProductButton.Text = "Редактировать";
            this.EditProductButton.Click += new System.EventHandler(this.EditProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.AutoSize = false;
            this.DeleteProductButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteProductButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteProductButton.Image")));
            this.DeleteProductButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(32, 32);
            this.DeleteProductButton.Text = "Удалить";
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(45, 32);
            this.toolStripLabel1.Text = "Поиск:";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(100, 35);
            this.SearchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // SortDropDownButton
            // 
            this.SortDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SortDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AscendingSortButton,
            this.DescendingSortButton,
            this.RefreshButton});
            this.SortDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("SortDropDownButton.Image")));
            this.SortDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortDropDownButton.Name = "SortDropDownButton";
            this.SortDropDownButton.Size = new System.Drawing.Size(29, 32);
            this.SortDropDownButton.Text = "Сортировка";
            // 
            // AscendingSortButton
            // 
            this.AscendingSortButton.Name = "AscendingSortButton";
            this.AscendingSortButton.Size = new System.Drawing.Size(165, 22);
            this.AscendingSortButton.Text = "По возрастанию";
            this.AscendingSortButton.Click += new System.EventHandler(this.AscendingSortButton_Click);
            // 
            // DescendingSortButton
            // 
            this.DescendingSortButton.Name = "DescendingSortButton";
            this.DescendingSortButton.Size = new System.Drawing.Size(165, 22);
            this.DescendingSortButton.Text = "По убыванию";
            this.DescendingSortButton.Click += new System.EventHandler(this.DescendingSortButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(165, 22);
            this.RefreshButton.Text = "Сброс";
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // FilterDropDownButton
            // 
            this.FilterDropDownButton.AutoSize = false;
            this.FilterDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FilterDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AllSuppliersFilterButton,
            this.KariFilterButton,
            this.BootsFotYouFilterButton});
            this.FilterDropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("FilterDropDownButton.Image")));
            this.FilterDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FilterDropDownButton.Name = "FilterDropDownButton";
            this.FilterDropDownButton.Size = new System.Drawing.Size(32, 32);
            this.FilterDropDownButton.Text = "Фильтрация";
            // 
            // AllSuppliersFilterButton
            // 
            this.AllSuppliersFilterButton.Name = "AllSuppliersFilterButton";
            this.AllSuppliersFilterButton.Size = new System.Drawing.Size(164, 22);
            this.AllSuppliersFilterButton.Text = "Все поставщики";
            this.AllSuppliersFilterButton.Click += new System.EventHandler(this.AllSuppliersFilterButton_Click);
            // 
            // KariFilterButton
            // 
            this.KariFilterButton.Name = "KariFilterButton";
            this.KariFilterButton.Size = new System.Drawing.Size(164, 22);
            this.KariFilterButton.Text = "Kari";
            this.KariFilterButton.Click += new System.EventHandler(this.KariFilterButton_Click);
            // 
            // BootsFotYouFilterButton
            // 
            this.BootsFotYouFilterButton.Name = "BootsFotYouFilterButton";
            this.BootsFotYouFilterButton.Size = new System.Drawing.Size(164, 22);
            this.BootsFotYouFilterButton.Text = "Обувь для вас";
            this.BootsFotYouFilterButton.Click += new System.EventHandler(this.BootsFotYouFilterButton_Click);
            // 
            // OrderFormButton
            // 
            this.OrderFormButton.AutoSize = false;
            this.OrderFormButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OrderFormButton.Image = ((System.Drawing.Image)(resources.GetObject("OrderFormButton.Image")));
            this.OrderFormButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OrderFormButton.Name = "OrderFormButton";
            this.OrderFormButton.Size = new System.Drawing.Size(32, 32);
            this.OrderFormButton.Text = "Посмотреть заказы";
            this.OrderFormButton.Click += new System.EventHandler(this.OrderFormButton_Click);
            // 
            // UserFIOLabel
            // 
            this.UserFIOLabel.AutoSize = true;
            this.UserFIOLabel.Location = new System.Drawing.Point(929, 9);
            this.UserFIOLabel.Name = "UserFIOLabel";
            this.UserFIOLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UserFIOLabel.Size = new System.Drawing.Size(35, 13);
            this.UserFIOLabel.TabIndex = 2;
            this.UserFIOLabel.Text = "label1";
            // 
            // CardPanel
            // 
            this.CardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardPanel.Controls.Add(this.ProductCard);
            this.CardPanel.Location = new System.Drawing.Point(207, 31);
            this.CardPanel.Name = "CardPanel";
            this.CardPanel.Size = new System.Drawing.Size(758, 251);
            this.CardPanel.TabIndex = 3;
            // 
            // ProductCard
            // 
            this.ProductCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductCard.BackColor = System.Drawing.Color.White;
            this.ProductCard.Location = new System.Drawing.Point(0, 0);
            this.ProductCard.Name = "ProductCard";
            this.ProductCard.Size = new System.Drawing.Size(758, 251);
            this.ProductCard.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 297);
            this.Controls.Add(this.CardPanel);
            this.Controls.Add(this.UserFIOLabel);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ProductList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.CardPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.ToolStrip MenuStrip;
        private System.Windows.Forms.ToolStripButton AddProductButton;
        private System.Windows.Forms.ToolStripButton EditProductButton;
        private System.Windows.Forms.ToolStripButton DeleteProductButton;
        private System.Windows.Forms.Label UserFIOLabel;
        private System.Windows.Forms.Panel CardPanel;
        private ProductCard.ProductView ProductCard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox SearchTextBox;
        private System.Windows.Forms.ToolStripDropDownButton SortDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem AscendingSortButton;
        private System.Windows.Forms.ToolStripMenuItem DescendingSortButton;
        private System.Windows.Forms.ToolStripMenuItem RefreshButton;
        private System.Windows.Forms.ToolStripDropDownButton FilterDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem AllSuppliersFilterButton;
        private System.Windows.Forms.ToolStripMenuItem KariFilterButton;
        private System.Windows.Forms.ToolStripMenuItem BootsFotYouFilterButton;
        private System.Windows.Forms.ToolStripButton OrderFormButton;
    }
}

