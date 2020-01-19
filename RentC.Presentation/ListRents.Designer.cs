namespace RentC.Presentation
{
    partial class ListRentsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.listRentsbutton = new System.Windows.Forms.Button();
            this.listRentsDataGridView = new System.Windows.Forms.DataGridView();
            this.listRentsToHomebutton = new System.Windows.Forms.Button();
            this.listRentsQuitbutton = new System.Windows.Forms.Button();
            this.carIDButton = new System.Windows.Forms.Button();
            this.customerIDButton = new System.Windows.Forms.Button();
            this.reservStatsButton = new System.Windows.Forms.Button();
            this.startDateButton = new System.Windows.Forms.Button();
            this.endDateButton = new System.Windows.Forms.Button();
            this.locationButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listRentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(290, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Press \'List Rents\' to List All the Rents";
            // 
            // listRentsbutton
            // 
            this.listRentsbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listRentsbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listRentsbutton.Location = new System.Drawing.Point(306, 143);
            this.listRentsbutton.Name = "listRentsbutton";
            this.listRentsbutton.Size = new System.Drawing.Size(300, 75);
            this.listRentsbutton.TabIndex = 1;
            this.listRentsbutton.Text = "LIST RENTS";
            this.listRentsbutton.UseVisualStyleBackColor = true;
            this.listRentsbutton.Click += new System.EventHandler(this.listRentsbutton_Click);
            // 
            // listRentsDataGridView
            // 
            this.listRentsDataGridView.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listRentsDataGridView.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listRentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listRentsDataGridView.Location = new System.Drawing.Point(57, 322);
            this.listRentsDataGridView.Name = "listRentsDataGridView";
            this.listRentsDataGridView.RowTemplate.Height = 28;
            this.listRentsDataGridView.Size = new System.Drawing.Size(823, 416);
            this.listRentsDataGridView.TabIndex = 2;
            // 
            // listRentsToHomebutton
            // 
            this.listRentsToHomebutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listRentsToHomebutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listRentsToHomebutton.Location = new System.Drawing.Point(26, 889);
            this.listRentsToHomebutton.Name = "listRentsToHomebutton";
            this.listRentsToHomebutton.Size = new System.Drawing.Size(75, 40);
            this.listRentsToHomebutton.TabIndex = 13;
            this.listRentsToHomebutton.Text = "Home";
            this.listRentsToHomebutton.UseVisualStyleBackColor = true;
            this.listRentsToHomebutton.Click += new System.EventHandler(this.listRentsToHomebutton_Click);
            // 
            // listRentsQuitbutton
            // 
            this.listRentsQuitbutton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listRentsQuitbutton.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listRentsQuitbutton.Location = new System.Drawing.Point(836, 889);
            this.listRentsQuitbutton.Name = "listRentsQuitbutton";
            this.listRentsQuitbutton.Size = new System.Drawing.Size(75, 40);
            this.listRentsQuitbutton.TabIndex = 14;
            this.listRentsQuitbutton.Text = "Quit";
            this.listRentsQuitbutton.UseVisualStyleBackColor = true;
            this.listRentsQuitbutton.Click += new System.EventHandler(this.listRentsQuitbutton_Click);
            // 
            // carIDButton
            // 
            this.carIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carIDButton.Location = new System.Drawing.Point(227, 767);
            this.carIDButton.Name = "carIDButton";
            this.carIDButton.Size = new System.Drawing.Size(75, 23);
            this.carIDButton.TabIndex = 15;
            this.carIDButton.Text = "CarID";
            this.carIDButton.UseVisualStyleBackColor = true;
            this.carIDButton.Click += new System.EventHandler(this.carIDButton_Click);
            // 
            // customerIDButton
            // 
            this.customerIDButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerIDButton.Location = new System.Drawing.Point(331, 767);
            this.customerIDButton.Name = "customerIDButton";
            this.customerIDButton.Size = new System.Drawing.Size(75, 23);
            this.customerIDButton.TabIndex = 16;
            this.customerIDButton.Text = "CostumerID";
            this.customerIDButton.UseVisualStyleBackColor = true;
            this.customerIDButton.Click += new System.EventHandler(this.customerIDButton_Click);
            // 
            // reservStatsButton
            // 
            this.reservStatsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reservStatsButton.Location = new System.Drawing.Point(431, 767);
            this.reservStatsButton.Name = "reservStatsButton";
            this.reservStatsButton.Size = new System.Drawing.Size(75, 23);
            this.reservStatsButton.TabIndex = 17;
            this.reservStatsButton.Text = "ReservStats";
            this.reservStatsButton.UseVisualStyleBackColor = true;
            this.reservStatsButton.Click += new System.EventHandler(this.reservStatsButton_Click);
            // 
            // startDateButton
            // 
            this.startDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startDateButton.Location = new System.Drawing.Point(531, 767);
            this.startDateButton.Name = "startDateButton";
            this.startDateButton.Size = new System.Drawing.Size(75, 23);
            this.startDateButton.TabIndex = 18;
            this.startDateButton.Text = "StartDate";
            this.startDateButton.UseVisualStyleBackColor = true;
            this.startDateButton.Click += new System.EventHandler(this.startDateButton_Click);
            // 
            // endDateButton
            // 
            this.endDateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.endDateButton.Location = new System.Drawing.Point(639, 767);
            this.endDateButton.Name = "endDateButton";
            this.endDateButton.Size = new System.Drawing.Size(75, 23);
            this.endDateButton.TabIndex = 19;
            this.endDateButton.Text = "EndDate";
            this.endDateButton.UseVisualStyleBackColor = true;
            this.endDateButton.Click += new System.EventHandler(this.endDateButton_Click);
            // 
            // locationButton
            // 
            this.locationButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.locationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.locationButton.Location = new System.Drawing.Point(741, 767);
            this.locationButton.Name = "locationButton";
            this.locationButton.Size = new System.Drawing.Size(75, 23);
            this.locationButton.TabIndex = 20;
            this.locationButton.Text = "Location";
            this.locationButton.UseVisualStyleBackColor = true;
            this.locationButton.Click += new System.EventHandler(this.locationButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 767);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Sort By: ";
            // 
            // ListRentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 944);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.locationButton);
            this.Controls.Add(this.endDateButton);
            this.Controls.Add(this.startDateButton);
            this.Controls.Add(this.reservStatsButton);
            this.Controls.Add(this.customerIDButton);
            this.Controls.Add(this.carIDButton);
            this.Controls.Add(this.listRentsQuitbutton);
            this.Controls.Add(this.listRentsToHomebutton);
            this.Controls.Add(this.listRentsDataGridView);
            this.Controls.Add(this.listRentsbutton);
            this.Controls.Add(this.label1);
            this.Name = "ListRentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Rents";
            ((System.ComponentModel.ISupportInitialize)(this.listRentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button listRentsbutton;
        private System.Windows.Forms.DataGridView listRentsDataGridView;
        private System.Windows.Forms.Button listRentsToHomebutton;
        private System.Windows.Forms.Button listRentsQuitbutton;
        private System.Windows.Forms.Button carIDButton;
        private System.Windows.Forms.Button customerIDButton;
        private System.Windows.Forms.Button reservStatsButton;
        private System.Windows.Forms.Button startDateButton;
        private System.Windows.Forms.Button endDateButton;
        private System.Windows.Forms.Button locationButton;
        private System.Windows.Forms.Label label2;
    }
}