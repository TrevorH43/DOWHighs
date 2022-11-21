namespace DOWHighs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.closingValueTextBox = new System.Windows.Forms.TextBox();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.allDatesRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.firstDateRadioButton = new System.Windows.Forms.RadioButton();
            this.dijaDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dijaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.closingValueTextBox);
            this.panel1.Controls.Add(this.clearFilterButton);
            this.panel1.Controls.Add(this.searchButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.allDatesRadioButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.firstDateRadioButton);
            this.panel1.Location = new System.Drawing.Point(28, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 100);
            this.panel1.TabIndex = 0;
            // 
            // closingValueTextBox
            // 
            this.closingValueTextBox.Location = new System.Drawing.Point(420, 42);
            this.closingValueTextBox.Name = "closingValueTextBox";
            this.closingValueTextBox.Size = new System.Drawing.Size(150, 23);
            this.closingValueTextBox.TabIndex = 1;
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.Location = new System.Drawing.Point(657, 41);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(75, 23);
            this.clearFilterButton.TabIndex = 5;
            this.clearFilterButton.Text = "Clear Filter";
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(576, 41);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Starting Closing Value:";
            // 
            // allDatesRadioButton
            // 
            this.allDatesRadioButton.AutoSize = true;
            this.allDatesRadioButton.Location = new System.Drawing.Point(188, 67);
            this.allDatesRadioButton.Name = "allDatesRadioButton";
            this.allDatesRadioButton.Size = new System.Drawing.Size(71, 19);
            this.allDatesRadioButton.TabIndex = 2;
            this.allDatesRadioButton.Text = "All Dates";
            this.allDatesRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Return Results For:";
            // 
            // firstDateRadioButton
            // 
            this.firstDateRadioButton.AutoSize = true;
            this.firstDateRadioButton.Location = new System.Drawing.Point(188, 24);
            this.firstDateRadioButton.Name = "firstDateRadioButton";
            this.firstDateRadioButton.Size = new System.Drawing.Size(74, 19);
            this.firstDateRadioButton.TabIndex = 1;
            this.firstDateRadioButton.Text = "First Date";
            this.firstDateRadioButton.UseVisualStyleBackColor = true;
            // 
            // dijaDataGridView
            // 
            this.dijaDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dijaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dijaDataGridView.Location = new System.Drawing.Point(28, 132);
            this.dijaDataGridView.Name = "dijaDataGridView";
            this.dijaDataGridView.RowTemplate.Height = 25;
            this.dijaDataGridView.Size = new System.Drawing.Size(745, 306);
            this.dijaDataGridView.TabIndex = 1;
            this.dijaDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dijaDataGridView_ColumnHeaderMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dijaDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Dow Jones International Average Highs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dijaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox closingValueTextBox;
        private Button clearFilterButton;
        private Button searchButton;
        private Label label2;
        private RadioButton allDatesRadioButton;
        private Label label1;
        private RadioButton firstDateRadioButton;
        private DataGridView dijaDataGridView;
    }
}