﻿
namespace ITMO.ADO_NET.U0E0.Test
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
            this.btnFillSales = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.orderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFillSales
            // 
            this.btnFillSales.Location = new System.Drawing.Point(438, 23);
            this.btnFillSales.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnFillSales.Name = "btnFillSales";
            this.btnFillSales.Size = new System.Drawing.Size(150, 44);
            this.btnFillSales.TabIndex = 0;
            this.btnFillSales.Text = "Fill Sales";
            this.btnFillSales.UseVisualStyleBackColor = true;
            this.btnFillSales.Click += new System.EventHandler(this.btnFillSales_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(600, 23);
            this.btnSave.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 44);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save to xml";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(124, 23);
            this.dateTimePickerFrom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(280, 31);
            this.dateTimePickerFrom.TabIndex = 2;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(124, 73);
            this.dateTimePickerTo.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(280, 31);
            this.dateTimePickerTo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "to";
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderId,
            this.orderDate,
            this.orderTotal});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(24, 131);
            this.listView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(720, 708);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // orderId
            // 
            this.orderId.Text = "Order ID";
            this.orderId.Width = 109;
            // 
            // orderDate
            // 
            this.orderDate.Text = "Order Date";
            this.orderDate.Width = 119;
            // 
            // orderTotal
            // 
            this.orderTotal.Text = "Order Total";
            this.orderTotal.Width = 128;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(432, 87);
            this.totalLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 25);
            this.totalLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 865);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnFillSales);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFillSales;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader orderId;
        private System.Windows.Forms.ColumnHeader orderDate;
        private System.Windows.Forms.ColumnHeader orderTotal;
        private System.Windows.Forms.Label totalLabel;
    }
}

