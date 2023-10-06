using System;
using System.IO;
using System.Collections.Generic;
using FilesTestes.Entities;

class Program {


    static void Main(string[] args) {


        string path = @"c:\AMD\Aula\Atv.csv";
        string pathCreateDirectory = @"c:\AMD\Aula\Out";
        string pathCreateFile = @"c:\AMD\Aula\Out\Sumary.csv";
       
        StreamReader sr;
        List<SumProcess> sm = new List<SumProcess>();
        try {

            Directory.CreateDirectory(pathCreateDirectory);

            string name;
            int quanty;
            double price;

            using (sr = new StreamReader(path)) { 
            
                while( !sr.EndOfStream ) {

                    string[] line = sr.ReadLine().Split(",");
                    name = line[0];
                    quanty = int.Parse(line[1]);
                    price = double.Parse(line[2]);
                    
                    sm.Add(new SumProcess(name, price, quanty));
                }
            }
            
            File.Create(pathCreateFile).Close();
            using (StreamWriter sw = new StreamWriter(pathCreateFile)){ 
            
                foreach(SumProcess line in sm) {

                    line.totalPrice();
                    sw.WriteLine(line.ToString());
                }
            
            }

        }
        catch (IOException ex) {

            Console.WriteLine("Error: " + ex.Message);
        }



    }
}