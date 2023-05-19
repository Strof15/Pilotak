


namespace Pilotak 
{
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
        
        static List<string> valami;

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
                    adat[3] = "";
                    pilotatomb.Add(new Class1(adat[0], adat[1], adat[2], int.Parse(adat[3])));
                   
                }
                else
                {
                    pilotatomb.Add(new Class1(adat[0], adat[1], adat[2], int.Parse(adat[3])));
                    
                }
                     valami = adat[1].Split(".").ToList();

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
           
            string[] otoshoztomb = pilotatomb.Count.ToString().Split(".");
            if (valami[0])
            {
                

            }


        }





        
    
    
    
    }


}
