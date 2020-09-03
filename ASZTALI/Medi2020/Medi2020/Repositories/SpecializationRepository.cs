using System;
using System.ComponentModel;
using System.Linq;
using Medi2020.Models;

namespace Medi2020.Repositories
{
    public class SpecializationRepository : IDisposable
    {
        private Medi2020Context db = new Medi2020Context();
        private int _totalItems;

        public BindingList<specialization> GetAllSpecializations(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.specializations
                .OrderBy(x => x.Id)
                .AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                query = query.Where(x => x.Nev.Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    default:
                        query = ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id);
                        break;
                    case "Nev":
                        query = ascending ? query.OrderBy(x => x.Nev) : query.OrderByDescending(x => x.Nev);
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

            return new BindingList<specialization>(query.ToList());
        }

        //public int Count()
        //{
        //    return _totalItems;
        //}

        //public void Insert(specialization specialization)
        //{
        //    if (db.specializations.Any(x => x.Nev == specialization.Nev))
        //    {
        //        throw new Exception("Már létezik ilyen névvel szakterület!");
        //    }

        //    db.specializations.Add(specialization);
        //}

        //public void Delete(int id)
        //{
        //    var specialization = db.specializations.Find(id);

        //    if (specialization != null)
        //    {
        //        db.specializations.Remove(specialization);
        //    }
        //}

        //public void Update(specialization param)
        //{
        //    var jk = db.specializations.Find(param.Id);

        //    if (jk != null)
        //    {
        //        db.Entry(jk).CurrentValues.SetValues(param);
        //    }
        //}

        //public bool Exists(specialization specialization)
        //{
        //    return db.specializations.Any(x => x.Id == specialization.Id);
        //}

        //public void Save()
        //{
        //    db.SaveChanges();
        //}

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
