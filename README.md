1. Forskellen på double of decimal
Forskellen opstår, fordi `double` gemmer tal som binære flydende tal, hvor tal som 0,1 og 0,2 ikke kan repræsenteres helt præcist. 
`decimal` bruger derimod en decimalbaseret repræsentation og kan derfor gemme disse tal præcist. Forsellen kan koste en virksomhed penge i fx regnskabs-, 
 fakturerings- eller betalingssystemer, hvor mange små afrundingsfejl kan ophobe sig til større beløb.

2.
Forskellen opstår, fordi `double` gemmer tal som binære flydende tal, hvor tal som 0,1 og 0,2 ikke kan repræsenteres helt præcist. 
`decimal` bruger derimod en decimalbaseret repræsentation og kan derfor gemme disse tal præcist. Forsellen kan koste en virksomhed penge i fx regnskabs-, 
fakturerings- eller betalingssystemer, hvor mange små afrundingsfejl kan ophobe sig til større beløb.

3. Her er koden fra del 3, jeg har ikke rettet syntaks, jeg har dog noteret fejelene
   using KodestandardTjekliste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class productCalculator // productCalculator skal være med stort P da det er en klasse
{
    private const decimal DiscountThreshold = 500m;
    private const decimal DiscountRate = 0.15m;

    static void Main(string[] args)
    {
        List<Vare> varer = new List<Vare>();
        bool registrerVare = true;

        while (registrerVare)
        {
            Console.Write("Indtast varenavn:");
            string strProductName = Console.ReadLine();

            Console.Write("Indtast antal varer:");
            string strQuantity = Console.ReadLine();
            int iQuantity = Convert.ToInt32(strQuantity);

            Console.Write("Indtast pris pr. vare:");
            string strPrice = Console.ReadLine();
            decimal dPrice = Convert.ToDecimal(strPrice);

            Vare vare = new Vare(strProductName, iQuantity, dPrice);
            varer.Add(vare);

            Console.WriteLine("Vil du registrere endnu en vare (j/n): ");
            string svar = Console.ReadLine();

            if (svar.ToLower() == "n") registrerVare = false;
        }

        decimal totalPris = 0m;

        foreach (Vare vare in varer)
        {
            decimal vareTotal = vare.BeregnTotalPris();
            totalPris += vareTotal;

            Console.WriteLine($"{vare.Navn}: {vare.Antal} stk. a {vare.Pris} kr. Total: {vareTotal}");
        }

        Console.WriteLine($"Samlet pris: {totalPris} DKK");
        if (totalPris > DiscountThreshold)
        {
            Console.WriteLine($"Total pris over 500 DKK, udløser 15% rabat\nPris efter rabat {totalPris * DiscountRate} DKK");
           
        }
        Console.ReadLine();
    }

    og min class
     internal class Vare
 {
     public string Navn { get; set; } 
     public int Antal { get; set; }
     public decimal Pris { get; set; }

     public Vare(string navn, int antal, decimal pris)
     {
         Navn = navn;
         Antal = antal;
         Pris = pris;
     }

     public decimal BeregnTotalPris()
     {
         return (decimal)Antal * Pris;
     }
 }
    

   
}
