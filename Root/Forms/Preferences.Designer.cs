
namespace GamePreferences
{
    partial class frmGamePreferences
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRandomWord = new System.Windows.Forms.Label();
            this.lblRandomDefinition = new System.Windows.Forms.Label();
            this.btnPlayGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox1.Location = new System.Drawing.Point(172, 141);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Questions";
            // 
            // lblRandomWord
            // 
            this.lblRandomWord.AutoSize = true;
            this.lblRandomWord.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRandomWord.Location = new System.Drawing.Point(45, 45);
            this.lblRandomWord.Name = "lblRandomWord";
            this.lblRandomWord.Size = new System.Drawing.Size(68, 30);
            this.lblRandomWord.TabIndex = 2;
            this.lblRandomWord.Text = "label2";
            this.lblRandomWord.Visible = false;
            // 
            // lblRandomDefinition
            // 
            this.lblRandomDefinition.AutoSize = true;
            this.lblRandomDefinition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRandomDefinition.Location = new System.Drawing.Point(45, 85);
            this.lblRandomDefinition.Name = "lblRandomDefinition";
            this.lblRandomDefinition.Size = new System.Drawing.Size(52, 21);
            this.lblRandomDefinition.TabIndex = 3;
            this.lblRandomDefinition.Text = "label2";
            this.lblRandomDefinition.Visible = false;
            // 
            // btnPlayGame
            // 
            this.btnPlayGame.Location = new System.Drawing.Point(45, 172);
            this.btnPlayGame.Name = "btnPlayGame";
            this.btnPlayGame.Size = new System.Drawing.Size(179, 23);
            this.btnPlayGame.TabIndex = 4;
            this.btnPlayGame.Text = "Play";
            this.btnPlayGame.UseVisualStyleBackColor = true;
            this.btnPlayGame.Click += new System.EventHandler(this.btnPlayGame_Click);
            // 
            // frmGamePreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 229);
            this.Controls.Add(this.btnPlayGame);
            this.Controls.Add(this.lblRandomDefinition);
            this.Controls.Add(this.lblRandomWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmGamePreferences";
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.frmGamePreferences_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRandomWord;
        private System.Windows.Forms.Label lblRandomDefinition;
        private System.Windows.Forms.Button btnPlayGame;
    }
}

