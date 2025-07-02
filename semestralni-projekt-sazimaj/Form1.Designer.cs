namespace semestralni_projekt_sazimaj
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.buttonScan = new System.Windows.Forms.Button();
            this.checkBoxPortScan = new System.Windows.Forms.CheckBox();
            this.textBoxEndIP = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.textBoxStartIP = new System.Windows.Forms.TextBox();
            this.textBoxBaseIP = new System.Windows.Forms.TextBox();
            this.labelRange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(730, 12);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(150, 21);
            this.comboBoxFilter.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(660, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Filtrovat:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Od:";
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.AllowUserToOrderColumns = true;
            this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Location = new System.Drawing.Point(10, 80);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResults.Size = new System.Drawing.Size(870, 400);
            this.dataGridViewResults.TabIndex = 20;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(10, 50);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(870, 20);
            this.progressBar.TabIndex = 19;
            // 
            // buttonScan
            // 
            this.buttonScan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonScan.Location = new System.Drawing.Point(380, 10);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(130, 30);
            this.buttonScan.TabIndex = 18;
            this.buttonScan.Text = "Scan";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // checkBoxPortScan
            // 
            this.checkBoxPortScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxPortScan.AutoSize = true;
            this.checkBoxPortScan.Location = new System.Drawing.Point(520, 15);
            this.checkBoxPortScan.Name = "checkBoxPortScan";
            this.checkBoxPortScan.Size = new System.Drawing.Size(115, 17);
            this.checkBoxPortScan.TabIndex = 17;
            this.checkBoxPortScan.Text = "Provést port scan?";
            this.checkBoxPortScan.UseVisualStyleBackColor = true;
            // 
            // textBoxEndIP
            // 
            this.textBoxEndIP.Location = new System.Drawing.Point(320, 12);
            this.textBoxEndIP.Name = "textBoxEndIP";
            this.textBoxEndIP.Size = new System.Drawing.Size(40, 20);
            this.textBoxEndIP.TabIndex = 16;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(290, 15);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(24, 13);
            this.labelTo.TabIndex = 15;
            this.labelTo.Text = "Do:";
            // 
            // textBoxStartIP
            // 
            this.textBoxStartIP.Location = new System.Drawing.Point(240, 12);
            this.textBoxStartIP.Name = "textBoxStartIP";
            this.textBoxStartIP.Size = new System.Drawing.Size(40, 20);
            this.textBoxStartIP.TabIndex = 14;
            // 
            // textBoxBaseIP
            // 
            this.textBoxBaseIP.Location = new System.Drawing.Point(100, 12);
            this.textBoxBaseIP.Name = "textBoxBaseIP";
            this.textBoxBaseIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxBaseIP.TabIndex = 13;
            // 
            // labelRange
            // 
            this.labelRange.AutoSize = true;
            this.labelRange.Location = new System.Drawing.Point(10, 15);
            this.labelRange.Name = "labelRange";
            this.labelRange.Size = new System.Drawing.Size(56, 13);
            this.labelRange.TabIndex = 12;
            this.labelRange.Text = "Základ IP:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 491);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewResults);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.buttonScan);
            this.Controls.Add(this.checkBoxPortScan);
            this.Controls.Add(this.textBoxEndIP);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.textBoxStartIP);
            this.Controls.Add(this.textBoxBaseIP);
            this.Controls.Add(this.labelRange);
            this.Name = "Form1";
            this.Text = "LAN Scanner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.CheckBox checkBoxPortScan;
        private System.Windows.Forms.TextBox textBoxEndIP;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxStartIP;
        private System.Windows.Forms.TextBox textBoxBaseIP;
        private System.Windows.Forms.Label labelRange;
    }
}

