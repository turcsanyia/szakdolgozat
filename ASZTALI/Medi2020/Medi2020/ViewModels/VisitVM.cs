using System;

namespace Medi2020.ViewModels
{
    public class VisitVM
    {
        public int VisitId { get; set; }
        public DateTime Idopont { get; set; }
        public string BetegTaj { get; set; }
        public string BetegNeve { get; set; }
        public int OrvosId { get; set; }
        public string OrvosNeve { get; set; }
        public int SzolgaltatasId { get; set; }
        public string SzolgaltatasNev { get; set; }

        public VisitVM(int visitId, DateTime idopont, string betegTaj, string betegNeve, int orvosId, string orvosNeve,
            int szolgaltatasId, string szolgaltatasNev)
        {
            VisitId = visitId;
            Idopont = idopont;
            BetegTaj = betegTaj;
            BetegNeve = betegNeve;
            OrvosId = orvosId;
            OrvosNeve = orvosNeve;
            SzolgaltatasId = szolgaltatasId;
            SzolgaltatasNev = szolgaltatasNev;
        }

        public VisitVM(int visitId, DateTime idopont, string betegTaj, string betegNeve, int orvosId, string orvosNeve,
            string szolgaltatasNev)
        {
            VisitId = visitId;
            Idopont = idopont;
            BetegTaj = betegTaj;
            BetegNeve = betegNeve;
            OrvosId = orvosId;
            OrvosNeve = orvosNeve;
            SzolgaltatasNev = szolgaltatasNev;
        }
    }
}
