namespace OrdersManager
{
    partial class UserForm
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
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblArticule = new System.Windows.Forms.Label();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.lblCount = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbBasket = new System.Windows.Forms.PictureBox();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.labelProducts = new System.Windows.Forms.Label();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.groupBox);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(7, 157);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(981, 146);
            this.panel.TabIndex = 0;
            this.panel.Visible = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblPrice);
            this.groupBox.Controls.Add(this.btnInfo);
            this.groupBox.Controls.Add(this.lblEmpty);
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
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfo.Location = new System.Drawing.Point(781, 53);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.Text = "i";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblEmpty.Location = new System.Drawing.Point(572, 97);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(249, 17);
            this.lblEmpty.TabIndex = 7;
            this.lblEmpty.Text = "На складе больше нет этого товара!";
            this.lblEmpty.Visible = false;
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
            this.lblCount.Location = new System.Drawing.Point(622, 29);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(137, 34);
            this.lblCount.TabIndex = 10;
            this.lblCount.Text = "На складе: 24";
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
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.pbBasket);
            this.panelHeader.Controls.Add(this.pbProfile);
            this.panelHeader.Controls.Add(this.pbExit);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1018, 62);
            this.panelHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(13, 13);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(601, 50);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Выбор товаров и оформление заказов";
            // 
            // pbBasket
            // 
            this.pbBasket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBasket.Image = global::OrdersManager.Properties.Resources.Basket;
            this.pbBasket.Location = new System.Drawing.Point(819, 0);
            this.pbBasket.Name = "pbBasket";
            this.pbBasket.Size = new System.Drawing.Size(60, 60);
            this.pbBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBasket.TabIndex = 2;
            this.pbBasket.TabStop = false;
            this.pbBasket.Click += new System.EventHandler(this.pbBasket_Click);
            // 
            // pbProfile
            // 
            this.pbProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbProfile.Image = global::OrdersManager.Properties.Resources.Account;
            this.pbProfile.Location = new System.Drawing.Point(879, 0);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(60, 60);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 1;
            this.pbProfile.TabStop = false;
            this.pbProfile.Click += new System.EventHandler(this.pbProfile_Click);
            // 
            // pbExit
            // 
            this.pbExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbExit.Image = global::OrdersManager.Properties.Resources.Exit;
            this.pbExit.Location = new System.Drawing.Point(939, 0);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(60, 60);
            this.pbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExit.TabIndex = 0;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // labelProducts
            // 
            this.labelProducts.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProducts.Location = new System.Drawing.Point(0, 80);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(999, 53);
            this.labelProducts.TabIndex = 8;
            this.labelProducts.Text = "Доступные товары:";
            this.labelProducts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMakeOrder.Location = new System.Drawing.Point(740, 116);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(248, 35);
            this.btnMakeOrder.TabIndex = 9;
            this.btnMakeOrder.Text = "Оформить заказ";
            this.btnMakeOrder.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1018, 744);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(1036, 791);
            this.MinimumSize = new System.Drawing.Size(1036, 791);
            this.Name = "UserForm";
            this.Text = "Пользователь ";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.panel.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox pbBasket;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblArticule;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Label lblCount;
    }
}