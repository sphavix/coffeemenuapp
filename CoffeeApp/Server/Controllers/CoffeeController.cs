using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CoffeeApp.Shared;

namespace CoffeeApp.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CoffeeController : ControllerBase
    {
        private List<Coffee> coffees = new()
        {
            new(1, "Black Coffee", "Black coffee is as simple as it gets with ground coffee beans soaked in hot water, served hot. And if you want to sound fancy, you can call black coffee by its proper name: café noir.",
            new string[]{
                "Coffee"
            }),
            new(2, "Latte","As the most popular coffee drink out there, the latte consists of a shot of espresso and steamed milk with just a touch of foam. It can be ordered unflavored or flavored with everything from vanilla to pumpkin spice.",
            new string[]{
                "Espresso" ,
                "Steamed Milk"
            }),
            
            new(3, "Caramel Latte", "If you like lattes with a special flavor, caramel lattes may be the best option to give you an experience of the natural sweetness and creaminess of steamed milk and caramel.",
            new string[]{
                "Espresso" ,
                "Steamed Milk" ,
                "Caramel Syrup"
            }),

            new(4, "Cappuccino", "Cappuccino is a latte made with more foam than steamed milk, often with a sprinkle of cocoa powder or cinnamon on top. Sometimes you can find variations that use cream instead of milk or ones that add flavorings as well.",
            new string[]{
                    "Espresso" ,
                    "Steamed Milk" ,
                    "Foam"
            }),

            new(5, "Americano", "With a similar taste to black coffee, americano consists of an espresso shot diluted with hot water.",
            new string[]{
                    "Espresso" ,
                    "Hot water"
            }),

            new(6, "Espresso", "An espresso shot can be served alone or used as a base for most coffee drinks, such as lattes and macchiatos.",
            new string[]{
                    "Espresso"
            }),

            new(7, "Macchiato", "The macchiato is another espresso-based drink that has a small amount of foam on top. It's the happy middle ground between a cappuccino and a doppio.",
            new string[]{
                "Espresso" ,
                "Foam"
            }),

            new(8, "Chai latte", "If you're looking for a tasty hot drink in the middle of winter, choose the chai latte. The combination of cardamom and cinnamon gives a wonderful taste.",
            new string[]{
                "Tea" ,
                "Milk" ,
                "Ginger" ,
                "Cardamom" ,
                "Cinnamon"
            }),

            new(9, "Hot Chocolate",  "On cold winter days, a cup of hot chocolate makes you feel cozy and happy. It also makes you feel good because it contains energizing caffeine.",
            new string[]{
                    "Chocolate" ,
                    "Milk"
            }),

            new(10, "Matcha Latte", "Matcha latte is a green, healthy coffee drink with finely crushed matcha tea and milk, offering mild sweetness, a unique taste and a mild caffeine kick.",
            new string[]{
                "Matcha Powder" ,
                "Milk" ,
                "Sugar*"
            })
        };

        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var cofee = coffees.Find(o => o.Id == id);

            if(cofee is not null)
            {
                return Ok(cofee);
            }
            return NotFound("Coffee Not Found");
        }

        [HttpGet("List")]
        public ActionResult List()
        {
            return Ok(coffees);
        }
    }
}