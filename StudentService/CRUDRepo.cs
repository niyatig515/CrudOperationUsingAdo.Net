using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using StudentRepository;

namespace StudentDataAccess
{
    public class CrudRepo
    {
        
        public List<Student> DisplayStudents()
        {
            List<Student> students = new List<Student>();

            try
            {
                SqlConnection con = Connection.GetConnection();
                {
                    Connection.OpenConnection(con);
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Students", con))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            students.Add(new Student
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Name = dr["Name"].ToString(),
                                Age = Convert.ToInt32(dr["Age"]),
                                Course = dr["Course"].ToString()
                            });
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error fetching students: " + ex.Message);
            }

            return students;
        }

        public bool InsertStudent(Student student)
        {
            try
            {
                using (SqlConnection con = Connection.GetConnection())
                {
                    Connection.OpenConnection(con);
                    Console.WriteLine("Connection Established");
                    string query = "INSERT INTO Students (Name, Age, Course) VALUES (@Name, @Age, @Course)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", student.Name);
                        cmd.Parameters.AddWithValue("@Age", student.Age);
                        cmd.Parameters.AddWithValue("@Course", student.Course);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error inserting student: " + ex.Message);
                return false;
            }
        }

        public bool UpdateStudent(Student student)
        {
            try
            {
                using (SqlConnection con = Connection.GetConnection())
                {
                    Connection.OpenConnection(con);
                    string query = "UPDATE Students SET Name=@Name, Age=@Age, Course=@Course WHERE Id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", student.Id);
                        cmd.Parameters.AddWithValue("@Name", student.Name);
                        cmd.Parameters.AddWithValue("@Age", student.Age);
                        cmd.Parameters.AddWithValue("@Course", student.Course);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error updating student: " + ex.Message);
                return false;
            }
        }

        public bool DeleteStudent(int id)
        {
            try
            {
                using (SqlConnection con = Connection.GetConnection())
                {
                    Connection.OpenConnection(con);
                    string query = "DELETE FROM Students WHERE Id=@Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error deleting student: " + ex.Message);
                return false;
            }
        }
        public List<Student> SearchStudentsById(int id)
        {
            List<Student> students = new List<Student>();

            try
            {
                using (SqlConnection con = Connection.GetConnection())
                {
                    Connection.OpenConnection(con);
                    string query = "SELECT * FROM Students WHERE Id = @Id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                students.Add(new Student
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    Name = dr["Name"].ToString(),
                                    Age = Convert.ToInt32(dr["Age"]),
                                    Course = dr["Course"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error searching students by ID: " + ex.Message);
            }

            return students;
        }


        public List<Student> SearchStudentsByName(string name)
        {
            List<Student> students = new List<Student>();

            try
            {
                using (SqlConnection con = Connection.GetConnection())
                {
                    Connection.OpenConnection(con);
                    string query = "SELECT * FROM Students WHERE Name LIKE @Name";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Name", "%" + name + "%");
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                students.Add(new Student
                                {
                                    Id = Convert.ToInt32(dr["Id"]),
                                    Name = dr["Name"].ToString(),
                                    Age = Convert.ToInt32(dr["Age"]),
                                    Course = dr["Course"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error searching students: " + ex.Message);
            }

            return students;
        }



    }
}
