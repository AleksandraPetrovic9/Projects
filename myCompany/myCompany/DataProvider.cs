using Cassandra;
using myCompany.QueryEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace myCompany
{
    public class DataProvider
    {
        #region  Sef
        public static List<Sef> vratiSveSefove()
        {
            ISession session = SessionManager.GetSession();
            List<Sef> sefovi = new List<Sef>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Sef\" ");

            foreach (var p in podaci)
            {
                Sef z = new Sef();
                z.idSefa = p["idSefa"].ToString();
                z.ime = p["ime"].ToString();
                z.prezime = p["prezime"].ToString();
                z.racun = p["racun"].ToString();
                z.telefon = p["telefon"].ToString();
                z.jmbg = p["jmbg"].ToString();
                z.email = p["email"].ToString();
                sefovi.Add(z);
            }

            return sefovi;
        }
        public static Sef vratiSefa(string idSefa)
        {
            ISession session = SessionManager.GetSession();
            Sef sef = new Sef();

            if (session == null)
                return null;

            Row podaci = session.Execute("select * from \"Sef\" where \"idSefa\"='" + idSefa + "'").FirstOrDefault();

            if (sef != null)
            {
                sef.idSefa = podaci["idSefa"] != null ? podaci["idSefa"].ToString() : string.Empty;
                sef.email = podaci["email"] != null ? podaci["email"].ToString() : string.Empty;
                sef.ime = podaci["ime"] != null ? podaci["ime"].ToString() : string.Empty;
                sef.jmbg = podaci["jmbg"] != null ? podaci["jmbg"].ToString() : string.Empty;
                sef.prezime = podaci["prezime"] != null ? podaci["prezime"].ToString() : string.Empty;
                sef.racun = podaci["racun"] != null ? podaci["racun"].ToString() : string.Empty;
                sef.telefon = podaci["telefon"] != null ? podaci["telefon"].ToString() : string.Empty;
            }

            return sef;
        }


        public static Sef vratiSefaPoEmailu(string email)
        {
            ISession session = SessionManager.GetSession();
            Sef sef = new Sef();

            if (session == null)
                return null;

            Row podaci = session.Execute("select * from \"Sef\" where email='" + email + "'ALLOW FILTERING").FirstOrDefault();

            if (sef != null)
            {
                sef.idSefa = podaci["idSefa"] != null ? podaci["idSefa"].ToString() : string.Empty;
                sef.email = podaci["email"] != null ? podaci["email"].ToString() : string.Empty;
                sef.ime = podaci["ime"] != null ? podaci["ime"].ToString() : string.Empty;
                sef.jmbg = podaci["jmbg"] != null ? podaci["jmbg"].ToString() : string.Empty;
                sef.prezime = podaci["prezime"] != null ? podaci["prezime"].ToString() : string.Empty;
                sef.racun = podaci["racun"] != null ? podaci["racun"].ToString() : string.Empty;
                sef.telefon = podaci["telefon"] != null ? podaci["telefon"].ToString() : string.Empty;
            }

            return sef;


        }
        public static List<Projekat> vratiProjekteZaSefa(string id)
        {
            ISession session = SessionManager.GetSession();
            List<Projekat> projekti = new List<Projekat>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Projekat\" where \"idSefa\" =  '" + id + "'ALLOW FILTERING ");

            foreach (var p in podaci)
            {
                Projekat z = new Projekat();
                z.idVodje = p["idVodje"].ToString();
                z.idSefa = p["idSefa"].ToString();
                z.datumKraja = Convert.ToDateTime(p["datumkraja"].ToString());
                z.datumPocetka = Convert.ToDateTime(p["datumpocetka"].ToString());
                z.idProjekta = p["idProjekta"].ToString();
                z.naziv = p["naziv"].ToString();
                z.prioritet = p["prioritet"].ToString();
                z.rok = Convert.ToDateTime(p["rok"].ToString());
                projekti.Add(z);
            }

            return projekti;
        }
        public static List<Projekat> vratiProjekteZaSefaPoNazivu(string id, string naziv)
        {
            ISession session = SessionManager.GetSession();
            List<Projekat> projekti = new List<Projekat>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Projekat\" where \"idSefa\" =  '" + id + "' and naziv='" + naziv + "'  ALLOW FILTERING");

            foreach (var p in podaci)
            {
                Projekat z = new Projekat();
                z.idVodje = p["idVodje"].ToString();
                z.idSefa = p["idSefa"].ToString();
                z.datumKraja = Convert.ToDateTime(p["datumkraja"].ToString());
                z.datumPocetka = Convert.ToDateTime(p["datumpocetka"].ToString());
                z.idProjekta = p["idProjekta"].ToString();
                z.naziv = p["naziv"].ToString();
                z.prioritet = p["prioritet"].ToString();
                z.rok = Convert.ToDateTime(p["rok"].ToString());
                projekti.Add(z);
            }

            return projekti;
        }
        public static List<Projekat> vratiProjekteZaSefaPoPrioritetu(string id, string prioritet)
        {
            ISession session = SessionManager.GetSession();
            List<Projekat> projekti = new List<Projekat>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Projekat\" where \"idSefa\" =  '" + id + "' and prioritet='" + prioritet + "'  ALLOW FILTERING");

            foreach (var p in podaci)
            {
                Projekat z = new Projekat();
                z.idVodje = p["idVodje"].ToString();
                z.idSefa = p["idSefa"].ToString();
                z.datumKraja = Convert.ToDateTime(p["datumkraja"].ToString());
                z.datumPocetka = Convert.ToDateTime(p["datumpocetka"].ToString());
                z.idProjekta = p["idProjekta"].ToString();
                z.naziv = p["naziv"].ToString();
                z.prioritet = p["prioritet"].ToString();
                z.rok = Convert.ToDateTime(p["rok"].ToString());
                projekti.Add(z);
            }

            return projekti;
        }
        public static List<Projekat> vratiProjekteZaSefaNezavrsene(string id)
        {
            ISession session = SessionManager.GetSession();
            List<Projekat> projekti = new List<Projekat>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Projekat\" where \"idSefa\" =  '" + id + "' and datumkraja='0001-01-01'  ALLOW FILTERING");

            foreach (var p in podaci)
            {
                Projekat z = new Projekat();
                z.idVodje = p["idVodje"].ToString();
                z.idSefa = p["idSefa"].ToString();
                z.datumKraja = Convert.ToDateTime(p["datumkraja"].ToString());
                z.datumPocetka = Convert.ToDateTime(p["datumpocetka"].ToString());
                z.idProjekta = p["idProjekta"].ToString();
                z.naziv = p["naziv"].ToString();
                z.prioritet = p["prioritet"].ToString();
                z.rok = Convert.ToDateTime(p["rok"].ToString());
                projekti.Add(z);
            }

            return projekti;
        }
        public static List<Projekat> vratiProjekteZaSefaPoRoku(string id, string datum)
        {
            ISession session = SessionManager.GetSession();
            List<Projekat> projekti = new List<Projekat>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Projekat\" where \"idSefa\" =  '" + id + "' and rok='" + datum + "'  ALLOW FILTERING");

            foreach (var p in podaci)
            {
                Projekat z = new Projekat();
                z.idVodje = p["idVodje"].ToString();
                z.idSefa = p["idSefa"].ToString();
                z.datumKraja = Convert.ToDateTime(p["datumkraja"].ToString());
                z.datumPocetka = Convert.ToDateTime(p["datumpocetka"].ToString());
                z.idProjekta = p["idProjekta"].ToString();
                z.naziv = p["naziv"].ToString();
                z.prioritet = p["prioritet"].ToString();
                z.rok = Convert.ToDateTime(p["rok"].ToString());
                projekti.Add(z);
            }

            return projekti;
        }


        #endregion
        #region Radnik
        public static Radnik vratiRadnikaPoIdu(string idRadnika)
        {
            ISession session = SessionManager.GetSession();
            Radnik radnik = new Radnik();

            if (session == null)
                return null;

            Row podaci = session.Execute("select * from \"Radnik\" where \"idRadnika\" = '" + idRadnika + "' ").FirstOrDefault();

            if (radnik != null)
            {
                radnik.idRadnika = podaci["idRadnika"] != null ? podaci["idRadnika"].ToString() : string.Empty;
                radnik.email = podaci["email"] != null ? podaci["email"].ToString() : string.Empty;
                radnik.ime = podaci["ime"] != null ? podaci["ime"].ToString() : string.Empty;
                radnik.jmbg = podaci["jmbg"] != null ? podaci["jmbg"].ToString() : string.Empty;
                radnik.prezime = podaci["prezime"] != null ? podaci["prezime"].ToString() : string.Empty;
                radnik.racun = podaci["racun"] != null ? podaci["racun"].ToString() : string.Empty;
                radnik.telefon = podaci["telefon"] != null ? podaci["telefon"].ToString() : string.Empty;
                radnik.slobodan = podaci["slobodan"] != null ? podaci["slobodan"].ToString() : string.Empty;
                radnik.odmor = podaci["odmor"] != null ? Int32.Parse(podaci["odmor"].ToString()) : 0;
                radnik.zanimanje = podaci["zanimanje"] != null ? podaci["zanimanje"].ToString() : string.Empty;
                radnik.plata = podaci["plata"] != null ? podaci["plata"].ToString() : string.Empty;
            }

            return radnik;
        }

        public static List<String> vratiIplatu(String id)
        {
            ISession session = SessionManager.GetSession();
            Radnik radnik = new Radnik();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Placanje\" where \"idRadnika\" =  '" + id + "' ALLOW FILTERING");
          
            List<String> listaUplata = new List<string>();
           // listaUplata = null;
            // MessageBox.Show(podaci.First().ToString());
            if (podaci != null)
            {
                foreach (var p in podaci)
                {
                  
                    listaUplata.Add(p["datumIsplate"].ToString());
                    listaUplata.Add(p["iznos"].ToString());
                }
            }


            return listaUplata;
        }

        public static String vratiMaxId()
        {


            ISession session = SessionManager.GetSession();

            if (session == null)
                return null;

            var maxRow = session.Execute("select MAX(\"idDana\") from \"SlobodniDani\" ").FirstOrDefault();

            //String maxId = (Int32.Parse(maxRow["system.max(idDana)"].ToString()) + 1).ToString();
            //Ovo sam promenila jer je pucalo tu
            String maxId = maxRow["system.max(idDana)"] != null ? maxRow["system.max(idDana)"].ToString() : 0.ToString();

            int idr = Int32.Parse(maxId);

            idr++;
            return idr.ToString();

        }

        public static void posaljiZahtevZaSlobodneDane(string id, string idSefa, DateTime d1, DateTime d2, String tipRadnika)
        {

            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            String idDana = vratiMaxId();
            SlobodniDani sl = new SlobodniDani();
            sl.idSefa = idSefa;
            sl.odobreno = "ne";
            sl.pregledano = "ne";
            sl.idDana = idDana;
            sl.datumDo = d1;
            sl.datumOd = d2;
            String datumOd = sl.datumOd.Year.ToString() + "-" + sl.datumOd.Month.ToString() + "-" + sl.datumOd.Day.ToString();
            String datumDo = sl.datumDo.Year.ToString() + "-" + sl.datumDo.Month.ToString() + "-" + sl.datumDo.Day.ToString();

            if (tipRadnika.Equals("radnik"))
            {
                sl.idRadnika = id;
                //RowSet zahtevData = session.Execute("insert into \"SlobodniDani\" (\"idDana\", \"idRadnika\", \"idSefa\", odobreno,  pregledano, \"datumOd\", \"datumDo\")  values ('" + sl.idDana + "', '" + sl.idRadnika + "', '" + sl.odobreno + "', '" + sl.pregledano + "', '" + datumOd + "', '" + datumDo + "')");
                RowSet zahtevData = session.Execute("insert into \"SlobodniDani\" (\"idDana\", \"idRadnika\", \"idSefa\", odobreno,  pregledano, \"datumOd\", \"datumDo\")  values ('" + sl.idDana + "', '" + sl.idRadnika + "', '" + sl.idSefa + "', '" + sl.odobreno + "', '" + sl.pregledano + "', '" + datumOd + "', '" + datumDo + "')");
            }
            else
            {
                sl.idVodje = id;
                //RowSet zahtevData = session.Execute("insert into \"SlobodniDani\" (\"idDana\", \"idVodje\", \"idSefa\", odobreno,  pregledano, \"datumOd\", \"datumDo\")  values ('" + sl.idDana + "', '" + sl.idVodje + "', '" + sl.odobreno + "', '" + sl.pregledano + "', '" + datumOd + "', '" + datumDo + "')");
                RowSet zahtevData = session.Execute("insert into \"SlobodniDani\" (\"idDana\", \"idVodje\", \"idSefa\", odobreno,  pregledano, \"datumOd\", \"datumDo\")  values ('" + sl.idDana + "', '" + sl.idVodje + "', '" + sl.idSefa + "', '" + sl.odobreno + "', '" + sl.pregledano + "', '" + datumOd + "', '" + datumDo + "')");
            }





            //insert into "SlobodniDani" ("idDana","idRadnika", "idVodje", odobreno, pregledano, "datumOd", "datumDo")  
            // values('1', '1', '1', 'ne', 'ne', '2020-01-10', '2020-01-15')

        }
        public static Radnik vratiRadnikaPoEmailu(string email)
        {
            ISession session = SessionManager.GetSession();
            Radnik radnik = new Radnik();

            if (session == null)
                return null;

            Row podaci = session.Execute("select * from \"Radnik\" where email='" + email + "'ALLOW FILTERING").FirstOrDefault();

            if (radnik != null)
            {
                radnik.idRadnika = podaci["idRadnika"] != null ? podaci["idRadnika"].ToString() : string.Empty;
                radnik.email = podaci["email"] != null ? podaci["email"].ToString() : string.Empty;
                radnik.ime = podaci["ime"] != null ? podaci["ime"].ToString() : string.Empty;
                radnik.jmbg = podaci["jmbg"] != null ? podaci["jmbg"].ToString() : string.Empty;
                radnik.prezime = podaci["prezime"] != null ? podaci["prezime"].ToString() : string.Empty;
                radnik.racun = podaci["racun"] != null ? podaci["racun"].ToString() : string.Empty;
                radnik.telefon = podaci["telefon"] != null ? podaci["telefon"].ToString() : string.Empty;
                //   radnik.odmor = Int32.Parse(podaci["odmor"] != null ? podaci["odmor"].ToString() : string.Empty);
            }

            return radnik;
        }
        public static Radnik vratiRadnikaPoJmbgu(string jmbg)
        {
            ISession session = SessionManager.GetSession();
            Radnik radnik = new Radnik();

            if (session == null)
                return null;

            Row podaci = session.Execute("select * from \"Radnik\" where jmbg='" + jmbg + "'ALLOW FILTERING").FirstOrDefault();

            if (podaci != null)//radnik
            {
                radnik.idRadnika = podaci["idRadnika"] != null ? podaci["idRadnika"].ToString() : string.Empty;
                radnik.email = podaci["email"] != null ? podaci["email"].ToString() : string.Empty;
                radnik.ime = podaci["ime"] != null ? podaci["ime"].ToString() : string.Empty;
                radnik.jmbg = podaci["jmbg"] != null ? podaci["jmbg"].ToString() : string.Empty;
                radnik.prezime = podaci["prezime"] != null ? podaci["prezime"].ToString() : string.Empty;
                radnik.racun = podaci["racun"] != null ? podaci["racun"].ToString() : string.Empty;
                radnik.telefon = podaci["telefon"] != null ? podaci["telefon"].ToString() : string.Empty;
                radnik.odmor = podaci["odmor"] != null ? Convert.ToInt32(podaci["odmor"]) : 0;
       
                radnik.zanimanje = podaci["zanimanje"] != null ? podaci["zanimanje"].ToString() : string.Empty;
                radnik.slobodan = podaci["slobodan"] != null ? podaci["slobodan"].ToString() : string.Empty;
                radnik.plata = podaci["plata"] != null ? podaci["plata"].ToString() : string.Empty;

            }

            return radnik;
        }
        public static List<Radnik> vratiRadnike()
        {
            ISession session = SessionManager.GetSession();

            List<Radnik> radnici = new List<Radnik>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Radnik\" ");
            foreach (var row in podaci)
                if (podaci != null)
                {
                    Radnik r = new Radnik();
                    r.idRadnika = row["idRadnika"] != null ? row["idRadnika"].ToString() : string.Empty;
                    r.ime = row["ime"] != null ? row["ime"].ToString() : string.Empty;
                    r.prezime = row["prezime"] != null ? row["prezime"].ToString() : string.Empty;
                    r.telefon = row["telefon"] != null ? row["telefon"].ToString() : string.Empty;
                    r.email = row["email"] != null ? row["email"].ToString() : string.Empty;
                    r.zanimanje = row["zanimanje"] != null ? row["zanimanje"].ToString() : string.Empty;
                    r.plata = row["plata"] != null ? row["plata"].ToString() : string.Empty;
                    r.jmbg = row["jmbg"] != null ? row["jmbg"].ToString() : string.Empty;
                    r.racun = row["racun"] != null ? row["racun"].ToString() : string.Empty;

                   
                    radnici.Add(r); 
                }


            return radnici;
        }
        public static void izmeniRadnika(string ime, string prezime, string email, string telefon, string jmbg, string odmor, string plata, string sloboda, string zanimanje)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            Radnik r = vratiRadnikaPoJmbgu(jmbg);
            RowSet rwd = session.Execute("update \"Radnik\" set ime='" + ime
                                                           + "',prezime='" + prezime
                                                           + "',email='" + email
                                                           + "',telefon='" + telefon
                                                           + "',jmbg='" + jmbg
                                                           + "',odmor='" + odmor
                                                           + "',plata='" + plata
                                                           + "',slobodan='" + sloboda
                                                           + "',zanimanje='" + zanimanje
                                                           + "' where \"idRadnika\" = '" + r.idRadnika + "'");




        }

        public static List<Radnik> GetSlobodniRadnici()
        {
            List<Radnik> slobodniRadnici = new List<Radnik>();
            ISession session = SessionManager.GetSession();


            if (session == null)
                return null;

            var slobodniRadniciData = session.Execute("select * from \"Radnik\" where slobodan = 'da' allow filtering; ");
            foreach (var radnikData in slobodniRadniciData)
            {
                Radnik radnik = new Radnik();
                radnik.idRadnika = radnikData["idRadnika"] != null ? radnikData["idRadnika"].ToString() : string.Empty;
                radnik.ime = radnikData["ime"] != null ? radnikData["ime"].ToString() : string.Empty;
                radnik.prezime = radnikData["prezime"] != null ? radnikData["prezime"].ToString() : string.Empty;
                radnik.email = radnikData["email"] != null ? radnikData["email"].ToString() : string.Empty;
                radnik.telefon = radnikData["telefon"] != null ? radnikData["telefon"].ToString() : string.Empty;
                radnik.racun = radnikData["racun"] != null ? radnikData["racun"].ToString() : string.Empty;
                radnik.jmbg = radnikData["jmbg"] != null ? radnikData["jmbg"].ToString() : string.Empty;
                radnik.plata = radnikData["plata"] != null ? radnikData["plata"].ToString() : string.Empty;
                radnik.slobodan = radnikData["slobodan"] != null ? radnikData["slobodan"].ToString() : string.Empty;
                radnik.zanimanje = radnikData["zanimanje"] != null ? radnikData["zanimanje"].ToString() : string.Empty;
                radnik.odmor = radnikData["odmor"] != null ? Convert.ToInt32(radnikData["odmor"]) : 0;
                slobodniRadnici.Add(radnik);
            }
            return slobodniRadnici;
        }

        public static void PromeniSlobodnostRadnika(string idRadnika, string YesOrNo)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
            {
                MessageBox.Show("Session is null");
            }
            RowSet zadatakData = session.Execute("Update \"Radnik\" set \"slobodan\"='" + YesOrNo + "' where \"idRadnika\"='" + idRadnika + "';");

        }
        public static void dodajRadnika(string ime, string prezime, string email, string plata, string slobodan, string telefon, string jmbg, string racun, string odmor, string zanimanje)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            //   int idr = maxIdRadnika();
            string idr = maxIdRadnika();// idr.ToString();
            RowSet red = session.Execute("insert into \"Radnik\" (\"idRadnika\", ime, prezime,email, jmbg, telefon, plata, zanimanje,racun,odmor,slobodan)  values ('" + idr + "','" + ime + "', '" + prezime + "', '" + email + "','" + jmbg + "', '" + telefon + "', '" + plata + "', '" + zanimanje + "','" + racun + "','" + odmor + "','" + slobodan + "')");
            RowSet red2 = session.Execute("INSERT INTO \"Login\" (\"email\", \"sifra\", \"tip\") VALUES('" + email + "','r" + idr + "','radnik');");

        }
        public static void obrisiRadnika(string id)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return; 
            Radnik r = DataProvider.vratiRadnikaPoIdu(id);
           // MessageBox.Show(r.email);

            RowSet red1 = session.Execute("delete from \"Login\" where \"email\" = '" + r.email + "'");

            RowSet red = session.Execute("delete from \"Radnik\" where \"idRadnika\" = '" + id + "'");


          

        }
        #endregion
        #region Vodja
        public static List<Projekat> vratiProjekteZaVodju(string id)
        {
            ISession session = SessionManager.GetSession();
            List<Projekat> projekti = new List<Projekat>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Projekat\" where \"idVodje\" =  '" + id + "' ALLOW FILTERING ");

            foreach (var p in podaci)
            {
                Projekat z = new Projekat();
                z.idVodje = p["idVodje"].ToString();
                z.idSefa = p["idSefa"].ToString();
                z.datumKraja = Convert.ToDateTime(p["datumkraja"].ToString());
                z.datumPocetka = Convert.ToDateTime(p["datumpocetka"].ToString());
                z.idProjekta = p["idProjekta"].ToString();
                z.naziv = p["naziv"].ToString();
                z.prioritet = p["prioritet"].ToString();
                z.rok = Convert.ToDateTime(p["rok"].ToString());
                projekti.Add(z);
            }

            return projekti;
        }
        public static Vodja GetVodja(string idVodje)
        {
            ISession session = SessionManager.GetSession();
            Vodja vodja = new Vodja();

            if (session == null)
                return null;

            Row vodjaData = session.Execute("select * from \"Vodja\" where \"idVodje\"='" + idVodje + "'").FirstOrDefault();

            if (vodjaData != null)
            {
                vodja.idVodje = vodjaData["idVodje"] != null ? vodjaData["idVodje"].ToString() : string.Empty;
                vodja.ime = vodjaData["ime"] != null ? vodjaData["ime"].ToString() : string.Empty;
                vodja.prezime = vodjaData["prezime"] != null ? vodjaData["prezime"].ToString() : string.Empty;
                vodja.email = vodjaData["email"] != null ? vodjaData["email"].ToString() : string.Empty;
                vodja.telefon = vodjaData["telefon"] != null ? vodjaData["telefon"].ToString() : string.Empty;
                vodja.racun = vodjaData["racun"] != null ? vodjaData["racun"].ToString() : string.Empty;
                vodja.jmbg = vodjaData["jmbg"] != null ? vodjaData["jmbg"].ToString() : string.Empty;
                vodja.plata = vodjaData["plata"] != null ? vodjaData["plata"].ToString() : string.Empty;
                vodja.slobodan = vodjaData["slobodan"] != null ? vodjaData["slobodan"].ToString() : string.Empty;
                vodja.odmor = vodjaData["odmor"] != null ? Convert.ToInt32(vodjaData["odmor"]) : 0;
            }
            return vodja;
        }
        public static List<Tim> vratTimoveZaVodju(string id)
        {
            ISession session = SessionManager.GetSession();
            List<Tim> timovi = new List<Tim>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Tim\" where \"idVodje\" =  '" + id + "' ALLOW FILTERING ");

            foreach (var p in podaci)
            {
                Tim t = new Tim();
                t.idVodje = p["idVodje"].ToString();
                t.idRadnika = p["idRadnika"].ToString();
                t.idTima = p["idTima"].ToString();
                t.aktivan = p["aktivan"].ToString();
                t.naziv = p["naziv"].ToString();
                timovi.Add(t);
            }

            return timovi;
        }
        public static void obrisiTimoveZaVodju(string id)
        {
            ISession session = SessionManager.GetSession();
            List<Tim> timovi = DataProvider.vratTimoveZaVodju(id);

            if (session == null)
                return;
            foreach (Tim tim in timovi)
            {
               // MessageBox.Show("TIM ID:" + tim.idTima);
                var podaci = session.Execute("delete from \"Tim\" where \"idTima\" =  '" + tim.idTima + "'");
            }
        }


        public static string GetVodjaId()
        {
            string id = "";
            int idr;
            ISession session = SessionManager.GetSession();
            Row red = session.Execute("select max(\"idVodje\") from \"Vodja\" ").FirstOrDefault();
            id = red["system.max(idVodje)"] != null ? red["system.max(idVodje)"].ToString() : string.Empty;
            idr = Int32.Parse(id);

            idr++;
            return idr.ToString();
        }

        public static Vodja vratiVodjuPoEmailu(string email)
        {
            ISession session = SessionManager.GetSession();
            Vodja vodja = new Vodja();

            if (session == null)
                return null;

            Row podaci = session.Execute("select * from \"Vodja\" where email='" + email + "'ALLOW FILTERING").FirstOrDefault();

            if (vodja != null)
            {
                vodja.idVodje = podaci["idVodje"] != null ? podaci["idVodje"].ToString() : string.Empty;
                vodja.email = podaci["email"] != null ? podaci["email"].ToString() : string.Empty;
                vodja.ime = podaci["ime"] != null ? podaci["ime"].ToString() : string.Empty;
                vodja.jmbg = podaci["jmbg"] != null ? podaci["jmbg"].ToString() : string.Empty;
                vodja.prezime = podaci["prezime"] != null ? podaci["prezime"].ToString() : string.Empty;
                vodja.racun = podaci["racun"] != null ? podaci["racun"].ToString() : string.Empty;
                vodja.telefon = podaci["telefon"] != null ? podaci["telefon"].ToString() : string.Empty;
                vodja.odmor = podaci["odmor"] != null ? Convert.ToInt32(podaci["odmor"].ToString()) : 0;
            }

            return vodja;
        }


        public static List<Vodja> vratiSveVodje()
        {
            ISession session = SessionManager.GetSession();
            List<Vodja> vodje = new List<Vodja>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Vodja\" ");

            foreach (var p in podaci)
            {
                Vodja z = new Vodja();
                z.idVodje = p["idVodje"].ToString();
                z.ime = p["ime"].ToString();
                z.prezime = p["prezime"].ToString();
                z.racun = p["racun"].ToString();
                z.telefon = p["telefon"].ToString();
                z.jmbg = p["jmbg"].ToString();
                z.email = p["email"].ToString();
                z.plata = p["plata"].ToString();
                z.slobodan = p["slobodan"].ToString();
               // z.odmor = Int32.Parse(p["omdor"].ToString());
                z.odmor = p["odmor"] != null ? Convert.ToInt32(p["odmor"]) : 0;

                vodje.Add(z);
            }

            return vodje;
        }

        public static Vodja vratiVodjuPoJmbgu(string jmbg)
        {
            ISession session = SessionManager.GetSession();
            Vodja vodja = new Vodja();

            if (session == null)
                return null;

            Row podaci = session.Execute("select * from \"Vodja\" where jmbg='" + jmbg + "'ALLOW FILTERING").FirstOrDefault();

            if (podaci != null)
            {
                vodja.idVodje = podaci["idVodje"] != null ? podaci["idVodje"].ToString() : string.Empty;
                vodja.email = podaci["email"] != null ? podaci["email"].ToString() : string.Empty;
                vodja.ime = podaci["ime"] != null ? podaci["ime"].ToString() : string.Empty;
                vodja.jmbg = podaci["jmbg"] != null ? podaci["jmbg"].ToString() : string.Empty;
                vodja.prezime = podaci["prezime"] != null ? podaci["prezime"].ToString() : string.Empty;
                vodja.racun = podaci["racun"] != null ? podaci["racun"].ToString() : string.Empty;
                vodja.telefon = podaci["telefon"] != null ? podaci["telefon"].ToString() : string.Empty;
                vodja.odmor = podaci["odmor"] != null ? Convert.ToInt32(podaci["odmor"].ToString()) : 0;
            }
            else vodja = null;
            return vodja;
        }
        #endregion
        #region Zadatak
        public static List<Zadatak> vratiZadatkeZaRadnika(string id)
        {
            ISession session = SessionManager.GetSession();
            List<Zadatak> zadaci = new List<Zadatak>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Zadatak\" where \"idRadnika\" =  '" + id + "' ALLOW FILTERING");

            foreach (var p in podaci)
            {
                Zadatak z = new Zadatak();
                z.idVodje = p["idVodje"].ToString();
                z.idRadnika = p["idRadnika"].ToString();
                z.idZadatka = p["idZadatka"].ToString();
                z.naziv = p["naziv"].ToString();
                z.obavljeno = p["obavljeno"].ToString();
                z.opis = p["opis"].ToString();
                zadaci.Add(z);
            }

            return zadaci;
        }
        public static void ZadajZadatak(Zadatak zadatak, Radnik radnik)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
            {
                MessageBox.Show("Session is null");
            }
            RowSet zadatakData = session.Execute("insert into \"Zadatak\"(\"idZadatka\", \"idRadnika\", \"idVodje\", naziv, obavljeno, opis)  values('" + zadatak.idZadatka + "', '" + zadatak.idRadnika + "', '" + zadatak.idVodje + "', '" + zadatak.naziv + "', '" + zadatak.obavljeno + "', '" + zadatak.opis + "');");

        }

        public static string GetZadatakId()
        {
            string id = "";
            int idr;
            ISession session = SessionManager.GetSession();
            Row red = session.Execute("select max(\"idZadatka\") from \"Zadatak\" ").FirstOrDefault();
            id = red["system.max(idZadatka)"] != null ? red["system.max(idZadatka)"].ToString() : 0.ToString();// string.Empty;
            idr = Int32.Parse(id);

            idr++;
            return idr.ToString();
        }
        #endregion
        #region Tim
        public static void AddTim(Tim tim)
        {
            ISession session = SessionManager.GetSession();
            if (session == null)
            {
                MessageBox.Show("Session is null");
            }
            RowSet zadatakData = session.Execute("insert into \"Tim\"(\"idTima\", \"idRadnika\", \"idVodje\", naziv, aktivan)  values('" + tim.idTima + "', '" + tim.idRadnika + "', '" + tim.idVodje + "', '" + tim.naziv + "', '" + tim.aktivan + "');");

        }

        public static string GetTimId()
        {
            string id = "";
            int idr;
            ISession session = SessionManager.GetSession();
            Row red = session.Execute("select max(\"idTima\") from \"Tim\" ").FirstOrDefault();
            id = red["system.max(idTima)"] != null ? red["system.max(idTima)"].ToString() : 0.ToString();
            idr = Int32.Parse(id);

            idr++;
            return idr.ToString();
        }

        public static List<Tim> vratiTimove()
        {
            ISession session = SessionManager.GetSession();
            // Tim tim = new Tim();
            List<Tim> timovi = new List<Tim>();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Tim\" ");
            foreach (var row in podaci)
                if (podaci != null)
                {
                    Tim tim = new Tim();
                    tim.idTima = row["idTima"] != null ? row["idTima"].ToString() : string.Empty;
                    tim.idRadnika = row["idRadnika"] != null ? row["idRadnika"].ToString() : string.Empty;
                    tim.idVodje = row["idVodje"] != null ? row["idVodje"].ToString() : string.Empty;
                    tim.naziv = row["naziv"] != null ? row["naziv"].ToString() : string.Empty;
                    tim.aktivan = row["aktivan"] != null ? row["aktivan"].ToString() : string.Empty;
                    timovi.Add(tim); //resiti duplikate
                }

            timovi = timovi.Distinct().ToList();
            return timovi;
        }

        public static Vodja nadjiVodjuTima(String naziv)
        {
            Vodja vodja = new Vodja();
            string idV = "";
            ISession session = SessionManager.GetSession();
            Row red = session.Execute("select \"idVodje\" from \"Tim\" where naziv='" + naziv + "'ALLOW FILTERING").FirstOrDefault();

            if (red != null)
            {
                idV = red["idVodje"] != null ? red["idVodje"].ToString() : string.Empty;

            }
            red = session.Execute("select * from \"Vodja\" where \"idVodje\"='" + idV + "'").FirstOrDefault();

            if (red != null)
            {
                vodja.idVodje = red["idVodje"] != null ? red["idVodje"].ToString() : string.Empty;
                vodja.ime = red["ime"] != null ? red["ime"].ToString() : string.Empty;
                vodja.prezime = red["prezime"] != null ? red["prezime"].ToString() : string.Empty;
                vodja.email = red["email"] != null ? red["email"].ToString() : string.Empty;
                vodja.jmbg = red["jmbg"] != null ? red["jmbg"].ToString() : string.Empty;

            }

            return vodja;

        }

        public static List<Radnik> nadjiRadnike(String nazivprojekta)
        {
            List<Radnik> radnici = new List<Radnik>();

            string idradnika = "";
            ISession session = SessionManager.GetSession();
            var podaci = session.Execute("select \"idRadnika\" from \"Tim\" where naziv='" + nazivprojekta + "'ALLOW FILTERING");
            foreach (var red in podaci)//petljeee
            {
                if (red != null)
                {
                    idradnika = red["idRadnika"] != null ? red["idRadnika"].ToString() : string.Empty;
                    //MessageBox.Show(idradnika);

                }
                //var red2 = session.Execute("select idRadnika,ime, prezime,email,telefon,plata,zanimanje from \"Radnik\" where \"idRadnika\"='" + idradnika + "'ALLOW FILTERING").FirstOrDefault();
                var red2 = session.Execute("select * from \"Radnik\" where \"idRadnika\"='" + idradnika + "'").FirstOrDefault();

                if (red2 != null)
                {
                    Radnik radnik = new Radnik();
                    radnik.idRadnika = red2["idRadnika"] != null ? red2["idRadnika"].ToString() : string.Empty;
                    radnik.ime = red2["ime"] != null ? red2["ime"].ToString() : string.Empty;
                    radnik.prezime = red2["prezime"] != null ? red2["prezime"].ToString() : string.Empty;
                    radnik.email = red2["email"] != null ? red2["email"].ToString() : string.Empty;
                    radnik.telefon = red2["telefon"] != null ? red2["telefon"].ToString() : string.Empty;
                    radnik.plata = red2["plata"] != null ? red2["plata"].ToString() : string.Empty;
                    radnik.zanimanje = red2["zanimanje"] != null ? red2["zanimanje"].ToString() : string.Empty;

                    radnici.Add(radnik);
                }


            }

            return radnici;
        }
        public static string maxIdRadnika()
        {

            ISession session = SessionManager.GetSession();

            if (session == null)
                return null;

            var maxRow = session.Execute("select MAX(\"idRadnika\") from \"Radnik\" ").FirstOrDefault();

            //String maxId = (Int32.Parse(maxRow["system.max(idDana)"].ToString()) + 1).ToString();
            //Ovo sam promenila jer je pucalo tu
            String maxId = maxRow["system.max(idRadnika)"] != null ? maxRow["system.max(idRadnika)"].ToString() : 0.ToString();

            int idr = Int32.Parse(maxId);

            idr++;
            return idr.ToString();
            

          /*  string id = "";
            int idr;
            ISession session = SessionManager.GetSession();
            Row red = session.Execute("select max(\"idRadnika\") from \"Radnik\" ").FirstOrDefault();
            id = red["system.max(idRadnika)"] != null ? red["system.max(idRadnika)"].ToString() : string.Empty;
            idr = Int32.Parse(id);

            idr++;
            return idr;*/

        }

        #endregion
        #region Login
        public static string login(string email, string sifra)
        {


            string tip = "";
            ISession session = SessionManager.GetSession();
            Row podaci = session.Execute("select tip from \"Login\" where \"sifra\"='" + sifra + "' and \"email\"='" + email + "'ALLOW FILTERING").FirstOrDefault(); ;

            if (podaci == null)
                return null;
            else
            {
                tip = podaci["tip"] != null ? podaci["tip"].ToString() : string.Empty;
                return tip;
            }
        }
        #endregion
        #region SlobodniDani
        public static List<Radnik> vratiRadnikeZaSlobodneDane()
        {
            List<Radnik> radnici = new List<Radnik>();

            string idradnika = "";
            ISession session = SessionManager.GetSession();
            var podaci = session.Execute("select \"idRadnika\" from \"SlobodniDani\" ");
            //  var red2= session.Execute("select \"idRadnika\" from \"SlobodniDani\" ");
            foreach (var red in podaci)
            {
                if (red != null)
                {
                    idradnika = red["idRadnika"] != null ? red["idRadnika"].ToString() : string.Empty;

                }
                if (idradnika != "")
                {
                    var red2 = session.Execute("select ime, prezime,email,jmbg,odmor,telefon,plata,zanimanje from \"Radnik\" where \"idRadnika\"='" + idradnika + "'").FirstOrDefault();
                    if (red2 != null)
                    {
                        Radnik radnik = new Radnik();
                        radnik.ime = red2["ime"] != null ? red2["ime"].ToString() : string.Empty;
                        // radnik.idRadnika = red2["idRadnika"] != null ? red2["idRadnika"].ToString() : string.Empty;//
                        radnik.prezime = red2["prezime"] != null ? red2["prezime"].ToString() : string.Empty;
                        radnik.email = red2["email"] != null ? red2["email"].ToString() : string.Empty;
                        radnik.jmbg = red2["jmbg"] != null ? red2["jmbg"].ToString() : string.Empty;
                        radnik.telefon = red2["telefon"] != null ? red2["telefon"].ToString() : string.Empty;
                        radnik.plata = red2["plata"] != null ? red2["plata"].ToString() : string.Empty;
                        radnik.zanimanje = red2["zanimanje"] != null ? red2["zanimanje"].ToString() : string.Empty;
                        radnik.odmor = red2["odmor"] != null ? Convert.ToInt32(red2["odmor"].ToString()) : 0; radnik.idRadnika = idradnika;
                        radnici.Add(radnik);
                    }
                }


            }

            return radnici;

        }
        public static String vratiIdDana(string idr)
        {
            ISession session = SessionManager.GetSession();


            String iddana = "";

            Row red = session.Execute("select * from \"SlobodniDani\" where \"idRadnika\"='" + idr + "' ALLOW FILTERING ").FirstOrDefault();
            iddana = red["idDana"] != null ? red["idDana"].ToString() : string.Empty;

            //    MessageBox.Show(iddana);
            return iddana;
        }
        public static String vratiIdDanaVodje(string idr)
        {
            ISession session = SessionManager.GetSession();


            String iddana = "";

            Row red = session.Execute("select * from \"SlobodniDani\" where \"idVodje\"='" + idr + "' ALLOW FILTERING ").FirstOrDefault();
            iddana = red["idDana"] != null ? red["idDana"].ToString() : string.Empty;

            
            return iddana;
        }
        public static void izmeniSlobodneDane(string idr, string pregledano, string odobreno, int vodja)
        {

            //na osnovu idRadnika menjamo pregledano i odobreno u slobodnidani


            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            String iddana = "";
            if (vodja == 1)
                iddana = vratiIdDana(idr);
            else if (vodja == 2)
                iddana = vratiIdDanaVodje(idr);
            RowSet rwd = session.Execute("update \"SlobodniDani\" set odobreno='" + odobreno + "',pregledano='" + pregledano + "' where \"idDana\" = '" + iddana + "'");


        }
        public static SlobodniDani vratiSlobodanDan(string iddana)
        {
            ISession session = SessionManager.GetSession();


            SlobodniDani sd = new SlobodniDani();

            var red = session.Execute("select * from \"SlobodniDani\" where \"idDana\"='" + iddana + "' ").FirstOrDefault();
            if (red != null)
            {
                // sd.idDana = red["idDana"] != null ? red["idDana"].ToString() : string.Empty;
                sd.idRadnika = red["idRadnika"] != null ? red["idRadnika"].ToString() : string.Empty;
                sd.idVodje = red["idVodje"] != null ? red["idVodje"].ToString() : string.Empty;
                sd.pregledano = red["pregledano"] != null ? red["pregledano"].ToString() : string.Empty;
                sd.odobreno = red["odobreno"] != null ? red["odobreno"].ToString() : string.Empty;

            }
            //   MessageBox.Show(iddana);
            return sd;
        }
        public static List<Vodja> vratiVodjeZaSlobodneDane()
        {
            List<Vodja> vodje = new List<Vodja>();

            string idradnika = "";
            ISession session = SessionManager.GetSession();
            var podaci = session.Execute("select \"idVodje\" from \"SlobodniDani\" ");
            foreach (var red in podaci)
            {
                if (red != null)
                {
                    idradnika = red["idVodje"] != null ? red["idVodje"].ToString() : string.Empty;

                }
                if (idradnika != "")
                {
                    var red2 = session.Execute("select ime, prezime,email,jmbg,odmor,telefon,plata from \"Vodja\" where \"idVodje\"='" + idradnika + "'").FirstOrDefault();
                    if (red2 != null)
                    {
                        Vodja radnik = new Vodja();
                        radnik.ime = red2["ime"] != null ? red2["ime"].ToString() : string.Empty;
                        // radnik.idRadnika = red2["idRadnika"] != null ? red2["idRadnika"].ToString() : string.Empty;//
                        radnik.prezime = red2["prezime"] != null ? red2["prezime"].ToString() : string.Empty;
                        radnik.email = red2["email"] != null ? red2["email"].ToString() : string.Empty;
                        radnik.jmbg = red2["jmbg"] != null ? red2["jmbg"].ToString() : string.Empty;
                        radnik.telefon = red2["telefon"] != null ? red2["telefon"].ToString() : string.Empty;
                        radnik.plata = red2["plata"] != null ? red2["plata"].ToString() : string.Empty;
                        //    radnik.zanimanje = red2["zanimanje"] != null ? red2["zanimanje"].ToString() : string.Empty;
                        radnik.odmor = red2["odmor"] != null ? Convert.ToInt32(red2["odmor"].ToString()) : 0; radnik.idVodje = idradnika;
                        vodje.Add(radnik);
                    }
                }

            }

            return vodje;

        }

        #endregion
        #region Projekat
        public static void dodajProjekat(Projekat p)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;
            int idr = maxIdProjekta();
            string id = idr.ToString();

            String datumPocetka = p.datumPocetka.Year.ToString() + "-" + p.datumPocetka.Month.ToString() + "-" + p.datumPocetka.Day.ToString();
            String datumKraja = p.datumKraja.Year.ToString() + "-" + p.datumKraja.Month.ToString() + "-" + p.datumKraja.Day.ToString();
            String rok = p.rok.Year.ToString() + "-" + p.rok.Month.ToString() + "-" + p.rok.Day.ToString();
            RowSet red = session.Execute("insert into \"Projekat\" (\"idProjekta\", naziv, prioritet,datumkraja, datumpocetka,rok,\"idSefa\",\"idVodje\" )  values ('" + id + "','" + p.naziv + "', '" + p.prioritet + "', '" + datumKraja + "','" + datumPocetka + "', '" + rok + "', '" + p.idSefa + "','" + p.idVodje + "')");

        }
        public static void obrisiProjekat(string id)
        {

            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            RowSet red = session.Execute("delete from \"Projekat\" where \"idProjekta\" = '" + id + "'");

        }
        public static void izmeniProjekat(Projekat p)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;


            String datumPocetka = p.datumPocetka.Year.ToString() + "-" + p.datumPocetka.Month.ToString() + "-" + p.datumPocetka.Day.ToString();
            String datumKraja = p.datumKraja.Year.ToString() + "-" + p.datumKraja.Month.ToString() + "-" + p.datumKraja.Day.ToString();
            String rok = p.rok.Year.ToString() + "-" + p.rok.Month.ToString() + "-" + p.rok.Day.ToString();

            RowSet rwd = session.Execute("update \"Projekat\" set naziv='" + p.naziv
                                                           + "',prioritet='" + p.prioritet
                                                           + "',rok='" + rok
                                                           + "',datumpocetka='" + datumPocetka
                                                            + "',datumkraja='" + datumKraja
                                                           + "',\"idVodje\"='" + p.idVodje
                                                           + "' where \"idProjekta\" = '" + p.idProjekta + "'");




        }
        public static Projekat vratiProjektePoIDu(string id)
        {
            ISession session = SessionManager.GetSession();
            Projekat projekat = new Projekat();

            if (session == null)
                return null;

            var podaci = session.Execute("select * from \"Projekat\" where \"idProjekta\" =  '" + id + "' ");

            foreach (var p in podaci)
            {

                projekat.idVodje = p["idVodje"].ToString();
                projekat.idSefa = p["idSefa"].ToString();
                projekat.datumKraja = Convert.ToDateTime(p["datumkraja"].ToString());
                projekat.datumPocetka = Convert.ToDateTime(p["datumpocetka"].ToString());
                projekat.idProjekta = p["idProjekta"].ToString();
                projekat.naziv = p["naziv"].ToString();
                projekat.prioritet = p["prioritet"].ToString();
                projekat.rok = Convert.ToDateTime(p["rok"].ToString());

            }

            return projekat;
        }
        public static int maxIdProjekta()
        {
            string id = "";
            int idr;
            ISession session = SessionManager.GetSession();
            Row red = session.Execute("select max(\"idProjekta\") from \"Projekat\" ").FirstOrDefault();
            id = red["system.max(idProjekta)"] != null ? red["system.max(idProjekta)"].ToString() : 0.ToString();

            idr = Int32.Parse(id);

            idr++;
            return idr;

        }
        #endregion
        #region Placanje
        public static void isplatiRadnike(String idSefa)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            List<Radnik> radnici = vratiRadnike();
            List<Vodja> vodje = vratiSveVodje();
           // String idPlate = vratiMaxIdPlate();

            foreach (Radnik r in radnici)
            {
                Placanje p = new Placanje();
                String idPlate = vratiMaxIdPlate();
                p.datumIsplate = System.DateTime.Now;
                string datum= p.datumIsplate.Year.ToString() + "-" + p.datumIsplate.Month.ToString() + "-" + p.datumIsplate.Day.ToString();
                p.idPlate = idPlate;
                p.idRadnika = r.idRadnika;
                p.idVodje = null;
                p.iznos = Int32.Parse(r.plata);
                p.idSefa = idSefa;
               // MessageBox.Show(r.idRadnika);
               // RowSet zahtevData = session.Execute("insert into \"Placanje\" (\"idPlate\", \"datumIsplate\", \"idRadnika\", iznos, \"idSefa\")  values ('" + p.idPlate + "', '" + p.datumIsplate + "', '" + p.idRadnika + "', " + p.iznos + ", '" + p.idSefa + "' )");
                  session.Execute("insert into \"Placanje\" (\"idPlate\", \"datumIsplate\", \"idRadnika\", iznos, \"idSefa\")  values ('" + p.idPlate + "', '" + datum + "', '" + p.idRadnika + "', " + p.iznos + ", '" + p.idSefa + "' )");

            }
        }

        public static void isplatiVodje(String idSefa)
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return;

            List<Radnik> radnici = vratiRadnike();
            List<Vodja> vodje = vratiSveVodje();
           

            foreach (Vodja r in vodje)
            {
               //tring datumPocetka = p.datumPocetka.Year.ToString() + "-" + p.datumPocetka.Month.ToString() + "-" + p.datumPocetka.Day.ToString();
                Placanje p = new Placanje();
                String idPlate = vratiMaxIdPlate();
                 p.datumIsplate = System.DateTime.Now; 
                string datum = p.datumIsplate.Year.ToString() + "-" + p.datumIsplate.Month.ToString() + "-" + p.datumIsplate.Day.ToString();
               
                p.idPlate = idPlate;
                p.idRadnika = null;
                p.idVodje = r.idVodje;
                p.iznos = Int32.Parse(r.plata);
                p.idSefa = idSefa;
                RowSet zahtev = session.Execute("insert into \"Placanje\" (\"idPlate\", \"datumIsplate\", \"idVodje\", iznos, \"idSefa\")  values ('" + p.idPlate + "', '" +datum + "', '" + p.idVodje + "', " + p.iznos + ", '" + p.idSefa + "' )");
            }
        }
        public static String vratiMaxIdPlate()
        {
            ISession session = SessionManager.GetSession();

            if (session == null)
                return null;

            var maxRow = session.Execute("select MAX(\"idPlate\") from \"Placanje\" ").FirstOrDefault();

            String maxId = maxRow["system.max(idPlate)"] != null ? maxRow["system.max(idPlate)"].ToString() : 0.ToString();

            int idr = Int32.Parse(maxId);

            idr++;
            return idr.ToString();

        }

        #endregion
    }
}
//   radnik.odmor = red2["odmor"] != null ? Convert.ToInt32(red2["odmor"].ToString()) : 0;