namespace OrdersManager
{
    partial class PriceReportForm
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
            this.lblUsersSum = new System.Windows.Forms.Label();
            this.nudSum = new System.Windows.Forms.NumericUpDown();
            this.btnShow = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelUsers = new System.Windows.Forms.Label();
            this.lblListUsers = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudSum)).BeginInit();
            this.panel.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsersSum
            // 
            this.lblUsersSum.AutoSize = true;
            this.lblUsersSum.Location = new System.Drawing.Point(12, 108);
            this.lblUsersSum.Name = "lblUsersSum";
            this.lblUsersSum.Size = new System.Drawing.Size(577, 34);
            this.lblUsersSum.TabIndex = 0;
            this.lblUsersSum.Text = "Сумма, которую должны превышать траты пользователей:";
            // 
            // nudSum
            // 
            this.nudSum.Font = new System.Drawing.Font("Verdana", 13.8F);
            this.nudSum.Location = new System.Drawing.Point(586, 102);
            this.nudSum.Name = "nudSum";
            this.nudSum.Size = new System.Drawing.Size(225, 35);
            this.nudSum.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 154);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(391, 38);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Показать пользователей";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.groupBox);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Location = new System.Drawing.Point(12, 240);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(799, 173);
            this.panel.TabIndex = 13;
            this.panel.Visible = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblSum);
            this.groupBox.Controls.Add(this.lblTelephone);
            this.groupBox.Controls.Add(this.lblAdress);
            this.groupBox.Controls.Add(this.lblLogin);
            this.groupBox.Font = new System.Drawing.Font("Myanmar Text", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(138, 10);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(655, 147);
            this.groupBox.TabIndex = 8;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Ван Даркхолм";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblSum.Location = new System.Drawing.Point(386, 72);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(111, 43);
            this.lblSum.TabIndex = 11;
            this.lblSum.Text = "Сумма:";
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
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(420, 154);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(391, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить отчет (.txt)";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelUsers
            // 
            this.labelUsers.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsers.Location = new System.Drawing.Point(0, 26);
            this.labelUsers.Name = "labelUsers";
            this.labelUsers.Size = new System.Drawing.Size(820, 53);
            this.labelUsers.TabIndex = 14;
            this.labelUsers.Text = "Отчет о пользователях по сумме трат";
            this.labelUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblListUsers
            // 
            this.lblListUsers.AutoSize = true;
            this.lblListUsers.Location = new System.Drawing.Point(12, 201);
            this.lblListUsers.Name = "lblListUsers";
            this.lblListUsers.Size = new System.Drawing.Size(354, 34);
            this.lblListUsers.TabIndex = 15;
            this.lblListUsers.Text = "Список подходящих пользователей:";
            this.lblListUsers.Visible = false;
            // 
            // PriceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(841, 681);
            this.Controls.Add(this.lblListUsers);
            this.Controls.Add(this.labelUsers);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.nudSum);
            this.Controls.Add(this.lblUsersSum);
            this.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(859, 728);
            this.MinimumSize = new System.Drawing.Size(859, 728);
            this.Name = "PriceReportForm";
            this.Text = "Отчет по сумме";
            this.Load += new System.EventHandler(this.PriceReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSum)).EndInit();
            this.panel.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsersSum;
        private System.Windows.Forms.NumericUpDown nudSum;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelUsers;
        private System.Windows.Forms.Label lblListUsers;
    }
}