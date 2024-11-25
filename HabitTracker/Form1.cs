using HabitTracker.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HabitTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelAppDescription_Click(object sender, EventArgs e)
        {

        }

        private void habitListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAddHabit_Click(object sender, EventArgs e)
        {
            AddHabitForm addHabitForm = new AddHabitForm();
            addHabitForm.ShowDialog();
        }

        private void LoadHabits()
        {
            habitListView.Items.Clear();
            using (var conn = TrackerDataBase.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Habits";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["Name"].ToString());
                        item.SubItems.Add(reader["Description"].ToString());
                        item.SubItems.Add(reader["Frequency"].ToString());
                        item.SubItems.Add(reader["Streak"].ToString());
                        item.Tag = reader["HabitId"]; // Store the habit ID
                        habitListView.Items.Add(item);
                    }
                }
            }
        }

        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (habitListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a habit to mark as complete.");
                return;
            }

            string habitId = habitListView.SelectedItems[0].Tag.ToString(); // Assume Tag contains the habit ID

            using (var conn = TrackerDataBase.GetConnection())
            {
                conn.Open();
                string query = @"
            UPDATE Habits
            SET LastCompletedDate = CURRENT_DATE,
                Streak = CASE 
                            WHEN LastCompletedDate = DATE(CURRENT_DATE, '-1 day') THEN Streak + 1
                            ELSE 1
                         END
            WHERE HabitId = @HabitId";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HabitId", habitId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Habit marked as complete!");
            LoadHabits();
        }

        private void btnViewStatistics_Click(object sender, EventArgs e)
        {
            StatisticsForm statsForm = new StatisticsForm();
            statsForm.ShowDialog();
        }
    }
}