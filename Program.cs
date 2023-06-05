using System;

// Restriction/Filtering Operations:Find the words in the collection that start with the letter 'L'
// List<string> fruits = new List<string>() {"Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry"}; //creates the list


// This is a collection called Lfruits that only contains fruits that start with L.
// IEnumerable<string> LFruits = from fruit in fruits 
// where fruit.StartsWith("L")
// select fruit;

// foreach (string singlefruit in LFruits) //we are looping thru the Lfruit collection and then printing them to the screen.
// {
//     Console.WriteLine($"{singlefruit}");
// }


// Restriction/Filtering Operations: Which of the following numbers are multiples of 4 or 6
// List<int> numbers = new List<int>() //creating a list of numbers
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };
// IEnumerable<int> fourSixMultiples = numbers.Where(n => n % 4 == 0 || n % 6 == 0);

// foreach (int num in fourSixMultiples)
// {
//     Console.WriteLine($"{num}");
// }

// Ordering Operations: Order these student names alphabetically, in descending order (Z to A)
// List<string> names = new List<string>() //creates the list
// {
//     "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
//     "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
//     "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
//     "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
//     "Francisco", "Tre"
// };

// List<string> descend = names.OrderByDescending(n => n).ToList(); //creates a new list called descend that orders names from z to a. 

// foreach (string name in descend) //loops through each name in the descend list and prints it in the console. 
// {
//     Console.WriteLine(name);
// }

//  Build a collection of these numbers sorted in ascending order
    // List<int> numbers = new List<int>() //creates a list of numbers. 
    //     {
    //         15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
    //     };

    // List<int> ascend = numbers.OrderBy(n => n).ToList(); // takes that prev list of numbers and creates a new list in order of lowest to highest.

    // foreach (int num in ascend) //loops through ascend list and prints into the console. 
    // {
    //     Console.WriteLine(num);
    // }

//    Aggregate Operations: Output how many numbers are in this list
// List<int> numbers = new List<int>() //creates a list of numbers called numbers.
// {
//     15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
// };

// int HowManyNumbers = numbers.Count(); //howmanynumbers is a variable with the value of the count of numbers in the numbers list. Count function determines the number of items in that numbers list. 

// Console.WriteLine(HowManyNumbers); //prints the value of the variable to the console. 

// How much money have we made?
// List<double> purchases = new List<double>()//creates a list called purchases.
// {
//     2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
// };

// double totalProfit = purchases.Sum();//calculates the total sum of all numbers in purchases list and gives that value to totalProfit variable. 
// double roundedProfit = Math.Round(totalProfit, 2);//takes totalProfit value to 2 dec places and calls it roundedProfit. Math.Round allows us to round a number to a specified number of decimal places. 

// Console.WriteLine(roundedProfit);//prints roundedProfit to the console. 

// What is our most expensive product?
// List<double> prices = new List<double>()//creates new list called prices. 
// {
//     879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
// };

// Console.WriteLine(prices.Max()); //Max function finds the max value in the prices list and prints it to console. 

//Partitioning Operations: Store each number in the following List until a perfect square is detected.

    //Expected output is { 66, 12, 8, 27, 82, 34, 7, 50, 19, 46 } 
    //Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx

//     List<int> wheresSquared = new List<int>()//creates new list called wheresSquared
// {
//     66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
// };

// bool isPerfectSquare(int nmb) //isPerfectSquare is a function that takes the int parameter (nmb) and determines if it's a perfect square.
// {
//     int square = (int)Math.Sqrt(nmb);//calc the square root of the given number with the Math.Sqrt function.
//     return square * square == nmb;//compares the calc sq root with the orig. number. If =, then number is perfect square and it returns true, if not it returns false.
// }

// List<int> storageList = new List<int>(); //Creates new list called storageList to store numbers that aren't perfect squares. 

// foreach (int number in wheresSquared) //loops through each number in wheresSquared list.
// {
//     if (isPerfectSquare(number))//checks if current number is perf squ using the isPerfectSquare func. if it is, loop is exited by the break statement. 
//         break;

//         storageList.Add(number);//adds current numer to storagelist bc it is not perf squ.
// }

// foreach (int number in storageList)//goes thru each number in storageList.
// {
//     Console.Write(number + " ");//prints the number followed by a space to the console. 
// }


//using Custom types : Build a collection of customers who are millionaires.
public class Customer
{
    public string Name { get; set; }//property of customer class that rep name of customer and allows getting and setting its value. 
    public double Balance { get; set; }
    public string Bank { get; set; }
}

public class Bank
{
    public string Name { get; set;}
}

public class Millionaire {
   public string Name { get; set; }
   public string Bank { get; set; }
}

public class Program
{
    public static void Main() {
        List<Customer> customers = new List<Customer>() {//creates customer list that holds the objects of the customer class. 
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

        List<Customer> millionaires = customers.Where(customer => customer.Balance >= 1000000).ToList();//creates a new list called millionaires that only holds customers with balance > a million.The where function is used to filter given the condtion of >than or = to a million. ToList function converts the filtered result to a new list. 

        foreach (var millionaire in millionaires)//loops through each customer obj in millionaires list and then console.writeline prints to consol. 
        {
            Console.WriteLine($"Name: {millionaire.Name}, Bank: {millionaire.Bank}, Balance: {millionaire.Balance}");
        }

        /*
            Given the same customer set, display how many millionaires per bank.
            Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

            Example Output:
            WF 2
            BOA 1
            FTB 1
            CITI 1
        */
 
        var millionaireBank = customers //creates new variable called millionairebank.
                .Where(customer => customer.Balance >= 1000000)//applies a filter to customers list. selects only those customers whose bal is > than or = to a million. 
                .GroupBy(m => m.Bank)//groups the filtered customers by their bank property.creates groups where cust belong to same bank. 
                .Select(group => new {Bank = group.Key, Count = group.Count()});//takes the group of customers, extracts the bank name as the Bank property, counts number of cust in group and stores it as the count property. Resulting in a collection of obj that represent the bank name and count of millionaires in each bank. 

        foreach (var bank in millionaireBank)//starts a loop that goes through each item in the millionaireBank collection.
        {
            Console.WriteLine($"{bank.Bank} {bank.Count}");//prints bank name and count of millionaires to the terminal. 
        }


    }
}
