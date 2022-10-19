//Christopher Prado
//09-07-2022
//Mini Challenge #2 "Add 2 numbers"
//We have a challenge where we want to add two numbers
//We wil take the users input and add those numbers
//And display the sum in the console 

//Must add #DataValidation and #PlayAgain feature 
//DataValidation Example in original MiniChallengeGuessIT

Console.Clear();

Console.WriteLine("Let's add two numbers!");
Console.WriteLine("Enter your first number");
string numberOne = Console.ReadLine();

Console.WriteLine("Enter your second number:");
string numberTwo = Console.ReadLine();

int num1 = Convert.ToInt32(numberOne);
int num2 = Convert.ToInt32(numberTwo);



Console.WriteLine("Your sum is:" + (num1 + num2));

