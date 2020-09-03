using System;
using System.ComponentModel;
using System.Linq;
using Medi2020.Models;

namespace Medi2020.Repositories
{
    public class ServiceRepository : IDisposable
    {
        private Medi2020Context db = new Medi2020Context();
        private int _totalItems;

        public BindingList<service> GetAllServices(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.services.OrderBy(x => x.Id).AsQueryable();

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
                    case "Nev":
                        query = ascending ? query.OrderBy(x => x.Nev) : query.OrderByDescending(x => x.Nev);
                        break;
                    default:
                        query = ascending ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id);
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

            return new BindingList<service>(query.ToList());
        }

        //public int Count()
        //{
        //    return _totalItems;
        //}

        //public void Insert(service service)
        //{
        //    if (db.services.Any(x => x.Nev == service.Nev))
        //    {
        //        throw new Exception("Már létezik ilyen névvel szolgáltatás!");
        //    }

        //    db.services.Add(service);
        //}

        //public void Delete(int id)
        //{
        //    var service = db.services.Find(id);

        //    if (service != null)
        //    {
        //        db.services.Remove(service);
        //    }
        //}

        //public void Update(service param)
        //{
        //    var service = db.services.Find(param.Id);

        //    if (service != null)
        //    {
        //        db.Entry(service).CurrentValues.SetValues(param);
        //    }
        //}

        //public bool Exists(service service)
        //{
        //    return db.services.Any(x => x.Id == service.Id);
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

        //public service GetServiceById(int id)
        //{
        //    return db.services.ToList().Find(x => x.Id == id);
        //}

        public service GetServiceByName(string name)
        {
            return db.services.ToList().Find(x => x.Nev == name);
        }
    }
}
