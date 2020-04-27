using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TemplateCreation
{ 


            public class Class1
            {    
                private string _templateID;
                private string _templateName;
                private string _createDate;
                private string _upDated;
                private string _createdBy;
                private string _updatedBy; 


                public string templateID
                {
                    get { return _templateID; }
                    set { _templateID = value; }
                }

                public string templateName
                {
                    get { return _templateName; }
                    set { _templateName = value; }
                }

                public string createDate
                {
                    get { return _createDate; }
                    set { _createDate = value; }
                }

                public string upDated
                {
                    get { return _upDated; }
                    set { _upDated = value; }
                }

                public int createdBy
                {
                    get { return _createdBy; }
                    set { _createdBy = value; }
                }

                public int updatedBy
                {
                    get { return _updatedBy; }
                    set { _updatedBy = value; }
                }

            }

}





























}









