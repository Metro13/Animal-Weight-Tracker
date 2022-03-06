namespace WeightTracker
{
    partial class updateactivity
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAddduration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtAddname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Update Activity";
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(273, 363);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(122, 41);
            this.cmdSubmit.TabIndex = 22;
            this.cmdSubmit.Text = "Update";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.CmdSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Activity Level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Duration (Minutes)";
            // 
            // TxtAddduration
            // 
            this.TxtAddduration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddduration.Location = new System.Drawing.Point(225, 153);
            this.TxtAddduration.Multiline = true;
            this.TxtAddduration.Name = "TxtAddduration";
            this.TxtAddduration.Size = new System.Drawing.Size(208, 38);
            this.TxtAddduration.TabIndex = 18;
            this.TxtAddduration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Exercise Name";
            // 
            // TxtAddname
            // 
            this.TxtAddname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddname.Location = new System.Drawing.Point(225, 81);
            this.TxtAddname.Multiline = true;
            this.TxtAddname.Name = "TxtAddname";
            this.TxtAddname.Size = new System.Drawing.Size(208, 38);
            this.TxtAddname.TabIndex = 16;
            this.TxtAddname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Date (MM/DD/YY)";
            // 
            // TxtDate
            // 
            this.TxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(225, 309);
            this.TxtDate.Multiline = true;
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(208, 38);
            this.TxtDate.TabIndex = 24;
            this.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Inactive",
            "Moderate",
            "Active"});
            this.comboBox1.Location = new System.Drawing.Point(261, 217);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 26;
            // 
            // updateactivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAddduration);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAddname);
            this.Name = "updateactivity";
            this.Size = new System.Drawing.Size(658, 425);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAddduration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtAddname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDate;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
