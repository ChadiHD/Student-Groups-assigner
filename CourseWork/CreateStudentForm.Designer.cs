namespace CourseWork
{
    partial class CreateStudentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateStudentForm));
            this.CreateStudentButton = new System.Windows.Forms.Button();
            this.PhoneNrValue = new System.Windows.Forms.TextBox();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.CreateStudentHeaderLabel = new System.Windows.Forms.Label();
            this.WeightingValue = new System.Windows.Forms.TextBox();
            this.WeightingMarkLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateStudentButton
            // 
            this.CreateStudentButton.BackColor = System.Drawing.Color.White;
            this.CreateStudentButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.CreateStudentButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CreateStudentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.CreateStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateStudentButton.Font = new System.Drawing.Font("Tahoma", 16F);
            this.CreateStudentButton.Location = new System.Drawing.Point(104, 288);
            this.CreateStudentButton.Name = "CreateStudentButton";
            this.CreateStudentButton.Size = new System.Drawing.Size(221, 63);
            this.CreateStudentButton.TabIndex = 28;
            this.CreateStudentButton.Text = "Create Student";
            this.CreateStudentButton.UseVisualStyleBackColor = false;
            this.CreateStudentButton.Click += new System.EventHandler(this.CreateStudentButton_Click);
            // 
            // PhoneNrValue
            // 
            this.PhoneNrValue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNrValue.Location = new System.Drawing.Point(186, 195);
            this.PhoneNrValue.Name = "PhoneNrValue";
            this.PhoneNrValue.Size = new System.Drawing.Size(214, 30);
            this.PhoneNrValue.TabIndex = 36;
            // 
            // EmailValue
            // 
            this.EmailValue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailValue.Location = new System.Drawing.Point(186, 159);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(214, 30);
            this.EmailValue.TabIndex = 35;
            // 
            // LastNameValue
            // 
            this.LastNameValue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameValue.Location = new System.Drawing.Point(186, 123);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(214, 30);
            this.LastNameValue.TabIndex = 34;
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameValue.Location = new System.Drawing.Point(186, 87);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(214, 30);
            this.FirstNameValue.TabIndex = 29;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(37, 192);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(125, 33);
            this.PhoneNumberLabel.TabIndex = 33;
            this.PhoneNumberLabel.Text = "Phone Nr";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmailLabel.Location = new System.Drawing.Point(37, 156);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(79, 33);
            this.EmailLabel.TabIndex = 32;
            this.EmailLabel.Text = "Email";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastNameLabel.Location = new System.Drawing.Point(37, 120);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(140, 33);
            this.LastNameLabel.TabIndex = 31;
            this.LastNameLabel.Text = "Last Name";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FirstNameLabel.Location = new System.Drawing.Point(37, 84);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(143, 33);
            this.FirstNameLabel.TabIndex = 30;
            this.FirstNameLabel.Text = "First Name";
            this.FirstNameLabel.UseMnemonic = false;
            // 
            // CreateStudentHeaderLabel
            // 
            this.CreateStudentHeaderLabel.AutoSize = true;
            this.CreateStudentHeaderLabel.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateStudentHeaderLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateStudentHeaderLabel.Location = new System.Drawing.Point(12, 9);
            this.CreateStudentHeaderLabel.Name = "CreateStudentHeaderLabel";
            this.CreateStudentHeaderLabel.Size = new System.Drawing.Size(262, 45);
            this.CreateStudentHeaderLabel.TabIndex = 37;
            this.CreateStudentHeaderLabel.Text = "Create Student";
            // 
            // WeightingValue
            // 
            this.WeightingValue.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightingValue.Location = new System.Drawing.Point(202, 231);
            this.WeightingValue.Name = "WeightingValue";
            this.WeightingValue.Size = new System.Drawing.Size(198, 30);
            this.WeightingValue.TabIndex = 39;
            this.WeightingValue.Text = "0";
            // 
            // WeightingMarkLabel
            // 
            this.WeightingMarkLabel.AutoSize = true;
            this.WeightingMarkLabel.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightingMarkLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WeightingMarkLabel.Location = new System.Drawing.Point(37, 228);
            this.WeightingMarkLabel.Name = "WeightingMarkLabel";
            this.WeightingMarkLabel.Size = new System.Drawing.Size(168, 33);
            this.WeightingMarkLabel.TabIndex = 38;
            this.WeightingMarkLabel.Text = "Weighting %";
            // 
            // CreateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 368);
            this.Controls.Add(this.WeightingValue);
            this.Controls.Add(this.WeightingMarkLabel);
            this.Controls.Add(this.CreateStudentHeaderLabel);
            this.Controls.Add(this.CreateStudentButton);
            this.Controls.Add(this.PhoneNrValue);
            this.Controls.Add(this.EmailValue);
            this.Controls.Add(this.LastNameValue);
            this.Controls.Add(this.FirstNameValue);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateStudentForm";
            this.Text = "Create Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateStudentButton;
        private System.Windows.Forms.TextBox PhoneNrValue;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label CreateStudentHeaderLabel;
        private System.Windows.Forms.TextBox WeightingValue;
        private System.Windows.Forms.Label WeightingMarkLabel;
    }
}