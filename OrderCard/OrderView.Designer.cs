namespace OrderCard
{
    partial class OrderView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ArticleLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.OrderDate = new System.Windows.Forms.Label();
            this.ArrivalDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ArticleLabel
            // 
            this.ArticleLabel.AutoSize = true;
            this.ArticleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArticleLabel.Location = new System.Drawing.Point(38, 38);
            this.ArticleLabel.Name = "ArticleLabel";
            this.ArticleLabel.Size = new System.Drawing.Size(79, 20);
            this.ArticleLabel.TabIndex = 0;
            this.ArticleLabel.Text = "Артикул";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatusLabel.Location = new System.Drawing.Point(39, 68);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(89, 15);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Статус заказа";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.Location = new System.Drawing.Point(39, 97);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(129, 15);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Адрес пункта выдачи";
            // 
            // OrderDate
            // 
            this.OrderDate.AutoSize = true;
            this.OrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderDate.Location = new System.Drawing.Point(39, 120);
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Size = new System.Drawing.Size(79, 15);
            this.OrderDate.TabIndex = 0;
            this.OrderDate.Text = "Дата заказа";
            // 
            // ArrivalDate
            // 
            this.ArrivalDate.AutoSize = true;
            this.ArrivalDate.Location = new System.Drawing.Point(520, 79);
            this.ArrivalDate.Name = "ArrivalDate";
            this.ArrivalDate.Size = new System.Drawing.Size(83, 13);
            this.ArrivalDate.TabIndex = 0;
            this.ArrivalDate.Text = "Дата доставки";
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ArrivalDate);
            this.Controls.Add(this.OrderDate);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.ArticleLabel);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(637, 174);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ArticleLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label OrderDate;
        private System.Windows.Forms.Label ArrivalDate;
    }
}
