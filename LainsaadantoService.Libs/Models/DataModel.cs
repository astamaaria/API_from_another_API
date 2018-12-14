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
                    new MinisteriInfo { LastName = "Häkkänen", Title = "Oikeusministeri", Party = MinisteriInfo.PartyNames[1] , PartyIndex=1},
                    new MinisteriInfo { LastName = "Orpo", Title = "Valtiovarainministeri", Party = MinisteriInfo.PartyNames[1] , PartyIndex=1},
                    new MinisteriInfo { LastName = "Mykkänen", Title = "Sisäministeri", Party = MinisteriInfo.PartyNames[1] , PartyIndex=1},
                    new MinisteriInfo { LastName = "Virolainen", Title = "Ulkomaankauppa- ja kehitysministeri", Party = MinisteriInfo.PartyNames[1] , PartyIndex=1},
                    new MinisteriInfo { LastName = "Grahn-Laasonen", Title = "Opetusministeri", Party = MinisteriInfo.PartyNames[1] , PartyIndex=1},

                    new MinisteriInfo { LastName = "Berner", Title = "Liikenne- ja viestintäministeri", Party=MinisteriInfo.PartyNames[0] , PartyIndex=0},
                    new MinisteriInfo { LastName = "Saarikko", Title = "Perhe- ja peruspalveluministerii", Party=MinisteriInfo.PartyNames[0] , PartyIndex=0},
                    new MinisteriInfo { LastName = "Sipilä", Title = "Pääministeri", Party=MinisteriInfo.PartyNames[0] , PartyIndex=0},
                    new MinisteriInfo { LastName = "Tiilikainen", Title = "Asunto-, energia- ja ympäristöministeri", Party=MinisteriInfo.PartyNames[0] , PartyIndex=0},
                    new MinisteriInfo { LastName = "Leppä", Title = "Maa- ja metsätalousministeri", Party=MinisteriInfo.PartyNames[0] , PartyIndex=0},
                    new MinisteriInfo { LastName = "Vehviläinen", Title = "Kunta- ja uudistusministeri", Party=MinisteriInfo.PartyNames[0] , PartyIndex=0},
                    new MinisteriInfo { LastName = "Lintilä", Title = "Elinkeinoministeri", Party=MinisteriInfo.PartyNames[0] , PartyIndex=0},

                    new MinisteriInfo { LastName = "Lindström", Title = "Työministeri", Party=MinisteriInfo.PartyNames[3] , PartyIndex=2},
                    new MinisteriInfo { LastName = "Niinistö", Title = "Puolustusministeri", Party=MinisteriInfo.PartyNames[3] , PartyIndex=2},
                    new MinisteriInfo { LastName = "Terho", Title = "Eurooppa-, kulttuuri- ja urheiluministeri", Party=MinisteriInfo.PartyNames[3] , PartyIndex=2},
                    new MinisteriInfo { LastName = "Mattila", Title = "Sosiaali- ja terveysministeri", Party=MinisteriInfo.PartyNames[3] , PartyIndex=2},
                    new MinisteriInfo { LastName = "Soini", Title = "Ulkoministeri", Party=MinisteriInfo.PartyNames[3], PartyIndex=2}
                });
            }
        }


    }
}