using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cassandra;
using Covid19.QueryEntities;

namespace Covid19
{
   public  class DataProvider
    {
        #region Admin
        public static Admin Login(string email,string psw)
        {
            Admin admin = new Admin();
            ISession session = SessionManager.GetSession();


            Row data = session.Execute("select * from Admin where email='" + email + "' and password='" + psw + "'").FirstOrDefault();
            admin.email = data["email"] != null ? data["email"].ToString() : string.Empty;
            admin.password = data["password"] != null ? data["password"].ToString() : string.Empty;
            admin.country = data["country"] != null ? data["country"].ToString() : string.Empty;
            return admin;

        }
      
        #endregion

        #region CountryInfo
        public static List<CountryInfo> AllCountry()
        {
            ISession session = SessionManager.GetSession();
            List<CountryInfo> countries = new List<CountryInfo>();

            if (session == null)
                return null;

            var data = session.Execute("select * from CountryInfo ");
            foreach (var p in data)
            {
                CountryInfo z = new CountryInfo();
                z.Country = p["country"].ToString();
                z.Confirmed = p["confirmed"].ToString();
                z.Deaths = p["deaths"].ToString();
                z.Recovered = p["recovered"].ToString();
                z.Active = p["active"].ToString();

                countries.Add(z);
            }

            return countries;
        }

        public static CountryInfo getCountryInfo(String country)
        {
            ISession session = SessionManager.GetSession();
            Row countryData = session.Execute("select * from CountryInfo where \"country\"='" + country + "'").FirstOrDefault();
            CountryInfo ci = new CountryInfo();

            if (countryData != null)
            {
                ci.Country = countryData["country"] != null ? countryData["country"].ToString() : string.Empty;
                ci.Active = countryData["active"] != null ? countryData["active"].ToString() : string.Empty;
                ci.Deaths = countryData["deaths"] != null ? countryData["deaths"].ToString() : string.Empty;
                ci.Recovered = countryData["recovered"] != null ? countryData["recovered"].ToString() : string.Empty;
                ci.Confirmed = countryData["confirmed"] != null ? countryData["confirmed"].ToString() : string.Empty;
            }
            
            return ci;
        }
        #endregion

        #region DateInfo
        public static List<DateInfo> DataInfoForAdmin(string country)
        {
            ISession session = SessionManager.GetSession();

            List<DateInfo> list = new List<DateInfo>();
            var data = session.Execute("select * from DateInfo where \"country\"='" + country + "'");
            foreach (var d in data)
            {
                DateInfo di = new DateInfo();
                di.Country = d["country"] != null ? d["country"].ToString() : string.Empty;
                di.Date = d["date"] != null ? d["date"].ToString() : string.Empty;
                di.NewCases = d["newcases"] != null ? d["newcases"].ToString() : string.Empty;
                di.NewDeaths = d["newdeaths"] != null ? d["newdeaths"].ToString() : string.Empty;
                di.NewRecovered = d["newrecovered"] != null ? d["newrecovered"].ToString() : string.Empty;
                list.Add(di);
            }
            return list;
        }
        public static void AddData(string c, string date, string cases, string deaths, string recovered)
        {
            ISession session = SessionManager.GetSession();


            RowSet data = session.Execute("INSERT INTO  DateInfo(country,date,newcases, newdeaths, newrecovered) VALUES('"+c+"', '"+date+"', '"+cases+"', '"+deaths+"', '"+recovered+"')");

            CountryInfo dataForCountry = DataProvider.getCountryInfo(c);
          int confirmed=Convert.ToInt32(  dataForCountry.Confirmed) + Convert.ToInt32( cases);
           int active= Convert.ToInt32(dataForCountry.Active) + Convert.ToInt32(cases);
           int death= Convert.ToInt32(dataForCountry.Deaths) + Convert.ToInt32(deaths);
         int rec= Convert.ToInt32(dataForCountry.Recovered)+ Convert.ToInt32(recovered);

            RowSet dataUpdate = session.Execute("UPDATE CountryInfo SET Confirmed='" + confirmed + "', Deaths='" + death + "', Recovered='" + rec + "',Active='"+ active + "' WHERE country='" + c + "'");
           
            if (data != null && dataUpdate!=null)
                MessageBox.Show("Data was added.");


        }
        public static void DeleteData(string c, string date)
        {

            ISession session = SessionManager.GetSession();
           //  RowSet data = session.Execute("DELETE  FROM  DateInfo WHERE country='"+c+"' and date='"+date+"'");
            DateInfo di = DataProvider.DateForOneDay(c, date);
            CountryInfo dataForCountry = DataProvider.getCountryInfo(c);
            int confirmed = Convert.ToInt32(dataForCountry.Confirmed) - Convert.ToInt32(di.NewCases);
            int active = Convert.ToInt32(dataForCountry.Active) - Convert.ToInt32(di.NewCases);
            int death = Convert.ToInt32(dataForCountry.Deaths)-Convert.ToInt32(di.NewDeaths);
            int rec = Convert.ToInt32(dataForCountry.Recovered) - Convert.ToInt32(di.NewRecovered);

            RowSet data = session.Execute("DELETE  FROM  DateInfo WHERE country='" + c + "' and date='" + date + "'");

            RowSet dataUpdate = session.Execute("UPDATE CountryInfo SET Confirmed='" + confirmed + "', Deaths='" + death + "', Recovered='" + rec + "',Active='" + active + "' WHERE country='" + c + "'");

            if (data != null && dataUpdate!=null)
                MessageBox.Show("Successfully");


        }
        public static DateInfo DateForOneDay(string country, string date)
        {
            ISession session = SessionManager.GetSession();


            DateInfo di = new DateInfo();
            var d = session.Execute("select * from DateInfo where \"country\"='" + country + "' and \"date\"='"+date+"'").FirstOrDefault();
            if (d != null)
            {

                di.Country = d["country"] != null ? d["country"].ToString() : string.Empty;
                di.Date = d["date"] != null ? d["date"].ToString() : string.Empty;
                di.NewCases = d["newcases"] != null ? d["newcases"].ToString() : "0";
                di.NewDeaths = d["newdeaths"] != null ? d["newdeaths"].ToString() : "0";
                di.NewRecovered = d["newrecovered"] != null ? d["newrecovered"].ToString() : "0";
            }
            else di = null;
            return di;
            
        }
        public static void UpdateData(string country, string date,string newc,string newd,string newr)
        {
            //          UPDATE covid.DateInfo
            //  SET newcases = '1',
            //newdeaths = '1',newrecovered = ''
            //WHERE country = '' and date = '';
            ISession session = SessionManager.GetSession();


            RowSet data = session.Execute("UPDATE DateInfo SET newcases='"+newc+"', newdeaths='"+newd+"', newrecovered='"+newr+"' WHERE country='" + country + "'and date= '" + date + "'");
            CountryInfo dataForCountry = DataProvider.getCountryInfo(country);
            int confirmed = Convert.ToInt32(dataForCountry.Confirmed) + Convert.ToInt32(newc);
            int active = Convert.ToInt32(dataForCountry.Active) + Convert.ToInt32(newc);
            int death = Convert.ToInt32(dataForCountry.Deaths) + Convert.ToInt32(newd);
            int rec = Convert.ToInt32(dataForCountry.Recovered) + Convert.ToInt32(newr);

            RowSet dataUpdate = session.Execute("UPDATE CountryInfo SET Confirmed='" + confirmed + "', Deaths='" + death + "', Recovered='" + rec + "',Active='" + active + "' WHERE country='" + country + "'");

            if (data != null && dataUpdate!=null)
                MessageBox.Show("Successfully");

        }

        #endregion

        #region Patients
        public static List<Patient> AllPatients()
        {
            ISession session = SessionManager.GetSession();
            List<Patient> patients = new List<Patient>();
            var data = session.Execute("select * from Patient");
            foreach (var d in data)
            {
             Patient p = new Patient();
            p.patient_id = d["patient_id"].ToString();
            p.age = d["age"] != null ? d["age"].ToString():string.Empty;
            p.confirmed_date = d["confirmed_date"] != null ? d["confirmed_date"].ToString():string.Empty;
            p.contact_number = d["contact_number"] != null ? d["contact_number"].ToString():string.Empty;
            p.infection_case = d["infection_case"] != null ? d["infection_case"].ToString():string.Empty;
            p.released_date = d["released_date"] != null ? d["released_date"].ToString():string.Empty;
            p.sex = d["sex"] != null ? d["sex"].ToString():string.Empty;
            p.state = d["state"] != null ? d["state"].ToString():string.Empty;
            p.symptom_onset_date = d["symptom_onset_date"] != null ? d["symptom_onset_date"].ToString():string.Empty;

       
                patients.Add(p);
            }

            return patients;

        }
        public static int InfectedFemaleMale()
        {
            List<Patient> patients = AllPatients();
            int countPatients = patients.Count();
            int female = 0, male = 0;
            foreach (Patient p in patients)
            {
                if (p.sex == "female")
                    female++;
                else if (p.sex == "male")
                    male++;
             
            }
          //  int count = female * 100 / countPatients;
           // MessageBox.Show("Ukupan broj pacijenata: " + countPatients + ", ukupno zena:" + female);
            return female;
        }
        public static int[] InfectedAge()
        {
            List<Patient> patients = AllPatients();
            int countPatients = patients.Count();
            List<int> poGodinama = new List<int>();
            int[] niz = { 0, 0, 0, 0, 0, 0, 0, 0, 0,0 };
            int c0 = 0, c10 = 0, c20 = 0, c30 = 0, c40 = 0, c50=0, c60=0, c70=0, c80=0, c90 = 0;
            int num = 0;
            foreach (Patient p in patients)
            {
                if (p.age == "0s")
                {
                    c0++;
                    num++;
                }
                else if (p.age == "10s")
                {    c10++; 
                    num++;
                }
                else if (p.age == "20s")
                { c20++;
                    num++;
                }
                else if (p.age == "30s")
                { c30++;
                    num++;
                }
                else if (p.age == "40s")
                { c40++;
                    num++;
                }
                else if (p.age == "50s")
                { c50++;
                    num++;
                }
                else if (p.age == "60s")
                { c60++;
                    num++;
                }
                else if (p.age == "70s")
                { c70++;
                    num++;
                }
                else if (p.age == "80s")
                { c80++;
                    num++;
                }
                else if (p.age == "90s")
                { c90++;
                    num++;
                }



            }
            niz[0]=  c0*100/num;
            niz[1] = c10 * 100 / num;
            niz[2] = c20 * 100 / num;
            niz[3] = c30 * 100 / num;
            niz[4] = c40 * 100 / num;
            niz[5] = c50 * 100 / num;
            niz[6] = c60 * 100 / num;
            niz[7] = c70 * 100 / num;
            niz[8] = c80 * 100 / num;
            niz[9] = c90 * 100 / num;
            return niz;
        }

        public static int ContactNumber()
        {
            List<Patient> patients = AllPatients();
            int countPatients = patients.Count();
            int contact = 0;
            int number = 0;
            int pom = 0;
          
            foreach (Patient p in patients)
            {
                try
                {  string pom1;
                    if (p.contact_number != string.Empty )
                        number++;
                  
                    pom1 = p.contact_number != string.Empty ? p.contact_number : "0";
                    pom = Convert.ToInt32(pom1.Trim());
                    contact += pom;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Exception caught.", ex);
                }
                

            }
           // MessageBox.Show(number.ToString());
            return contact/number;

        }
        public static int[] DeceasedMaleFemale()
        {
            List<Patient> patients = AllPatients();
            int countPatients = patients.Count();
            int female = 0, num = 0,  male = 0;
            foreach (Patient p in patients)
            {
                try
                {
                   
                    if (p.state.Equals("deceased") && p.sex.Equals("female"))
                    {
                        num++;
                        female++;
                    }
                    else if(p.state.Equals("deceased") && p.sex.Equals("male"))
                    { num++;
                        male++;
                    }
                       
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Exception caught.", ex);
                }

            }
            int[] list = {  0, 0 };
          
            list[0]=female*100/num;
            list[1]=100-list[0];
            return list;
        }
        public static int Isolated()
        {
            List<Patient> patients = AllPatients();
            int countPatients = patients.Count();
            int isolated = 0;
            foreach (Patient p in patients)
            {
                if (p.state == "isolated")
                    isolated++;
               

            }

            return isolated * 100 / countPatients;
        }
        public static int Released()
        {
            List<Patient> patients = AllPatients();
            int countPatients = patients.Count();
            int released = 0;
            foreach (Patient p in patients)
            {
                if (p.state == "released")
                    released++;


            }

            return released * 100 / countPatients;
        }
        public static int Deceased()
        {
            List<Patient> patients = AllPatients();
            int countPatients = patients.Count();
            int deceased = 0;
            foreach (Patient p in patients)
            {
                if (p.state == "deceased")
                    deceased++;


            }

            return deceased*100/countPatients;
        }
       
        #endregion

        #region Symptoms
        public static void AddSymptom(string email, string kasalj, string ot_disanje, string umor, string temp, string bol, string dah, string rez)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet symptomData = session.Execute("insert into Symptoms (email, cough, dyspnea, fatigue, fever, myalgia, shortness_of_breath, test_result)" +
                "  values ('" + email + "', '" + kasalj + "', '" + ot_disanje + "', '" + umor + "', '" + temp + "', '" + bol + "', '" + dah + "',  '" + rez + "')");

        }
        #endregion
    }
}
