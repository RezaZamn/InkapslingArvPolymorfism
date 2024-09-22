using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InkapslingArvPolymorfism
{
    internal class AnswerToTheQuestions
    {
        /*
         13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
         attribut, i vilken klass bör vi lägga det? i klass Bird

         14.F: Om alla djur behöver det nya attributet, vart skulle man lägga det då? i klass Animal

         9.F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
        För att de har inte samma typ och listan tillåter bara objekt av den specifika typen.

        10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans? Animal

        13. F: Förklara vad det är som händer?
        Det skriver ut egenskaperna på varje djur, och för varje djur förutom Bas egenskaperna som finns i Animal klass och skrivs
        även den tillagda och specifika egenskapen.
        I de tre fågeln som har inte implementerat metoden även skrivs ut egenskaperna för att de ärver från Bird.

        17. F: Varför inte?
        För att Animals ärver inte från Dog och därför har inte tillgång till metoden.
        
         
         */
    }
}
