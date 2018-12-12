using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LainsaadantoService.Libs.Models
{
    public class MinisteriInfo
    {

        public string lastName { get; set; }
        public string title { get; set; }
        public Party? party { get; set; }
        public enum Party
        {
            KESKUSTA,
            KOKOOMUS,
            SINISET
        }
    }
}
