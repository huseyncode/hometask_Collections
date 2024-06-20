using System;
using System.Collections.Generic;

namespace PhoneBookExample
{
    class PhoneBook
    {
        public Dictionary<string, string> Contacts { get; } = new Dictionary<string, string>();

        public void AddContact(string name, string phoneNumber)
        {
            Contacts[name] = phoneNumber;
        }

        public void RemoveContact(string name)
        {
            if (Contacts.ContainsKey(name))
                Contacts.Remove(name);
        }

        public List<string> GetAllContacts()
        {
            return new List<string>(Contacts.Keys);
        }

        public string FindContactByName(string name)
        {
            if (Contacts.ContainsKey(name))
                return Contacts[name];
            else
                return "Əlaqə tapılmadı";
        }
    }
}