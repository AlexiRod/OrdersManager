namespace OrdersManager
{
    partial class ExtraEnterForm
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
            this.btnApply = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBoxExtra = new System.Windows.Forms.GroupBox();
            this.btnFixImage = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.tbAdress = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.tbTelephone = new System.Windows.Forms.TextBox();
            this.groupBoxExtra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.White;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Location = new System.Drawing.Point(23, 430);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(500, 43);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Зарегестрироваться";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(186, 129);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(336, 39);
            this.tbPassword.TabIndex = 10;
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLogin.Location = new System.Drawing.Point(186, 70);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(336, 39);
            this.tbLogin.TabIndex = 9;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(16, 134);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(172, 34);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Введите пароль*";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(16, 75);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(161, 34);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Введите e-mail*";
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(3, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(519, 46);
            this.lblHeader.TabIndex = 6;
            this.lblHeader.Text = "Регистрация";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(116, 55);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(241, 39);
            this.tbName.TabIndex = 13;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(104, 36);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Никнейм";
            // 
            // groupBoxExtra
            // 
            this.groupBoxExtra.Controls.Add(this.btnFixImage);
            this.groupBoxExtra.Controls.Add(this.pbImage);
            this.groupBoxExtra.Controls.Add(this.lblAdress);
            this.groupBoxExtra.Controls.Add(this.tbAdress);
            this.groupBoxExtra.Controls.Add(this.lblTelephone);
            this.groupBoxExtra.Controls.Add(this.tbTelephone);
            this.groupBoxExtra.Controls.Add(this.lblName);
            this.groupBoxExtra.Controls.Add(this.tbName);
            this.groupBoxExtra.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxExtra.Location = new System.Drawing.Point(22, 184);
            this.groupBoxExtra.Name = "groupBoxExtra";
            this.groupBoxExtra.Size = new System.Drawing.Size(500, 231);
            this.groupBoxExtra.TabIndex = 14;
            this.groupBoxExtra.TabStop = false;
            this.groupBoxExtra.Text = "Дополнительная информация";
            // 
            // btnFixImage
            // 
            this.btnFixImage.BackColor = System.Drawing.Color.White;
            this.btnFixImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFixImage.Location = new System.Drawing.Point(363, 182);
            this.btnFixImage.Name = "btnFixImage";
            this.btnFixImage.Size = new System.Drawing.Size(121, 34);
            this.btnFixImage.TabIndex = 15;
            this.btnFixImage.Text = "Изменить";
            this.btnFixImage.UseVisualStyleBackColor = false;
            this.btnFixImage.Click += new System.EventHandler(this.btnFixImage_Click);
            // 
            // pbImage
            // 
            this.pbImage.Image = global::OrdersManager.Properties.Resources.Account;
            this.pbImage.Location = new System.Drawing.Point(363, 55);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(121, 121);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 18;
            this.pbImage.TabStop = false;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(10, 180);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(76, 36);
            this.lblAdress.TabIndex = 16;
            this.lblAdress.Text = "Адрес";
            // 
            // tbAdress
            // 
            this.tbAdress.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAdress.Location = new System.Drawing.Point(92, 177);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Size = new System.Drawing.Size(265, 39);
            this.tbAdress.TabIndex = 17;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(10, 122);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(105, 36);
            this.lblTelephone.TabIndex = 14;
            this.lblTelephone.Text = "Телефон";
            // 
            // tbTelephone
            // 
            this.tbTelephone.Font = new System.Drawing.Font("Myanmar Text", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelephone.Location = new System.Drawing.Point(116, 119);
            this.tbTelephone.Name = "tbTelephone";
            this.tbTelephone.Size = new System.Drawing.Size(241, 39);
            this.tbTelephone.TabIndex = 15;
            // 
            // ExtraEnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 492);
            this.Controls.Add(this.groupBoxExtra);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(560, 539);
            this.MinimumSize = new System.Drawing.Size(560, 539);
            this.Name = "ExtraEnterForm";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.ExtraEnterForm_Load);
            this.groupBoxExtra.ResumeLayout(false);
            this.groupBoxExtra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBoxExtra;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox tbAdress;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox tbTelephone;
        private System.Windows.Forms.Button btnFixImage;
        private System.Windows.Forms.PictureBox pbImage;
    }
}