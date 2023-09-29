﻿// PA2

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

    // Title Message
    System.Console.WriteLine("Welcome to the Compass!\n  ");
    System.Console.WriteLine(@"
                  N
    ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
    ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣄⠀⠀⠀⠀⣠⡟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
    ⠀⠀⠀⠀⠀⣤⡀⠀⢀⣤⣶⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⡀⣀⣤⣶⡟⠀⠀⠀⠀
    ⠀⠀⠀⠀⠀⠈⣻⣾⣿⣿⣿⡿⠟⠛⠛⠛⠛⠻⢿⣿⣿⣿⡿⣻⡟⠀⠀⠀⠀⠀
    ⠀⠀⠀⠀⠀⣴⣿⣿⣿⠟⠁⠀⠀⠀⠀⢀⣠⣴⣿⣿⡿⠋⣼⣿⣦⠀⠀⠀⠀⠀
    ⠀⢠⣄⣀⣼⣿⣿⡿⠁⠀⠀⠀⣀⣤⣾⣿⣿⣿⡿⠋⢀⣼⢿⣿⣿⣧⣀⣠⡄⠀
    ⠀⠀⠀⠙⣿⣿⣿⠁⠀⠀⠐⣼⠛⢿⣿⣿⡿⠋⠀⢀⡾⠃⠈⣿⣿⣿⠋⠀⠀⠀
  W ⠀⠀⠀⠀⣿⣿⣿⠀⠀⢀⣾⠃⠀⠀⢙⡋⠀⠀⢠⡿⠁⠀⠀⣿⣿⣿⠀⠀⠀⠀ E
    ⠀⠀⠀⣠⣿⣿⣿⡀⢀⡾⠁⠀⢀⣴⣿⣿⣦⣠⡟⠁⠀⠀⢀⣿⣿⣿⣄⠀⠀⠀
    ⠀⠘⠋⠉⢻⣿⣿⣷⡿⠁⢀⣴⣿⣿⣿⡿⠟⠋⠀⠀⠀⢀⣾⣿⣿⡟⠉⠙⠃⠀
    ⠀⠀⠀⠀⠀⢻⣿⡟⢀⣴⣿⣿⠿⠋⠁⠀⠀⠀⠀⢀⣴⣿⣿⣿⡟⠀⠀⠀⠀⠀
    ⠀⠀⠀⠀⠀⣼⢟⣴⣿⣿⣿⣷⣦⣤⣤⣤⣤⣴⣶⣿⣿⣿⡿⣯⡀⠀⠀⠀⠀⠀
    ⠀⠀⠀⠀⣼⠿⠛⠉⠉⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠉⠀⠈⠛⠀⠀⠀⠀⠀
    ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣸⠋⠀⠉⠉⠀⠙⣧⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
    ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
                  S
    "); 

    // Prompts User To Input Number Of Right/Left Turns Made 
    System.Console.WriteLine("Enter the number of right turns you've made: ");
    rightTurns = int.Parse(Console.ReadLine()); 

    System.Console.WriteLine("Enter the number of left turns you've made: ");
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

    // Title Message
    System.Console.WriteLine("This is the Park-Fee system\n "); 

    // Asks User If They Are In An RV or Not
    System.Console.WriteLine("Are you in an RV? (yes/no): "); 
    string rvResponse = Console.ReadLine(); 

    // Asks User For Number Of Attendees
    System.Console.WriteLine("Please enter the number of attendees: ");
    totalAttendees = int.Parse(Console.ReadLine());

    // Calculation For Base Cost; Based On If User Has An RV Or Not
    int baseCost = 0;
    if(rvResponse == "yes")
    {
        baseCost = totalAttendees * amountWithRv;
    }
    else
    {
        baseCost = totalAttendees * amountWithoutRv;
    }

    // Checks For High-Occupancy State Tax
    if(totalAttendees >= 6)
    {
        baseCost += (int)occupancyTax;
    }

    // Asks User For The Number Of Children
    System.Console.WriteLine("Of that total, please enter the number of children: ");
    totalChildren = int.Parse(Console.ReadLine());

    // Calculation For The Child Ticket Discount
    double childDiscountAmount = totalChildren * adultTickets * childDiscount;

    // Calculation For The Federal Tax
    double taxAmount = baseCost * fedTax;

    // Calculation For The Total Amount Due
    amountDue = (int)(baseCost + taxAmount - childDiscountAmount);

    // Asks User To Enter Amount Paid
    System.Console.WriteLine("Please enter the amount paid: ");
    double amountPaid = double.Parse(Console.ReadLine());

    // Checks If The Amount Paid Is Sufficient
    if (amountPaid < amountDue)
    {
        System.Console.WriteLine("Error!! Insufficient payment!!");
    }
    else
    {
        // Calculation For Change
        double change = amountPaid - amountDue;

        // Displays Total Amount Due And Change
        System.Console.WriteLine($"The total amount due is: ${amountDue}");
        System.Console.WriteLine($"Your change is: ${change}");
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
    // Title Message
    string userFeedback = ""; 
    System.Console.WriteLine("You are now in the feedback center. We hope you enjoyed your experience with our application!");

    // Asks User To Leave A Rating On A 1/5 Scale
    System.Console.WriteLine("If you don't mind, please leave a rating: (1/5)");
    userFeedback = Console.ReadLine(); 

    while(userFeedback != "6") 
    {
        switch(userFeedback)
        {
            // Response If Rated "1"
            case "1":
                System.Console.WriteLine("We are so sorry you did not enjoy your experience with our application :(");
                System.Console.WriteLine("");
                System.Console.WriteLine("Please tell us why you rated '1' and how we could improve: ");
                userFeedback = Console.ReadLine();
                Console.Clear();
                break; 

            // Response If Rated "2"
            case "2":
                System.Console.WriteLine("We are so sorry you did not enjoy your experience with our application :(");
                System.Console.WriteLine("");
                System.Console.WriteLine("Please tell us why you rated '2' and how we could improve: ");
                userFeedback = Console.ReadLine(); 
                Console.Clear(); 
                break;

            // Response If Rated "3"
            case "3":
                System.Console.WriteLine("We see that experience could have been better");
                System.Console.WriteLine("");
                System.Console.WriteLine("Please tell us why you rated '3' and how we could improve: ");
                userFeedback = Console.ReadLine(); 
                Console.Clear(); 
                break; 

            // Response If Rated "4"
            case "4":
                System.Console.WriteLine("We are thrilled you enjoyed your experience with our application :) ");
                System.Console.WriteLine("");
                System.Console.WriteLine("Please tell us why you rated '4' and what we could do better: ");
                userFeedback = Console.ReadLine(); 
                Console.Clear(); 
                break;

            // Response If Rated "5"
            case "5":
                System.Console.WriteLine("We are overjoyed that you enjoy experience with our application :) ");
                System.Console.WriteLine("");
                System.Console.WriteLine("Please tell us why are rated '5' and what liked most: ");
                userFeedback = Console.ReadLine();
                Console.Clear(); 
                break; 

                Console.ReadKey();      
        }  
            // Output Message Thanking User For Their Feedback 
            System.Console.WriteLine("We appreciate your feedback. Have a great day!");
            Pause(); 
            DisplayMenu(); 
            return; 
    }      
}

// User Error Message
static void DisplayError()
{
    System.Console.WriteLine("Invalid option, please a valid menu option: "); 
}

// Returns To Menu
static void Pause()
{
    Console.WriteLine("When done, press any key to return to main menu"); 
    Console.ReadKey(); 
    Console.Clear(); 
}