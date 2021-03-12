using System;
using System.Collections.Generic;
using System.Text;

namespace ModelConsoleAPP
{
    class Person
    {//creating person fields
        int personId;
        string firstName;
        string lastName;
        public int height;//default assigned 0
        int weight;
        string colour;
        string status;
    }
   
   { 
    //Making a Constructor
    private Person()
    {
        string firstName = "Ugo";
        string lastName = "Forsblom";
    }
    public string Info()
    return $"Name:(firstName) (lastName)/n (status): {status}/n height : {height}";
    
}
enum status
{
    married,
    single,
    divorcec,
    seperated,
}



    }
}


    }
}
