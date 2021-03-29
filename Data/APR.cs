using System.Collections.Generic;

namespace RyskTech
{
    static class APR
    {
        // Chemical, Physical, Biological, Mechanic
        public static bool[] considered_agents = new bool[4];

        public static UnitInformation unit_info = new UnitInformation();
        public static LabInformation lab_info = new LabInformation();

        public static bool LoadPrevious()
        {
            // TODO Try to load an old version of the form

            return false;
        }

        public static void FetchSpaceInformation()
        {
            // Read any information that has not been filled yet (mostly data view grids)
            unit_info.spaces = ((UnitMainFormOld)System.Windows.Forms.Application.OpenForms["MainForm"]).getStructureData();
        }

        public static string GetLocationString()
        {
            string location = "";

            switch (unit_info.location.prefix)
            {
                case LocationPrefix.Rua:
                    location = "Rua ";
                    break;
                case LocationPrefix.Avenida:
                    location = "Avenida ";
                    break;
                case LocationPrefix.Alameda:
                    location = "Alameda ";
                    break;
                case LocationPrefix.Travessa:
                    location = "Travessa ";
                    break;
                case LocationPrefix.Rodovia:
                    location = "Rodovia ";
                    break;
                default:
                    break;
            }

            location += unit_info.location.street_name + ", ";
            location += "número " + unit_info.location.number + ", ";
            location += "bairro " + unit_info.location.neighborhood + ", ";
            location += "complemento " + unit_info.location.complement + ", ";
            location += "CEP " + unit_info.location.ZIP;

            return location;
        }

        public static List<string> GetDirectors()
        {
            string director = "";
            director += "Diretor: " + unit_info.team.director.name;
            director += ", Telefone: " + unit_info.team.director.phone;
            director += ", E-Mail: " + unit_info.team.director.e_mail;

            string vice_director = "";
            vice_director += "Vice-Diretor: " + unit_info.team.vice_director.name;
            vice_director += ", Telefone: " + unit_info.team.vice_director.phone;
            vice_director += ", E-Mail: " + unit_info.team.vice_director.e_mail;

            List<string> directors = new List<string>();
            directors.Add(director);
            directors.Add(vice_director);

            return directors;
        }
    }
}
