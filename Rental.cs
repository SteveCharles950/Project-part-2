using System;

class Rental
 {
  public Book book {get; set;}
  //public DateTime DateRented {get; set;}
  public DateTime DateDue {get; set;}

  
  public Rental(Book Book, DateTime dateDue){
    book = Book;
    DateDue = dateDue;
  }

}