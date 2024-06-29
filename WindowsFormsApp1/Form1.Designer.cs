namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Surch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.updateform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Surch
            // 
            this.Surch.Location = new System.Drawing.Point(28, 12);
            this.Surch.Name = "Surch";
            this.Surch.Size = new System.Drawing.Size(164, 29);
            this.Surch.TabIndex = 0;
            this.Surch.Text = "ぜんぶだすぞ";
            this.Surch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Surch.UseVisualStyleBackColor = true;
            this.Surch.Click += new System.EventHandler(this.Surch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 377);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // updateform
            // 
            this.updateform.Location = new System.Drawing.Point(198, 12);
            this.updateform.Name = "updateform";
            this.updateform.Size = new System.Drawing.Size(150, 29);
            this.updateform.TabIndex = 2;
            this.updateform.Text = "登録";
            this.updateform.UseVisualStyleBackColor = true;
            this.updateform.Click += new System.EventHandler(this.Submit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateform);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Surch);
            this.Name = "Form1";
            this.Text = "おさいふSTEM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Surch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button updateform;
    }
}

