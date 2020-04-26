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
        public static bool Load(ref List<coreTemplate> myTemplateList,
                                ref string error)
        {

            SqlConnection myTemplateConnection = new SqlConnection();
            SqlDataReader myTemplateDataReader;
            SqlCommand myTemplateCommand;
            coreTemplate myTemplate;
            try
            {
                myTemplateConnection = templateDataBase.GetConnection();
                myTemplateConnection.Open();

                //setup Command
                myTemplateCommand = new SqlCommand();
                myTemplateCommand.Connection = myStudentConnection;
                myTemplateCommand.CommandText = "Select template_id, template_name, message_content, created_date, updated_date, created_by, updated_by FROM dbo.message_template";

                //exceute the command to produce a DataReader
                myTemplateDataReader = myTemplateCommand.ExecuteReader();

                while (myTemplateDataReader.Read())
                {
                    //create a new student based on the student record just read
                    //  0 is StudentID
                    //  1 is StudentName
                    //  2 is StudentMidterm
                    //  3 is StudentFinal
                    //  4 is StudentMajor
                    myTemplate = new coreTemplate();
                    myTemplate.templateID = myTemplateDataReader.GetInt32(0);
                    myTemplate.templateName = myTemplateDataReader.GetString(1);
                    myTemplate.createDate= myTemplateDataReader.GetString(2);
                    myTemplate.upDated = myTemplateDataReader.GetString(3);
                    myTemplate.createdBy = myTemplateDataReader.GetInt(4);
                    myTemplate.updatedBy = myTemplateDataReader.GetInt(4);

                    myTemplateList.Add(myStudent);
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