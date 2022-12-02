using Xunit;
using System;
using contactsLib;
namespace unit_test;
public class ContactTest
{
    [Fact]
    public void TestAdd()
    {
        Contact testContact = new Contact("1234ABC", "John Smith", "04010101011");
        ContactLink link = new ContactLink();
        
    }
}