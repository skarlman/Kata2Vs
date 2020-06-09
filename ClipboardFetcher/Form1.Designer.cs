namespace ClipboardFetcher
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCodePath = new System.Windows.Forms.TextBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.txtSlug = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 119);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 265);
            this.textBox1.TabIndex = 0;
            // 
            // txtCodePath
            // 
            this.txtCodePath.Location = new System.Drawing.Point(16, 28);
            this.txtCodePath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodePath.Name = "txtCodePath";
            this.txtCodePath.Size = new System.Drawing.Size(480, 22);
            this.txtCodePath.TabIndex = 1;
            this.txtCodePath.Text = "C:\\code\\temp\\KataSolver\\KataSolver";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(232, 393);
            this.btnCreateFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(100, 28);
            this.btnCreateFile.TabIndex = 2;
            this.btnCreateFile.Text = "button1";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // txtSlug
            // 
            this.txtSlug.Location = new System.Drawing.Point(16, 87);
            this.txtSlug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSlug.Name = "txtSlug";
            this.txtSlug.Size = new System.Drawing.Size(453, 22);
            this.txtSlug.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 554);
            this.Controls.Add(this.txtSlug);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.txtCodePath);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtCodePath;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.TextBox txtSlug;
    }
}

