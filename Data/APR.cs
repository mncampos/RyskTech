using System.Collections.Generic;
using RyskTech.Data;

namespace RyskTech
{
    static class APR
    {
        public static Unit unit = new Unit();
        public static Lab lab = new Lab();

        public static bool LoadPrevious()
        {
            // TODO Try to load an old version of the form

            return false;
        }

        public static void FetchSpaceInformation()
        {
            // Read any information that has not been filled yet (mostly data view grids)
            //unit_info.spaces = ((UnitMainFormOld)System.Windows.Forms.Application.OpenForms["MainForm"]).getStructureData();
        }

        public static string GetLocationString()
        {
            return unit.location.GetFormattedLocationString();
        }

        public static List<string> GetDirectorsFormattedDescriptionList()
        {
            List<string> directors = new List<string>();

            directors.Add(unit.director.GetFormattedIndividualString());
            directors.Add(unit.viceDirector.GetFormattedIndividualString());

            return directors;
        }
    }
}
