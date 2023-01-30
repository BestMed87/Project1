string choice1 = "1. Create new account";
string choice2 = "2. Log in your account";
string choice3 = "3. Browse available Itmes";
bool menuLoop = true;
bool appRun = true;
do{
    Console.WriteLine("Welcome to my new App!");
Console.WriteLine("What do you want to do?");
Console.WriteLine(choice1);
Console.WriteLine(choice2);
Console.WriteLine(choice3);
Console.WriteLine("Input selection number:");
var selection = Console.ReadLine();
do{
    if(selection.Equals("1"))
{
    Console.WriteLine($"You chose {choice1}");
    menuLoop = true;
    appRun = false;
}
else if (selection.Equals("2"))
{
    Console.WriteLine($"You chose {choice2}");
    menuLoop = true;
     appRun = false;
}
else if (selection.Equals("3"))
{
    Console.WriteLine($"You chose {choice3}");
    menuLoop = true;
     appRun = false;
}
else{ Console.WriteLine("That is not a valid choice please input a valid seletion");}
} while (menuLoop == false);
}
while(appRun == true);


