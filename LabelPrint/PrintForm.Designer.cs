namespace WinPrint
{
    partial class PrintForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintForm));
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.fileLabel = new TX.Framework.WindowUI.Controls.TXTextBox();
            this.BtnClear = new TX.Framework.WindowUI.Controls.TXButton();
            this.BtnSeletAll = new TX.Framework.WindowUI.Controls.TXButton();
            this.BtnPrint = new TX.Framework.WindowUI.Controls.TXButton();
            this.BtnImport = new TX.Framework.WindowUI.Controls.TXButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvData.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Location = new System.Drawing.Point(32, 94);
            this.dgvData.Margin = new System.Windows.Forms.Padding(4);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.RowHeadersWidth = 62;
            this.dgvData.RowTemplate.Height = 23;
            this.dgvData.Size = new System.Drawing.Size(956, 504);
            this.dgvData.TabIndex = 4;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "OpenFileDialog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "文件路径:";
            // 
            // fileLabel
            // 
            this.fileLabel.BackColor = System.Drawing.Color.Transparent;
            this.fileLabel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(168)))), ((int)(((byte)(192)))));
            this.fileLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileLabel.ForeColor = System.Drawing.SystemColors.WindowText;
            this.fileLabel.HeightLightBolorColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(67)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.fileLabel.Image = null;
            this.fileLabel.ImageSize = new System.Drawing.Size(0, 0);
            this.fileLabel.Location = new System.Drawing.Point(133, 30);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Padding = new System.Windows.Forms.Padding(2);
            this.fileLabel.PasswordChar = '\0';
            this.fileLabel.ReadOnly = true;
            this.fileLabel.Required = false;
            this.fileLabel.Size = new System.Drawing.Size(417, 34);
            this.fileLabel.TabIndex = 6;
            // 
            // BtnClear
            // 
            this.BtnClear.Image = global::WinPrint.Properties.Resources.清空;
            this.BtnClear.Location = new System.Drawing.Point(196, 624);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(133, 40);
            this.BtnClear.TabIndex = 9;
            this.BtnClear.Text = "清空";
            this.BtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSeletAll
            // 
            this.BtnSeletAll.Image = global::WinPrint.Properties.Resources.全选;
            this.BtnSeletAll.Location = new System.Drawing.Point(32, 624);
            this.BtnSeletAll.Name = "BtnSeletAll";
            this.BtnSeletAll.Size = new System.Drawing.Size(133, 40);
            this.BtnSeletAll.TabIndex = 8;
            this.BtnSeletAll.Text = "全选";
            this.BtnSeletAll.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnSeletAll.UseVisualStyleBackColor = true;
            this.BtnSeletAll.Click += new System.EventHandler(this.BtnSeletAll_Click);
            // 
            // BtnPrint
            // 
            this.BtnPrint.Image = global::WinPrint.Properties.Resources.打印机;
            this.BtnPrint.Location = new System.Drawing.Point(374, 624);
            this.BtnPrint.Name = "BtnPrint";
            this.BtnPrint.Size = new System.Drawing.Size(133, 40);
            this.BtnPrint.TabIndex = 7;
            this.BtnPrint.Text = "打印";
            this.BtnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnPrint.UseVisualStyleBackColor = true;
            this.BtnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // BtnImport
            // 
            this.BtnImport.Image = global::WinPrint.Properties.Resources.excel;
            this.BtnImport.Location = new System.Drawing.Point(567, 27);
            this.BtnImport.Name = "BtnImport";
            this.BtnImport.Size = new System.Drawing.Size(133, 40);
            this.BtnImport.TabIndex = 5;
            this.BtnImport.Text = "导入";
            this.BtnImport.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnImport.UseVisualStyleBackColor = true;
            this.BtnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 688);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnSeletAll);
            this.Controls.Add(this.BtnPrint);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.BtnImport);
            this.Controls.Add(this.dgvData);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "标签打印";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_FormClosed);
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvData;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Label label1;
        private TX.Framework.WindowUI.Controls.TXButton BtnImport;
        private TX.Framework.WindowUI.Controls.TXTextBox fileLabel;
        private TX.Framework.WindowUI.Controls.TXButton BtnPrint;
        private TX.Framework.WindowUI.Controls.TXButton BtnSeletAll;
        private TX.Framework.WindowUI.Controls.TXButton BtnClear;
    }
}

