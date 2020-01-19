namespace RentC.Presentation
{
    partial class ListCustomersForm
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
            this.listCustomersButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listCustomersToHomebutton = new System.Windows.Forms.Button();
            this.listCustomersQuitbutton = new System.Windows.Forms.Button();
            this.listCustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.SortByIDbutton = new System.Windows.Forms.Button();
            this.sortByNamebutton = new System.Windows.Forms.Button();
            this.sortByBirthDatebutton = new System.Windows.Forms.Button();
            this.sortByLocationbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listCustomersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listCustomersButton
            // 
            this.listCustomersButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listCustomersButton.Location = new System.Drawing.Point(305, 146);
            this.listCustomersButton.Name = "listCustomersButton";
            this.listCustomersButton.Size = new System.Drawing.Size(300, 75);
            this.listCustomersButton.TabIndex = 4;
            this.listCustomersButton.Text = "LIST CUSTOMERS";
            this.listCustomersButton.UseVisualStyleBackColor = true;
            this.listCustomersButton.Click += new System.EventHandler(this.listCustomersButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(249, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Press \'List Customers\' to See All Customers";
            // 
            // listCustomersToHomebutton
            // 
            this.listCustomersToHomebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listCustomersToHomebutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listCustomersToHomebutton.Location = new System.Drawing.Point(27, 887);
            this.listCustomersToHomebutton.Name = "listCustomersToHomebutton";
            this.listCustomersToHomebutton.Size = new System.Drawing.Size(75, 40);
            this.listCustomersToHomebutton.TabIndex = 13;
            this.listCustomersToHomebutton.Text = "Home";
            this.listCustomersToHomebutton.UseVisualStyleBackColor = true;
            this.listCustomersToHomebutton.Click += new System.EventHandler(this.listCustomersToHomebutton_Click);
            // 
            // listCustomersQuitbutton
            // 
            this.listCustomersQuitbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listCustomersQuitbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listCustomersQuitbutton.Location = new System.Drawing.Point(830, 887);
            this.listCustomersQuitbutton.Name = "listCustomersQuitbutton";
            this.listCustomersQuitbutton.Size = new System.Drawing.Size(75, 40);
            this.listCustomersQuitbutton.TabIndex = 14;
            this.listCustomersQuitbutton.Text = "Quit";
            this.listCustomersQuitbutton.UseVisualStyleBackColor = true;
            this.listCustomersQuitbutton.Click += new System.EventHandler(this.listCustomersQuitbutton_Click);
            // 
            // listCustomersDataGridView
            // 
            this.listCustomersDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listCustomersDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listCustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listCustomersDataGridView.Location = new System.Drawing.Point(56, 325);
            this.listCustomersDataGridView.Name = "listCustomersDataGridView";
            this.listCustomersDataGridView.RowTemplate.Height = 28;
            this.listCustomersDataGridView.Size = new System.Drawing.Size(823, 416);
            this.listCustomersDataGridView.TabIndex = 5;
            // 
            // SortByIDbutton
            // 
            this.SortByIDbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SortByIDbutton.Location = new System.Drawing.Point(104, 783);
            this.SortByIDbutton.Name = "SortByIDbutton";
            this.SortByIDbutton.Size = new System.Drawing.Size(164, 32);
            this.SortByIDbutton.TabIndex = 15;
            this.SortByIDbutton.Text = "Sort BY ID";
            this.SortByIDbutton.UseVisualStyleBackColor = true;
            this.SortByIDbutton.Click += new System.EventHandler(this.SortByIDbutton_Click);
            // 
            // sortByNamebutton
            // 
            this.sortByNamebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortByNamebutton.Location = new System.Drawing.Point(305, 783);
            this.sortByNamebutton.Name = "sortByNamebutton";
            this.sortByNamebutton.Size = new System.Drawing.Size(164, 32);
            this.sortByNamebutton.TabIndex = 16;
            this.sortByNamebutton.Text = "Sort By Name";
            this.sortByNamebutton.UseVisualStyleBackColor = true;
            this.sortByNamebutton.Click += new System.EventHandler(this.sortByNamebutton_Click);
            // 
            // sortByBirthDatebutton
            // 
            this.sortByBirthDatebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortByBirthDatebutton.Location = new System.Drawing.Point(506, 783);
            this.sortByBirthDatebutton.Name = "sortByBirthDatebutton";
            this.sortByBirthDatebutton.Size = new System.Drawing.Size(164, 32);
            this.sortByBirthDatebutton.TabIndex = 17;
            this.sortByBirthDatebutton.Text = "Sort By Birth Date";
            this.sortByBirthDatebutton.UseVisualStyleBackColor = true;
            this.sortByBirthDatebutton.Click += new System.EventHandler(this.sortByBirthDatebutton_Click);
            // 
            // sortByLocationbutton
            // 
            this.sortByLocationbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortByLocationbutton.Location = new System.Drawing.Point(696, 783);
            this.sortByLocationbutton.Name = "sortByLocationbutton";
            this.sortByLocationbutton.Size = new System.Drawing.Size(164, 32);
            this.sortByLocationbutton.TabIndex = 18;
            this.sortByLocationbutton.Text = "Sort By Location";
            this.sortByLocationbutton.UseVisualStyleBackColor = true;
            this.sortByLocationbutton.Click += new System.EventHandler(this.sortByLocationbutton_Click);
            // 
            // ListCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 944);
            this.Controls.Add(this.sortByLocationbutton);
            this.Controls.Add(this.sortByBirthDatebutton);
            this.Controls.Add(this.sortByNamebutton);
            this.Controls.Add(this.SortByIDbutton);
            this.Controls.Add(this.listCustomersQuitbutton);
            this.Controls.Add(this.listCustomersToHomebutton);
            this.Controls.Add(this.listCustomersDataGridView);
            this.Controls.Add(this.listCustomersButton);
            this.Controls.Add(this.label3);
            this.Name = "ListCustomersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Customers";
            ((System.ComponentModel.ISupportInitialize)(this.listCustomersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button listCustomersButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button listCustomersToHomebutton;
        private System.Windows.Forms.Button listCustomersQuitbutton;
        private System.Windows.Forms.DataGridView listCustomersDataGridView;
        private System.Windows.Forms.Button SortByIDbutton;
        private System.Windows.Forms.Button sortByNamebutton;
        private System.Windows.Forms.Button sortByBirthDatebutton;
        private System.Windows.Forms.Button sortByLocationbutton;
    }
}