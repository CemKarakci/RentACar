namespace RentC.Presentation
{
    partial class MainMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.registerNewCarRentButton = new System.Windows.Forms.Button();
            this.listRentsButton = new System.Windows.Forms.Button();
            this.registerNewCustomerButton = new System.Windows.Forms.Button();
            this.updateCustomerButton = new System.Windows.Forms.Button();
            this.listCustomersButton = new System.Windows.Forms.Button();
            this.listAvailableCarsButton = new System.Windows.Forms.Button();
            this.updateCarRentButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Reportbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registerNewCarRentButton
            // 
            this.registerNewCarRentButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registerNewCarRentButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.registerNewCarRentButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.registerNewCarRentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerNewCarRentButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.registerNewCarRentButton.Location = new System.Drawing.Point(94, 171);
            this.registerNewCarRentButton.Name = "registerNewCarRentButton";
            this.registerNewCarRentButton.Size = new System.Drawing.Size(300, 75);
            this.registerNewCarRentButton.TabIndex = 0;
            this.registerNewCarRentButton.Text = "REGISTER NEW CAR RENT";
            this.registerNewCarRentButton.UseVisualStyleBackColor = false;
            this.registerNewCarRentButton.Click += new System.EventHandler(this.registerNewCarRentButton_Click);
            // 
            // listRentsButton
            // 
            this.listRentsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listRentsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listRentsButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listRentsButton.Location = new System.Drawing.Point(94, 443);
            this.listRentsButton.Name = "listRentsButton";
            this.listRentsButton.Size = new System.Drawing.Size(300, 75);
            this.listRentsButton.TabIndex = 1;
            this.listRentsButton.Text = "LIST RENTS";
            this.listRentsButton.UseVisualStyleBackColor = true;
            this.listRentsButton.Click += new System.EventHandler(this.listRentsButton_Click);
            // 
            // registerNewCustomerButton
            // 
            this.registerNewCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.registerNewCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerNewCustomerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.registerNewCustomerButton.Location = new System.Drawing.Point(538, 304);
            this.registerNewCustomerButton.Name = "registerNewCustomerButton";
            this.registerNewCustomerButton.Size = new System.Drawing.Size(300, 75);
            this.registerNewCustomerButton.TabIndex = 2;
            this.registerNewCustomerButton.Text = "REGISTER NEW CUSTOMER";
            this.registerNewCustomerButton.UseVisualStyleBackColor = true;
            this.registerNewCustomerButton.Click += new System.EventHandler(this.registerNewCustomerButton_Click);
            // 
            // updateCustomerButton
            // 
            this.updateCustomerButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateCustomerButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.updateCustomerButton.Location = new System.Drawing.Point(538, 443);
            this.updateCustomerButton.Name = "updateCustomerButton";
            this.updateCustomerButton.Size = new System.Drawing.Size(300, 75);
            this.updateCustomerButton.TabIndex = 3;
            this.updateCustomerButton.Text = "UPDATE CUSTOMER";
            this.updateCustomerButton.UseVisualStyleBackColor = true;
            this.updateCustomerButton.Click += new System.EventHandler(this.updateCustomerButton_Click);
            // 
            // listCustomersButton
            // 
            this.listCustomersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listCustomersButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listCustomersButton.Location = new System.Drawing.Point(94, 566);
            this.listCustomersButton.Name = "listCustomersButton";
            this.listCustomersButton.Size = new System.Drawing.Size(300, 75);
            this.listCustomersButton.TabIndex = 4;
            this.listCustomersButton.Text = "LIST CUSTOMERS";
            this.listCustomersButton.UseVisualStyleBackColor = true;
            this.listCustomersButton.Click += new System.EventHandler(this.listCustomersButton_Click);
            // 
            // listAvailableCarsButton
            // 
            this.listAvailableCarsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listAvailableCarsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listAvailableCarsButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listAvailableCarsButton.Location = new System.Drawing.Point(538, 181);
            this.listAvailableCarsButton.Name = "listAvailableCarsButton";
            this.listAvailableCarsButton.Size = new System.Drawing.Size(300, 75);
            this.listAvailableCarsButton.TabIndex = 5;
            this.listAvailableCarsButton.Text = "LIST AVAILABLE CARS";
            this.listAvailableCarsButton.UseVisualStyleBackColor = true;
            this.listAvailableCarsButton.Click += new System.EventHandler(this.listAvailableCarsButton_Click);
            // 
            // updateCarRentButton
            // 
            this.updateCarRentButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updateCarRentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateCarRentButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.updateCarRentButton.Location = new System.Drawing.Point(94, 304);
            this.updateCarRentButton.Name = "updateCarRentButton";
            this.updateCarRentButton.Size = new System.Drawing.Size(300, 75);
            this.updateCarRentButton.TabIndex = 6;
            this.updateCarRentButton.Text = "UPDATE CAR RENT";
            this.updateCarRentButton.UseVisualStyleBackColor = true;
            this.updateCarRentButton.Click += new System.EventHandler(this.updateCarRentButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.quitButton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.quitButton.Location = new System.Drawing.Point(318, 739);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(300, 70);
            this.quitButton.TabIndex = 7;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(133, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(660, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Welcome to RentC, your brand new solution to manage and control";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(222, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(456, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "your company\'s data without missing anything";
            // 
            // Reportbutton
            // 
            this.Reportbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Reportbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Reportbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Reportbutton.Location = new System.Drawing.Point(538, 568);
            this.Reportbutton.Name = "Reportbutton";
            this.Reportbutton.Size = new System.Drawing.Size(300, 75);
            this.Reportbutton.TabIndex = 10;
            this.Reportbutton.Text = "REPORTS";
            this.Reportbutton.UseVisualStyleBackColor = true;
            this.Reportbutton.Click += new System.EventHandler(this.Reportbutton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 944);
            this.Controls.Add(this.Reportbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.updateCarRentButton);
            this.Controls.Add(this.listAvailableCarsButton);
            this.Controls.Add(this.listCustomersButton);
            this.Controls.Add(this.updateCustomerButton);
            this.Controls.Add(this.registerNewCustomerButton);
            this.Controls.Add(this.listRentsButton);
            this.Controls.Add(this.registerNewCarRentButton);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerNewCarRentButton;
        private System.Windows.Forms.Button listRentsButton;
        private System.Windows.Forms.Button registerNewCustomerButton;
        private System.Windows.Forms.Button updateCustomerButton;
        private System.Windows.Forms.Button listCustomersButton;
        private System.Windows.Forms.Button listAvailableCarsButton;
        private System.Windows.Forms.Button updateCarRentButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Reportbutton;
    }
}

