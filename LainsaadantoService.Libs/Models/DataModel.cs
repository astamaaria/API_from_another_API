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

        public bool LiittyLainsaadantoon { get; set; }
        public string Tyyppi { get; set; }
        public string Tila { get; set; }
        public string Nimi { get; set; }
        public string Tiivistelma { get; set; }
        public bool Rauennut { get; set; }

        public MinisteriInfo Vastuuministeri {get; set;}

        public static MinisteriInfo HaeMinisteri(string nimi)
        {
            if (string.IsNullOrEmpty(nimi))
            {
                return new MinisteriInfo();
            }

            var ministeri = ministeriInfos.Where(m => nimi.ToLower().Contains(m.LastName.ToLower())).SingleOrDefault<MinisteriInfo>();
            return ministeri;
        }

        public DataModel()
        {
            if (ministeriInfos == null)
            {

                ministeriInfos = new List<MinisteriInfo>();
                ministeriInfos.AddRange(new List<MinisteriInfo>(){
                    new MinisteriInfo { LastName = "Häkkänen", Title = "Oikeusministeri", Party = PartyName.KOKOOMUS },
                    new MinisteriInfo { LastName = "Orpo", Title = "Valtiovarainministeri", Party = PartyName.KOKOOMUS },
                    new MinisteriInfo { LastName = "Mykkänen", Title = "Sisäministeri", Party = PartyName.KOKOOMUS },
                    new MinisteriInfo { LastName = "Virolainen", Title = "Ulkomaankauppa- ja kehitysministeri", Party = PartyName.KOKOOMUS },
                    new MinisteriInfo { LastName = "Grahn-Laasonen", Title = "Opetusministeri", Party = PartyName.KOKOOMUS },

                    new MinisteriInfo { LastName = "Berner", Title = "Liikenne- ja viestintäministeri", Party = PartyName.KESKUSTA },
                    new MinisteriInfo { LastName = "Saarikko", Title = "Perhe- ja peruspalveluministerii", Party = PartyName.KESKUSTA },
                    new MinisteriInfo { LastName = "Sipilä", Title = "Pääministeri", Party = PartyName.KESKUSTA },
                    new MinisteriInfo { LastName = "Tiilikainen", Title = "Asunto-, energia- ja ympäristöministeri", Party = PartyName.KESKUSTA },
                    new MinisteriInfo { LastName = "Leppä", Title = "Maa- ja metsätalousministeri", Party = PartyName.KESKUSTA },
                    new MinisteriInfo { LastName = "Vehviläinen", Title = "Kunta- ja uudistusministeri", Party = PartyName.KESKUSTA },
                    new MinisteriInfo { LastName = "Lintilä", Title = "Elinkeinoministeri", Party = PartyName.KESKUSTA },

                    new MinisteriInfo { LastName = "Lindström", Title = "Työministeri", Party = PartyName.SINISET },
                    new MinisteriInfo { LastName = "Niinistö", Title = "Puolustusministeri", Party = PartyName.SINISET },
                    new MinisteriInfo { LastName = "Terho", Title = "Eurooppa-, kulttuuri- ja urheiluministeri", Party = PartyName.SINISET },
                    new MinisteriInfo { LastName = "Mattila", Title = "Sosiaali- ja terveysministeri", Party = PartyName.SINISET },
                    new MinisteriInfo { LastName = "Soini", Title = "Ulkoministeri", Party = PartyName.SINISET }
                });
            }
        }


    }
}