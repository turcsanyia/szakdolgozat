using System.Collections.Generic;

namespace Medi2020.Models
{
    public partial class patient
    {
        public patient(string taj, string jelszo, string vezeteknev, string keresztnev, int iranyitoszam,
            string telepules,
            string lakcim, string email, string telefon)
        {
            this.Taj = taj;
            this.Jelszo = jelszo;
            this.Vezeteknev = vezeteknev;
            this.Keresztnev = keresztnev;
            this.Iranyitoszam = iranyitoszam;
            this.Telepules = telepules;
            this.Lakcim = lakcim;
            this.Email = email;
            this.Telefon = telefon;
            this.visits = new HashSet<visit>();
        }

        public override string ToString()
        {
            return Vezeteknev + " " + Keresztnev + " (" + Taj + ")";
        }
    }
}
