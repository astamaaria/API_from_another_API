using System;
using System.Collections.Generic;
using System.Text;

namespace LainsaadantoService.Libs.Models
{
    public class DataModel
    {
        private string[] ministeriLista = new string[] { "häkkänen", "grahn-laasonen", "mykkänen", "orpo", "virolainen", "berner", "saarikko", "sipilä", "tiilikainen","leppä",
            "vehviläinen","lintilä", "niinistö", "terho", "lindström", "mattila", "soini" };
        public bool liittyLainsaadantoon { get; set; }
        public string tyyppi { get; set; }
        public string tila { get; set; }
        public string nimi { get; set; }
        public string tiivistelma { get; set; }
        public bool rauennut { get; set; }
        private string _vastuuministeri;
        public string vastuuministeri
        {
            get
            {
                if (string.IsNullOrEmpty(_vastuuministeri))
                {
                    return _vastuuministeri;
                }

                else
                {
                    foreach (var item in ministeriLista)
                    {
                        if (_vastuuministeri.ToLower().Contains(item))
                        {
                            if (item.Contains("-"))
                            {
                                int charLocation = item.IndexOf("-");
                                _vastuuministeri = "ministeri " + char.ToUpper(item[0]) + item.Substring(1, charLocation) + char.ToUpper(item[charLocation + 1]) + item.Substring(charLocation + 2);
                                break;
                            }
                            else
                            {
                                _vastuuministeri = "ministeri " + char.ToUpper(item[0]) + item.Substring(1);
                            }
                        }
                    }
                }

                return _vastuuministeri;
            }
            set
            {
                _vastuuministeri = value;
            }
        }


    }
}