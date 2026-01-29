using DemoInterface.Classes;
using DemoInterface.Interfaces;

Canard canard = new Canard();
Avion avion = new Avion();

canard.Manger(); 
avion.Decoller();

IVolant[] toutCeQuiVole = { canard, avion };

foreach(IVolant volant in toutCeQuiVole)
{
    volant.Decoller();
    volant.Atterir();
}