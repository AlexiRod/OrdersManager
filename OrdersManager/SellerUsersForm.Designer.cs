namespace OrdersManager
{
    partial class SellerUsersForm
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
            this.labelUsers = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUsers
            // 
            this.labelUsers.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.Location = new System.Drawing.Point(1, 22);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(820, 53);
            this.labelUsers.TabIndex = 11;
            this.labelUsers.Text = "Список пользователей";
            this.labelUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.groupBox);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(12, 108);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(846, 173);
            this.panel.TabIndex = 12;
            this.panel.Visible = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblTelephone);
            this.groupBox.Controls.Add(this.lblAdress);
            this.groupBox.Controls.Add(this.lblLogin);
            this.groupBox.Controls.Add(this.btnInfo);
            this.groupBox.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(140, 9);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(694, 147);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ван Даркхолм";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTelephone.Location = new System.Drawing.Point(8, 109);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(128, 34);
            this.lblTelephone.TabIndex = 9;
            this.lblTelephone.Text = "+7133722869";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Font = new System.Drawing.Font("Myanmar Text", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdress.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAdress.Location = new System.Drawing.Point(8, 81);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(143, 34);
            this.lblAdress.TabIndex = 10;
            this.lblAdress.Text = "Ulitsa Pushkina";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblLogin.Location = new System.Drawing.Point(8, 44);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(336, 43);
            this.lblLogin.TabIndex = 9;
            this.lblLogin.Text = "DungMaster1488@gmail.com";
            // 
            // btnInfo
            // 
            this.btnInfo.BackgroundImage = global::OrdersManager.Properties.Resources.Information;
            this.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfo.Location = new System.Drawing.Point(634, 67);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::OrdersManager.Properties.Resources.NoImage;
            this.pictureBox.Location = new System.Drawing.Point(12, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(120, 120);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // SellerUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(882, 631);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.labelUsers);
            this.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(900, 678);
            this.MinimumSize = new System.Drawing.Size(900, 678);
            this.Name = "SellerUsersForm";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.SellerUsersForm_Load);
            this.panel.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblAdress;
    }
}