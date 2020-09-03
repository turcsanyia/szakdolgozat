using System;
using System.ComponentModel;
using System.Linq;
using Medi2020.Models;

namespace Medi2020.Repositories
{
    public class DoctorRepository : IDisposable
    {
        private Medi2020Context db = new Medi2020Context();
        private int _totalItems;

        public BindingList<doctor> GetAllDoctors(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.doctors.OrderBy(x => x.Id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                query = query.Where(x => x.Id.ToString().ToLower().Contains(search) ||
                                         x.Vezeteknev.ToLower().Contains(search) ||
                                         x.Keresztnev.ToLower().Contains(search) ||
                                         x.specialization.Nev.ToLower().Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "Keresztnév":
                        query = ascending
                            ? query.OrderBy(x => x.Keresztnev)
                            : query.OrderByDescending(x => x.Keresztnev);
                        break;
                    case "Szakterület":
                        query = ascending
                            ? query.OrderBy(x => x.specialization.Nev)
                            : query.OrderByDescending(x => x.specialization.Nev);
                        break;
                    default:
                        query = ascending ? query.OrderBy(x => x.Vezeteknev) : query.OrderByDescending(x => x.Vezeteknev);
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

            return new BindingList<doctor>(query.ToList());
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Insert(doctor doctor)
        {
            try
            {
                ValidateDoctor(doctor);
                db.doctors.Add(doctor);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ValidateDoctor(doctor doctor)
        {
            if (char.IsLower(doctor.Vezeteknev.ElementAt(0)))
            {
                throw new Exception("Vezetéknév nem kezdődhet kisbetűvel.");
            }

            if (char.IsLower(doctor.Keresztnev.ElementAt(0)))
            {
                throw new Exception("Keresztnév nem kezdődhet kisbetűvel.");
            }
        }

        public void Delete(int id)
        {
            var doctor = db.doctors.Find(id);

            if (doctor != null)
            {
                db.doctors.Remove(doctor);
            }
        }

        public void Update(doctor param)
        {
            var doctor = db.doctors.Find(param.Id);

            try
            {
                ValidateDoctor(param);
            }
            catch (Exception)
            {
                throw;
            }

            if (doctor != null)
            {
                db.Entry(doctor).CurrentValues.SetValues(param);
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
