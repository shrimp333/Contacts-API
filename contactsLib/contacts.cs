namespace contactsLib;
public class Contact
{
    public string? contactID {get; set;}
    public string? name {get; set;}
    public string? phoneNumber {get; set;}
    public Contact(string contactID, string name, string phoneNumber)
    {
        this.name = name;
        this.contactID = name;
        this.phoneNumber = phoneNumber;
    }
}
public class Contacts {
    List<Contact> contactsList;
    public void AddContact(Contact contact) {
        contactsList.Add(contact);
        return;
    }
    public void DeleteContact(int index){
        contactsList.RemoveAt(index);
        return;
    }
    public List<string> ConvertContactListToString(List<Contact> contList){
        List<string> stringList = new List<string>();
        foreach (Contact cont in contList) {
            stringList.Add($"{cont.contactID}:{cont.name}:{cont.phoneNumber}");
        }
        return stringList;
    }
}
