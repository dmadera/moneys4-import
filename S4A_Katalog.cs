using System;
using System.Collections.Generic;
using System.Text;

using SA_Katalog;
using SkladData;

namespace S4DataObjs {
    class S4A_Katalog : S4_Generic<S5Data> {
        private List<S5DataArtikl> _artikly = new List<S5DataArtikl>();

        private List<S5DataKategorieArtiklu> _kategorie = new List<S5DataKategorieArtiklu>();

        public static string GetID(string id) {
            return "KARTY" + id;
        }

        public S4A_Katalog(string dir, Encoding enc) {
            convertKod(new SkladDataFile(dir, SFile.KOD, enc));
            convertPodKod(new SkladDataFile(dir, SFile.PODKOD, enc));
            convertKarty(new SkladDataFile(dir, SFile.KARTY, enc));
        }

        public override S5Data GetS5Data() {
            return new S5Data() {
                ArtiklList = _artikly.ToArray(),
                KategorieArtikluList = _kategorie.ToArray(),
            };
        }

        private void convertKod(SkladDataFile file) {
            string kategorie, kategorieID;

            foreach (SkladDataObj obj in file.Data) {
                var d = obj.Items;
                kategorie = d["KodZbozi"].GetNum();
                kategorieID = S4_IDs.GetKategorieArtikluID(kategorie);
                if (kategorieID == null) kategorieID = Guid.NewGuid().ToString();

                var cat = new S5DataKategorieArtiklu() {
                    ID = kategorieID,
                    Kod = kategorie,
                    Nazev = d["NazevKodu"].GetText(),
                };
                _kategorie.Add(cat);
            }
        }

        private void convertPodKod(SkladDataFile file) {
            string podkategorie, podkategorieID;

            foreach (SkladDataObj obj in file.Data) {
                var d = obj.Items;

                podkategorie = d["KodZbozi"].GetNum() + d["PodKodZbozi"].GetNum();
                podkategorieID = S4_IDs.GetKategorieArtikluID(podkategorie);
                if (podkategorieID == null) podkategorieID = Guid.NewGuid().ToString();

                var cat = new S5DataKategorieArtiklu() {
                    ID = podkategorieID,
                    Kod = podkategorie,
                    Nazev = d["NazevPOdKodu"].GetText(),
                    ParentObject_ID = _kategorie.Find((a) => { return a.Kod == d["KodZbozi"].GetNum(); }).ID
                };
                _kategorie.Add(cat);
            }
        }

        private void convertKarty(SkladDataFile file) {
            foreach (SkladDataObj obj in file.Data) {
                var d = obj.Items;

                var sazbaDPH = new enum_DruhSazbyDPH() {
                    Value = d["SazbaD"].GetNum() == "21" ?
                        enum_DruhSazbyDPH_value.Item1 :
                        (d["SazbaD"].GetNum() == "15" ?
                            enum_DruhSazbyDPH_value.Item0 :
                            enum_DruhSazbyDPH_value.Item2)
                };

                var mernaJednotka = SkladDataItem.RemoveDiacritics(d["MernaJednotka"].GetNoSpaces().ToLower());
                var jednotkaID = S4_IDs.GetJednotkaID(mernaJednotka);

                var artikl = new S5DataArtikl() {
                    Katalog = GetID(d["CisloKarty"].GetNum()),
                    Nazev = d["NazevZbozi"].GetText(),
                    Poznamka = d["NazevZbozi2"].GetText() + obj.ToString(),
                    // Group = new group() { Kod = "Nezařazené" },
                    PosledniCena = d["NakupCena"].GetDecimal(),
                    DruhArtiklu_ID = S4_IDs.GetDruhZboziID("ZBO"),
                    PLU = d["Pozice"].GetAlfaNum().ToUpper(), 
                    SazbyDPH = new S5DataArtiklSazbyDPH() {
                        ArtiklDPH = new S5DataArtiklSazbyDPHArtiklDPH[] {
                            new S5DataArtiklSazbyDPHArtiklDPH() {
                                SazbaVstup = sazbaDPH,
                                SazbaVystup = sazbaDPH
                            }
                        }
                    }
                };

                if (jednotkaID != "") {
                    artikl.Jednotky = new S5DataArtiklJednotky() {
                        HlavniJednotka = new S5DataArtiklJednotkyHlavniJednotka() {
                            Jednotka_ID = jednotkaID,
                        },
                        NakupniJednotka = new S5DataArtiklJednotkyNakupniJednotka() {
                            Jednotka_ID = jednotkaID,
                        },
                        ProdejniJednotka = new S5DataArtiklJednotkyProdejniJednotka() {
                            Jednotka_ID = jednotkaID,
                        },
                        SeznamJednotek = new S5DataArtiklJednotkySeznamJednotek() {
                            ArtiklJednotka = new S5DataArtiklJednotkySeznamJednotekArtiklJednotka[] {
                                    new S5DataArtiklJednotkySeznamJednotekArtiklJednotka() {
                                        Mnozstvi = "1",
                                        VychoziMnozstvi = "1",
                                        Jednotka_ID = jednotkaID,
                                        Kod = mernaJednotka,
                                        NedelitelneMnozstvi = d["MinFol"].GetBoolean() == "True" ? d["VFol"].GetNum() : null
                                    },
                                    d["VFol"].GetNum() != "0" ? new S5DataArtiklJednotkySeznamJednotekArtiklJednotka() {
                                        Mnozstvi = "1",
                                        VychoziMnozstvi = d["VFol"].GetNum(),
                                        Jednotka_ID = S4_IDs.GetJednotkaID("fol"),
                                        Kod = "fol",
                                        ParentJednotka = new S5DataArtiklJednotkySeznamJednotekArtiklJednotkaParentJednotka() {
                                            Jednotka_ID = jednotkaID
                                        }
                                    } : null,
                                    d["VKart"].GetNum() != "0" ? new S5DataArtiklJednotkySeznamJednotekArtiklJednotka() {
                                        Mnozstvi = "1",
                                        VychoziMnozstvi = d["VKart"].GetNum(),
                                        Jednotka_ID = S4_IDs.GetJednotkaID("kar"),
                                        Kod = "kar",
                                        ParentJednotka = new S5DataArtiklJednotkySeznamJednotekArtiklJednotkaParentJednotka() {
                                            Jednotka_ID = jednotkaID
                                        },
                                    } : null,
                                    d["VPal"].GetNum() != "0" ? new S5DataArtiklJednotkySeznamJednotekArtiklJednotka() {
                                        Mnozstvi = "1",
                                        VychoziMnozstvi = d["VPal"].GetNum(),
                                        Kod = "pal",
                                        Jednotka_ID = S4_IDs.GetJednotkaID("pal"),
                                        ParentJednotka = new S5DataArtiklJednotkySeznamJednotekArtiklJednotkaParentJednotka() {
                                            Jednotka_ID = jednotkaID
                                        }
                                    } : null,
                                }
                        }
                    };
                }

                var priznak = d["Priznak"].GetNoSpaces().ToUpper();
                var priznakID = S4_IDs.GetProduktovyKlicID(priznak);

                if(priznak != "P") {
                    artikl.ProduktoveKlice = priznakID != "" ? new S5DataArtiklProduktoveKlice() {
                        ArtiklProduktovyKlic = new S5DataArtiklProduktoveKliceArtiklProduktovyKlic[] {
                            new S5DataArtiklProduktoveKliceArtiklProduktovyKlic() {                        
                                ProduktovyKlic_ID = priznakID,
                                ProduktovyKlic = new S5DataArtiklProduktoveKliceArtiklProduktovyKlicProduktovyKlic() {
                                    ID = priznakID
                                }
                            }
                        }
                    } : null;
                } else {
                    //přenesená daňová povinnost
                    // artikl.PreneseniDane = new S5DataArtiklPreneseniDane() {

                    // }
                }

                artikl.Dodavatele = d["CisloDodavatele"].GetNum() != "00000" ? new S5DataArtiklDodavatele() {
                    SeznamDodavatelu = new S5DataArtiklDodavateleSeznamDodavatelu() {
                        ArtiklDodavatel = new S5DataArtiklDodavateleSeznamDodavateluArtiklDodavatel[] {
                                new S5DataArtiklDodavateleSeznamDodavateluArtiklDodavatel() {
                                    DodavatelskeOznaceni = new S5DataArtiklDodavateleSeznamDodavateluArtiklDodavatelDodavatelskeOznaceni() {
                                        Kod = d["DodCislo"].GetAlfaNum(),
                                        Nazev = d["DodCislo"].GetText()
                                    },
                                    PosledniCena = d["NakupCena"].GetDecimal(),
                                    Firma = new S5DataArtiklDodavateleSeznamDodavateluArtiklDodavatelFirma() {
                                        Kod = S4A_Adresar.GetDodID(d["CisloDodavatele"].GetNum())
                                    },
                                    Firma_ID = S4A_Adresar.GetDodID(d["CisloDodavatele"].GetNum())
                                }
                            }
                    }
                } : null;

                var kod = _kategorie.Find(k => { return k.Kod == d["KodZbozi"].GetNum(); });
                var podkod = _kategorie.Find(k => { return k.Kod == (d["KodZbozi"].GetNum() + d["PodKodZbozi"].GetNum()); });

                if (kod != null && podkod != null) {
                    artikl.Kategorie = string.Format(
                        "{0}|{1}",
                        kod.ID,
                        podkod.ID
                    );
                }

                artikl.SmazatOstatniDodavatele = "True";
                artikl.SmazatOstatniJednotky = "True";
                artikl.SmazatOstatniSazbyDPH = "True";
                artikl.SmazatOstatniProduktoveKlice = "True";

                _artikly.Add(artikl);
            }
        }


    }
}