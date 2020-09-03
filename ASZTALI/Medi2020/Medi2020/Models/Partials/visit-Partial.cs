using System;

namespace Medi2020.Models
{
    public partial class visit
    {
        public visit(int orvosId, string betegTaj, int szolgaltatasId, DateTime idopont)
        {
            this.OrvosId = orvosId;
            this.BetegTaj = betegTaj;
            this.SzolgaltatasId = szolgaltatasId;
            this.Idopont = idopont;
        }

        public visit()
        {

        }
    }
}
