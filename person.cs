using System;


class Person
  {
        //Auto-implemented properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email {get; set;}
       
      

        /*public Person() 
        {
         
          Console.WriteLine("Person constructor");
        }*/

        public Person(string fname, string lname)
        {
          FirstName = fname;
          LastName = lname;
       
          //Console.WriteLine("Person constructor");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Hello my name is "+ FirstName +" "+ LastName);
        }
      
    }