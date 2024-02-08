using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Luokkaharjoituksia
{
    internal class Hooman
    {
        // Define properties of Hooman
        public string name = "Essi Esimerkki";

        public string gender = "Omistaja";
        public int age = 30;

        public Hooman()
        {
        }

        public Hooman(string name)
        {
            this.name = name;
        }

        public Hooman(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Hooman(string name, string gender, int age)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
        }

        public void SayOpinion()
        {
            Console.WriteLine("Voi, lemmikit ne on elämän suola");
        }
    }

    internal class Pet
    {
        public string diet = "food";

        public Pet()
        {
        }

        public Pet(string diet)
        {
            this.diet = diet;
        }

        public virtual void SayDiet()
        {
            Console.WriteLine("this pet eats " + diet);
        }
    }

    internal class Hare : Pet
    {
        public new string diet = "carrots";

        public override void SayDiet()
        {
            Console.WriteLine("I'm a bunny and I eat " + diet);
        }
    }

    internal class CatOwner : Hooman
    {
        public new void SayOpinion()
        {
            Console.WriteLine("Kissat ovat itsenäisiä ja pitävät hiiret loitolla");
        }
    }

    internal class DogOwner : Hooman
    {
        public new void SayOpinion()
        {
            Console.WriteLine("Koira on ihmisen paras ystävä");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Hooman owner = new Hooman("Ossi Omistaja", "isäntä", 35);
            // Call the SayOpinion method
            owner.SayOpinion();

            string who = owner.name;
            Console.WriteLine("Totesi " + who);

            CatOwner catOwner = new CatOwner();

            // Use catowners SayOpinion method
            catOwner.SayOpinion();

            DogOwner dogOwner = new DogOwner();
            dogOwner.SayOpinion();

            Pet petOwner = new Pet();
            petOwner.SayDiet();

            Hare hareOwner = new Hare();
            hareOwner.SayDiet();

            // Keep the window opent until enter pressed
            Console.ReadLine();
        }
    }
}