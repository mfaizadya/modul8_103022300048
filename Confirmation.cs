using System;
using System.Security.Cryptography.X509Certificates;

public class Confirmation
{
    public string en { get; set; }
    public string id { get; set; }

    public Confirmation(string en, string id)
    {
        this.en = en;
        this.id = id;
    }
 
}
