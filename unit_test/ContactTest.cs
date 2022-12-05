using Xunit;
using System;
using contactsLib;
namespace unit_test;
public class ContactTest
{

    public static ContactLink test = new ContactLink();
    [Fact]
    public void testAdd()
    {
        string johnString = "1:John:0459";
        string janeString = "2:jane:0460";
        string billString = "3:bill:0461";
        string bobString = "4:bob:0462";
        Contact john = new Contact("1", "John", "0459");
        test.get().AddContact(john);
        Contact jane = new Contact("2", "jane", "0460");
        test.get().AddContact(jane);
        Contact bill = new Contact("3", "bill", "0461");
        test.get().AddContact(bill);
        Contact bob = new Contact("4", "bob", "0462");
        test.get().AddContact(bob);
        Assert.Equal(johnString, test.get().ConvertToString()[0]);
        Assert.Equal(janeString, test.get().ConvertToString()[1]);
        Assert.Equal(billString, test.get().ConvertToString()[2]);
        Assert.Equal(bobString, test.get().ConvertToString()[3]);
        return;
    }

    [Fact]
    public void testRemove()
    {
        string johnString = "abc123:John:0459";
        Contact john = new Contact("abc123", "John", "0459");
        test.get().AddContact(john);
        Assert.Equal(johnString, test.get().ConvertToString()[0]);
        //test to see if john got added
        test.get().DeleteContact("abc123");
        Assert.Equal(0, test.get().ConvertToString().Count);
        //test to see if the list is now empty
    }
}