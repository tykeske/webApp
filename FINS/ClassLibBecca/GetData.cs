using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibBecca
{
    public class GetData
    {
        private string _messageContent;
        private int _createdBy;
        private string _createdDate;
        private int _subCount;
        private int _locationID;
        private int _templateID;


        public string MessageContent
        {
            get { return _messageContent; }
            set { _messageContent = value; }
        }

        public int CreatedBy
        {
            get { return _createdBy; }
            set { _createdBy = value; }
        }

        public string CreatedDate
        {
            get { return _createdDate; }
            set { _createdDate = value; }
        }

        public int SubCount
        {
            get { return _subCount; }
            set { _subCount = value; }
        }

        public int Location
        {
            get { return _locationID; }
            set { _locationID = value; }
        }

        public int TemplateID
        {
            get { return _templateID; }
            set { _templateID = value; }
        }

    }
}
