using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_2
{
    internal class EventOrganizer
    {
        public EventOrganizer() { }

        public void StageDecoration()
        {
            Console.WriteLine("Stage Decorated !!");
        }

        async public Task DropRawMaterialToTheVenue()
        {
            Console.WriteLine("Food Raw materials Are In Transist");
            await Task.Delay(2000);
            Console.WriteLine("Food Raw materials Droped In the Venue");
        }

         public void SecurityCheckup()
        {
            Console.WriteLine("All Clear In The Venue! Good To Go!");
        }

        public void PickUpChiefGuest()
        {
            Console.WriteLine("Car send to pickup chiefguest");
        }

         async public void PrepareFood() {
            Console.WriteLine("Foods Are started To Cook!!");
            await Task.Delay(6000);
            Console.WriteLine("Foods Are Ready To Served");
        }

        public void CheckSpeech()
        {
            Console.WriteLine("Speech Sheet is Verified!");
        }

        async public Task GetPricesToTheVenue()
        {
            await Task.Delay(2000);
            Console.WriteLine("Prices Arrived To The Stage");

        }

        async public Task GuestSpeech()
        {
            Console.WriteLine("Chief Guest Started his speech");
            await Task.Delay(2000);
            Console.WriteLine("Chief Guest Has Finished His Speech");
        }

        async public Task PriceDistibution()
        {
            Console.WriteLine("Price Distribution has Started");
            await Task.Delay(2000);
            Console.WriteLine("Price Distibution Has ended");
        }

        public void FoodDistibution()
        {
            Console.WriteLine("Food Distributed To The guests");
        }
            

    }
}
