// See https://aka.ms/new-console-template for more information
using KunUz;

KunUzAxborotXizmati kunUzAxborotXizmati = new KunUzAxborotXizmati();
kunUzAxborotXizmati.Xabar = Show;
kunUzAxborotXizmati.XabarlarniChopEtish();

void Show(int xabar){
    Console.WriteLine($"DOLLER KURS: {xabar} so'm");
}

// Uy ishi shuni o'zilar qaytadan qilib kelasizlar