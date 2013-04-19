namespace PasswordGenerator
{
    partial class FrmMain
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
            this.btnGenerator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPasswordGenerator = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGenerator
            // 
            this.btnGenerator.Location = new System.Drawing.Point(136, 91);
            this.btnGenerator.Name = "btnGenerator";
            this.btnGenerator.Size = new System.Drawing.Size(75, 23);
            this.btnGenerator.TabIndex = 0;
            this.btnGenerator.Text = "Generator";
            this.btnGenerator.UseVisualStyleBackColor = true;
            this.btnGenerator.Click += new System.EventHandler(this.btnGenerator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Password Generator";
            // 
            // txtPasswordGenerator
            // 
            this.txtPasswordGenerator.Location = new System.Drawing.Point(136, 56);
            this.txtPasswordGenerator.Name = "txtPasswordGenerator";
            this.txtPasswordGenerator.Size = new System.Drawing.Size(220, 20);
            this.txtPasswordGenerator.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 145);
            this.Controls.Add(this.txtPasswordGenerator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerator);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerator;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPasswordGenerator;
    }
}

