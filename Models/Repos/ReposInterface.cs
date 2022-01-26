using System;
namespace design_pattern_arch_project.Models.Repos
{
    public interface ReposInterface
    {
        // Function to convert kmph to mph
        public double convertKmphTOmph(string kmph);
        // convert speed from Km per hour to Knot per hour 
        public double convertKMPHToKnotPH(string kmph);
        // conveter time 24 hr
        public string convertTo24Hr(string time);
        //converter to data dd.mm.yyyy
        public string convertDate(string date);

    }
}
