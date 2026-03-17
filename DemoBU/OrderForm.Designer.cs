namespace DemoBU
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrderList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OrderCard = new OrderCard.OrderView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderList
            // 
            this.OrderList.FormattingEnabled = true;
            this.OrderList.Location = new System.Drawing.Point(12, 32);
            this.OrderList.Name = "OrderList";
            this.OrderList.Size = new System.Drawing.Size(272, 199);
            this.OrderList.TabIndex = 0;
            this.OrderList.SelectedIndexChanged += new System.EventHandler(this.OrderList_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OrderCard);
            this.panel1.Location = new System.Drawing.Point(290, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 197);
            this.panel1.TabIndex = 1;
            // 
            // OrderCard
            // 
            this.OrderCard.BackColor = System.Drawing.Color.White;
            this.OrderCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderCard.Location = new System.Drawing.Point(0, 0);
            this.OrderCard.Name = "OrderCard";
            this.OrderCard.Size = new System.Drawing.Size(721, 197);
            this.OrderCard.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить заказ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 258);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OrderList);
            this.Name = "OrderForm";
            this.Text = "AddOrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox OrderList;
        private System.Windows.Forms.Panel panel1;
        private OrderCard.OrderView OrderCard;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}