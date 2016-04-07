using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CredentialManagement;

namespace remove_outlook_credentials
{
    class Program
    {
        static void Main(string[] args)
        {
            CredentialSet set = new CredentialSet();
            var creds = set.Load();
            foreach(Credential cred in creds)
            {
                Console.WriteLine(cred.Target);
                if (cred.Target.Contains("MS.Outlook"))
                {
                    cred.Delete();
                }
            }
        }
    }
}
