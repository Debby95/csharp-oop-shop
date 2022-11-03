// See https://aka.ms/new-console-template for more information

//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva

using System.ComponentModel;
using System.Net.Http.Headers;



public class Program
{
    private static void Main(string[] args)
    {
        //variabili globali
        Product product = new Product();

        product.Code = "40";
        product.Name = "Keyboard";
        product.Description = "Gaming Keyboard";
        product.Price = 180;
        product.Iva = 10;

        Console.WriteLine("Product code: " + product.Code);
        Console.WriteLine("Product name: " + product.Name);
        Console.WriteLine("Product description: " + product.Description);
        Console.WriteLine("Product price: " + product.Price);

    }
}

public class Product
{
#pragma warning disable CS8618 // Il campo non nullable deve contenere un valore non Null all'uscita dal costruttore. Provare a dichiararlo come nullable.
    public string Code { get; set; }
#pragma warning restore CS8618 // Il campo non nullable deve contenere un valore non Null all'uscita dal costruttore. Provare a dichiararlo come nullable.
#pragma warning disable CS8618 // Il campo non nullable deve contenere un valore non Null all'uscita dal costruttore. Provare a dichiararlo come nullable.
    public string Name { get; set; }
#pragma warning restore CS8618 // Il campo non nullable deve contenere un valore non Null all'uscita dal costruttore. Provare a dichiararlo come nullable.
#pragma warning disable CS8618 // Il campo non nullable deve contenere un valore non Null all'uscita dal costruttore. Provare a dichiararlo come nullable.
    public string Description { get; set; }
#pragma warning restore CS8618 // Il campo non nullable deve contenere un valore non Null all'uscita dal costruttore. Provare a dichiararlo come nullable.
    public int Price { get; set; }
    public double Iva { get; set; }
    
}