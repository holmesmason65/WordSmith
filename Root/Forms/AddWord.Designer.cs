
namespace Root.Forms
{
    partial class frmAddWord
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
            this.txtWordName = new System.Windows.Forms.TextBox();
            this.txtDefinition = new System.Windows.Forms.TextBox();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtWordName
            // 
            this.txtWordName.Location = new System.Drawing.Point(91, 43);
            this.txtWordName.Name = "txtWordName";
            this.txtWordName.Size = new System.Drawing.Size(115, 23);
            this.txtWordName.TabIndex = 0;
            // 
            // txtDefinition
            // 
            this.txtDefinition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDefinition.Location = new System.Drawing.Point(91, 72);
            this.txtDefinition.Multiline = true;
            this.txtDefinition.Name = "txtDefinition";
            this.txtDefinition.Size = new System.Drawing.Size(295, 43);
            this.txtDefinition.TabIndex = 1;
            // 
            // btnAddWord
            // 
            this.btnAddWord.Location = new System.Drawing.Point(91, 121);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(101, 23);
            this.btnAddWord.TabIndex = 2;
            this.btnAddWord.Text = "Add Word";
            this.btnAddWord.UseVisualStyleBackColor = true;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Definition";
            // 
            // frmAddWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(400, 167);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddWord);
            this.Controls.Add(this.txtDefinition);
            this.Controls.Add(this.txtWordName);
            this.Name = "frmAddWord";
            this.Text = "AddWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtWordName;
        private System.Windows.Forms.TextBox txtDefinition;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}