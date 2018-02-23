using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rain_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Dictionary<string, string> typeD = new Dictionary<string, string>();
            Dictionary<string, string> forecastD = new Dictionary<string, string>();
            int br = 0;
            
            string newfore = "";
            string newtype = "";
            string newsource = "";
            
            while (command != "Davai Emo")
            {
                string[] forecast = command.Split(':','!', '.', ',', '?');
                string[] source = command.Split(' ');
                string[] type = command.Split(' ');
                if (br == 0)
                {
                    if (type[0] == "Type:")
                    {
                        if (type[1] == "Normal" || type[1] == "Danger" || type[1] == "Warning")
                        {
                            br++;
                            source = command.Split(' ');
                            newtype = type[1];
                        }
                        
                    }
                    
                }
                if (br == 1)
                {
                    if (source[0] == "Source:")
                    {
                        newsource = source[1];
                        
                        typeD.Add(newsource,newtype);
                        br++;
                    }
                    
                }
                if (br == 2)
                {
                    if (forecast[0] == "Forecast")
                    {
                        newfore = forecast[1];
                        
                        forecastD.Add(newsource, newfore);
                        br = 0;
                        
                    }
                    
                }
                command = Console.ReadLine(); 
            }
            foreach (var cast in typeD)
            {
                Console.WriteLine("({0}){1} ~ {2}", typeD[cast.Key], forecastD[cast.Key], cast.Key);
            }
            
        }
    }
}

//string[] type = command.Split(':','!', '.', ',', '?');
