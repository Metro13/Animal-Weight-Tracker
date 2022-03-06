namespace WeightTracker
{
    partial class updatemeal
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
            this.TxtUpdateCvalue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUpdateQuantity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtupdatename = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Update Meal";
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.Location = new System.Drawing.Point(266, 342);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(122, 41);
            this.cmdSubmit.TabIndex = 14;
            this.cmdSubmit.Text = "Update";
            this.cmdSubmit.UseVisualStyleBackColor = true;
            this.cmdSubmit.Click += new System.EventHandler(this.CmdSubmit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Calorific value (Kcal)";
            // 
            // TxtUpdateCvalue
            // 
            this.TxtUpdateCvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUpdateCvalue.Location = new System.Drawing.Point(223, 221);
            this.TxtUpdateCvalue.Multiline = true;
            this.TxtUpdateCvalue.Name = "TxtUpdateCvalue";
            this.TxtUpdateCvalue.Size = new System.Drawing.Size(208, 38);
            this.TxtUpdateCvalue.TabIndex = 12;
            this.TxtUpdateCvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Meal Quantity";
            // 
            // TxtUpdateQuantity
            // 
            this.TxtUpdateQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUpdateQuantity.Location = new System.Drawing.Point(223, 149);
            this.TxtUpdateQuantity.Multiline = true;
            this.TxtUpdateQuantity.Name = "TxtUpdateQuantity";
            this.TxtUpdateQuantity.Size = new System.Drawing.Size(208, 38);
            this.TxtUpdateQuantity.TabIndex = 10;
            this.TxtUpdateQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name of meal";
            // 
            // Txtupdatename
            // 
            this.Txtupdatename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtupdatename.Location = new System.Drawing.Point(223, 77);
            this.Txtupdatename.Multiline = true;
            this.Txtupdatename.Name = "Txtupdatename";
            this.Txtupdatename.Size = new System.Drawing.Size(208, 38);
            this.Txtupdatename.TabIndex = 8;
            this.Txtupdatename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date (MM/DD/YY)";
            // 
            // TxtDate
            // 
            this.TxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(223, 289);
            this.TxtDate.Multiline = true;
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(208, 38);
            this.TxtDate.TabIndex = 16;
            this.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // updatemeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmdSubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtUpdateCvalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtUpdateQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtupdatename);
            this.Name = "updatemeal";
            this.Size = new System.Drawing.Size(658, 409);
            this.Load += new System.EventHandler(this.Updatemeal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtUpdateCvalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUpdateQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txtupdatename;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtDate;
    }
}
