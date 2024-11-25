namespace HabitTracker
{
    partial class AddHabitForm
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
            this.labelHabitName = new System.Windows.Forms.Label();
            this.txtNameHabit = new System.Windows.Forms.TextBox();
            this.labelHabitDescription = new System.Windows.Forms.Label();
            this.txtDescribeHabit = new System.Windows.Forms.TextBox();
            this.labelFrequency = new System.Windows.Forms.Label();
            this.comboBoxFrequency = new System.Windows.Forms.ComboBox();
            this.buttonSaveHabit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHabitName
            // 
            this.labelHabitName.AutoSize = true;
            this.labelHabitName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHabitName.Location = new System.Drawing.Point(13, 13);
            this.labelHabitName.Name = "labelHabitName";
            this.labelHabitName.Size = new System.Drawing.Size(107, 23);
            this.labelHabitName.TabIndex = 0;
            this.labelHabitName.Text = "Habit Name";
            this.labelHabitName.Click += new System.EventHandler(this.labelHabitName_Click);
            // 
            // txtNameHabit
            // 
            this.txtNameHabit.Location = new System.Drawing.Point(17, 39);
            this.txtNameHabit.Name = "txtNameHabit";
            this.txtNameHabit.Size = new System.Drawing.Size(350, 22);
            this.txtNameHabit.TabIndex = 1;
            this.txtNameHabit.TextChanged += new System.EventHandler(this.txtNameHabit_TextChanged);
            // 
            // labelHabitDescription
            // 
            this.labelHabitDescription.AutoSize = true;
            this.labelHabitDescription.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHabitDescription.Location = new System.Drawing.Point(13, 88);
            this.labelHabitDescription.Name = "labelHabitDescription";
            this.labelHabitDescription.Size = new System.Drawing.Size(157, 23);
            this.labelHabitDescription.TabIndex = 2;
            this.labelHabitDescription.Text = "Describe the habit";
            this.labelHabitDescription.Click += new System.EventHandler(this.labelHabitDescription_Click);
            // 
            // txtDescribeHabit
            // 
            this.txtDescribeHabit.Location = new System.Drawing.Point(17, 115);
            this.txtDescribeHabit.Name = "txtDescribeHabit";
            this.txtDescribeHabit.Size = new System.Drawing.Size(771, 22);
            this.txtDescribeHabit.TabIndex = 3;
            this.txtDescribeHabit.TextChanged += new System.EventHandler(this.txtDescribeHabit_TextChanged);
            // 
            // labelFrequency
            // 
            this.labelFrequency.AutoSize = true;
            this.labelFrequency.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrequency.Location = new System.Drawing.Point(13, 167);
            this.labelFrequency.Name = "labelFrequency";
            this.labelFrequency.Size = new System.Drawing.Size(192, 23);
            this.labelFrequency.TabIndex = 4;
            this.labelFrequency.Text = "Frequency of the habit";
            this.labelFrequency.Click += new System.EventHandler(this.labelFrequency_Click);
            // 
            // comboBoxFrequency
            // 
            this.comboBoxFrequency.FormattingEnabled = true;
            this.comboBoxFrequency.Items.AddRange(new object[] {
            "Daily",
            "Every Other Day",
            "Weekly",
            "Monthly"});
            this.comboBoxFrequency.Location = new System.Drawing.Point(17, 193);
            this.comboBoxFrequency.Name = "comboBoxFrequency";
            this.comboBoxFrequency.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFrequency.TabIndex = 5;
            this.comboBoxFrequency.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrequency_SelectedIndexChanged);
            // 
            // buttonSaveHabit
            // 
            this.buttonSaveHabit.Location = new System.Drawing.Point(17, 262);
            this.buttonSaveHabit.Name = "buttonSaveHabit";
            this.buttonSaveHabit.Size = new System.Drawing.Size(121, 23);
            this.buttonSaveHabit.TabIndex = 6;
            this.buttonSaveHabit.Text = "Save New Habit";
            this.buttonSaveHabit.UseVisualStyleBackColor = true;
            this.buttonSaveHabit.Click += new System.EventHandler(this.buttonSaveHabit_Click);
            // 
            // AddHabitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSaveHabit);
            this.Controls.Add(this.comboBoxFrequency);
            this.Controls.Add(this.labelFrequency);
            this.Controls.Add(this.txtDescribeHabit);
            this.Controls.Add(this.labelHabitDescription);
            this.Controls.Add(this.txtNameHabit);
            this.Controls.Add(this.labelHabitName);
            this.Name = "AddHabitForm";
            this.Text = "AddHabitForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHabitName;
        private System.Windows.Forms.TextBox txtNameHabit;
        private System.Windows.Forms.Label labelHabitDescription;
        private System.Windows.Forms.TextBox txtDescribeHabit;
        private System.Windows.Forms.Label labelFrequency;
        private System.Windows.Forms.ComboBox comboBoxFrequency;
        private System.Windows.Forms.Button buttonSaveHabit;
    }
}