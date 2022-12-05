using Microsoft.AspNetCore.Mvc;
using contactsLibDatabase;
using System.Data.SqlClient;
namespace webapi.Controllers;
[ApiController]
[Route("[controller]")]
public class ApiController : ControllerBase
{
    public static SqlConnection conn = new SqlConnection(@"Server=db-ben.cx9d0jwmg18x.ap-northeast-1.rds.amazonaws.com;Database=contacts;User Id=admin;Password=Greats12345!!;");
    public static ContactLink link = new ContactLink();

    private readonly ILogger<ApiController> _logger;
    public ApiController(ILogger<ApiController> logger)
    {
        _logger = logger;
    }

    [HttpGet("get")]
    public string Get()
    {
        Connect();
        return "The contacts api";
    }
    [HttpGet("add")]
    public string Add(string contactConstructor)
    {
        //contructor is cid,name,phoneN
        try
        {
            string[] arr = contactConstructor.Split(",");
            conn.Open();
            SqlCommand cmd = new("INSERT INTO CONTACTS VALUES (@cid, @fname, @pnum)", conn);
            cmd.Parameters.AddWithValue("@cid", arr[0]);
            cmd.Parameters.AddWithValue("@fname", arr[1]);
            cmd.Parameters.AddWithValue("@pnum", arr[2]);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        catch (System.Exception)
        {
            return "Something went wrong";
        }
        return "Success";
    }

    [HttpGet("delete")]
    public string Delete(string cid)
    {
        try
        {
            link.get().DeleteContact(cid);
        }
        catch (System.Exception)
        {
            return "Something went wrong";
        }
        return "Success";
    }
    [HttpGet("search")]
    public string Search(string cid)
    {
        string result = "empty";
        try
        {
            result = link.get().Search(cid);
        }
        catch (System.Exception)
        {
            return "Something went wrong";
        }
        return $"Success\n{result}";
    }

    static void Connect()
    {
        using (SqlConnection conn = new SqlConnection(@"Server=db-ben.cx9d0jwmg18x.ap-northeast-1.rds.amazonaws.com;Database=master;User Id=admin;Password=Greats12345!!;"))
        {
            conn.Open();
            Console.WriteLine("Connection is just opened");
            System.Threading.Thread.Sleep(10000);
            conn.Close();
        }
    }
}
