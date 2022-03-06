namespace WeightTracker
{
    partial class addspecie
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
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAddHabitat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAddGender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAddAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(279, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Add Specie";
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(270, 315);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(122, 41);
            this.cmdSubmit.TabIndex = 14;
            this.cmdSubmit.Text = "Add";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.CmdSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Habitat";
            // 
            // TxtAddHabitat
            // 
            this.TxtAddHabitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddHabitat.Location = new System.Drawing.Point(225, 255);
            this.TxtAddHabitat.Multiline = true;
            this.TxtAddHabitat.Name = "TxtAddHabitat";
            this.TxtAddHabitat.Size = new System.Drawing.Size(208, 38);
            this.TxtAddHabitat.TabIndex = 12;
            this.TxtAddHabitat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gender";
            // 
            // TxtAddGender
            // 
            this.TxtAddGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddGender.Location = new System.Drawing.Point(225, 183);
            this.TxtAddGender.Multiline = true;
            this.TxtAddGender.Name = "TxtAddGender";
            this.TxtAddGender.Size = new System.Drawing.Size(208, 38);
            this.TxtAddGender.TabIndex = 10;
            this.TxtAddGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Age";
            // 
            // TxtAddAge
            // 
            this.TxtAddAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddAge.Location = new System.Drawing.Point(225, 111);
            this.TxtAddAge.Multiline = true;
            this.TxtAddAge.Name = "TxtAddAge";
            this.TxtAddAge.Size = new System.Drawing.Size(208, 38);
            this.TxtAddAge.TabIndex = 8;
            this.TxtAddAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addspecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAddHabitat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAddGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAddAge);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "addspecie";
            this.Size = new System.Drawing.Size(658, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAddHabitat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAddGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAddAge;
    }
}
