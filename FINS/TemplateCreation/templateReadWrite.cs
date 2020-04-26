using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace TemplateCreation
{

    public static class templateReadWrite
    {
        public static bool Load(ref List<Student> myStudentList,
                                ref string error)
        {

            SqlConnection myStudentConnection = new SqlConnection();
            SqlDataReader myStudentDataReader;
            SqlCommand myStudentCommand;
            Student myStudent;
            try
            {
                myStudentConnection = RegistrationDB.GetConnection();
                myStudentConnection.Open();

                //setup Command
                myStudentCommand = new SqlCommand();
                myStudentCommand.Connection = myStudentConnection;
                myStudentCommand.CommandText = "Select StudentID, StudentName, StudentMidterm, StudentFinal, StudentMajor from Students";

                //exceute the command to produce a DataReader
                myStudentDataReader = myStudentCommand.ExecuteReader();

                while (myStudentDataReader.Read())
                {
                    //create a new student based on the student record just read
                    //  0 is StudentID
                    //  1 is StudentName
                    //  2 is StudentMidterm
                    //  3 is StudentFinal
                    //  4 is StudentMajor
                    myStudent = new Student();
                    myStudent.ID = myStudentDataReader.GetInt32(0);
                    myStudent.Name = myStudentDataReader.GetString(1);
                    myStudent.Midterm = myStudentDataReader.GetInt32(2);
                    myStudent.Final = myStudentDataReader.GetInt32(3);
                    myStudent.Major = myStudentDataReader.GetString(4);

                    myStudentList.Add(myStudent);
                }

                myStudentDataReader.Close();

                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
            finally
            {
                myStudentConnection.Close();
            }

        }























    }







}