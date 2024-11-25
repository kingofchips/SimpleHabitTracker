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
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            using (var conn =TrackerDataBase.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT 
                COUNT(*) AS TotalHabits,
                SUM(CASE WHEN Streak > 0 THEN 1 ELSE 0 END) AS ActiveStreaks
            FROM Habits";
                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        labelTotalHabits.Text = "Total Habits: " + reader["TotalHabits"].ToString();
                        labelActiveStreaks.Text = "Active Streaks: " + reader["ActiveStreaks"].ToString();
                    }
                }
            }
        }
    }
}
