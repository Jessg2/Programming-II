using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4
{
    internal class Engine
    {
        string[] names;
        Person Player;
        Random randomnumber = new Random();
        public List<Person> People = new List<Person>();
        public void Play()
        {
            //app will start here
            Console.WriteLine(GetTextFromExternalFile("../../../data/welcome.txt"));
            names = GetTextElementsFromExternalFile("../../../data/names.txt");
            //Player = new Person(names[randomnumber.Next(names.Length)]);
            //Console.WriteLine($"Your random name is {Player.Name}");
            CreateInstancesFromExternalFile("../../../data/names.txt", "../../../data/items.txt");
            Console.WriteLine($"There are {People.Count} people in the list");
            foreach(Person person in People) { Console.WriteLine(person.Name); }

            Console.WriteLine($"{People[0].Inventory.Count} items in {People[0].Name}'s inventory");
            foreach(Item item in People[0].Inventory)
            {
                Console.WriteLine($"{item.Name}");
            }
        }

        private Item MakeItem(Recipe recipe)
        {
            //for each item in the recipe's requiredItems list...



            return new Item();
        }

        private string GetTextFromExternalFile(string filename)
        {
            string output = "";
            if (File.Exists(filename))
            {
                output = File.ReadAllText(filename);
                if (output == "")
                {
                    return "Data not found";
                }
            }
            else
            {
                output = "File not available";
            }

            return output;

        }

        private string[] GetTextElementsFromExternalFile(string filename)
        {
            string[] _names = File.ReadAllLines(filename);
            //string[] randomnames = {"Joe", "Susan" };
            return _names;
        
        }
        private void CreateInstancesFromExternalFile(string filename)
        {
            string[] _names = File.ReadAllLines(filename);
           
            foreach (string name in _names)
            {
                People.Add(new Person(name));
            }
        }
        private void CreateInstancesFromExternalFile(string filename, string itemlist)
        {
            string[] _names = File.ReadAllLines(filename);
            string[] _items = File.ReadAllLines(itemlist);

            foreach (string name in _names) 
            {
                Person person = new Person(name);
                foreach(string item in _items)
                {
                    person.Inventory.Add(new Item() {Name = item });
                }
                People.Add(person);
            }
        }
        
    }
}
