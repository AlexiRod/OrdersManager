namespace OrdersManager
{
    partial class SellerOredersForm
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
            this.labelOrders = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblPaid = new System.Windows.Forms.Label();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnShowActive = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelOrders
            // 
            this.labelOrders.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrders.Location = new System.Drawing.Point(3, 26);
            this.labelOrders.Name = "labelOrders";
            this.labelOrders.Size = new System.Drawing.Size(820, 53);
            this.labelOrders.TabIndex = 12;
            this.labelOrders.Text = "Список заказов";
            this.labelOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblPaid);
            this.groupBox.Controls.Add(this.cbStatus);
            this.groupBox.Controls.Add(this.lblDate);
            this.groupBox.Controls.Add(this.lblStatus);
            this.groupBox.Controls.Add(this.lblPrice);
            this.groupBox.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(12, 137);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(863, 125);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Заказ №14881337";
            this.groupBox.Visible = false;
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPaid.Location = new System.Drawing.Point(414, 62);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(121, 34);
            this.lblPaid.TabIndex = 15;
            this.lblPaid.Text = "Оплата: Да";
            this.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbStatus
            // 
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(622, 62);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(222, 28);
            this.cbStatus.TabIndex = 14;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkGray;
            this.lblDate.Location = new System.Drawing.Point(15, 82);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(142, 34);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "12.3.2020 19:56";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblStatus.Location = new System.Drawing.Point(539, 62);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 34);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Статус:";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrice.Location = new System.Drawing.Point(12, 45);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(308, 43);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Общая стоимость: 300$";
            // 
            // btnShowActive
            // 
            this.btnShowActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowActive.Location = new System.Drawing.Point(14, 96);
            this.btnShowActive.Name = "btnShowActive";
            this.btnShowActive.Size = new System.Drawing.Size(281, 35);
            this.btnShowActive.TabIndex = 14;
            this.btnShowActive.Text = "Показать активные заказы";
            this.btnShowActive.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnShowActive.UseVisualStyleBackColor = true;
            this.btnShowActive.Click += new System.EventHandler(this.btnShowActive_Click);
            // 
            // SellerOredersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(887, 587);
            this.Controls.Add(this.btnShowActive);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.labelOrders);
            this.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(905, 634);
            this.MinimumSize = new System.Drawing.Size(905, 634);
            this.Name = "SellerOredersForm";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.SellerOredersForm_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelOrders;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnShowActive;
    }
}