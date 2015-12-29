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


            //Deklarirane na tip danni i konvertirane v drug tip

            object MyNumber = 100;
            Console.WriteLine("The value of My Number is {0}", MyNumber);

            MyNumber = "5";
            Console.WriteLine("The value of My Number is {0}", MyNumber);
            /* Tipa object e nai-glavniq, bazov tip danni. Ako se opitame prosto da mu dobavim danni ot tip string ("5"), toi
            shte sraboti i shte izvadi stoinost. Na object tip danni, obache, ne sa prisyshti matematicheski znaci.

            Otdolu se pokazva konvertirane (ili pridavane) na stoinost ot tip string na tip byte. 
            Tova stava s pomoshta na Parse. Ako izpisnem byte NewNum = "2", to tova ne raboti.
            Za da sraboti, pravim slednoto...*/

            byte NewNum = 250;
            Console.WriteLine("The value of My Number is {0}", NewNum);

            NewNum = byte.Parse("13");
            Console.WriteLine("The value of My Number is {0}", NewNum);


        }
    }
}
