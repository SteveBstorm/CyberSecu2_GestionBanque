﻿using GestionBanque.Models;

Personne p1 = new Personne();
p1.Nom = "Pendragon";
p1.Prenom = "Arthur";
p1.DateNaiss = DateTime.Now;

Courant c1 = new Courant();
c1.Numero = "BE1234";
c1.Titulaire = p1;
c1.Depot(500);

Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");

c1.Retrait(200);
Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");
c1.Retrait(500);
Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");

c1.LigneDeCredit = 500;
c1.Retrait(1000);
Console.WriteLine($"Le solde du compte {c1.Numero} de {c1.Titulaire.Nom} est de {c1.Solde}");
