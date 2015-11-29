using System; /*Kazva na PC da izpolzva tazi biblioteka i neinite vyzmojnosti v programata*/


namespace CSharp
{
    class HelloCSharp /*Klasyt e edinica, v koqto se namirat parcheta kod. Mojem da gi izpolzvame v drugi blokcheta kod i obiknoveno stoqt
        v drugi failove. Vseki class ima otdelni blokcheta kod (otdolu).*/
    {
        static void Main() /*absolutno zadyljitelno pole i trqbva da e Main! Tova pokazva na PC nachalnata tochka na koda.*/
        {

            Console.WriteLine("Hello there!"); /*Tuk veche sa otdelnite komandi. Razdelqt se s ; . Tochkata . mejdu Console i Writeline
            kazva na PC: vzemi konzolata i v neq napishi "Hello there!" */

            /*Otdolu vkarvame 2 chisla v konzolata i gi stepenuvame (chislo A na stepen chislo B).
            Konzolata chete SAMO TEKST, zatova trqbva da se konvertira v chislo chrez A=int.Parse i vyvedenoto kato tekst v konzolata.
            
            Natiskane na ctrl + . pri preimenuvane na promelniva ili class ni pozvolqva da q preimenuvame navsqkyde v koda.
            Natiskane na ctrl + F5 ni startira i izpylnqva koda.
            Natiskane na F10 ni vkarva v Debug mode.*/

            int A;
            string NumberOne = Console.ReadLine();
            A = int.Parse(NumberOne);

            int B;
            string NumberTwo = Console.ReadLine();
            B = int.Parse(NumberTwo);

            Console.WriteLine(Math.Pow(A, B));

        }
    }
}
