Console.WriteLine("Ønsker du en ny hobby? Skriv et navn under!");
var name = Console.ReadLine();

var hobby0 = "Fotball";
var hobby1 = "Trylling";
var hobby2 = "Discgolf";
var hobby3 = "Bowling";
var hobby4 = "Gitar";

var rand = new Random();
var randomHobby = rand.Next(0, 5);
if (randomHobby == 0)
    Console.WriteLine($"Javell.. {name}, Da ble det {hobby0} på deg!");
else if (randomHobby == 1)
    Console.WriteLine($"Javell.. {name}, Da ble det {hobby1} på deg!");
else if (randomHobby == 2)
    Console.WriteLine($"Javell.. {name}, Da ble det {hobby2} på deg!");
else if (randomHobby == 3)
    Console.WriteLine($"Javell.. {name}, Da ble det {hobby3} på deg!");
else if (randomHobby == 4) Console.WriteLine($"Javell.. {name}, Da ble det {hobby4} på deg!");