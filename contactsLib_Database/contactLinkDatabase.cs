namespace contactsLibDatabase;
public class ContactLink {
    static Contacts instance = new Contacts();
    public Contacts get() {
        return instance;
    }
}