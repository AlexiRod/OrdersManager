namespace OrdersManager
{
    partial class AccountForm
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
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblOrders = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPhoto
            // 
            this.pbPhoto.Image = global::OrdersManager.Properties.Resources.Account;
            this.pbPhoto.Location = new System.Drawing.Point(8, 72);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(180, 180);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhoto.TabIndex = 1;
            this.pbPhoto.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(14, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(490, 60);
            this.labelHeader.TabIndex = 9;
            this.labelHeader.Text = "Информация о профиле";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(205, 125);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(83, 36);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "Логин: ";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(205, 167);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(114, 36);
            this.lblTelephone.TabIndex = 11;
            this.lblTelephone.Text = "Телефон: ";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(205, 209);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(85, 36);
            this.lblAdress.TabIndex = 12;
            this.lblAdress.Text = "Адрес: ";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(157, 266);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(177, 36);
            this.lblList.TabIndex = 13;
            this.lblList.Text = "Список заказов:";
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Location = new System.Drawing.Point(17, 302);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(0, 36);
            this.lblOrders.TabIndex = 14;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(205, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(113, 36);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Никнейм: ";
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(515, 676);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.pbPhoto);
            this.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximumSize = new System.Drawing.Size(533, 723);
            this.MinimumSize = new System.Drawing.Size(533, 723);
            this.Name = "AccountForm";
            this.Text = "Информация";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.Label lblName;
    }
}