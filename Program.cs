/* BREIF:
 * 
 * Create a Console Application that asks the user for their name. Welcome 
 * me (Josh) as professor or anyone else as student. 
 * Do this until the user types "exit".
 * 
 */
bool exitStatus = false;
string firstName;
string inputStatus;


do
{
    Console.Write("What is your first name?: ");
    firstName = Console.ReadLine();

    switch (firstName.ToLower())
    {
        case "josh":
            Console.WriteLine("Welcome back, Professor!");
            break;
        default:
            Console.WriteLine("Welcome, Student!");
            break;
    }

    Console.WriteLine("Type Exit to close, or press ENTER to continue");
    inputStatus = Console.ReadLine();
    if (inputStatus.ToLower() == "exit")
    {
        exitStatus = true;
    }

} while (exitStatus == false);