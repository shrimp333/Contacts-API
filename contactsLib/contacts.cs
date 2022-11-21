namespace contactsLib;
public class Contact
{
    string? contactID;
    string? name;
    string? phoneNumber;
    public Contact(string contactID, string name, string phoneNumber)
    {
        this.name = name;
        this.contactID = name;
        this.phoneNumber = phoneNumber;
    }
}
public class Contacts {
    List<Contact>? contactsList;
}
public class ContactLink {
    static Contacts pcs = new Contacts();
    public static Contacts getContacts() {
        return pcs;
    }
}