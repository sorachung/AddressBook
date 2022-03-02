using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts;

        public AddressBook()
        {
            Contacts = new Dictionary<string, Contact>();
        }

        public void AddContact(Contact contact)
        {
            Contacts.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email)
        {
            return Contacts[email];
        }

    }
}