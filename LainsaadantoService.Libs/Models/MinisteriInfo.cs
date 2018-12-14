using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LainsaadantoService.Libs.Models
{
    public class MinisteriInfo
    {

        public string LastName { get; set; }
        public string Title { get; set; }

        public string Party { get; set; }
        public int PartyIndex { get; set; }
        public static string[] PartyNames = new string[] { "Keskusta", "Kokoomus", "Sosiaalidemokraatit", "Siniset", "Perussuomalaiset", "Vasemmistoliitto", "RKP", "Kristillisdemokraatit" };
       
        
       
    }
}
