namespace WindowsFormsApp1
{
    partial class RegistrationForm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.youtoTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.okaneTextBox = new System.Windows.Forms.TextBox();
            this.hanComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.AutoSize = true;
            this.registerButton.Location = new System.Drawing.Point(187, 110);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(76, 25);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "これでよし";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // youtoTextBox
            // 
            this.youtoTextBox.Location = new System.Drawing.Point(54, 6);
            this.youtoTextBox.Name = "youtoTextBox";
            this.youtoTextBox.Size = new System.Drawing.Size(209, 22);
            this.youtoTextBox.TabIndex = 1;
            this.youtoTextBox.TextChanged += new System.EventHandler(this.youtoTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "用途";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "班名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "金額";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // okaneTextBox
            // 
            this.okaneTextBox.Location = new System.Drawing.Point(54, 80);
            this.okaneTextBox.Name = "okaneTextBox";
            this.okaneTextBox.Size = new System.Drawing.Size(209, 22);
            this.okaneTextBox.TabIndex = 5;
            this.okaneTextBox.TextChanged += new System.EventHandler(this.okaneTextBox_TextChanged);
            // 
            // hanComboBox
            // 
            this.hanComboBox.FormattingEnabled = true;
            this.hanComboBox.Location = new System.Drawing.Point(54, 42);
            this.hanComboBox.Name = "hanComboBox";
            this.hanComboBox.Size = new System.Drawing.Size(121, 23);
            this.hanComboBox.TabIndex = 6;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 147);
            this.Controls.Add(this.hanComboBox);
            this.Controls.Add(this.okaneTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.youtoTextBox);
            this.Controls.Add(this.registerButton);
            this.Name = "RegistrationForm";
            this.Text = "登録フォーム";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox youtoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox okaneTextBox;
        private System.Windows.Forms.ComboBox hanComboBox;
    }
}