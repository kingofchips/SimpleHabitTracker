namespace HabitTracker
{
    partial class StatisticsForm
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
            this.labelTotalHabits = new System.Windows.Forms.Label();
            this.labelActiveStreaks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotalHabits
            // 
            this.labelTotalHabits.AutoSize = true;
            this.labelTotalHabits.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalHabits.Location = new System.Drawing.Point(12, 9);
            this.labelTotalHabits.Name = "labelTotalHabits";
            this.labelTotalHabits.Size = new System.Drawing.Size(155, 31);
            this.labelTotalHabits.TabIndex = 0;
            this.labelTotalHabits.Text = "Total Habits: ";
            // 
            // labelActiveStreaks
            // 
            this.labelActiveStreaks.AutoSize = true;
            this.labelActiveStreaks.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActiveStreaks.Location = new System.Drawing.Point(12, 54);
            this.labelActiveStreaks.Name = "labelActiveStreaks";
            this.labelActiveStreaks.Size = new System.Drawing.Size(176, 31);
            this.labelActiveStreaks.TabIndex = 1;
            this.labelActiveStreaks.Text = "Active Streaks: ";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelActiveStreaks);
            this.Controls.Add(this.labelTotalHabits);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalHabits;
        private System.Windows.Forms.Label labelActiveStreaks;
    }
}