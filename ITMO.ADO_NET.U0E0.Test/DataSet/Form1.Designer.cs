
namespace DataSet
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
            this.aWDataSet = new DataSet.AWDataSet();
            this.productTableAdapter = new DataSet.AWDataSetTableAdapters.ProductTableAdapter();
            this.btn_addRow = new System.Windows.Forms.Button();
            this.btn_delRow = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_reject = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.aWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // aWDataSet
            // 
            this.aWDataSet.DataSetName = "AWDataSet";
            this.aWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // btn_addRow
            // 
            this.btn_addRow.Location = new System.Drawing.Point(11, 234);
            this.btn_addRow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addRow.Name = "btn_addRow";
            this.btn_addRow.Size = new System.Drawing.Size(63, 21);
            this.btn_addRow.TabIndex = 1;
            this.btn_addRow.Text = "Add row";
            this.btn_addRow.UseVisualStyleBackColor = true;
            this.btn_addRow.Click += new System.EventHandler(this.btn_addRow_Click);
            // 
            // btn_delRow
            // 
            this.btn_delRow.Location = new System.Drawing.Point(91, 234);
            this.btn_delRow.Margin = new System.Windows.Forms.Padding(2);
            this.btn_delRow.Name = "btn_delRow";
            this.btn_delRow.Size = new System.Drawing.Size(63, 21);
            this.btn_delRow.TabIndex = 1;
            this.btn_delRow.Text = "Del row";
            this.btn_delRow.UseVisualStyleBackColor = true;
            this.btn_delRow.Click += new System.EventHandler(this.btn_delRow_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(168, 234);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(63, 21);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_reject
            // 
            this.btn_reject.Location = new System.Drawing.Point(246, 234);
            this.btn_reject.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reject.Name = "btn_reject";
            this.btn_reject.Size = new System.Drawing.Size(63, 21);
            this.btn_reject.TabIndex = 1;
            this.btn_reject.Text = "Reject";
            this.btn_reject.UseVisualStyleBackColor = true;
            this.btn_reject.Click += new System.EventHandler(this.btn_reject_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(297, 217);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 266);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_reject);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_delRow);
            this.Controls.Add(this.btn_addRow);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private AWDataSet aWDataSet;
        private AWDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Button btn_addRow;
        private System.Windows.Forms.Button btn_delRow;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_reject;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

