using System.Data.SqlClient;
namespace contactsLibDatabase;
public class Contacts
{
    public static SqlConnection conn = new SqlConnection(@"Server=db-ben.cx9d0jwmg18x.ap-northeast-1.rds.amazonaws.com;Database=contacts;User Id=admin;Password=Greats12345!!;");
    public void AddContact(string contact)
    {
        string[] arr = contact.Split(",");
        conn.Open();
        SqlCommand cmd = new("INSERT INTO CONTACTS VALUES (@cid, @fname, @pnum)", conn);
        cmd.Parameters.AddWithValue("@cid", arr[0]);
        cmd.Parameters.AddWithValue("@fname", arr[1]);
        cmd.Parameters.AddWithValue("@pnum", arr[2]);
        cmd.ExecuteNonQuery();
        conn.Close();
        return;
    }
    public void DeleteContact(string cid)
    {
        conn.Open();
        SqlCommand cmd = new("DELETE FROM CONTACTS WHERE CUSTOMERID=@cid;", conn);
        cmd.Parameters.AddWithValue("@cid", cid);
        cmd.ExecuteNonQuery();
        conn.Close();
        return;
    }
    // public List<string> ConvertToString()
    // {
    //     List<string> stringList = new List<string>();
    //     foreach (Contact cont in contactsList)
    //     {
    //         stringList.Add($"{cont.contactID}:{cont.name}:{cont.phoneNumber}");
    //     }
    //     return stringList;
    // }

    // public string Search(string cid)
    // {
    //     int index = contactsList.FindIndex(x => x.contactID == cid);
    //     return $"{ConvertToString()[index]} at place {index}";
    // }
}
