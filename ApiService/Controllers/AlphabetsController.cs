using Microsoft.AspNetCore.Mvc;

namespace ApiService.Controllers;

[ApiController]
[Route("[controller]")]
public class AlphabetsController : ControllerBase{
    public List<Alphabet> alphabets = new List<Alphabet>{
        new Alphabet(1, "A", 1378),
        new Alphabet(2, "B" , 1379),
        new Alphabet(3, "C" , 1380),
    };


    [HttpGet]
    public List<Alphabet> GetAlphabets(){
        return alphabets;
    }

    [HttpGet("{id:int}")]
    public Alphabet GetAlphabetBy(int id){
        return this.alphabets.Find(x=>x.Id==id);
    }

    [HttpPost]
    public List<Alphabet> AddAlphabet([FromBody] Alphabet alphabet){
        this.alphabets.Add(alphabet);
        return alphabets;
    }

}
