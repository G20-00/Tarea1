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

            public string getDepartamentCode()
            {
                return departmentCode;
            }

            public string getMunicipalityCode()
            {
                return municipalityCode;
            }

            public string getDepartamentName()
            {
                return departamentName;
            }

            public string getMunicipalityName()
            {
                return municipalityName;
            }

            public string getMunicipalityType()
            {
                return municipalityType;
            }

        }
    }