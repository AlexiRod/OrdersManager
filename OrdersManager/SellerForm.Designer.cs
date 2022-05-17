namespace OrdersManager
{
    partial class SellerForm
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
            this.labelProducts = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnFix = new System.Windows.Forms.Button();
            this.lblArticule = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pbDefected = new System.Windows.Forms.PictureBox();
            this.pbPriced = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbOrders = new System.Windows.Forms.PictureBox();
            this.pbUsers = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPriced)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // labelProducts
            // 
            this.labelProducts.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(0, 91);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(999, 53);
            this.labelProducts.TabIndex = 10;
            this.labelProducts.Text = "Товары на складе:";
            this.labelProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.groupBox);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(7, 168);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(981, 146);
            this.panel.TabIndex = 9;
            this.panel.Visible = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblPrice);
            this.groupBox.Controls.Add(this.btnFix);
            this.groupBox.Controls.Add(this.lblArticule);
            this.groupBox.Controls.Add(this.nudCount);
            this.groupBox.Controls.Add(this.lblCount);
            this.groupBox.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(140, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(829, 121);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Фистинг от Вана Даркхолма";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrice.Location = new System.Drawing.Point(6, 42);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(148, 43);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "Цена: 300$";
            // 
            // btnFix
            // 
            this.btnFix.BackgroundImage = global::OrdersManager.Properties.Resources.Fix;
            this.btnFix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFix.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFix.Location = new System.Drawing.Point(781, 53);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(40, 40);
            this.btnFix.TabIndex = 6;
            this.btnFix.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFix.UseVisualStyleBackColor = true;
            // 
            // lblArticule
            // 
            this.lblArticule.AutoSize = true;
            this.lblArticule.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticule.ForeColor = System.Drawing.Color.DarkGray;
            this.lblArticule.Location = new System.Drawing.Point(8, 80);
            this.lblArticule.Name = "lblArticule";
            this.lblArticule.Size = new System.Drawing.Size(116, 34);
            this.lblArticule.TabIndex = 9;
            this.lblArticule.Text = "#133722869";
            // 
            // nudCount
            // 
            this.nudCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCount.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCount.Location = new System.Drawing.Point(628, 56);
            this.nudCount.Name = "nudCount";
            this.nudCount.Size = new System.Drawing.Size(147, 35);
            this.nudCount.TabIndex = 5;
            this.nudCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCount.Location = new System.Drawing.Point(507, 59);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(117, 34);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "На складе: ";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::OrdersManager.Properties.Resources.NoImage;
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.pbDefected);
            this.panelHeader.Controls.Add(this.pbPriced);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.pbOrders);
            this.panelHeader.Controls.Add(this.pbUsers);
            this.panelHeader.Controls.Add(this.pbExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1020, 62);
            this.panelHeader.TabIndex = 11;
            // 
            // pbDefected
            // 
            this.pbDefected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbDefected.Image = global::OrdersManager.Properties.Resources.Defected;
            this.pbDefected.Location = new System.Drawing.Point(701, 0);
            this.pbDefected.Name = "pbDefected";
            this.pbDefected.Size = new System.Drawing.Size(60, 60);
            this.pbDefected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDefected.TabIndex = 5;
            this.pbDefected.TabStop = false;
            this.pbDefected.Click += new System.EventHandler(this.pbDefected_Click);
            // 
            // pbPriced
            // 
            this.pbPriced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPriced.Image = global::OrdersManager.Properties.Resources.Priced;
            this.pbPriced.Location = new System.Drawing.Point(761, 0);
            this.pbPriced.Name = "pbPriced";
            this.pbPriced.Size = new System.Drawing.Size(60, 60);
            this.pbPriced.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPriced.TabIndex = 4;
            this.pbPriced.TabStop = false;
            this.pbPriced.Click += new System.EventHandler(this.pbPriced_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(13, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(403, 50);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Редактирование товаров";
            // 
            // pbOrders
            // 
            this.pbOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbOrders.Image = global::OrdersManager.Properties.Resources.Orders;
            this.pbOrders.Location = new System.Drawing.Point(821, 0);
            this.pbOrders.Name = "pbOrders";
            this.pbOrders.Size = new System.Drawing.Size(60, 60);
            this.pbOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOrders.TabIndex = 2;
            this.pbOrders.TabStop = false;
            this.pbOrders.Click += new System.EventHandler(this.pbOrders_Click);
            // 
            // pbUsers
            // 
            this.pbUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUsers.Image = global::OrdersManager.Properties.Resources.Users;
            this.pbUsers.Location = new System.Drawing.Point(881, 0);
            this.pbUsers.Name = "pbUsers";
            this.pbUsers.Size = new System.Drawing.Size(60, 60);
            this.pbUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsers.TabIndex = 1;
            this.pbUsers.TabStop = false;
            this.pbUsers.Click += new System.EventHandler(this.pbUsers_Click);
            // 
            // pbExit
            // 
            this.pbExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExit.Image = global::OrdersManager.Properties.Resources.Exit;
            this.pbExit.Location = new System.Drawing.Point(941, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(60, 60);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 0;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1020, 767);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "SellerForm";
            this.Text = "Продавец";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPriced)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.Label lblArticule;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbOrders;
        private System.Windows.Forms.PictureBox pbUsers;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.PictureBox pbDefected;
        private System.Windows.Forms.PictureBox pbPriced;
    }
}