# Contacts-API
## Task
``` 
Q1
Use the following attributes.
Contacts:
cid    name         phone
4      Joe          0493824453
24     Sally        039834289
Create a solution and contactsLib library.
  Add the classes to the library.
Q1.1
Write a class which holds a record with a contact id (cid), name and phone number.
  (Contact.cs file)
  Q1.2
Write a class with a list to hold the contacts( Contacts.cs file)
// Contacts model. 
public class Contacts
{
    // List of contacts
    List<Contact> arr;
In the Contacts class, 
 write method or methods to add a contact to the array.
    public void add(Contact)
    {
        // TODO your code
    }
In the Contacts class, 
 write a method to delete a record with an index.
You must use the following:
    public void delete(int index)
    {
        // TODO your code
    }
In the Contacts class,
 write a method to convert the contacts to List<string>
Create a ContactsTest class.
    
Add a function to populate some date (e.g. 4 records).
 This can be used in testing.
 write a test function.
ContactsTest.cs file:
public class ContactsTest
{
     public ContactsTest() {}
    public void add_records(Contacts cs2)
    {
        // TODO
        // e.g. cs2.add("2884:fred:smith:visa293089392");
    }
    public void test01()
    {
        // TODO      
    }
Q1.4  Make a singleton to access a Contacts instance.
e.g.
Make a library code file ContactsLink.cs,
ContactsLink csl = new ContactsLink();
Contacts cs = csl.get();
Q1.5 show source control (In demonstration)
Q2
Make a console User Interface. e.g. test01 
ContactsApp2
   |
   |-------test01    - to test Contact and Contacts manually. 
Write test code to manually test the adding and deleting records.
Demonstrate these to the assessor (run the console application and discuss the results 
and code)
Q3
Console menu application
PS D:\data\prog\d1\contactsApp\demo01> dotnet run
1. Add record
2. Delete record
3. Print
4. Exit
Q4
Web api,
  Get i'th record
  Get records
  Delete i'th record
  Add record
  Test with Swagger. Your port can vary
  https://localhost:7102/swagger/index.html
Create a controller with api/Controller
As a guide, the following may be useful, but it does not
 have the singleton.
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
    [HttpGet(template:"{id})]
    public string Get(int id)
    {
       // TODO get the id record
       //   and return as a string
    }
_________________________________________________________________________________
Part 2
Part 2 uses the database.
Q5
Write a Contacts2 class with the same or similar functions
 as Contacts, but instead of the data being in `List<Contact> arr', 
 the data is accessed through the XAMP database.
 Create the database. Suggest that you populate it with
 a few records (say 4 for testing)
Q6
Write a Menu console app as Q2 but using Contacts (access data through the database)
Q7
webapi2 - web api, make another access points.
  Same as Q4, but using Contacts2 with accessing the database.
```