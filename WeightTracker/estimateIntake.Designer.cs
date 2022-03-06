namespace WeightTracker
{
    partial class estimateIntake
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
            this.lblSpecie = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstimate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Font = new System.Drawing.Font("Montserrat SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecie.Location = new System.Drawing.Point(286, 76);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(77, 29);
            this.lblSpecie.TabIndex = 7;
            this.lblSpecie.Text = "Horse";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Specie :";
            // 
            // lblEstimate
            // 
            this.lblEstimate.AutoSize = true;
            this.lblEstimate.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstimate.Location = new System.Drawing.Point(215, 215);
            this.lblEstimate.Name = "lblEstimate";
            this.lblEstimate.Size = new System.Drawing.Size(148, 45);
            this.lblEstimate.TabIndex = 5;
            this.lblEstimate.Text = "00 Kcals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Daily Maintenance Calories";
            // 
            // estimateIntake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblEstimate);
            this.Controls.Add(this.label1);
            this.Name = "estimateIntake";
            this.Size = new System.Drawing.Size(586, 405);
            this.Load += new System.EventHandler(this.EstimateIntake_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpecie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEstimate;
        private System.Windows.Forms.Label label1;
    }
}
