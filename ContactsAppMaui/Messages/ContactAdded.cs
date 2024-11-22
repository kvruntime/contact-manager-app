using CommunityToolkit.Mvvm.Messaging.Messages;
using ContactsAppDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsAppMaui.Messages
{
    internal class ContactAdded : ValueChangedMessage<ContactEntity>
    {
        public ContactAdded(ContactEntity value) : base(value)
        {
        }
    }
}
