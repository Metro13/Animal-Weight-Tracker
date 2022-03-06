namespace WeightTracker
{
    partial class deletespecie
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtspeciename = new System.Windows.Forms.TextBox();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Delete Meal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Enter Specie Name";
            // 
            // Txtspeciename
            // 
            this.Txtspeciename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtspeciename.Location = new System.Drawing.Point(226, 189);
            this.Txtspeciename.Multiline = true;
            this.Txtspeciename.Name = "Txtspeciename";
            this.Txtspeciename.Size = new System.Drawing.Size(208, 38);
            this.Txtspeciename.TabIndex = 23;
            this.Txtspeciename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(273, 246);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(122, 41);
            this.cmdSubmit.TabIndex = 22;
            this.cmdSubmit.Text = "Delete";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.CmdSubmit_Click);
            // 
            // deletespecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txtspeciename);
            this.Controls.Add(this.cmdSubmit);
            this.Name = "deletespecie";
            this.Size = new System.Drawing.Size(658, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtspeciename;
        private System.Windows.Forms.Button cmdSubmit;
    }
}
