namespace WeightTracker
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSpecie = new System.Windows.Forms.ComboBox();
            this.cmdProceed = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(122, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "select a specie to start";
            // 
            // cmbSpecie
            // 
            this.cmbSpecie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpecie.FormattingEnabled = true;
            this.cmbSpecie.ItemHeight = 17;
            this.cmbSpecie.Items.AddRange(new object[] {
            "Sheep",
            "Horse",
            "Bear"});
            this.cmbSpecie.Location = new System.Drawing.Point(91, 209);
            this.cmbSpecie.Name = "cmbSpecie";
            this.cmbSpecie.Size = new System.Drawing.Size(192, 25);
            this.cmbSpecie.TabIndex = 2;
            this.cmbSpecie.Text = "Tap here";
            // 
            // cmdProceed
            // 
            this.cmdProceed.Location = new System.Drawing.Point(125, 312);
            this.cmdProceed.Name = "cmdProceed";
            this.cmdProceed.Size = new System.Drawing.Size(128, 37);
            this.cmdProceed.TabIndex = 3;
            this.cmdProceed.Text = "Proceed";
            this.cmdProceed.UseVisualStyleBackColor = true;
            this.cmdProceed.Click += new System.EventHandler(this.CmdProceed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 462);
            this.Controls.Add(this.cmdProceed);
            this.Controls.Add(this.cmbSpecie);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSpecie;
        private System.Windows.Forms.Button cmdProceed;
    }
}

