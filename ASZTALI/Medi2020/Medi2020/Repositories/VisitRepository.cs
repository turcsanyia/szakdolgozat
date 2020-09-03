using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Medi2020.Models;
using Medi2020.ViewModels;

namespace Medi2020.Repositories
{
    public class VisitRepository : IDisposable
    {
        private Medi2020Context db = new Medi2020Context();
        private int _totalItems;

        public BindingList<VisitVM> GetAllVisits(
            int page = 0,
            int itemsPerPage = 0,
            string search = null,
            string sortBy = null,
            bool ascending = true)
        {
            var query = db.visits.OrderBy(x => x.Id).AsQueryable();

            // Keresés
            if (!string.IsNullOrWhiteSpace(search))
            {
                search = search.ToLower();

                query = query.Where(x => x.Id.ToString().ToLower().Contains(search) ||
                                         x.Idopont.ToString().ToLower().Contains(search) ||
                                         (x.patient.Vezeteknev.ToLower() + " " + x.patient.Keresztnev)
                                         .Contains(search) ||
                                         (x.doctor.Vezeteknev.ToLower() + " " + x.doctor.Keresztnev).Contains(search) ||
                                         x.service.Nev.ToLower().Contains(search));
            }

            // Sorbarendezés
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                switch (sortBy)
                {
                    case "Beteg neve":
                        query = ascending
                            ? query.OrderBy(x => x.patient.Vezeteknev).ThenBy(x => x.patient.Keresztnev)
                            : query.OrderByDescending(x => x.patient.Vezeteknev).ThenBy(x => x.patient.Keresztnev);
                        break;
                    case "Orvos neve":
                        query = ascending
                            ? query.OrderBy(x => x.doctor.Vezeteknev).ThenBy(x => x.doctor.Keresztnev)
                            : query.OrderByDescending(x => x.doctor.Vezeteknev).ThenBy(x => x.doctor.Keresztnev);
                        break;
                    case "Igénybe vett szolgáltatás":
                        query = ascending
                            ? query.OrderBy(x => x.service.Nev)
                            : query.OrderByDescending(x => x.service.Nev);
                        break;
                    default:
                        query = ascending ? query.OrderBy(x => x.Idopont) : query.OrderByDescending(x => x.Idopont);
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

            var dblist = query.ToList();

            var rendelesVMList = new List<VisitVM>();

            foreach (var visit in dblist)
            {
                string betegNeve = visit.patient.Vezeteknev + " " + visit.patient.Keresztnev;
                int orvosId = visit.doctor.Id;
                string orvosNeve = visit.doctor.Vezeteknev + " " + visit.doctor.Keresztnev;

                var visitVM = new VisitVM(visit.Id, visit.Idopont, visit.patient.Taj, betegNeve, orvosId, orvosNeve,
                    visit.service.Id, visit.service.Nev);

                rendelesVMList.Add(visitVM);
            }

            return new BindingList<VisitVM>(rendelesVMList);
        }

        public int Count()
        {
            return _totalItems;
        }

        public void Insert(VisitVM visitVM)
        {
            if (IsEarlier(visitVM.Idopont.Year, visitVM.Idopont.Month, visitVM.Idopont.Day))
            {
                throw new Exception("Rendelés nem vehető fel a mainál korábbi időpontra!");
            }

            db.visits.Add(new visit(visitVM.OrvosId, visitVM.BetegTaj, visitVM.SzolgaltatasId, visitVM.Idopont));
        }

        public void Delete(int id)
        {
            var visit = db.visits.Find(id);

            if (visit != null)
            {
                if (IsEarlier(visit.Idopont.Year, visit.Idopont.Month, visit.Idopont.Day))
                {
                    throw new Exception("Korábbi orvosi rendelések adatai nem törölhetők.");
                }

                db.visits.Remove(visit);
            }
        }

        public void Update(VisitVM param)
        {
            var visit = db.visits.Find(param.VisitId);
            var korabbiIdopont = visit.Idopont;

            if (visit != null)
            {
                if (IsEarlier(korabbiIdopont.Year, korabbiIdopont.Month, korabbiIdopont.Day))
                {
                    throw new Exception("Korábbi orvosi rendelés adatai nem módosíthatók.");
                }

                if (IsEarlier(param.Idopont.Year, param.Idopont.Month, param.Idopont.Day))
                {
                    throw new Exception("Korábbi időpontra nem módosítható a rendelés.");
                }

                db.Entry(visit).CurrentValues.SetValues(param);
            }
        }

        private bool IsEarlier(int year, int month, int day)
        {
            return year < DateTime.Now.Year ||
                   month == DateTime.Now.Month && day < DateTime.Now.Day
                   || month < DateTime.Now.Month;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public double GetHaviBevetel(int honap)
        {
            var haviBevetel = 0.0;

            foreach (var visit in db.visits.ToList())
            {
                if (visit.Idopont.Month == honap)
                {
                    haviBevetel += visit.service.Egysegar;
                }
            }

            return haviBevetel;
        }

        public double GetOsszesBevetel()
        {
            var osszesBevetel = 0.0;

            foreach (var visit in db.visits.ToList())
            {
                osszesBevetel += visit.service.Egysegar;
            }

            return osszesBevetel;
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
