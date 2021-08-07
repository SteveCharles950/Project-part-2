using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

var book1 = new Book(1, "Harry Potter");
var book2 = new Book(2, "James and The Giant Peach");
var book3 = new Book(3, "Matilda");

var pat1 = new Patron("Tim", "Smith", "1111");
var pat2 = new Patron("Ron", "Dahl", "6262");
var pat3 = new Patron("Lisa", "Coving", "`1578");
var pat4 = new Patron("Janche", "Sang", "0807");
var pat5 = new Patron("Penny", "Neisen", "2828");

pat1.AddToRentalCart(book1, DateTime.Parse("8/08/2020"));

pat1.AddToRentalCart(book3, DateTime.Parse("8/15/2020"));

pat1.RemoveFromRentalCart(book3);

pat1.DisplayInfo();


  }
}