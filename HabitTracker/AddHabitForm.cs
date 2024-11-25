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
    public partial class AddHabitForm : Form
    {
        public AddHabitForm()
        {
            InitializeComponent();
        }

        private void labelHabitName_Click(object sender, EventArgs e)
        {

        }

        private void txtNameHabit_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelHabitDescription_Click(object sender, EventArgs e)
        {

        }

        private void txtDescribeHabit_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelFrequency_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxFrequency_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveHabit_Click(object sender, EventArgs e)
        {
            string name = txtNameHabit.Text;
            string description = txtDescribeHabit.Text;
            string frequency = comboBoxFrequency.SelectedItem.ToString();

            using (var conn = TrackerDataBase.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Habits (Name, Description, Frequency) VALUES (@Name, @Description, @Frequency)";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Frequency", frequency);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Habit added successfully!");
            this.Close();
        }
    }
}
