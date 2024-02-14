using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCloudFileConverter
{
    public class Program
    {

        public static Dictionary<MoleculeType, List<MassPoint>> moleculeDictionary = new Dictionary<MoleculeType, List<MassPoint>>();


        static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                Console.WriteLine("Usage : PointCloudFileConverter.exe PathToFileToConvert [PathToFolder=\"./\"] [PointPerFile=32768] ");
                return;
            }

            string pathtofile = args[0];
            Console.WriteLine("File to convert : " + pathtofile);

            string folder = "./";
            int pointPerFile = 32768;
            if(args.Length==2)
            {
                folder = args[1];
            }

            if(args.Length==3)
            {
                try
                {
                    pointPerFile = int.Parse(args[2]);
                }
                catch
                {
                    pointPerFile = 32768;
                }
            }

            Console.WriteLine("Convert with these parameters : ");
            Console.WriteLine("Extraction folder : " + Path.GetFullPath(folder));
            Console.WriteLine("Point per file : " + pointPerFile);

            InitDictionary();
            ReadFile(pathtofile);
            CreateFiles(folder, pointPerFile);
        }

        public static void InitDictionary()
        {
            moleculeDictionary = new Dictionary<MoleculeType, List<MassPoint>>();
            foreach (var item in Enum.GetValues(typeof(MoleculeType))) 
            {
                Console.WriteLine("Init dictionnary item : " + item.ToString());
                moleculeDictionary.Add((MoleculeType)item, new List<MassPoint>());

            }
        }




        public static void ReadFile(string filePath)
        {

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Input File do not exists");
            }
            Console.WriteLine("Reading file " + filePath);
            StreamReader csvreader = new StreamReader(filePath);
            string inputLine = "";

            char inputSeparator = '\t';


            while ((inputLine = csvreader.ReadLine()) != null)
            {
                //Console.WriteLine(inputLine);
                if (inputLine.Contains(";"))
                {
                    inputSeparator = ';';
                }

                string[] lineContent = inputLine.Split(inputSeparator);

                MassPoint mp = new MassPoint()
                {
                    X = (float) double.Parse(lineContent[0], CultureInfo.InvariantCulture),
                    Y = (float)double.Parse(lineContent[1], CultureInfo.InvariantCulture),
                    Z = (float)double.Parse(lineContent[2], CultureInfo.InvariantCulture),
                    M = (float)double.Parse(lineContent[3], CultureInfo.InvariantCulture),
                };

                moleculeDictionary.TryGetValue(mp.GetMolecule(), out List<MassPoint> pointList);

                pointList.Add(mp);
            }
            Console.WriteLine("Reading file done !");


            Console.WriteLine("Content : ");

            foreach (var item in moleculeDictionary)
            {

                Console.WriteLine("Molecule type : " + item.Key.ToString() + " : " + item.Value.Count);
            }
        }


        public static void CreateFiles(string folderPath, int pointperfile)
        {
            Console.WriteLine("Creating files !");

            int fileindex = 0;

            foreach (var item in moleculeDictionary)
            {
                Console.WriteLine("Writing " + item.Key.ToString() + " " + item.Value.Count);
                int currentPoint = 0;
                
                int currentIndex = 0;


                string[] content = new string[pointperfile];
                while (currentPoint < item.Value.Count)
                {
                    content[currentIndex] = item.Value[currentPoint].ToCsv();


                    if (currentPoint == item.Value.Count - 1)
                    {
                        //On est en bout de liste, on ecrit un fichier

                        string filename = folderPath + "/" + item.Key.ToString() + "_" + fileindex + ".txt";
                        File.WriteAllLines(filename, content.ToList().GetRange(0, currentIndex));
                        currentIndex = 0;
                    }
                    else
                    {
                        if (currentIndex == pointperfile - 1)
                        {
                            Console.WriteLine("Writing file " + fileindex);
                            string filename = folderPath + "/" + item.Key.ToString() + "_" + fileindex + ".txt";
                            File.WriteAllLines(filename, content);
                            fileindex++;
                            currentIndex = 0;
                        }
                        else
                        {
                            currentIndex++;
                        }
                    }
                    currentPoint++;
                }

                //il faut écrire le dernier fichier !

            }
        }




    }
}
