using System.Collections.Generic;
using System.Globalization;
using System;

class Author : Person {

private List<Book> books = new List<Book>();
public string Email {get; set;}


public Author ( string fname, string lname, string email) : base (fname, lname){
  Console.WriteLine("Author constructor");
}

}