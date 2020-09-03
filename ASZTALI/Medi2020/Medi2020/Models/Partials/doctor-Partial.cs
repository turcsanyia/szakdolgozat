using System.Collections.Generic;

namespace Medi2020.Models
{
    public partial class doctor
    {
        public doctor(int id, string vezeteknev, string keresztnev, int szakteruletId, specialization specialization)
        {
            this.Id = id;
            this.Vezeteknev = vezeteknev;
            this.Keresztnev = keresztnev;
            this.SzakteruletId = szakteruletId;
            this.specialization = specialization;
            this.visits = new HashSet<visit>();
        }

        public override string ToString()
        {
            return Vezeteknev + " " + Keresztnev + " (" + specialization.Nev + ")";
        }
    }
}
