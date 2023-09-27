// See https://aka.ms/new-console-template for more information
using EntityVoiturePersonneAdresse.Context;
using EntityVoiturePersonneAdresse.Entities;
using System.Xml;

Console.WriteLine("Hello, World!");


using (DatabaseContext db = new DatabaseContext())
{

    Personne? p = db.personnes.FirstOrDefault(x => x.Email == "Patoche@email.com");

    Console.WriteLine(p.Adresse.Rue);


}