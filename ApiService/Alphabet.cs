namespace ApiService;
public class Alphabet{
    public int Id{get ;set;}
    public string Name{get; set;}
    public int Year{get; set;}

    public Alphabet(int id, string name, int year){
        Id=id;
        Name=name;
        Year=year;
    }
}