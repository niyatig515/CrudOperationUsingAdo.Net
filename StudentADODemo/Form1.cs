using StudentDataAccess;
using StudentRepository;
using System;
using System.Windows.Forms;

namespace StudentApllicationUsingADO.NET
{
    public partial class Form1 : Form
    {
        CrudRepo repo = null;
        Student s = null;

        public Form1()
        {
            InitializeComponent();
            repo = new CrudRepo();
            DataGridView.SelectionChanged += DataGridView_SelectionChanged;
        }

        private bool checkAllFields()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required");
                return false;
            }
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Age should be a valid number");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Course is required");
                return false;
            }
            return true;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!checkAllFields()) return;
            s = new Student();
            s.Name = txtName.Text;

            if (int.TryParse(txtAge.Text, out int age))
            {
                s.Age = age;
            }
            else
            {
                MessageBox.Show("Age should be a valid number");
                return;
            }

            s.Course = txtCourse.Text;
            if (repo.InsertStudent(s))
                MessageBox.Show("Student Data Added Successfully!");
            else
                MessageBox.Show("Student already added. Please add a new one.");

            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (s == null || s.Id == 0)
            {
                MessageBox.Show("Please select a student from the grid to update.");
                return;
            }

            checkAllFields();
            s.Name = txtName.Text;

            if (int.TryParse(txtAge.Text, out int age))
            {
                s.Age = age;
            }
            else
            {
                MessageBox.Show("Age should be a valid number");
                return;
            }

            s.Course = txtCourse.Text;
            if (repo.UpdateStudent(s))
                MessageBox.Show("Student Data Updated Successfully!");
            else
                MessageBox.Show("Update failed. Please check the details.");

            LoadData();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            LoadData();
        }




        private void LoadData()
        {
            DataGridView.DataSource = null;
            var students = repo.DisplayStudents();
            DataGridView.DataSource = students;

            // Auto-adjust height to fit rows (max height: 10 rows)
            int rowHeight = DataGridView.RowTemplate.Height;
            int rowCount = DataGridView.Rows.Count;

            DataGridView.Height = Math.Min(rowCount * rowHeight + 40, 400); // Max Height: 400px

        }



        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                s = new Student
                {
                    Id = Convert.ToInt32(DataGridView.SelectedRows[0].Cells["Id"].Value),
                    Name = DataGridView.SelectedRows[0].Cells["Name"].Value.ToString(),
                    Age = Convert.ToInt32(DataGridView.SelectedRows[0].Cells["Age"].Value),
                    Course = DataGridView.SelectedRows[0].Cells["Course"].Value.ToString()
                };

                txtName.Text = s.Name;
                txtAge.Text = s.Age.ToString();
                txtCourse.Text = s.Course;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (s == null || s.Id == 0)
            {
                MessageBox.Show("Please select a student from the grid to delete.");
                return;
            }

            var confirmResult = MessageBox.Show("Are you sure you want to delete this student?",
                                                "Confirm Delete",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                if (repo.DeleteStudent(s.Id))
                {
                    MessageBox.Show("Student Deleted Successfully!");
                    txtName.Clear();
                    txtAge.Clear();
                    txtCourse.Clear();
                    s = null;
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Failed to delete student.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            // This method is currently empty.
            // You can add any necessary logic here if needed.
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                LoadData(); // Reload full data if search box is empty
                return;
            }

            DataGridView.DataSource = null;

            // Try parsing as an ID (if user enters a number)
            bool isNumeric = int.TryParse(searchText, out int searchId);
            List<Student> students;

            if (isNumeric)
            {
                students = repo.SearchStudentsById(searchId);
            }
            else
            {
                students = repo.SearchStudentsByName(searchText);
            }

            if (students == null || students.Count == 0)
            {
                MessageBox.Show("No such data is present in the database.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DataGridView.DataSource = students;
        }


        private void lblAge_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView.ScrollBars = ScrollBars.Vertical;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
