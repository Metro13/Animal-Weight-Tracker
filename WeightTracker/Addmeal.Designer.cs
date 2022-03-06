namespace WeightTracker
{
    partial class Addmeal
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
            this.TxtAddname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAddQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtAddCvalue = new System.Windows.Forms.TextBox();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtAddname
            // 
            this.TxtAddname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddname.Location = new System.Drawing.Point(211, 91);
            this.TxtAddname.Multiline = true;
            this.TxtAddname.Name = "TxtAddname";
            this.TxtAddname.Size = new System.Drawing.Size(208, 38);
            this.TxtAddname.TabIndex = 0;
            this.TxtAddname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name of meal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Meal Quantity";
            // 
            // TxtAddQuantity
            // 
            this.TxtAddQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddQuantity.Location = new System.Drawing.Point(211, 163);
            this.TxtAddQuantity.Multiline = true;
            this.TxtAddQuantity.Name = "TxtAddQuantity";
            this.TxtAddQuantity.Size = new System.Drawing.Size(208, 38);
            this.TxtAddQuantity.TabIndex = 2;
            this.TxtAddQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Calorific value (Kcal)";
            // 
            // TxtAddCvalue
            // 
            this.TxtAddCvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddCvalue.Location = new System.Drawing.Point(211, 235);
            this.TxtAddCvalue.Multiline = true;
            this.TxtAddCvalue.Name = "TxtAddCvalue";
            this.TxtAddCvalue.Size = new System.Drawing.Size(208, 38);
            this.TxtAddCvalue.TabIndex = 4;
            this.TxtAddCvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(256, 295);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(122, 41);
            this.cmdSubmit.TabIndex = 6;
            this.cmdSubmit.Text = "Add";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.CmdSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Add Meal";
            // 
            // Addmeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtAddCvalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtAddQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtAddname);
            this.Name = "Addmeal";
            this.Size = new System.Drawing.Size(658, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAddname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAddQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtAddCvalue;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.Label label4;
    }
}
