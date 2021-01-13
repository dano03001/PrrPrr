
using System;

class Bil
{
    private string Tillverkare;
    private string Modell;
    private int Year;
    private int Vikt;


    public void setTillverkare(string T) 
    { 
        Tillverkare = T; 
    }

    public string getTillverkare() 
    {
        return Tillverkare; 
    }

    public void setModell(string M) 
    { 
        Modell = M; 
    }

    public string getModell() 
    { 
        return Modell; 
    }

    public void setYear(int Y) 
    { 
        Year = Y; 
    }

    public int getYear() 
    { 
        return Year; 
    }

    public void setVikt(int V) 
    {
        Vikt = V; 
    }

    public int getVikt() 
    { 
        return Vikt; 
    }
}