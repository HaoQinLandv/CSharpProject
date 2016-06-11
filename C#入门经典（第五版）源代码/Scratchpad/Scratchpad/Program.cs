﻿using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using Microsoft.Office.Interop.Outlook;

namespace Scratchpad
{

    class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            var mapi = app.GetNamespace("MAPI");
            mapi.Logon(ShowDialog: false, NewSession: false);
            var outbox = mapi.GetDefaultFolder(OlDefaultFolders.olFolderOutbox);

            MailItem email = app.CreateItem(OlItemType.olMailItem);
            email.To = "morgan@morganskinner.com";
            email.Subject = "Autogenerated email";
            email.Body = "This is a test";
            email.Send();
//            WorkflowInvoker.Invoke(new Workflow1());
        }
    }
}
