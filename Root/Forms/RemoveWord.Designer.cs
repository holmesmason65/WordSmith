
namespace Root.Forms
{
    partial class frmRemoveWord
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
            this.txtRemoveWord = new System.Windows.Forms.TextBox();
            this.btnRemoveWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRemoveWord
            // 
            this.txtRemoveWord.Location = new System.Drawing.Point(103, 71);
            this.txtRemoveWord.Name = "txtRemoveWord";
            this.txtRemoveWord.Size = new System.Drawing.Size(148, 23);
            this.txtRemoveWord.TabIndex = 0;
            // 
            // btnRemoveWord
            // 
            this.btnRemoveWord.Location = new System.Drawing.Point(136, 112);
            this.btnRemoveWord.Name = "btnRemoveWord";
            this.btnRemoveWord.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveWord.TabIndex = 1;
            this.btnRemoveWord.Text = "Remove";
            this.btnRemoveWord.UseVisualStyleBackColor = true;
            this.btnRemoveWord.Click += new System.EventHandler(this.btnRemoveWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter a word to be removed";
            // 
            // frmRemoveWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 183);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveWord);
            this.Controls.Add(this.txtRemoveWord);
            this.Name = "frmRemoveWord";
            this.Text = "Remove Word";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRemoveWord;
        private System.Windows.Forms.Button btnRemoveWord;
        private System.Windows.Forms.Label label1;
    }
}