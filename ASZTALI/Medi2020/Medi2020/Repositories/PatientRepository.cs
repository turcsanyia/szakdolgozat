using System;
using System.ComponentModel;
using System.Linq;
using Medi2020.Models;

namespace Medi2020.Repositories
{
    public class PatientRepository : IDisposable
    {
        private Medi2020Context db = new Medi2020Context();
        private int _totalItems;

        public BindingList<patient> GetAllPatients(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.patients.OrderBy(x => x.Taj).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();
                int irszam;
                int.TryParse(search, out irszam);

                query = query.Where(x => x.Taj.ToString().ToLower().Contains(search) ||
                                         x.Vezeteknev.ToLower().Contains(search) ||
                                         x.Keresztnev.ToLower().Contains(search) ||
                                         x.Telepules.ToLower().Contains(search) ||
                                         x.Lakcim.ToLower().Contains(search) ||
                                         x.Iranyitoszam.Equals(irszam) ||
                                         x.Telefon.ToLower().Contains(search) ||
                                         x.Email.ToLower().Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "Vezetéknév":
                        query = ascending
                            ? query.OrderBy(x => x.Vezeteknev)
                            : query.OrderByDescending(x => x.Vezeteknev);
                        break;
                    case "Keresztnév":
                        query = ascending
                            ? query.OrderBy(x => x.Keresztnev)
                            : query.OrderByDescending(x => x.Keresztnev);
                        break;
                    case "Irányítószám":
                        query = ascending
                            ? query.OrderBy(x => x.Iranyitoszam)
                            : query.OrderByDescending(x => x.Iranyitoszam);
                        break;
                    case "Település":
                        query = ascending ? query.OrderBy(x => x.Telepules) : query.OrderByDescending(x => x.Telepules);
                        break;
                    case "Lakcím":
                        query = ascending ? query.OrderBy(x => x.Lakcim) : query.OrderByDescending(x => x.Lakcim);
                        break;
                    case "E-mail cím":
                        query = ascending ? query.OrderBy(x => x.Email) : query.OrderByDescending(x => x.Email);
                        break;
                    case "Telefon":
                        query = ascending
                            ? query.OrderBy(x => x.Telefon)
                            : query.OrderByDescending(x => x.Telefon);
                        break;
                    default:
                        query = ascending ? query.OrderBy(x => x.Taj) : query.OrderByDescending(x => x.Taj);
                        break;
                }
            }

            // Összes találat kiszámítása
            _totalItems = query.Count();

            // Oldaltördelés
            if (page + itemsPerPage > 0)
            {
                query = query.Skip((page - 1) * itemsPerPage).Take(itemsPerPage);
            }

            return new BindingList<patient>(query.ToList());
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Insert(patient patient)
        {
            db.patients.Add(patient);
        }

        public void Delete(string taj)
        {
            var patient = db.patients.Find(taj);

            if (patient != null)
            {
                db.patients.Remove(patient);
            }
        }

        public void Update(patient param)
        {
            var patient = db.patients.Find(param.Taj);

            if (patient != null)
            {
                db.Entry(patient).CurrentValues.SetValues(param);
            }
        }

        public bool IsExisting(string taj)
        {
            return db.patients.ToList().Exists(x => x.Taj == taj);
        }

        public void ValidatePatient(patient patient)
        {
            string taj = patient.Taj;
            string jelszo = patient.Jelszo;
            string vezeteknev = patient.Vezeteknev;
            string keresztnev = patient.Keresztnev;
            int iranyitoszam = patient.Iranyitoszam;
            string telepules = patient.Telepules;
            string lakcim = patient.Lakcim;
            string email = patient.Email;
            string telefon = patient.Telefon;

            if (string.IsNullOrEmpty(taj) ||
                string.IsNullOrEmpty(jelszo) ||
                string.IsNullOrEmpty(vezeteknev) ||
                string.IsNullOrEmpty(keresztnev) ||
                string.IsNullOrEmpty(telepules) ||
                string.IsNullOrEmpty(lakcim) ||
                string.IsNullOrEmpty(email) ||
                string.IsNullOrEmpty(telefon))
            {
                throw new Exception("Üres bemenet.");
            }

            if (taj.Length != 11 || !taj.Contains('-') || taj.Any(char.IsLetter))
            {
                throw new Exception(
                    "Taj számnak tartalmaznia kell kötőjelet és 3-as tagolással összesen 11 karakter hosszú lehet, valamint nem tartalmazhat betűt.");
            }

            if (vezeteknev.Length > 50 || keresztnev.Length > 50)
            {
                throw new Exception("A vezetéknév vagy a keresztnév nem lehet hosszabb 50 karakternél.");
            }

            if (char.IsLower(vezeteknev.ElementAt(0)) || char.IsLower(keresztnev.ElementAt(0)))
            {
                throw new Exception("Vezetéknévnek vagy keresztnévnek nagy betűvel kell kezdődjön.");
            }

            if (jelszo.Length > 11)
            {
                throw new Exception("Jelszó 11 karakterből állhat.");
            }

            if (iranyitoszam == 0 || iranyitoszam.ToString().Length != 4)
            {
                throw new Exception("Irányítószám nem tartalmazhat betűt és 4 karakternek kell lennie!");
            }

            if (char.IsLower(telepules.ElementAt(0)) || telepules.Any(char.IsNumber))
            {
                throw new Exception("Teleülés neve nem kezdődhet kisbetűvel és nem tartalmazhat számot.");
            }

            if (char.IsLower(lakcim.ElementAt(0)))
            {
                throw new Exception("Lakcím nem kezdődhet kisbetűvel.");
            }

            if (!email.Contains('@'))
            {
                throw new Exception("Nem megfelelő e-mail cím formátum.");
            }

            if (telefon.Length > 11 || !telefon.Any(char.IsNumber))
            {
                throw new Exception(
                    "Telefonszám maximum 11 karakter hosszú lehet, és nem tartalmazhat speciális karaktereket (zárójel, kötőjel, stb.), illetve betűt.");
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }
    }
}
