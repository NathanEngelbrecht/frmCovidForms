using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmForm {
    class capture {
        string ID;
        string Name;
        string Surname;
        string MedicalAid;
        string RefDr;
        string BloodType;
        string Allergies;
        string HadCovid;
        string CovidVaccine;

        string HospName;
        string HospAddress;
        string HospType; // public or private
        string HospProvice; 
        #region Patient setters
        public void setID(string id) 
        {
            ID = id;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public void setSurname(string surname)
        {
            Surname = surname;
        }
        public void setMedicalAid(string medicalaid)
        {
            MedicalAid = medicalaid;
        }
        public void setRefDr(string defdr)
        {
            RefDr = defdr;
        }
        public void setBloodType(string bloodtype)
        {
            BloodType = bloodtype;
        }
        public void setAllergies(string allergies)
        {
            Allergies = allergies;
        }
        public void setHadCovid(string hadcovid)
        {
            HadCovid = hadcovid;
        }
        public void setCovidVaccine(string covidvaccine)
        {
            CovidVaccine = covidvaccine;
        }
        #endregion

        #region Patient getters
        public string getID()
        {
            return ID;
        }
        public string getName()
        {
            return Name;
        }
        public string getSurname()
        {
            return Surname;
        }
        public string getMedicalAid()
        {
            return MedicalAid;
        }
        public string getRefDr()
        {
            return RefDr;
        }
        public string getBloodType()
        {
            return BloodType;
        }
        public string getAllergies()
        {
            return Allergies;
        }
        public string getHadCovid()
        {
            return HadCovid;
        }
        public string getCovidVaccine()
        {
            return CovidVaccine;
        }
        #endregion

        #region Hospital Setters
        public void setHospName(string hospname)
        {
            HospName = hospname;
        }
        public void setHospAddress(string hospaddress)
        {
            HospAddress = hospaddress;
        }
        public void setHospType(string hosptype)
        {
            HospType = hosptype;
        }
        public void setHospProvice(string hospprovice)
        {
            HospProvice = hospprovice;
        }
        #endregion

        #region Hospital Getters
        public string getHospName()
        {
            return HospName;
        }
        public string getHospAddress()
        {
            return HospAddress;
        }
        public string getHospType()
        {
            return HospType;
        }
        public string getHospProvince()
        {
            return HospProvice;
        }
        #endregion
    }
}
