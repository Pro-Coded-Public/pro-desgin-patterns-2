using Builder;
using Builder.HouseBuilder;

var director = new HouseDirector();
IHouseBuilder luxuryBuilder = new LuxuryHouseBuilder();
IHouseBuilder ecoFriendlyBuilder = new EcoFriendlyHouseBuilder();

List<string> luxuryAmenities = new List<string> { "Swimming pool", "Home theater" };
List<string> ecoFriendlyAmenities = new List<string> { "Energy-efficient appliances" };

// Construct a luxury house
director.Construct(luxuryBuilder, 5, true, luxuryAmenities);
var luxuryHouse = luxuryBuilder.GetHouse();

// Construct an eco-friendly house
director.Construct(ecoFriendlyBuilder, 3, false, ecoFriendlyAmenities);
var ecoFriendlyHouse = ecoFriendlyBuilder.GetHouse();

// Display house details
Console.WriteLine("Luxury House:");
luxuryHouse.Display();

Console.WriteLine("\nEco-Friendly House:");
ecoFriendlyHouse.Display();

Console.ReadLine();