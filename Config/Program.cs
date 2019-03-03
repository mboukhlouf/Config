using System;
using System.IO;

using ConfigLib;

namespace ConfigExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Config config;
            if (!File.Exists("config.json"))
            {
                Console.WriteLine("Coudln't find config.json file.");
                config = new Config();
                File.WriteAllText("config.json", config.ToJson());
                Console.WriteLine("A config.json file was just created, please fill it and run the program again.");
                Console.Read();
                return;
            }

            String configJson = File.ReadAllText("config.json");
            config = Config.ParseFromJson(configJson);

            Console.WriteLine(config);
        }
    }
}
