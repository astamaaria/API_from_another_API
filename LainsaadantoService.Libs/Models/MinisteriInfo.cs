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
        public PartyName? Party { get; set; }
        public enum PartyName
        {
            KESKUSTA,
            KOKOOMUS,
            SINISET
        }
    }
}
