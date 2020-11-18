using System;

namespace Övningsuppgifter_2_Campus
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Övning 1.
            Console.WriteLine("Hej, skriv in ett nummer! ");
            int oneNumb = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Skriv in ett nummer till! ");
            int twoNumb = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ok , skriv in ett sista nummer! ");
            int threeNumb = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Du skrev in talen: " + oneNumb + " " + twoNumb + " " + threeNumb + " Tack för din medverkan pappskalle :)");
            */

            /* Övning 2 + 3 forts övning 1.

            Console.WriteLine("Hej, skriv in ett nummer! ");
            int oneNumb = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Skriv in ett nummer till! ");
            int twoNumb = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ok , skriv in ett sista nummer! ");
            int threeNumb = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            int answer = oneNumb + twoNumb + threeNumb;

            Console.WriteLine(answer);

            */
            /* Övning 4 forts & avslut på 1-3*/

            /*
            Console.WriteLine("Hej, skriv in ett nummer! ");
            int oneNumb = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Skriv in ett nummer till! ");
            int twoNumb = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ok , skriv in ett sista nummer! ");
            int threeNumb = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            


            if (oneNumb > twoNumb && oneNumb > threeNumb)
            {
                if (twoNumb > threeNumb)
                {
                    Console.WriteLine(oneNumb + " " + threeNumb +" " + twoNumb);
                }
                else
                {
                    Console.WriteLine(oneNumb + " " + twoNumb + " " + threeNumb);
                }
            }
            if (twoNumb > oneNumb && twoNumb > threeNumb)
            {
                if (oneNumb > threeNumb)
                {
                    Console.WriteLine(twoNumb + " " + oneNumb + " " + threeNumb);
                }
                else
                {
                    Console.WriteLine(twoNumb + " " + threeNumb + " " + oneNumb);
            }   }       
            if (threeNumb > oneNumb && threeNumb > twoNumb)
            {
                if (oneNumb > twoNumb)
                {
                    Console.WriteLine(threeNumb + " " + oneNumb + " " + twoNumb);
                }
                else
                {
                    Console.WriteLine(threeNumb + " " + twoNumb + " " + oneNumb);
                }
            }
             Console.ReadLine();
            
            */
            /*
            Console.WriteLine("Hej, skriv in ett nummer! ");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Skriv in ett nummer till! ");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ok , skriv in ett sista nummer! ");
            int three = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            if (one > two && one > three)
            {
                if (two > three)
                {
                    Console.WriteLine(one + " " + two + " " + three);
                }
                else if (three > two)
                {
                    Console.WriteLine(one + " " + three + " " + two);
                }
            }
            if (two > one && two > three)
            {
                if (one > three)
                {
                    Console.WriteLine(two + one + three);
                }
                else if (three > one)
                {
                    Console.WriteLine(two + " " + three + " " + one);
                }
            }
            if (three > one && three > two)
            {
                if (one > two)
                {
                    Console.WriteLine(three + " " + one + " " + two);
                }
                else if (two > one)
                {
                    Console.WriteLine(three + " " + two + " " + one);
                }
            }

            Console.ReadLine();
            */
            /*
             * 
            Console.WriteLine("Hej, skriv in ett nummer! ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Skriv in ett nummer till! ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ok , skriv in ett sista nummer! ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Clear();


            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                else if (c > b)
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
            }
            if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine(b + " " + a + " " + " " + c);
                }
                else if (c > a)
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
            if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
                else if (b > a)
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }

            Console.ReadLine();

            */
            /*
            Console.WriteLine("Hej, skriv in ett nummer! ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Skriv in ett nummer till! ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ok , skriv in ett sista nummer! ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (y > l && y > x)
            {
                if (l > x)
                {
                    Console.WriteLine(y + " " + l + " " + x);
                }
                else if (x > l)
                {
                    Console.WriteLine(y + " " + x + " " + l);
                }
            }
            if (l > y && l > x)
            {
                if (y > x)
                {
                    Console.WriteLine(l + " " + y + " " + x);
                }
                else if (x > y)
                {
                    Console.WriteLine(l + " " + x + " " + y);
                }
            }
            if (x > y && x > l)
            {
                if (y > l)
                {
                    Console.WriteLine(x + " " + y + " " + l);
                }
                else if (l > y)
                {
                    Console.WriteLine(x + " " + l + " " + y);
                }
            }
            Console.ReadLine();
            */
            /*
            Console.WriteLine("Hej, skriv in ett nummer! ");
            int tR = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Skriv in ett nummer till! ");
            int aR = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ok , skriv in ett sista nummer! ");
            int pR = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (tR > aR && tR > pR)
            {
                if (aR > pR)
                {
                    Console.WriteLine(tR + " " + aR + " " + pR);
                }
                else if (pR > aR)
                {
                    Console.WriteLine(tR + " " + pR + " " + aR);
                }
            }
            if (aR > tR && aR > pR)
            {
                if (tR > pR)
                {
                    Console.WriteLine(aR + " " + tR + " " + pR);
                }
                else if (pR > tR)
                {
                    Console.WriteLine(aR + " " + pR + " " + tR);
                }
            }
            if (pR > tR && pR > aR)
            {
                if (tR > aR)
                {
                    Console.WriteLine(pR + " " + tR + " " + aR);
                }
                else if (aR > tR)
                {
                    Console.WriteLine(pR + " " + aR + " " + tR);
                }
            }
            Console.ReadLine();
            */

            // VÄND PÅ ALLT
            /*
            Console.WriteLine("Hej, skriv in ett nummer! ");
            int one = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Skriv in ett nummer till! ");
            int two = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ok , skriv in ett sista nummer! ");
            int three = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (three < two && three < one)
            {
                if (two < one)
                {
                    Console.WriteLine(three + " " + two + " " + one);
                }
                else if (one < two)
                {
                    Console.WriteLine(three + " " + one + " " + two);
                }
            }
            if (two < one && two < three)
            {
                if (one < three)
                {
                    Console.WriteLine(two + " " + three + " " + one);
                }
                else if (three < one)
                {
                    Console.WriteLine(two + " " + one + " " + three);
                }
            }
            if (one < two && one < three)
            {
                if (two < three)
                {
                    Console.WriteLine(one + " " + two + " " + three);
                }
                else if (three < two)
                {
                    Console.WriteLine(one + " " + three + " " + two);
                }
            }
            Console.ReadLine();

            */

            // Sortera så att mitten värdet skrivs ut först sen högst, sist lägsta värdet.
            /*
            Console.WriteLine("Hej, skriv in ett nummer! ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Skriv in ett nummer till! ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Ok, skriv in ett sista nummer! ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else if (c > b)
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
            }
            if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                else if (c > a)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
            }
            if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
                else if (b > a)
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
            Console.ReadLine();
            */

            // 1.Skapa ett program som ber användaren skriva in 3 nummer
            // 2.Addera talen
            // 3.Skriv ut summan
            // 4.Skriv sedan ut dem i storleks ordning. Störst först

            /*

            Console.WriteLine("Skriv in ett tal ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ett tal till ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in ett sista tal ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine(a + " " + b + " " + c);
                }
                else if (c > b)
                {
                    Console.WriteLine(a + " " + c + " " + b);
                }
            }
            else if (b > a && b > c)
            {
                if (a > c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else if (c > a)
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
            }
            else if (c > a && c > b)
            {
                if (a > b)
                {
                    Console.WriteLine(c + " " + a + " " + b);
                }
                else if (b > a)
                {
                    Console.WriteLine(c + " " + b + " " + a);
                }
            }
               Console.ReadLine();
                */
            // Avancerad uppgift: Skriv ett program som printar ut tians gånger tabell
            /*  BENNYS PSEUDO
             *  För varje i mindre än 11 räkna upp i 
                 för varje j mindre än 11 räkna upp j
                     summan är i gånger j
                     om summan är mindre än 10
                         skriv ut summan i rätt formatering
                     annars
                         skriv ut summan i en annan formatering
                     om j är detsamma som 10
                         infoga en radbrytning
             slut på för*/
            /*
            int sum;

            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    sum = i * j;
                    if (sum <= 10)
                    {
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.Write(sum);
                    }
                    if (j == 10)
                    {
                        Console.WriteLine(" ");
                    }
                }
            }

            Console.ReadLine();
            */



            /* Övning 5 Skapa ett program som tar in två nummer a och b

            Console.WriteLine("Skriv in nummer a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in nummer b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " " + b);
            Console.ReadKey();

            */

            // 6. Värdet av a ska ligga i b och värdet av b ska ligga i a. Variablerna skall byta värde helt enkelt.
            /*
            Console.WriteLine("Skriv in nummer a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in nummer b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a + " " + b);
            Console.ReadKey();

            */
            // 7. Skapa ett program som låter användaren mata in sin ålder
            /*
            Console.WriteLine("Skriv din ålder");
            int age = Convert.ToInt32(Console.ReadLine());
            */
            // 8. Skriv ut hur många år det är till pension
            /*
            Console.WriteLine("Skriv din ålder");
            int age = Convert.ToInt32(Console.ReadLine());
            int pension = 65;
            int years = (pension - age);
            Console.WriteLine("Du har " + years + " kvar till pension");
            */
            /*
            // 9. Fråga användaren om man vill spola fram tiden till pension

            Console.WriteLine("Skriv din ålder");
            int age = Convert.ToInt32(Console.ReadLine());
            int pension = 65;
            int years = (pension - age);
            Console.WriteLine("Vill du spola fram till pensionen?");
            /*

            Console.WriteLine("Skriv din ålder");
            int age = Convert.ToInt32(Console.ReadLine());
            int pension = 65;
            int years = (pension - age);
            Console.WriteLine("Vill du spola fram till pensionen?");
            */

            // 10. Om användaren svarar "Ja" så sätter vi programmet i en loop och ökar värdet år för år tills att personen är 65
            /*
            Console.WriteLine("Skriv din ålder");
            int age = Convert.ToInt32(Console.ReadLine());
            int pension = 65;
            int years = (pension - age);
            Console.WriteLine("Vill du spola fram till pensionen? 1 for yes 0 for no ");

            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                while (pension > age)
                {
                    Console.WriteLine(age);
                    age++;
                }
                Console.WriteLine("65 Du är gammal nog nu grattis!");
            }
            else if (answer == 0)
            {
                Console.WriteLine("Slipp då pappskalle :) ");
            }        

            Console.ReadLine();
            */

            // 11. Vid 65 ska användaren få bestämma om de vill stanna kvar på den åldern eller spola tillbaks tiden
            /*
            Console.WriteLine("Skriv din ålder");
            int age = Convert.ToInt32(Console.ReadLine());
            int pension = 65;
            int years = (pension - age);
            Console.WriteLine("Vill du spola fram till pensionen? 1 for yes 0 for no ");

            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                while (pension > age)
                {
                    Console.WriteLine(age);
                    age++;
                }
                Console.Clear();
                Console.WriteLine("65");
                Console.WriteLine("Vill du stanna på denna ålder eller spola tillbaks tiden?");              
            }
            else if (answer == 0)
            {
                Console.WriteLine("Slipp då pappskalle :) ");
            }

            Console.ReadLine();
            */

            // 12. Presentera dessa val i form av en meny med writeline. "1.Jag vill stanna på denna ålder" eller "2. Jag ångrar mig! Ta mig tillbaks!"
            // 13.Väljer användaren 1 så skriver programmet ut något passande och avslutas
            // 14.Väljer användaren 2 så startar loopen om men dekrementerar värdet år efter år istället.Denna loop ska fortsätta tills att åldern är lika med ursprungsåldern.
            // 15.Skriv något passande och avsluta programmet

            /*
            Console.WriteLine("Skriv din ålder");
            int age = Convert.ToInt32(Console.ReadLine());
            int startAge = age;
            int pension = 65;
            int years = (pension - age);
            Console.WriteLine("Vill du spola fram till pensionen? 1 for yes 0 for no ");

            int answer = Convert.ToInt32(Console.ReadLine());
            if (answer == 1)
            {
                while (pension > age)
                {
                    Console.WriteLine(age);
                    age++;
                }
                Console.Clear();
                Console.WriteLine("65");
                Console.WriteLine("1.Jag vill stanna på denna ålder");
                Console.WriteLine("2. Jag ångrar mig! Ta mig tillbaks!");
                int stay = Convert.ToInt32(Console.ReadLine());
                if (stay == 2)
                {
                    while (age > startAge)
                    {
                        Console.WriteLine(age);
                        age--;
                    }
                    Console.WriteLine("44 Nu är du tillbaks på din startålder.");
                }
                else if (stay == 1)
                {
                    Console.WriteLine("Slipp då pappskalle :(");
                }
            }
            else if (answer == 0)
            {
                Console.WriteLine("Slipp då pappskalle :) ");
            }

            Console.ReadLine();
            */

            // Repetera alla övningar från 1 - 15

            // 1. Skapa ett program som ber användaren skriva in 3 nummer
            // 2.Addera talen
            // 3.Skriv ut summan
            // 4. Skriv sedan ut dem i storleks ordning. Störst först


            /*
            Console.WriteLine("Skriv in tal 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in tal 2: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Skriv in tal 2: ");
            int c = Convert.ToInt32(Console.ReadLine());
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            int sum = a + b + c;
            Console.WriteLine(sum);
            System.Threading.Thread.Sleep(1500);
            Console.Clear();

            if (a > b && a > c)
            {
                if (b > c)
                    Console.WriteLine(a + " " + b + " " + c);
                else if (c > b)
                    Console.WriteLine(a + " " + c + " " + b);
            }
            else if (b > a && b > c)
            {
                if (a > c)
                    Console.WriteLine(b + " " + a + " " + c);
                else if (c > a)
                    Console.WriteLine(b + " " + c + " " + a);
            }
            else if (c > a && c > b)
            {
                if (a > b)
                    Console.WriteLine(c + " " + a + " " + b);
                else if(b > a)
                    Console.WriteLine(c + " " + b + " " + a);
            }
            System.Threading.Thread.Sleep(3000);
            */

            // 5. Skapa ett program som tar in två nummer a och b
            // 6.Värdet av a ska ligga i b och värdet av b ska ligga i a. Variablerna skall byta värde helt enkelt.

            /*

            string a;
            string b;
            Console.WriteLine("Vad heter du? ");
            a = Console.ReadLine();
            Console.WriteLine("Vad heter du i efternamn? ");
            b = Console.ReadLine();
            Console.WriteLine(a + " " + b);
            string temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a + " " + b);
            Console.ReadLine();
            */

            // 7. Skapa ett program som låter användaren mata in sin ålder
            // 8.Skriv ut hur många år det är till pension
            // 9.Fråga användaren om man vill spola fram tiden till pension
            // 10.Om användaren svarar "Ja" så sätter vi programmet i en loop och ökar värdet år för år tills att personen är 65
            // 11.Vid 65 ska användaren få bestämma om de vill stanna kvar på den åldern eller spola tillbaks tiden
            // 12.Presentera dessa val i form av en meny med writeline. "1.Jag vill stanna på denna ålder" eller "2. Jag ångrar mig! Ta mig tillbaks!"
            // 13.Väljer användaren 1 så skriver programmet ut något passande och avslutas
            // 14.Väljer användaren 2 så startar loopen om men dekrementerar värdet år efter år istället.Denna loop ska fortsätta tills att åldern är lika med ursprungsåldern.
            // 15.Skriv något passande och avsluta programmet

            /*
            Console.WriteLine("Hej! hur gammal är du? ");
            int age = Convert.ToInt32(Console.ReadLine());
            int ageSave = age;
            const int ret = 65;
            int left = ret - age;
            Console.WriteLine("Du har " + left + " år kvar till pension");
            Console.WriteLine("Vill du spola fram dina år till pensionen?");
            Console.WriteLine("1. För ja.");
            Console.WriteLine("2. För nej.");
            System.Threading.Thread.Sleep(500);
            
            int yesNo = Convert.ToInt32(Console.ReadLine());

            if (yesNo == 1)
            {
                while (ret >= age)
                {
                    Console.WriteLine(age);
                    age++;
                }
                Console.WriteLine("Du är nu pensionär :)");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Vill du stanna som pensionär eller spola tillbaks tiden? ");
                Console.WriteLine("1.Jag vill stanna på denna ålder.");
                Console.WriteLine("2. Jag ångrar mig! Ta mig tillbaks!");
                int back = Convert.ToInt32(Console.ReadLine());
                
                if (back == 1)
                {
                    Console.WriteLine("Tack för att du deltog, ha en trevlig och lång pension!");
                }
                else if (back == 2)
                {
                    while (age > ageSave)
                    {
                        Console.WriteLine(age);
                        age--;
                    }
                    System.Threading.Thread.Sleep(1000);
                    
                    Console.WriteLine(age + " Nu är du tillbaks på " + age + " år, kör hårt fram till pensionen!");
                    System.Threading.Thread.Sleep(4000);
                    Console.Clear();
                }

            }
            else if (yesNo == 0)
            {
                Console.WriteLine("Slipp då pappskalle :D ");
                System.Threading.Thread.Sleep(2500);
                
            }
            Console.WriteLine("Tack för ditt deltagande programmet avslutas");
            Console.ReadLine();
            */

            
        }
    }
}       
