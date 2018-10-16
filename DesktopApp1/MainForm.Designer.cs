using System;

namespace FeromApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnAction = new System.Windows.Forms.Button();
            this.tbNovaPrice = new System.Windows.Forms.TextBox();
            this.tbStockNumber = new System.Windows.Forms.TextBox();
            this.tbUnitaryPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DrawCodeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.bnHistory = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cbActionPicker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(469, 66);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(80, 23);
            this.btnAction.TabIndex = 0;
            this.btnAction.Text = "Salveaza";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.ActionBtn_Click);
            // 
            // tbNovaPrice
            // 
            this.tbNovaPrice.Location = new System.Drawing.Point(363, 68);
            this.tbNovaPrice.Name = "tbNovaPrice";
            this.tbNovaPrice.Size = new System.Drawing.Size(100, 20);
            this.tbNovaPrice.TabIndex = 1;
            // 
            // tbStockNumber
            // 
            this.tbStockNumber.Location = new System.Drawing.Point(257, 68);
            this.tbStockNumber.Name = "tbStockNumber";
            this.tbStockNumber.Size = new System.Drawing.Size(100, 20);
            this.tbStockNumber.TabIndex = 4;
            // 
            // tbUnitaryPrice
            // 
            this.tbUnitaryPrice.Location = new System.Drawing.Point(151, 68);
            this.tbUnitaryPrice.Name = "tbUnitaryPrice";
            this.tbUnitaryPrice.Size = new System.Drawing.Size(100, 20);
            this.tbUnitaryPrice.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Preț Unitar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nr. în stoc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(360, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Preț Nova";
            // 
            // DrawCodeID
            // 
            this.DrawCodeID.Location = new System.Drawing.Point(45, 68);
            this.DrawCodeID.Name = "DrawCodeID";
            this.DrawCodeID.Size = new System.Drawing.Size(100, 20);
            this.DrawCodeID.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "COD DESEN";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(584, 42);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 23);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Afișează";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // bnHistory
            // 
            this.bnHistory.Location = new System.Drawing.Point(670, 42);
            this.bnHistory.Name = "bnHistory";
            this.bnHistory.Size = new System.Drawing.Size(75, 23);
            this.bnHistory.TabIndex = 16;
            this.bnHistory.Text = "History";
            this.bnHistory.UseVisualStyleBackColor = true;
            this.bnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(804, 41);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(45, 114);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(959, 474);
            this.dgv.TabIndex = 20;
            // 
            // cbActionPicker
            // 
            this.cbActionPicker.FormattingEnabled = true;
            this.cbActionPicker.Location = new System.Drawing.Point(130, 12);
            this.cbActionPicker.Name = "cbActionPicker";
            this.cbActionPicker.Size = new System.Drawing.Size(121, 21);
            this.cbActionPicker.TabIndex = 21;
            this.cbActionPicker.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tip";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1031, 553);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 23);
            this.button3.TabIndex = 23;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1138, 625);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbActionPicker);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bnHistory);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DrawCodeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUnitaryPrice);
            this.Controls.Add(this.tbStockNumber);
            this.Controls.Add(this.tbNovaPrice);
            this.Controls.Add(this.btnAction);
            this.Name = "MainForm";
            this.Text = "Ferom";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox tbNovaPrice;
        private System.Windows.Forms.TextBox tbStockNumber;
        private System.Windows.Forms.TextBox tbUnitaryPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DrawCodeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button bnHistory;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox cbActionPicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

