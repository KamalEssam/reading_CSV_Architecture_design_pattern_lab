using System;
namespace design_pattern_arch_project.Models.Repos
{
    public class RepositoryHome:ReposInterface
    {
        public RepositoryHome()
        {

        }
        // Function to convert kmph to mph
        public double convertKmphTOmph(string kmph)
        {
            double newkmph = Double.Parse(kmph);
            newkmph = Math.Round(0.6214 * newkmph / 1.852, 3);
            return newkmph;
        }
        // return convertion resulte 
        public string convertTo24Hr(string time) {

            DateTime Hr1 = System.Convert.ToDateTime(time);
            string newCell = Hr1.ToString("HH:mm:ss");

            return newCell;
        }

        // convert speed from Km per hour to Knot per hour 
        public double convertKMPHToKnotPH(string kmph) {

            double kmphnew = Double.Parse(kmph);
            kmphnew = Math.Round(kmphnew /1.852 , 3);

            return kmphnew;
        }
     
        //converter to data dd.mm.yyyy
        public string convertDate(string date) {
            DateTime Hr1 = System.Convert.ToDateTime(date);

            string newCell = Hr1.ToString("dd.MM.yyyy");
            return newCell;
        }

    }
}
