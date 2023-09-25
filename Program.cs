
// ***** Main *****

DisplayMenu(); 


// Priming Read
string userChoice = Console.ReadLine(); 

while (userChoice != "5")
{
    RouteEm(userChoice); 
    DisplayMenu(); 
    userChoice = Console.ReadLine(); 
}
// ***** End Main *****

static void DisplayMenu()
{
    System.Console.WriteLine("1: Compass\n2: Park-Fees\n3: Park Events\n4: Leave A Rating Or Review\n5: Exit Application");
}

static void RouteEm(string userChoice)
{
    if(userChoice == "1")
    {
        DisplayCompass(); 
    }
    else
    {
        if(userChoice == "2")
        {
            ParkFees(); 
        }
        if(userChoice == "3") 
        {
            ParkEvents();  
        }
        if(userChoice == "4")
        {
            FeedBackFromExperience(); 
        }
        else
        {
            DisplayError(); 
        }
    }  
}

static void DisplayCompass()
{
    System.Console.WriteLine("Welcome to the Compass!");
    Pause(); 
}

static void ParkFees()
{
    System.Console.WriteLine("This is the Park-Fee system");
    Pause(); 
}

static void ParkEvents()
{
    System.Console.WriteLine("Welcome to the park event calendar! press any key to continue to list continue to event list:"); 
    Pause(); 
}

static void FeedBackFromExperience()
{
    System.Console.WriteLine("You are now in the feedback center"); 
    Pause(); 
}

static void DisplayError()
{
    System.Console.WriteLine("Invalid option, please a valid menu option: "); 
}

static void Pause()
{
    System.Console.WriteLine("Press any key to continue");
    Console.ReadKey(); 
    Console.Clear(); 
}