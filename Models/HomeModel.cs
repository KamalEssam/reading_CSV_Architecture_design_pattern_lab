using System;
namespace design_pattern_arch_project.Models
{
    public class HomeModel
    {


        ///<summary>
        /// Gets or sets date.
        ///</summary>
        public int date { set; get; }
        ///<summary>
        /// Gets or sets time.
        ///</summary>
        public int time { get; set; }
        ///<summary>
        /// Gets or sets speed.
        ///</summary>
        public int speed { get; set; }
        ///<summary>
        /// Gets or sets distance.
        ///</summary>
        public int distance { get; set; }
        ///<summary>
        /// Gets or sets describtion.
        ///</summary>
        public string desc { get; set; }
    }
}
