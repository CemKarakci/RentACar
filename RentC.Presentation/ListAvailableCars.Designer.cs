namespace RentC.Presentation
{
    partial class ListAvailableCars
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
            this.listAvailableCarsDataGridView = new System.Windows.Forms.DataGridView();
            this.listAvailableCarsbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listCarsToHomebutton = new System.Windows.Forms.Button();
            this.listAvailableCarsQuitbutton = new System.Windows.Forms.Button();
            this.sortByIDbutton = new System.Windows.Forms.Button();
            this.sortByPlatebutton = new System.Windows.Forms.Button();
            this.sortByManufacturerbutton = new System.Windows.Forms.Button();
            this.sortByModelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listAvailableCarsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listAvailableCarsDataGridView
            // 
            this.listAvailableCarsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listAvailableCarsDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listAvailableCarsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAvailableCarsDataGridView.Location = new System.Drawing.Point(57, 338);
            this.listAvailableCarsDataGridView.Name = "listAvailableCarsDataGridView";
            this.listAvailableCarsDataGridView.RowTemplate.Height = 28;
            this.listAvailableCarsDataGridView.Size = new System.Drawing.Size(823, 416);
            this.listAvailableCarsDataGridView.TabIndex = 5;
            // 
            // listAvailableCarsbutton
            // 
            this.listAvailableCarsbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listAvailableCarsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listAvailableCarsbutton.Location = new System.Drawing.Point(338, 163);
            this.listAvailableCarsbutton.Name = "listAvailableCarsbutton";
            this.listAvailableCarsbutton.Size = new System.Drawing.Size(300, 75);
            this.listAvailableCarsbutton.TabIndex = 4;
            this.listAvailableCarsbutton.Text = "LIST AVAILABLE CARS";
            this.listAvailableCarsbutton.UseVisualStyleBackColor = true;
            this.listAvailableCarsbutton.Click += new System.EventHandler(this.listAvailableCarsbutton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(268, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(425, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Press \'List Available Cars\' to List Available Cars";
            // 
            // listCarsToHomebutton
            // 
            this.listCarsToHomebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listCarsToHomebutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listCarsToHomebutton.Location = new System.Drawing.Point(35, 882);
            this.listCarsToHomebutton.Name = "listCarsToHomebutton";
            this.listCarsToHomebutton.Size = new System.Drawing.Size(75, 40);
            this.listCarsToHomebutton.TabIndex = 13;
            this.listCarsToHomebutton.Text = "Home";
            this.listCarsToHomebutton.UseVisualStyleBackColor = true;
            this.listCarsToHomebutton.Click += new System.EventHandler(this.listCarsToHomebutton_Click);
            // 
            // listAvailableCarsQuitbutton
            // 
            this.listAvailableCarsQuitbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listAvailableCarsQuitbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listAvailableCarsQuitbutton.Location = new System.Drawing.Point(832, 891);
            this.listAvailableCarsQuitbutton.Name = "listAvailableCarsQuitbutton";
            this.listAvailableCarsQuitbutton.Size = new System.Drawing.Size(75, 40);
            this.listAvailableCarsQuitbutton.TabIndex = 14;
            this.listAvailableCarsQuitbutton.Text = "Quit";
            this.listAvailableCarsQuitbutton.UseVisualStyleBackColor = true;
            this.listAvailableCarsQuitbutton.Click += new System.EventHandler(this.listAvailableCarsQuitbutton_Click);
            // 
            // sortByIDbutton
            // 
            this.sortByIDbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortByIDbutton.Location = new System.Drawing.Point(95, 779);
            this.sortByIDbutton.Name = "sortByIDbutton";
            this.sortByIDbutton.Size = new System.Drawing.Size(176, 34);
            this.sortByIDbutton.TabIndex = 15;
            this.sortByIDbutton.Text = "Sort By ID";
            this.sortByIDbutton.UseVisualStyleBackColor = true;
            this.sortByIDbutton.Click += new System.EventHandler(this.sortByIDbutton_Click);
            // 
            // sortByPlatebutton
            // 
            this.sortByPlatebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortByPlatebutton.Location = new System.Drawing.Point(286, 779);
            this.sortByPlatebutton.Name = "sortByPlatebutton";
            this.sortByPlatebutton.Size = new System.Drawing.Size(176, 34);
            this.sortByPlatebutton.TabIndex = 16;
            this.sortByPlatebutton.Text = "Sort By Plate";
            this.sortByPlatebutton.UseVisualStyleBackColor = true;
            this.sortByPlatebutton.Click += new System.EventHandler(this.sortByPlatebutton_Click);
            // 
            // sortByManufacturerbutton
            // 
            this.sortByManufacturerbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortByManufacturerbutton.Location = new System.Drawing.Point(484, 779);
            this.sortByManufacturerbutton.Name = "sortByManufacturerbutton";
            this.sortByManufacturerbutton.Size = new System.Drawing.Size(176, 34);
            this.sortByManufacturerbutton.TabIndex = 17;
            this.sortByManufacturerbutton.Text = "Sort By Manufacturer";
            this.sortByManufacturerbutton.UseVisualStyleBackColor = true;
            this.sortByManufacturerbutton.Click += new System.EventHandler(this.sortByManufacturerbutton_Click);
            // 
            // sortByModelbutton
            // 
            this.sortByModelbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sortByModelbutton.Location = new System.Drawing.Point(680, 779);
            this.sortByModelbutton.Name = "sortByModelbutton";
            this.sortByModelbutton.Size = new System.Drawing.Size(176, 34);
            this.sortByModelbutton.TabIndex = 18;
            this.sortByModelbutton.Text = "Sort By Model";
            this.sortByModelbutton.UseVisualStyleBackColor = true;
            this.sortByModelbutton.Click += new System.EventHandler(this.sortByModelbutton_Click);
            // 
            // ListAvailableCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 944);
            this.Controls.Add(this.sortByModelbutton);
            this.Controls.Add(this.sortByManufacturerbutton);
            this.Controls.Add(this.sortByPlatebutton);
            this.Controls.Add(this.sortByIDbutton);
            this.Controls.Add(this.listAvailableCarsQuitbutton);
            this.Controls.Add(this.listCarsToHomebutton);
            this.Controls.Add(this.listAvailableCarsDataGridView);
            this.Controls.Add(this.listAvailableCarsbutton);
            this.Controls.Add(this.label2);
            this.Name = "ListAvailableCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Available Cars";
            ((System.ComponentModel.ISupportInitialize)(this.listAvailableCarsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listAvailableCarsDataGridView;
        private System.Windows.Forms.Button listAvailableCarsbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button listCarsToHomebutton;
        private System.Windows.Forms.Button listAvailableCarsQuitbutton;
        private System.Windows.Forms.Button sortByIDbutton;
        private System.Windows.Forms.Button sortByPlatebutton;
        private System.Windows.Forms.Button sortByManufacturerbutton;
        private System.Windows.Forms.Button sortByModelbutton;
    }
}