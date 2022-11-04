namespace ConOpenClose
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
            this.btnOpenClose = new System.Windows.Forms.Button();
            this.lblOpenClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenClose
            // 
            this.btnOpenClose.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnOpenClose.FlatAppearance.BorderSize = 2;
            this.btnOpenClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenClose.Location = new System.Drawing.Point(241, 296);
            this.btnOpenClose.Name = "btnOpenClose";
            this.btnOpenClose.Size = new System.Drawing.Size(219, 102);
            this.btnOpenClose.TabIndex = 0;
            this.btnOpenClose.Text = "Connect";
            this.btnOpenClose.UseVisualStyleBackColor = false;
            this.btnOpenClose.Click += new System.EventHandler(this.btnOpenClose_Click);
            // 
            // lblOpenClose
            // 
            this.lblOpenClose.AutoSize = true;
            this.lblOpenClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOpenClose.Location = new System.Drawing.Point(460, 97);
            this.lblOpenClose.Name = "lblOpenClose";
            this.lblOpenClose.Size = new System.Drawing.Size(138, 48);
            this.lblOpenClose.TabIndex = 1;
            this.lblOpenClose.Text = " Close";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(75, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Connection State:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(738, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOpenClose);
            this.Controls.Add(this.btnOpenClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenClose;
        private System.Windows.Forms.Label lblOpenClose;
        private System.Windows.Forms.Label label1;
    }
}

