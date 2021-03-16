using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DemoWebService.Models
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "idStudent")]
        public String idStudent { get; set; }

        [DataMember(Name ="nameStudent")]
        public string nameStudent { get; set; }

        [DataMember(Name ="Age")]
        public int age { get; set; }




    }
}