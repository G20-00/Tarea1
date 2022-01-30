using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador1
{
        public class Municipality
        {
            private string departmentCode;
            private string municipalityCode;
            private string departamentName;
            private string municipalityName;
            private string municipalityType;

            public Municipality(string departmentCode, string municipalityCode, string departamentName, string municipalityName, string municipalityType)
            {
                this.departmentCode = departmentCode;
                this.municipalityCode = municipalityCode;
                this.departamentName = departamentName;
                this.municipalityName = municipalityName;
                this.municipalityType = municipalityType;
            }

           
        public String DepartmentCode { get => departmentCode; set => departmentCode = value; }
        public String MunicipalityCode { get => municipalityCode; set => municipalityCode = value; }
        public String DepartamentName { get => departamentName; set => departamentName = value; }

 public String getDepartment()
        {
            return departamentName;
        }

        public String MunicipalityName { get => municipalityName; set => municipalityName = value; }
        public String MunicipalityType { get => municipalityType; set => municipalityType = value; }

    }
    
}