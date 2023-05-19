
using Pilotak;

    internal class prog 
    {
        static void main(string[] args) 
        {
            Beolvasas();
            harmasfeladat();
            negyesfeladat();
            otosfeladat();
        }
        static List<Class1> pilotatomb = new List<Class1>();

        static void Beolvasas()
            {
                StreamReader olvas = new StreamReader("pilotak.csv");
                olvas.ReadLine();
                pilotatomb.Take(1);            
                while (!olvas.EndOfStream)
                {
                    string[] adat = olvas.ReadLine().Split(';');
                    

                if (adat[3] == "") 
                {
                    
                    pilotatomb.Add(new Class1(adat[0], adat[1], adat[2]));
                   
                }
                else
                {
                    pilotatomb.Add(new Class1(adat[0], adat[1], adat[2], int.Parse(adat[3])));
                    
                }
                   

                }

               

                olvas.Close();

            }

        static void harmasfeladat() 
        {
            Console.WriteLine($"3. feladat: {pilotatomb.Count}");
        }

        static void negyesfeladat()
        {
            Console.WriteLine($"4. feladat: {pilotatomb.Last().Nev}");
        }

        static void otosfeladat()
        {
            
            Console.WriteLine("5. feladat:");
           foreach ( var x in pilotatomb )
            {
                string[] datumsplit = x.Szuldate.Split(".");
            if (1901 > int.Parse(datumsplit[0]))
            {
                Console.WriteLine($"\t{x.Nev}({x.Szuldate})");
            }

            }


        }





        
    
    
    
    }



