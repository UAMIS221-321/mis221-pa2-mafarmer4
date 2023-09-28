// PA 2

// ***** Main *****

DisplayMenu(); 
string userChoice = Console.ReadLine(); 

while (userChoice != "5")
{
    RouteEm(userChoice); 
    userChoice = Console.ReadLine(); 
}
// ***** End Main *****

// Menu
static void DisplayMenu()
{
    System.Console.WriteLine(@"
    
    ");
    System.Console.WriteLine("1: Compass\n2: Park-Fees\n3: Park Events\n4: Leave A Rating Or Review\n5: Exit Application");
}

static void RouteEm(string userChoice)
{
    if(userChoice == "1")
        {
            DisplayCompass(); 
        }
    else if(userChoice == "2")
        {
            ParkFees(); 
        }
    else if(userChoice == "3") 
        {
            ParkEvents();  
        }
    else if(userChoice == "4")
        {
            FeedBackFromExperience(); 
        }
    else
        {
            DisplayError(); 
        }  
}

// Compass
static void DisplayCompass()
{
    string direction = ""; 
    int rightTurns = 0; 
    int leftTurns = 0; 

    System.Console.WriteLine("Welcome to the Compass!\n  ");
    System.Console.WriteLine(@"

    ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣄⠀⠀⠀⠀⣠⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣤⡀⠀⢀⣤⣶⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⡀⣀⣤⣶⡟⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠈⣻⣾⣿⣿⣿⡿⠟⠛⠛⠛⠛⠻⢿⣿⣿⣿⡿⣻⡟⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣴⣿⣿⣿⠟⠁⠀⠀⠀⠀⢀⣠⣴⣿⣿⡿⠋⣼⣿⣦⠀⠀⠀⠀⠀
⠀⢠⣄⣀⣼⣿⣿⡿⠁⠀⠀⠀⣀⣤⣾⣿⣿⣿⡿⠋⢀⣼⢿⣿⣿⣧⣀⣠⡄⠀
⠀⠀⠀⠙⣿⣿⣿⠁⠀⠀⠐⣼⠛⢿⣿⣿⡿⠋⠀⢀⡾⠃⠈⣿⣿⣿⠋⠀⠀⠀
⠀⠀⠀⠀⣿⣿⣿⠀⠀⢀⣾⠃⠀⠀⢙⡋⠀⠀⢠⡿⠁⠀⠀⣿⣿⣿⠀⠀⠀⠀
⠀⠀⠀⣠⣿⣿⣿⡀⢀⡾⠁⠀⢀⣴⣿⣿⣦⣠⡟⠁⠀⠀⢀⣿⣿⣿⣄⠀⠀⠀
⠀⠘⠋⠉⢻⣿⣿⣷⡿⠁⢀⣴⣿⣿⣿⡿⠟⠋⠀⠀⠀⢀⣾⣿⣿⡟⠉⠙⠃⠀
⠀⠀⠀⠀⠀⢻⣿⡟⢀⣴⣿⣿⠿⠋⠁⠀⠀⠀⠀⢀⣴⣿⣿⣿⡟⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⣼⢟⣴⣿⣿⣿⣷⣦⣤⣤⣤⣤⣴⣶⣿⣿⣿⡿⣯⡀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⣼⠿⠛⠉⠉⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠉⠀⠈⠛⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⠋⠀⠉⠉⠀⠙⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀

    "); 

    // Prompts User To Input Number Of Right/Left Turns Made 
    Console.Write("Enter the number of right turns you've made: ");
    rightTurns = int.Parse(Console.ReadLine()); 

    Console.Write("Enter the number of left turns you've made: ");
    leftTurns = int.Parse(Console.ReadLine()); 

    int totalTurns = rightTurns - leftTurns;

    if(totalTurns % 4 == 0)
    {
        direction = "North"; 
    }
    else if(totalTurns % 4 == 1 || totalTurns % 4 == -3)
    {
        direction = "East";
    }
    else if(totalTurns % 4 == 2 || totalTurns % 4 == -2)
    {
        direction = "South";
    }
    else if(totalTurns % 4 == 3 || totalTurns % 4 == -1)
    {
        direction = "West";
    }
    
    // Outputs Direction Facing Based On Inputed Number Of Right/Left Turns
    Console.WriteLine($"You are facing {direction}!"); 

    Pause(); 
    DisplayMenu(); 
}

// Visitor Fees 
static void ParkFees()
{
    // Variables For RV Prompt
    string rvResponse = ""; 
    string isInRV = "The cost for having an RV will be $20"; 
    string otherVehicles = "The cost for having your vehicle will be $10"; 

    // Variables For Calculations/Costs 
    int totalAttendees = 0;  
    int amountDue = 0; 
    int amountWithRv = 20; 
    int amountWithoutRv = 10;
    int totalChildren = 0; 
    double childDiscount = 0.20;
    double fedTax = 0.09; 
    double occupancyTax = 5.00; 
    const double adultTickets = 12.00; 
    const double RV_COST = 20.00;
    const double NON_RV_COST = 10.00;  

    System.Console.WriteLine("This is the Park-Fee system\n "); 
    System.Console.WriteLine("Are you in an RV? (yes/no): ");
    rvResponse = Console.ReadLine(); 

    if(rvResponse == "yes")
    {
        System.Console.WriteLine(isInRV);
        if(rvResponse == "yes")
        {
            System.Console.WriteLine("Since you had an RV, your bill so far is: $" + RV_COST);
        }
    }

    if(rvResponse == "no")
    {
        System.Console.WriteLine(otherVehicles);
        if(rvResponse == "no")
        {
            System.Console.WriteLine("Since you did not have an RV, Your bill so far is: $" + NON_RV_COST);
        }
    }

    double baseTicketCost = (rvResponse == "yes") ? RV_COST:NON_RV_COST; 
    double totalCost = (totalAttendees - totalChildren) * baseTicketCost + totalChildren * baseTicketCost * (1 - childDiscount); 

    // Number Of People 
    Console.WriteLine(""); 
    System.Console.WriteLine("How many people in your group?: ");
    totalAttendees = int.Parse(Console.ReadLine()); 


    // Number Of Children & Apply Discount Accordingly
    Console.WriteLine(""); 
    System.Console.WriteLine("Of that total, how many are children?: ");
    totalChildren = int.Parse(Console.ReadLine());
 
    if(totalAttendees >= 6)
    {
       totalCost += occupancyTax; 
    }

    // Provides User With The Amount Due
    System.Console.WriteLine("Total amount due: $" + totalCost);

    // Asks User For The Amount They Paid
    System.Console.WriteLine("\n What is the amount you paid?: ");
    double amountPaid = int.Parse(Console.ReadLine()); 

    if(amountPaid < totalCost)
    {
        Console.WriteLine("Error!! Amount paid is less than the amount owed.");
    }
    else
    {
        Console.WriteLine($"Change due: ${amountPaid - totalCost:F2}");
    }

    // **** Got This If Statement From Google. Could Not Figure Out How To Get Method To Run Properly Otherwise ****
    if(!double.TryParse(Console.ReadLine(), out amountPaid))
    {
        Console.WriteLine("Invalid input. Please enter a valid amount.");
        return;
    }

    Pause(); 
    DisplayMenu(); 
}

// Park Event Calender (Extra)
static void ParkEvents()
{
    System.Console.WriteLine("Welcome to the park event calendar!\n press any key to continue to list continue to event list:");  
    Console.ReadKey(); 
    Console.Clear(); 

    // Asks User To Select A Time and Displays The Events Scheduled And Their Duration
    string timeChoice = " "; 
    System.Console.WriteLine("The park hosts special events throughout the day starting from 9:00am - 5:00pm");
    System.Console.WriteLine("Enter a time: "); 
    timeChoice = Console.ReadLine();

    Pause(); 
    DisplayMenu();      
}

// Leave A Rating Or Review (Extra)
static void FeedBackFromExperience()
{
    System.Console.WriteLine(@"

⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣶⣾⣿⣿⣿⣷⣦⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⢠⣾⣿⠟⠉⠁⠀⠈⠉⠻⢿⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢠⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⢸⣿⣏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠹⣿⣆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠈⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠘⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠸⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠀⠀⠀⠀⠀⣀⣀⣀⣀⣀⣀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣿⣴⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣶⣤⣄⡀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠘⣿⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣿⠿⠿⠟⠛⠛⠛⠋⠉⠉⠉⠉⠉⠉⠛⠿⣿⣿⣿⣿⣦⡀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣀⣤⣤⣤⣤⣄⡀⠀⠀⠙⢿⣿⣿⣿⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣤⣶⣿⣿⠿⠿⠛⠛⠛⠛⠛⠃⠀⠀⠀⠀⢻⣿⣿⡇⠀⠀
⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⣿⡿⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀
⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣿⡀⠀⠀
⠀⠀⣀⣤⣶⣾⣿⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⣿⣿⣿⣿⣷⡄
⠀⣴⣿⣿⠟⠛⠉⠛⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣷⣄⡀⠀⠀⠀⠀⣀⣀⣠⣤⣤⣶⣶⣿⡿⠛⠁⠀⠘⣿⣿⣿
⣸⣿⣿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣾⣿⢿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠛⠉⠁⠀⠀⠀⠀⠀⣹⣿⡿
⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣿⡿⠃⠀⣿⡿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣿⣿⠇
⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣴⣾⡿⠋⠀⠀⠀⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣾⣿⡟⠀
⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣤⣴⣶⣾⣿⠿⠟⠉⠀⠀⠀⠀⠀⢻⣿⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣤⣾⣿⣿⡏⠀⠀
⢸⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠉⠉⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣹⣿⣷⣶⣤⣤⣤⣤⣴⣶⣾⣿⡿⠟⠋⠹⣿⣿⡆⠀
⠈⣿⣿⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣴⣿⡟⠉⠉⠉⠉⠉⠉⠉⠉⠉⠀⠀⠀⠀⠀⢹⣿⣿⠀
⠀⢹⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⣿⣿⠀
⠀⠀⢿⣿⣷⡀⠀⠀⠀⠀⠀⠀⠀⠀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢿⣿⣧⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣿⣿⡟⠀
⠀⠀⠈⢿⣿⣿⣄⡀⠀⠀⠀⠀⠀⣼⣿⣿⣶⣄⡀⠀⠀⠀⠀⠀⠀⠀⠀⠛⢿⣿⣶⣤⣤⣀⣀⣀⣀⣠⣤⣴⣾⣿⣿⠿⠋⠀⠀
⠀⠀⠀⠈⠻⣿⣿⣿⣷⣤⣤⣴⣾⣿⡿⠻⣿⣿⣿⣶⣦⣤⣤⣤⣤⣤⣴⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠿⠛⠋⠁⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠈⠛⠿⢿⣿⣿⡿⠟⠋⠀⠀⠀⠈⠉⠙⠛⠛⠻⠿⠿⠿⠿⠿⠿⠛⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀

    ");
    System.Console.WriteLine("You are now in the feedback center\n  We hope you enjoyed are experience with our application");
    System.Console.WriteLine(" ");

    Pause(); 
    DisplayMenu(); 
}

// User Error Message
static void DisplayError()
{
    System.Console.WriteLine("Invalid option, please a valid menu option: "); 
}

static void Pause()
{
    Console.WriteLine("Press any key to return to main menu"); 
    Console.ReadKey(); 
    Console.Clear(); 
}