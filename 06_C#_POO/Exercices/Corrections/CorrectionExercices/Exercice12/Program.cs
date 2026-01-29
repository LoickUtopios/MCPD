
using Exercice12.Classes;
using Exercice12.Interfaces;

Voiture voiture = new Voiture("Clio 2", "Renault");
VoitureHybride voitureHybride = new VoitureHybride("Yarris", "Toyota");
Hydravion hydravion = new Hydravion("Canard Voisin", "Voisin");

voiture.Demarrer(); 
voitureHybride.Recharger();
hydravion.Naviguer();

Vehicule[] mesVehicules = { voiture, voitureHybride, hydravion }; 

foreach(Vehicule vehi in mesVehicules)
{
    Console.WriteLine(vehi); 

    if(vehi is IMotorise moto)
    {
        moto.Demarrer();
    }

    if(vehi is IElectrique elec)
    {
        elec.Recharger();
    }

    if(vehi is IFlottant flo)
    {
        flo.Naviguer(); 
    }

    if(vehi is IVolant volant)
    {
        volant.Atterir();
        volant.Decoller();
    }
}

