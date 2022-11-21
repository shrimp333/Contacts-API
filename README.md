# Contacts-API
## Task
``` 
Testing and programming project for ICT
Can work in a team up to 3 people.
* only one person needs to submit, but the word document needs all the 
members to be listed with their student id's.
* demonstrations requires all participants
*
Parts 1 and 2 can be worked upon independently, but doing part 1 first
Part 1 (Q1-Q4)
Overview of solution and projects within the solution.
Your solution name and projects names can differ, but you need to explain
this in the demonstrations.
ContactsApp2
|
|------test01       - manual testing console application (print to 
screen)
|
|------contactsLib  -library of code.
|
|------menu         - console application (with Contacts class)
|
|------webapi       - web interface
|
|------unit_test    - test Contact and Contacts (do not need to test 
webapi here)
|
|------menu2        - console application (with database)
|
|------webapi2      - menu (same as webapi) but with database
Contacts:
cid    name         phone
4      Joe          0493824453
24     Sally        039834289
Q1
Create a solution and contactsLib library.
Add the classes to the library.
Q1.1
Write a class which holds a record with a contact id (cid), name and phone 
number.
Q1.2
Write a class with a list to hold the contacts.
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
Q1.4  Make a singleton to access a Contacts instance.
e.g.
In the library code file
private static pcs = new Contacts()
public Contacts getContacts()
{
return pcs;
}
Q2
Make a console User Interface. e.g. test01
ContactsApp2
|
|-------test01    - to test Contact and Contacts manually.
Write test code to manually test the adding and deleting records.
Demonstrate these to the assessor (run the console application and discuss 
the results and code)
Q3 Console menu application
PS D:\data\prog\d1\contactsApp\demo01> dotnet run
1. Add record
2. Delete record
3. Print
4. Exit
Q4 Web api,
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
Part 2
Q5
Write a Contacts2 class with the same or similar fucnctions
as Contacts, but instead of the data being in `List<Contact> arr',
the data is accessed through the XAMP database.
Q7 write a Menu consol app as Q2 but using Contacts (access data through 
the database)
Q8 webapi2 - web api, make another acccess points.
Same as Q4, but using Contacts2 with accessing the database.
```