namespace OrdersManager
{
    partial class OrderMakeForm
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnInfo = new System.Windows.Forms.Button();
            this.nudCount = new System.Windows.Forms.NumericUpDown();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.Font = new System.Drawing.Font("Myanmar Text", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(-1, 9);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(755, 53);
            this.labelHeader.TabIndex = 9;
            this.labelHeader.Text = "Оформление заказа";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel
            // 
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.lblPrice);
            this.panel.Controls.Add(this.btnInfo);
            this.panel.Controls.Add(this.nudCount);
            this.panel.Controls.Add(this.pictureBox);
            this.panel.Controls.Add(this.lblName);
            this.panel.Location = new System.Drawing.Point(6, 50);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(717, 93);
            this.panel.TabIndex = 10;
            this.panel.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrice.Location = new System.Drawing.Point(93, 44);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(200, 43);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Цена: 300 бакс";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnInfo
            // 
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInfo.Location = new System.Drawing.Point(666, 29);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(35, 35);
            this.btnInfo.TabIndex = 6;
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInfo.UseVisualStyleBackColor = true;
            // 
            // nudCount
            // 
            this.nudCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudCount.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudCount.Location = new System.Drawing.Point(566, 29);
            this.nudCount.Name = "nudCount";
            this.nudCount.ReadOnly = true;
            this.nudCount.Size = new System.Drawing.Size(92, 35);
            this.nudCount.TabIndex = 5;
            this.nudCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::OrdersManager.Properties.Resources.NoImage;
            this.pictureBox.Location = new System.Drawing.Point(3, 3);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(84, 84);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Myanmar Text", 16.2F);
            this.lblName.Location = new System.Drawing.Point(92, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(425, 50);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Фистинг от Вана Даркхолма";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(383, 86);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(360, 50);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Подтвердить заказ";
            this.btnAccept.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(13, 86);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(360, 50);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отменить заказ";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox
            // 
            this.groupBox.AutoSize = true;
            this.groupBox.Controls.Add(this.panel);
            this.groupBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(13, 157);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(729, 219);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Товары/услуги в заказе:";
            // 
            // OrderMakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(769, 674);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.labelHeader);
            this.Font = new System.Drawing.Font("Myanmar Text", 10.8F);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximumSize = new System.Drawing.Size(787, 721);
            this.MinimumSize = new System.Drawing.Size(787, 721);
            this.Name = "OrderMakeForm";
            this.Text = "Новый заказ";
            this.Load += new System.EventHandler(this.OrderMakeForm_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudCount;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox;
    }
}