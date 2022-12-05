using Microsoft.AspNetCore.Mvc;
using contactsLib;
namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class ApiController : ControllerBase
{
    public static ContactLink link = new ContactLink();

    private readonly ILogger<ApiController> _logger;
    public ApiController(ILogger<ApiController> logger)
    {
        _logger = logger;
    }

    [HttpGet("get")]
    public string Get()
    {
        return "The contacts api";
    }
    [HttpGet("add")]
    public string Add(string contactConstructor)
    {
        //contructor is cid,name,phoneN
        try
        {
            string[] split = contactConstructor.Split(",");
            Contact contact = new(split[0], split[1], split[2]);
            link.get().AddContact(contact);
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
    [HttpGet("test")]
    public int test(int i, int j)
    {
        return i + j;
    }
}
