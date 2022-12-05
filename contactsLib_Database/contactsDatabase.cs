using System.Data.SqlClient;
using System.Data;
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

    public string Search(string cid)
    {
        List<string> result = new();
        DataTable dtResult = new DataTable();
        conn.Open();
        Console.WriteLine("open");
        SqlDataAdapter cmd = new($"SELECT * FROM CONTACTS WHERE CUSTOMERID='{cid}';", conn);
        Console.WriteLine($"SELECT * FROM CONTACTS WHERE CUSTOMERID={cid};");
        DataTable table = new();
        cmd.Fill(table);
        DataRow dr = table.Rows[0];
        foreach (DataColumn dc in table.Columns)
        {
            result.Add(dr[dc.ColumnName].ToString());
            Console.WriteLine(dr[dc.ColumnName].ToString());
        }
        conn.Close();
        return $"{result[0]}:{result[1]}:{result[2]}";
    }
}
