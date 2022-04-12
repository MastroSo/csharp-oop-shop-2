using Csharp_Shop_2;

Acqua miaAcqua = new Acqua("Nepi", "Acqua leggermente frizzante", 1.5, 7, "Nepi", 3.00, 22);

miaAcqua.StampaDati();
miaAcqua.Bevi(1);
miaAcqua.Riempi(0.5);
Acqua.DaLitriAGalloni("2");

CiboInScatola mioCibo = new CiboInScatola("Scatoletta di tonno", "Tonno al naturale", 300);
mioCibo.Mangia(200);
mioCibo.StampaDati();

Elettrodomestico mioElettrodomestico = new Elettrodomestico("Lg", "Lavatrice", 2021, "Bianco");
mioElettrodomestico.AssegnaCodiceMatricola("0923454");
mioElettrodomestico.StampaDati();

SacchettoFrutta mioSacchetto = new SacchettoFrutta("Equilibra", "Frutta mista", 5);
mioSacchetto.ComponiSacchetto();