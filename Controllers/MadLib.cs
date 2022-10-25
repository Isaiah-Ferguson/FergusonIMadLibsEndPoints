//Isaiah Keith Ferguson
//10/25/2022
//MadLib End Points
//The user will enter a variaty of words and it will be output into a wacky story.
//Peer Reviewed by:

using Microsoft.AspNetCore.Mvc;

namespace FergusonIMadLibsEndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    [HttpGet]
    [Route("MadLibs/{AnimeTitle}/{Adjective}/{Size}/{Emotion}/{Food}/{Restaurant}/{Celebrity}/{animeCharacter}/{shoe}/{num}/{num1}")]

    public string MadLib(string AnimeTitle, string Adjective, string Size, string Emotion, string Food, string Restaurant, string Celebrity, string AnimeCharacter, string shoe, string num, string num1)
    {
        //So it's a Little easier to read
        //{ANIMETITLE} Is the best {ADJECTIVE} Anime ever!
        //the main character's feet seems kinda {SIZE}
        //I can't believed they named him after {CELEBRITY}
        //The plot had so many twists I can't believe {ANIMECHARACTER} Showed up at the end!
        // did you see when {CELEBRITY} Wore {SHOE}'s I really wish he didn't wear those
        //Honestly it made me kind of {EMOTION}
        //Anyway, {Celebrity} thought that {REALNUM1} + {REALNUM2} was 21 instead of {TruNum} ! what a memer!!
        //I usually watch it at {Restaurant} I go there so often they usually give me free {Food}.

        

        return $"{AnimeTitle} Is the best {Adjective} Anime ever! \n the main character's feet seems kinda {Size} \n I can't believed they named him after {Celebrity} \n The plot had so many twists I can't believe {AnimeCharacter} Showed up at the end! \n did you see when {Celebrity} Wore {shoe}'s I really wish he didn't wear those \n Honestly it made me kind of {Emotion} \n Anyway, {Celebrity} thought that {num1} + {num} was 21! what a memer!! \n I usually watch it at {Restaurant} I go there so often they usually give me free {Food}";
    }
}