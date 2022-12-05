namespace contactsLibDatabase;
public class Contact
{
    public string contactID {get; set;}
    public string name {get; set;}
    public string phoneNumber {get; set;}
    public Contact(string contactID, string name, string phoneNumber)
    {
        this.name = name;
        this.contactID = contactID;
        this.phoneNumber = phoneNumber;
    }
}
public class Contacts {
    List<Contact> contactsList = new List<Contact>();
    public void AddContact(Contact contact) {
        contactsList.Add(contact);
        return;
    }
    public void DeleteContact(string cid){
        int index = contactsList.FindIndex(x => x.contactID == cid);
        contactsList.RemoveAt(index);
        return;
    }
    public List<string> ConvertToString(){
        List<string> stringList = new List<string>();
        foreach (Contact cont in contactsList) {
            stringList.Add($"{cont.contactID}:{cont.name}:{cont.phoneNumber}");
        }
        return stringList;
    }

    public string Search(string cid)
    {
        int index = contactsList.FindIndex(x => x.contactID == cid);
        return $"{ConvertToString()[index]} at place {index}";
    }
}
