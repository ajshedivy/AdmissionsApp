using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace AdmissionsLibrary
{
    public class Applicant
    {
        private string Name;
        public Guid ApplicantID { get; set; }
        public string College { get; set; }
        public string AreaOfStudy { get; set; }

        public Applicant(string name)
        {
            Name = name;
            ApplicantID = GenerateID();
        }

        private Guid GenerateID()
        {
            this.ApplicantID = Guid.NewGuid();
            return this.ApplicantID;
        }

        public string getName()
        {
            return this.Name;
        }
            
        public override string ToString()
        {
            Dictionary<string, string> d = new Dictionary<string, string>();
            d["Name"] = this.Name;
            d["ID"] = this.ApplicantID.ToString();
            d["Area of Study"] = this.AreaOfStudy;
            d["College"] = this.College;

            return "{" + string.Join(",", d.Select(kv => kv.Key + "=" + kv.Value).ToArray()) + "}";
        }


    }
}
