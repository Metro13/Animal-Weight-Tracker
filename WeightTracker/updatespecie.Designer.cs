namespace WeightTracker
{
    partial class updatespecie
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
            this.TxtUpdateHabitat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUpdateGender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtUpdateAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Update Specie";
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(270, 314);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(122, 41);
            this.cmdSubmit.TabIndex = 22;
            this.cmdSubmit.Text = "Add";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.CmdSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Habitat";
            // 
            // TxtUpdateHabitat
            // 
            this.TxtUpdateHabitat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUpdateHabitat.Location = new System.Drawing.Point(225, 254);
            this.TxtUpdateHabitat.Multiline = true;
            this.TxtUpdateHabitat.Name = "TxtUpdateHabitat";
            this.TxtUpdateHabitat.Size = new System.Drawing.Size(208, 38);
            this.TxtUpdateHabitat.TabIndex = 20;
            this.TxtUpdateHabitat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Gender";
            // 
            // TxtUpdateGender
            // 
            this.TxtUpdateGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUpdateGender.Location = new System.Drawing.Point(225, 182);
            this.TxtUpdateGender.Multiline = true;
            this.TxtUpdateGender.Name = "TxtUpdateGender";
            this.TxtUpdateGender.Size = new System.Drawing.Size(208, 38);
            this.TxtUpdateGender.TabIndex = 18;
            this.TxtUpdateGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Age";
            // 
            // TxtUpdateAge
            // 
            this.TxtUpdateAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUpdateAge.Location = new System.Drawing.Point(225, 110);
            this.TxtUpdateAge.Multiline = true;
            this.TxtUpdateAge.Name = "TxtUpdateAge";
            this.TxtUpdateAge.Size = new System.Drawing.Size(208, 38);
            this.TxtUpdateAge.TabIndex = 16;
            this.TxtUpdateAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updatespecie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUpdateHabitat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUpdateGender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUpdateAge);
            this.Name = "updatespecie";
            this.Size = new System.Drawing.Size(658, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUpdateHabitat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUpdateGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtUpdateAge;
    }
}
