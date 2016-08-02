using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWcfService {
    [DataContract]
    public class Employee {
        [DataMember(Order =1, Name = "ID")]
        public int Id { get; set; }
        [DataMember(Order = 2)]
        public string Name { get; set; }
        [DataMember(Order = 3)]
        public string Gender { get; set; }
        [DataMember(Order = 4)]
        public DateTime DateOfBirth { get; set; }
    }
}
