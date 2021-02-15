
namespace ITMO.ADO_NET.U4E6.DataViewExample
{
    partial class Form1
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
            this.CustomersGrid = new System.Windows.Forms.DataGridView();
            this.SetDataViewPropertiesButton = new System.Windows.Forms.Button();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.SortTextBox = new System.Windows.Forms.TextBox();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersGrid
            // 
            this.CustomersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGrid.Location = new System.Drawing.Point(12, 12);
            this.CustomersGrid.Name = "CustomersGrid";
            this.CustomersGrid.RowHeadersWidth = 82;
            this.CustomersGrid.RowTemplate.Height = 33;
            this.CustomersGrid.Size = new System.Drawing.Size(398, 426);
            this.CustomersGrid.TabIndex = 0;
            // 
            // SetDataViewPropertiesButton
            // 
            this.SetDataViewPropertiesButton.Location = new System.Drawing.Point(429, 134);
            this.SetDataViewPropertiesButton.Name = "SetDataViewPropertiesButton";
            this.SetDataViewPropertiesButton.Size = new System.Drawing.Size(359, 47);
            this.SetDataViewPropertiesButton.TabIndex = 1;
            this.SetDataViewPropertiesButton.Text = "Set DataView Properties";
            this.SetDataViewPropertiesButton.UseVisualStyleBackColor = true;
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(429, 187);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(359, 47);
            this.AddRowButton.TabIndex = 1;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            // 
            // SortTextBox
            // 
            this.SortTextBox.Location = new System.Drawing.Point(429, 20);
            this.SortTextBox.Name = "SortTextBox";
            this.SortTextBox.Size = new System.Drawing.Size(359, 31);
            this.SortTextBox.TabIndex = 2;
            this.SortTextBox.Text = "CustomerID";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(429, 57);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(359, 31);
            this.FilterTextBox.TabIndex = 2;
            this.FilterTextBox.Text = "City = \'London\'";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.SortTextBox);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.SetDataViewPropertiesButton);
            this.Controls.Add(this.CustomersGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersGrid;
        private System.Windows.Forms.Button SetDataViewPropertiesButton;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.TextBox SortTextBox;
        private System.Windows.Forms.TextBox FilterTextBox;
    }
}

