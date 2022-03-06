namespace WeightTracker
{
    partial class deletemeasurements
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.Txtdate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Date (DD/MM/YY)";
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(242, 263);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(139, 43);
            this.cmdSubmit.TabIndex = 37;
            this.cmdSubmit.Text = "Add";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.CmdSubmit_Click);
            // 
            // Txtdate
            // 
            this.Txtdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtdate.Location = new System.Drawing.Point(207, 195);
            this.Txtdate.Multiline = true;
            this.Txtdate.Name = "Txtdate";
            this.Txtdate.Size = new System.Drawing.Size(208, 38);
            this.Txtdate.TabIndex = 36;
            this.Txtdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 21);
            this.label4.TabIndex = 39;
            this.label4.Text = "Delete Measurements";
            // 
            // deletemeasurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.Txtdate);
            this.Name = "deletemeasurements";
            this.Size = new System.Drawing.Size(625, 432);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.TextBox Txtdate;
        private System.Windows.Forms.Label label4;
    }
}
