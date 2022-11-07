namespace contactsLib;
public class contact
{
    string? contactID;
    string? name;
    string? phoneNumber;
    public contact(string contactID, string name, string phoneNumber)
    {
        this.name = name;
        this.contactID = name;
        this.phoneNumber = phoneNumber;
    }
}