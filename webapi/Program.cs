using contactslib;

namespace webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactsController : ControllerBase
{
    Contacts cs = new Contacts();

    // api/Contacts
    [HttpGet]
    public IEnumerable<string> Get()
    {
        ContactsTest cst = new ContactsTest();
        cst.add_records(cs);

        List<string> en =  cs.get_list_str();
        IEnumerable<string> en2 = en as IEnumerable<string>;

        return en;
    }
    //get i'th record
    // api/Contacts/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return cs.get_record(id);
    }

    //get records
    // api/Contacts/1
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return cs.get_record(id);
    }

    
    //delete i'th record
    // api/Contacts/1
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        cs.delete_record(id);
    }
    
    //add record
    // api/Contacts/1
    [HttpPost("{id}")]
    public void Post(int id, [FromBody] string value)
    {
        cs.add_record(id, value);
    }

    [HttpGet(template:"{id}")]
    public string Get(int id)
    {
        return cs.get_record(id);
    }
}