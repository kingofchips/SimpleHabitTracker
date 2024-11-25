namespace HabitTracker
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
            this.habitListView = new System.Windows.Forms.ListView();
            this.columnHabitName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFrequency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnStreak = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddHabit = new System.Windows.Forms.Button();
            this.btnMarkComplete = new System.Windows.Forms.Button();
            this.btnViewStatistics = new System.Windows.Forms.Button();
            this.labelAppDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // habitListView
            // 
            this.habitListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.habitListView.CheckBoxes = true;
            this.habitListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHabitName,
            this.columnDescription,
            this.columnFrequency,
            this.columnStreak});
            this.habitListView.FullRowSelect = true;
            this.habitListView.HideSelection = false;
            this.habitListView.Location = new System.Drawing.Point(145, 4);
            this.habitListView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.habitListView.Name = "habitListView";
            this.habitListView.Size = new System.Drawing.Size(1051, 486);
            this.habitListView.TabIndex = 1;
            this.habitListView.UseCompatibleStateImageBehavior = false;
            this.habitListView.View = System.Windows.Forms.View.Details;
            this.habitListView.SelectedIndexChanged += new System.EventHandler(this.habitListView_SelectedIndexChanged);
            // 
            // columnHabitName
            // 
            this.columnHabitName.Text = "Habit Name";
            this.columnHabitName.Width = 200;
            // 
            // columnDescription
            // 
            this.columnDescription.Text = "Description";
            this.columnDescription.Width = 300;
            // 
            // columnFrequency
            // 
            this.columnFrequency.Text = "Frequency";
            this.columnFrequency.Width = 126;
            // 
            // columnStreak
            // 
            this.columnStreak.Text = "Streak";
            this.columnStreak.Width = 115;
            // 
            // btnAddHabit
            // 
            this.btnAddHabit.Location = new System.Drawing.Point(3, 4);
            this.btnAddHabit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddHabit.Name = "btnAddHabit";
            this.btnAddHabit.Size = new System.Drawing.Size(125, 23);
            this.btnAddHabit.TabIndex = 2;
            this.btnAddHabit.Text = "Add Habit";
            this.btnAddHabit.UseVisualStyleBackColor = true;
            this.btnAddHabit.Click += new System.EventHandler(this.btnAddHabit_Click);
            // 
            // btnMarkComplete
            // 
            this.btnMarkComplete.Location = new System.Drawing.Point(5, 43);
            this.btnMarkComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMarkComplete.Name = "btnMarkComplete";
            this.btnMarkComplete.Size = new System.Drawing.Size(125, 23);
            this.btnMarkComplete.TabIndex = 3;
            this.btnMarkComplete.Text = "Mark Complete";
            this.btnMarkComplete.UseVisualStyleBackColor = true;
            this.btnMarkComplete.Click += new System.EventHandler(this.btnMarkComplete_Click);
            // 
            // btnViewStatistics
            // 
            this.btnViewStatistics.Location = new System.Drawing.Point(5, 82);
            this.btnViewStatistics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewStatistics.Name = "btnViewStatistics";
            this.btnViewStatistics.Size = new System.Drawing.Size(125, 23);
            this.btnViewStatistics.TabIndex = 4;
            this.btnViewStatistics.Text = "View Statistics";
            this.btnViewStatistics.UseVisualStyleBackColor = true;
            this.btnViewStatistics.Click += new System.EventHandler(this.btnViewStatistics_Click);
            // 
            // labelAppDescription
            // 
            this.labelAppDescription.AutoSize = true;
            this.labelAppDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAppDescription.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppDescription.Location = new System.Drawing.Point(0, 0);
            this.labelAppDescription.Name = "labelAppDescription";
            this.labelAppDescription.Size = new System.Drawing.Size(497, 38);
            this.labelAppDescription.TabIndex = 5;
            this.labelAppDescription.Text = "Create and learn new healthy habits!";
            this.labelAppDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAppDescription.Click += new System.EventHandler(this.labelAppDescription_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddHabit);
            this.panel1.Controls.Add(this.btnMarkComplete);
            this.panel1.Controls.Add(this.habitListView);
            this.panel1.Controls.Add(this.btnViewStatistics);
            this.panel1.Location = new System.Drawing.Point(7, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 500);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 553);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelAppDescription);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Habit Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView habitListView;
        private System.Windows.Forms.ColumnHeader columnHabitName;
        private System.Windows.Forms.ColumnHeader columnDescription;
        private System.Windows.Forms.ColumnHeader columnFrequency;
        private System.Windows.Forms.ColumnHeader columnStreak;
        private System.Windows.Forms.Button btnAddHabit;
        private System.Windows.Forms.Button btnMarkComplete;
        private System.Windows.Forms.Button btnViewStatistics;
        private System.Windows.Forms.Label labelAppDescription;
        private System.Windows.Forms.Panel panel1;
    }
}

