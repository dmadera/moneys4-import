using System;
using System.IO;
using System.Xml.Serialization;

using S_IDs;

namespace S4DataObjs {
    static class S4_IDs {
        private static S5Data _data;

        public static void Deserialize(string input) {
            var serializer = new XmlSerializer(typeof(S5Data));

            using (var stringReader = new StringReader(File.ReadAllText(input))) {
                _data = (S5Data)serializer.Deserialize(stringReader);
            }
        }

        public static string GetArtiklID(string katalog) {
            if (_data == null) throw new Exception("First call Deserialize method.");

            foreach (S5DataArtikl artikl in _data.ArtiklList) {
                if (artikl.Katalog == katalog) {
                    return artikl.ID;
                }
            }

            return null;
        }

        public static string GetFirmaID(string kod) {
            if (_data == null) throw new Exception("First call Deserialize method.");

            foreach (S5DataFirma firma in _data.FirmaList) {
                if (firma.Kod == kod) {
                    return firma.ID;
                }
            }

            return null;
        }

        public static string GetSkladID(string kod) {
            if (_data == null) throw new Exception("First call Deserialize method.");

            foreach (S5DataSklad sklad in _data.SkladList) {
                if (sklad.Kod == kod) {
                    return sklad.ID;
                }
            }

            return null;
        }

        public static string GetSazbaDPHID(string sazba) {
            if (_data == null) throw new Exception("First call Deserialize method.");

            foreach (S5DataSazbaDPH dph in _data.SazbaDPHList) {
                if (dph.Sazba.StartsWith(sazba)) {
                    return dph.ID;
                }
            }

            return null;
        }

        public static string GetTypSpojeniID(string kod) {
            if (_data == null) throw new Exception("First call Deserialize method.");

            foreach (S5DataTypSpojeni spojeni in _data.TypSpojeniList) {
                if (spojeni.Kod == kod) {
                    return spojeni.ID;
                }
            }

            return null;
        }

        public static string GetFunkceOsobyID(string kod) {
            if (_data == null) throw new Exception("First call Deserialize method.");

            foreach (S5DataFunkceOsoby funkceOsoby in _data.FunkceOsobyList) {
                if (funkceOsoby.Code == kod) {
                    return funkceOsoby.ID;
                }
            }

            return null;
        }

        public static string GetStatID(string kod) {
            if (_data == null) throw new Exception("First call Deserialize method.");

            foreach (S5DataStat stat in _data.StatList) {
                if (stat.Kod == kod) {
                    return stat.ID;
                }
            }

            return null;
        }

        public static string GetZpusobPlatbyID(string kod) {
            if (_data == null) throw new Exception("First call Deserialize method.");

            foreach (S5DataZpusobPlatby zpusobPlatby in _data.ZpusobPlatbyList) {
                if (zpusobPlatby.Kod == kod) {
                    return zpusobPlatby.ID;
                }
            }

            return null;
        }

        public static string GetJednotkaID(string kod) {
            if (_data == null) throw new Exception("First call Deserialize method.");

            foreach (S5DataJednotka jednotka in _data.JednotkaList) {
                if (jednotka.Kod == kod) {
                    return jednotka.ID;
                }
            }

            return null;
        }

        public static string GetDruhZboziID(string kod) {
            if (_data == null) throw new Exception("First call Deserialize method.");

            foreach (S5DataDruhArtiklu druhZbozi in _data.DruhArtikluList) {
                if (druhZbozi.Kod == kod) {
                    return druhZbozi.ID;
                }
            }

            return null;
        }
    }
}