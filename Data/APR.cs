using RyskTech.Data;
using System.Collections.Generic;

namespace RyskTech
{
    public class APR
    {
        public Unit unit;
        public Lab lab;

        public APR(Unit unit)
        {
            this.unit = unit;
            this.lab = null;
        }

        public APR(Lab lab)
        {
            this.unit = null;
            this.lab = lab;
        }

        public string GetLocationString()
        {
            return unit.location.GetFormattedLocationString();
        }

        public List<string> GetDirectorsFormattedDescriptionList()
        {
            List<string> directors = new List<string>();

            directors.Add(unit.team.director.GetFormattedIndividualString());
            directors.Add(unit.team.director.GetFormattedIndividualString());

            return directors;
        }
    }
}
