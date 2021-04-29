using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Batuzek
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            int velikostBatohu = rnd.Next(15, 50);

            Random radekrnd = new Random();
            

           

            List<item> predmetList = new List<item>();

            //nacitani souboru
            using (var streamReader = new StreamReader(@"D:\Visual\C#\Batuzek\data.csv", Encoding.UTF8))
            {
                if (streamReader.ReadLine() == "Vaha,Cena") 
                {

                    while (!streamReader.EndOfStream)
                    {
                        string[] split = streamReader.ReadLine().Split(",");
                        predmetList.Add(new item(int.Parse(split[1]), int.Parse(split[0])));
                    }
                
                }
            }


            Batoh batoh1 = new Batoh(velikostBatohu);
           
            bool konec = true;

            while (konec)
            {
                int radek = radekrnd.Next(predmetList.Count);
                konec=batoh1.add(predmetList[radek]);
                predmetList.RemoveAt(radek);
                            
            }

            Console.WriteLine("velikost Batohu je: " + velikostBatohu + " KG");
            Console.WriteLine(batoh1);


        }
    }
}
            
        
  
        

