namespace WeightTracker
{
    partial class Choice
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
            this.cmdMeals = new System.Windows.Forms.Button();
            this.cmdActivities = new System.Windows.Forms.Button();
            this.cmdMeasurements = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSpecie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdMeals
            // 
            this.cmdMeals.Location = new System.Drawing.Point(229, 182);
            this.cmdMeals.Name = "cmdMeals";
            this.cmdMeals.Size = new System.Drawing.Size(147, 49);
            this.cmdMeals.TabIndex = 0;
            this.cmdMeals.Text = "Meals";
            this.cmdMeals.UseVisualStyleBackColor = true;
            this.cmdMeals.Click += new System.EventHandler(this.CmdMeals_Click);
            // 
            // cmdActivities
            // 
            this.cmdActivities.Location = new System.Drawing.Point(382, 182);
            this.cmdActivities.Name = "cmdActivities";
            this.cmdActivities.Size = new System.Drawing.Size(147, 49);
            this.cmdActivities.TabIndex = 1;
            this.cmdActivities.Text = "Activities";
            this.cmdActivities.UseVisualStyleBackColor = true;
            this.cmdActivities.Click += new System.EventHandler(this.CmdActivities_Click);
            // 
            // cmdMeasurements
            // 
            this.cmdMeasurements.Location = new System.Drawing.Point(535, 182);
            this.cmdMeasurements.Name = "cmdMeasurements";
            this.cmdMeasurements.Size = new System.Drawing.Size(147, 49);
            this.cmdMeasurements.TabIndex = 2;
            this.cmdMeasurements.Text = "Measurements";
            this.cmdMeasurements.UseVisualStyleBackColor = true;
            this.cmdMeasurements.Click += new System.EventHandler(this.CmdMeasurements_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select what you want to manage";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // cmdSpecie
            // 
            this.cmdSpecie.Location = new System.Drawing.Point(76, 182);
            this.cmdSpecie.Name = "cmdSpecie";
            this.cmdSpecie.Size = new System.Drawing.Size(147, 49);
            this.cmdSpecie.TabIndex = 4;
            this.cmdSpecie.Text = "Specie";
            this.cmdSpecie.UseVisualStyleBackColor = true;
            this.cmdSpecie.Click += new System.EventHandler(this.CmdSpecie_Click);
            // 
            // Choice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 354);
            this.Controls.Add(this.cmdSpecie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdMeasurements);
            this.Controls.Add(this.cmdActivities);
            this.Controls.Add(this.cmdMeals);
            this.Name = "Choice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdMeals;
        private System.Windows.Forms.Button cmdActivities;
        private System.Windows.Forms.Button cmdMeasurements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdSpecie;
    }
}