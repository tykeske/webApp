using System;

class templateData
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

/*
Author: Vince Amela
Date: 4/19/20
Class: CIS 234A
Assignment: 3
Bugs: 
      *  none at this time 
      *  
command.Parameters.Add("@templateName", SqlDbType.NVarChar, 50).Value = templateName;
                        command.Parameters.Add("@msgContent", SqlDbType.NVarChar, 1000).Value = msgContent;
                        command.Parameters.Add("@created_date", SqlDbType.SmallDateTime, 19).Value = createDate;
                        command.Parameters.Add("@updated_date", SqlDbType.SmallDateTime, 19).Value = upDated;
                        command.Parameters.Add("@created_by", SqlDbType.Int, 50).Value = createdBy;
                        command.Parameters.Add("@updated_by", SqlDbType.Int, 50).Value = updatedBy;      * 
*/
