using System;
using System.Collections.Generic;

class Patron : Person
{
	public string LibraryId {get; set;}
	public DateTime StartDate {get; set;}
	public DateTime EndDate {get; set;}
	public bool IsAccountActive {get; set;}
	public List <Rental> RentalCart = new List<Rental>();
	public int FineAmountDue {get; set;}



public Patron(string fname, string lname, string id): base (fname, lname){
LibraryId = id;
FineAmountDue =0 ;
StartDate = DateTime.Today;
IsAccountActive = true;
}

public override void DisplayInfo(){
//base.DisplayInfo();
  Console.WriteLine("Patron id = "+LibraryId+"  "+ "Name = " + base.FirstName+ " " +base.LastName );
}

public void AddToRentalCart(Book book, DateTime dueDate){
Rental ren1 = new Rental(book, dueDate);

RentalCart.Add(ren1);
Console.WriteLine("Added to rental cart " + book.BookName + " Book " + book.BookId + " for Patron " + base.FirstName + " " + base.LastName);

}

public void RemoveFromRentalCart(Book book){
for (int i = 0; i < RentalCart.Count; i++)
{
if (RentalCart[i].book.BookId.Equals(book.BookId) && RentalCart[i].book.BookName.Equals(book.BookName))
{

RentalCart.RemoveAt(i);
break;
}
}
Console.WriteLine("Removed from rental cart " + book.BookName + " Book " + book.BookId + " for Patron " + base.FirstName + " " + base.LastName);
}

}

