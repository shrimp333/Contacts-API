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


    // api/Contacts/4  - gets the fourth record if it exists
    [HttpGet(template:"{id}")]
    public string Get(int id)
    {
        return cs.get_record(id);
    }
}