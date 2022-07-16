bool isInt = false;
int menuChoice = 0;
int count = 1;
int groceryInput = 0;
decimal total = 0m;
int addRemoveCheckInput = 0;
string input = " ";
int groceryViewInput = 0;

Dictionary<string, decimal> groceryChoices = new Dictionary<string, decimal>()
{
    {"Eggs", 1.50m },
    {"Bread", 0.99m },
    {"Cheese", 1.25m },
    {"Butter", 1.10m },
    {"Toothpaste", 2.50m },
    {"Laundry Detergent", 12.75m },
    {"Shampoo", 7.99m },
    {"Handsoap", 4.30m }
};

List<string> shoppingList = new List<string>();


MainMenu();

if(menuChoice > 2 || menuChoice == 0)
{
    do
    {
    Console.WriteLine("Please enter a valid choice.\n");
    Console.WriteLine("Please press any key to return to the main menu.");
    Console.ReadKey();
    Console.Clear();

        MainMenu();
    } while (menuChoice > 2 && menuChoice == 0);

} 

if(isInt == false)
{
    do
    {
    Console.WriteLine("Please enter a valid choice.\n");
    Console.WriteLine("Please press any key to return to the main menu.");
    Console.ReadKey();
    Console.Clear();

        MainMenu();
    } while (isInt == false);
}

if (menuChoice == 1)
{
    GroceryView();
    IfStatements();
    AddRemoveCheck();
}

if (menuChoice == 2)
{
    Console.WriteLine("Goodbye!\n");
    Console.WriteLine("Press any key to exit program.");
}

void RemoveItem()
{
    Console.Clear();
    foreach (KeyValuePair<string, decimal> kvp in groceryChoices)
    {
        Console.WriteLine(count + ". " + kvp.Key + " " + kvp.Value);
        count++;
    }
    count = 1;

    Console.WriteLine("\nYour current shopping list: ");

    foreach (string item in shoppingList)
    {
        Console.WriteLine("*" + item);
    }
    Console.Write("\nSelect a number to remove the item from your list: ");
    groceryInput = int.Parse(Console.ReadLine());

    if (groceryInput == 1)
    {
        if (shoppingList.Contains("Eggs") == true)
        {
            shoppingList.Remove("Eggs");
            Console.Clear();
            Console.WriteLine("You chose eggs");
            total -= groceryChoices["Eggs"];
        }
        else 
        {
            Console.Clear();
            Console.WriteLine("You don't have eggs in your cart!");
        }
    }
    else if (groceryInput == 2)
    {
        if (shoppingList.Contains("Bread") == true)
        {
            shoppingList.Remove("Bread");
            Console.Clear();
            Console.WriteLine("You chose bread");
            total -= groceryChoices["Bread"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You don't have bread in your cart!");
        }
    }
    else if (groceryInput == 3)
    {
        if (shoppingList.Contains("Cheese") == true)
        {
            shoppingList.Remove("Cheese");
            Console.Clear();
            Console.WriteLine("You chose cheese");
            total -= groceryChoices["Cheese"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You don't have cheese in your cart!");
        }
    }
    else if (groceryInput == 4)
    {
        if (shoppingList.Contains("Butter") == true)
        {
            shoppingList.Remove("Butter");
            Console.Clear();
            Console.WriteLine("You chose butter");
            total -= groceryChoices["Butter"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You don't have butter in your cart!");
        }
    }
    else if (groceryInput == 5)
    {
        if (shoppingList.Contains("Toothpaste") == true)
        {
            shoppingList.Remove("Toothpaste");
            Console.Clear();
            Console.WriteLine("You chose toothpaste");
            total -= groceryChoices["Toothpaste"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You don't have toothpaste in your cart!");
        }
    }
    else if (groceryInput == 6)
    {
        if (shoppingList.Contains("Laundry Detergent") == true)
        {
            shoppingList.Remove("Laundry Detergent");
            Console.Clear();
            Console.WriteLine("You chose laundry detergent");
            total -= groceryChoices["Laundry Detergent"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You don't have laundry detergent in your cart!");
        }
    }
    else if (groceryInput == 7)
    {
        if (shoppingList.Contains("Shampoo") == true)
        {
            shoppingList.Remove("Shampoo");
            Console.Clear();
            Console.WriteLine("You chose shampoo");
            total -= groceryChoices["Shampoo"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You don't have shampoo in your cart!");
        }
    }
    else if (groceryInput == 8)
    {
        if (shoppingList.Contains("Handsoap") == true)
        {
            shoppingList.Remove("Handsoap");
            Console.Clear();
            Console.WriteLine("You chose handsoap");
            total -= groceryChoices["Handsoap"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You don't have handsoap in your cart!");
        }
    }

}

void AddRemoveCheck()
{
    Console.WriteLine("\nYour shopping list so far:");
    foreach (string shopping in shoppingList)
    {
        Console.WriteLine("*" + shopping);
    }

    Console.WriteLine("\nYour total so far is: " + total);

    Console.WriteLine("\nWould you like to:");
    Console.WriteLine("1. Add another item");
    Console.WriteLine("2. Remove an item");
    Console.WriteLine("3. Check out");

    addRemoveCheckInput = int.Parse(Console.ReadLine());

    if (addRemoveCheckInput == 1)

    {
        while (addRemoveCheckInput == 1)
        {
            Console.Clear();
            GroceryView();
            IfStatements();
            AddRemoveCheck();
        }
    }

    if (addRemoveCheckInput == 2)
    {
        while (addRemoveCheckInput == 2)
        {
            Console.Clear();
            RemoveItem();
            AddRemoveCheck();
        }
    }

    if (addRemoveCheckInput == 3)
    {
        Console.Clear();
        Console.WriteLine("Your final shopping list is: \n");

        foreach (string shopping in shoppingList)
        {
            Console.WriteLine("*" + shopping);
        }

        Console.WriteLine("\nYour total is: " + total);
    }
}

void IfStatements()
{
    if (groceryInput == 1)
    {
        if (shoppingList.Contains("Eggs") == false)
        {
            shoppingList.Add("Eggs");
            Console.Clear();
            Console.WriteLine("You chose eggs");
            total += groceryChoices["Eggs"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You already have eggs on the list!");
        }
    }
    else if (groceryInput == 2)
    {
        if (shoppingList.Contains("Bread") == false)
        {
            shoppingList.Add("Bread");
            Console.Clear();
            Console.WriteLine("You chose bread");
            total += groceryChoices["Bread"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You already have bread on the list!");
        }
    }
    else if (groceryInput == 3)
    {
        if (shoppingList.Contains("Cheese") == false)
        {
            shoppingList.Add("Cheese");
            Console.Clear();
            Console.WriteLine("You chose cheese");
            total += groceryChoices["Cheese"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You already have Cheese on the list!");
        }
    }
    else if (groceryInput == 4)
    {
        if (shoppingList.Contains("Butter") == false)
        {
            shoppingList.Add("Butter");
            Console.Clear();
            Console.WriteLine("You chose butter");
            total += groceryChoices["Butter"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You already have butter on the list!");
        }
    }
    else if (groceryInput == 5)
    {
        if (shoppingList.Contains("Toothpaste") == false)
        {
            shoppingList.Add("Toothpaste");
            Console.Clear();
            Console.WriteLine("You chose toothpaste");
            total += groceryChoices["Toothpaste"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You already have toothpaste on the list!");
        }
    }
    else if (groceryInput == 6)
    {
        if (shoppingList.Contains("Laundry Detergent") == false)
        {

            shoppingList.Add("Laundry Detergent");
            Console.Clear();
            Console.WriteLine("You chose Laundry Detergent");
            total += groceryChoices["Laundry Detergent"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You already have laundry detergent on the list!");
        }
         
    }
  
    
    else if (groceryInput == 7)
    {
        if (shoppingList.Contains("Shampoo") == false)
        {
            shoppingList.Add("Shampoo");
            Console.Clear();
            Console.WriteLine("You chose shampoo");
            total += groceryChoices["Shampoo"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You already have shampoo on the list!");
        }
    }
    else if (groceryInput == 8)
    {
        if (shoppingList.Contains("Handsoap") == false)
        {
            shoppingList.Add("Handsoap");
            Console.Clear();
            Console.WriteLine("You chose handsoap");
            total += groceryChoices["Handsoap"];
        }
        else
        {
            Console.Clear();
            Console.WriteLine("You already have handsoap on the list!");
        }
    }
}

void GroceryView()
{

        Console.Clear();
        foreach (KeyValuePair<string, decimal> kvp in groceryChoices)
        {
            Console.WriteLine(count + ". " + kvp.Key + " " + kvp.Value);
            count++;
        }
        count = 1;

        Console.WriteLine("\nYour current shopping list: ");

        if (shoppingList.Count == 0)
        {
            Console.WriteLine("Your list is empty!");
        }
        else
        {
            foreach (string shopping in shoppingList)
            {
                Console.WriteLine("*" + shopping);
            }
        }

        Console.Write("\nWhich item do you want to add? ");

 

        try
        {
            groceryInput = int.Parse(Console.ReadLine());
            IfStatements();

    }
        catch (Exception e)
        {
            Console.WriteLine("\nPlease enter a valid option. Press any key to restart.");
            Console.ReadKey(); 
            GroceryView();
        }

        while (groceryInput > 8 || groceryInput == 0)
        {
        Console.WriteLine("Please enter a valid option. Press any key to retry.");
        Console.ReadKey();
        GroceryView();
        }
    }
    


void MainMenu()
{

        Console.WriteLine("Welcome to your shopping list!\n");
        Console.WriteLine("What would you like to do?\n");

        Console.WriteLine("1. View Available Groceries");
        Console.WriteLine("2. Exit Program");

        input = Console.ReadLine();

        isInt = int.TryParse(input, out menuChoice);

        Console.Clear();
}

Console.ReadKey();