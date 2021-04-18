using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Data;

namespace LessonEndProject.Models
{
    public class StudentQuery
    {

        //static string connectionstring = "Server=BSC-6WWCH92\\SQLEXPRESS; Database=School;Integrated security=true;";
        static string connectionstring = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public List<Student> getData()
        {
            List<Student> students = new List<Student>();
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select *  from [Student]", conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Student student = new Student();
                        student.ID = Convert.ToInt32(rdr.GetValue(0));
                        student.Sname = rdr.GetValue(1).ToString();
                        student.std = rdr.GetValue(2).ToString();
                        student.Physics = Convert.ToInt32(rdr.GetValue(3));
                        student.Chemistry = Convert.ToInt32(rdr.GetValue(4));
                        student.Maths = Convert.ToInt32(rdr.GetValue(5));
                        student.English = Convert.ToInt32(rdr.GetValue(6));
                        students.Add(student);
                    }
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return students;
        }
        public int getcount()
        {
            int result = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select count(*)  from [Student]", conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public int getsubjects()
        {
            int result = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select count(*)  from [Subjects]", conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public int getminPhy()
        {
            int result = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select Min([Physics])  from [Student]", conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public int getminChe()
        {
            int result = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select Min([Chemistry])  from [Student]", conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public int getminMath()
        {
            int result = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select Min([Maths])  from [Student]", conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public int getminEng()
        {
            int result = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select Min([English])  from [Student]", conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public int getmaxPhy()
        {
            int result = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select Max([Physics])  from [Student]", conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public int getmaxChe()
        {
            int result = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select Max([Chemistry])  from [Student]", conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public int getmaxMath()
        {
            int result = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select Max([Maths])  from [Student]", conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public int getmaxEng()
        {
            int result = 0;
            try
            {

                using (SqlConnection conn = new SqlConnection(connectionstring))
                {
                    SqlCommand cmd = new SqlCommand("select Max([English])  from [Student]", conn);
                    cmd.CommandType = System.Data.CommandType.Text;
                    conn.Open();
                    result = (int)cmd.ExecuteScalar();
                    conn.Close();

                }
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }
        public List<Student> getstudentwithlowestandhighestmarks()
        {
            List<Student> student = new List<Student>();
            using (SqlConnection conn = new SqlConnection(connectionstring))
            {
                SqlCommand cmd = new SqlCommand("select Min([Physics])  from [Student]", conn);
                cmd.CommandType = System.Data.CommandType.Text;
                conn.Open();
                int marks = (int)cmd.ExecuteScalar();
                SqlCommand cmd2 = new SqlCommand("select Max([Physics])  from [Student]", conn);
                cmd2.CommandType = System.Data.CommandType.Text;
             
                int marks2 = (int)cmd2.ExecuteScalar();

                SqlCommand cmd1 = new SqlCommand("select * from [Student] WHERE Physics=@marks OR Physics=@marks2", conn);
                cmd1.Parameters.Add("@marks", SqlDbType.Int).Value = marks;
                cmd1.Parameters.Add("@marks2", SqlDbType.Int).Value = marks2;
                cmd1.CommandType = System.Data.CommandType.Text;
                SqlDataReader rdr = cmd1.ExecuteReader();
                while (rdr.Read())
                 {
                    Student result = new Student();
                    result.ID = Convert.ToInt32(rdr.GetValue(0));
                    result.Sname = rdr.GetValue(1).ToString();
                    result.std = rdr.GetValue(2).ToString();
                    result.Physics = Convert.ToInt32(rdr.GetValue(3));
                    result.Chemistry = Convert.ToInt32(rdr.GetValue(4));
                    result.Maths = Convert.ToInt32(rdr.GetValue(5));
                    result.English = Convert.ToInt32(rdr.GetValue(6));
                    student.Add(result);
                }
                conn.Close();

            }
            return student;
        }
    }
}