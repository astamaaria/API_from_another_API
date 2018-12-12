using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static LainsaadantoService.Libs.Models.MinisteriInfo;

namespace LainsaadantoService.Libs.Models
{
    public class DataModel
    {

        private static List<MinisteriInfo> ministeriInfos;

        public bool liittyLainsaadantoon { get; set; }
        public string tyyppi { get; set; }
        public string tila { get; set; }
        public string nimi { get; set; }
        public string tiivistelma { get; set; }
        public bool rauennut { get; set; }

        public MinisteriInfo vastuuministeri {get; set;}

        public static MinisteriInfo HaeMinisteri(string nimi)
        {
            if (string.IsNullOrEmpty(nimi))
            {
                return new MinisteriInfo();
            }

            var ministeri = ministeriInfos.Where(m => nimi.ToLower().Contains(m.lastName.ToLower())).SingleOrDefault<MinisteriInfo>();
            return ministeri;
        }

        public DataModel()
        {
            if (ministeriInfos == null)
            {

                ministeriInfos = new List<MinisteriInfo>();
                ministeriInfos.AddRange(new List<MinisteriInfo>(){
                    new MinisteriInfo { lastName = "Häkkänen", title = "Oikeusministeri", party = Party.KOKOOMUS },
                    new MinisteriInfo { lastName = "Orpo", title = "Valtiovarainministeri", party = Party.KOKOOMUS },
                    new MinisteriInfo { lastName = "Mykkänen", title = "Sisäministeri", party = Party.KOKOOMUS },
                    new MinisteriInfo { lastName = "Virolainen", title = "Ulkomaankauppa- ja kehitysministeri", party = Party.KOKOOMUS },
                    new MinisteriInfo { lastName = "Grahn-Laasonen", title = "Opetusministeri", party = Party.KOKOOMUS },

                    new MinisteriInfo { lastName = "Berner", title = "Liikenne- ja viestintäministeri", party = Party.KESKUSTA },
                    new MinisteriInfo { lastName = "Saarikko", title = "Perhe- ja peruspalveluministerii", party = Party.KESKUSTA },
                    new MinisteriInfo { lastName = "Sipilä", title = "Pääministeri", party = Party.KESKUSTA },
                    new MinisteriInfo { lastName = "Tiilikainen", title = "Asunto-, energia- ja ympäristöministeri", party = Party.KESKUSTA },
                    new MinisteriInfo { lastName = "Leppä", title = "Maa- ja metsätalousministeri", party = Party.KESKUSTA },
                    new MinisteriInfo { lastName = "Vehviläinen", title = "Kunta- ja uudistusministeri", party = Party.KESKUSTA },
                    new MinisteriInfo { lastName = "Lintilä", title = "Elinkeinoministeri", party = Party.KESKUSTA },

                    new MinisteriInfo { lastName = "Lindström", title = "Työministeri", party = Party.SINISET },
                    new MinisteriInfo { lastName = "Niinistö", title = "Puolustusministeri", party = Party.SINISET },
                    new MinisteriInfo { lastName = "Terho", title = "Eurooppa-, kulttuuri- ja urheiluministeri", party = Party.SINISET },
                    new MinisteriInfo { lastName = "Mattila", title = "Sosiaali- ja terveysministeri", party = Party.SINISET },
                    new MinisteriInfo { lastName = "Soini", title = "Ulkoministeri", party = Party.SINISET }
                });
            }
        }


    }
}