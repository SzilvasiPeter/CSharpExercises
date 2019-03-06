using System;

namespace CSharp.Exercise1
{
    public class Mtable
    {

        static void MultiplicationTable(){
            Random r = new Random();
            int intNumber;
            int leftOperand = 1;

            Console.WriteLine("Please give me a number or press Enter for random number: ");
            string stringNumber = Console.ReadLine();
            if(stringNumber != ""){
                intNumber = Int32.Parse(stringNumber);
            }else{
                intNumber = r.Next(0, 9);
            }
            while(leftOperand != 10){
                Console.WriteLine(leftOperand + " * " + intNumber + " = " + (leftOperand * intNumber));
                leftOperand++;
            }
        }

        static void Calculator(){
            int leftOperand;
            int rightOperand;
            char op;

            Console.WriteLine("Give me your first number: ");
            leftOperand = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Give me your second number: ");
            rightOperand = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("Give me the operator: ");
            op = Char.Parse(Console.ReadLine());

            switch(op){
                case '+':
                    System.Console.WriteLine("Result: " + (leftOperand + rightOperand));
                    break;
                case '-':
                    System.Console.WriteLine("Result: " + (leftOperand - rightOperand));
                    break;
                case '*':
                    System.Console.WriteLine("Result: " + (leftOperand * rightOperand));
                    break;
                case '/':
                    if(rightOperand != 0){
                        System.Console.WriteLine("Result: " + (leftOperand / rightOperand));
                    }
                    else{
                        System.Console.WriteLine("You cannot divided by zero!");
                    }
                    break;
                default:
                    System.Console.WriteLine("Wrong operator!");
                    break;                
            }
        }

        static void RockPaperScissor(){
            int? userInput = null;
            int computerInput;
            int sum;
            int userScore = 0;
            int computerScore = 0;
            Random r = new Random();

            System.Console.WriteLine("----------  Options  ----------");
            System.Console.WriteLine("0: Exit, 1: Rock, 2: Paper, 3: Scissor");
            while(userInput != 0){
                System.Console.WriteLine("Choose from the above options: ");
                userInput = Int32.Parse(Console.ReadLine());
                computerInput = r.Next(1,3);
                System.Console.WriteLine("Computer's input: " + computerInput);
                
                sum = (int) userInput - computerInput;
                if(sum < 0 ){
                    if(sum % 2 == 0){
                        userScore++;
                    }else{
                        computerScore++;
                    }
                }else if(sum > 0){
                    if(sum % 2 == 0){
                        computerScore++;
                    }else{
                        userScore++;
                    }
                }else{
                    userScore++;
                    computerScore++;
                }

                System.Console.WriteLine("Your score: " + userScore);
                System.Console.WriteLine("Computer score: " + computerScore);
            }
        }

        static void guessingGame(){

            Random r = new Random();
            
            START:
            int i = 0;
            int x;
            Console.WriteLine("Choose game mode!");
            Console.WriteLine("1 - You think a number");
            Console.WriteLine("2 - Computer think a number");
            
            switch (Console.ReadKey(true).KeyChar)
            {
                case '1': goto PLAYER;
                case '2': goto COMPUTER;
            }

            PLAYER:
                Console.WriteLine("Think a number! (1 - 100)");
                Console.ReadLine();
                x = 50;
                int min = 0;
                int max = 100;
                while (i < 5){
                    Console.WriteLine("The computer's number is: {0}", x);
                    Console.WriteLine("The number is? (l:less/g:greater/e:equal)");
                switch (Console.ReadKey(true).KeyChar){
                    case 'l':
                        if (i == 3)
                            x = r.Next(min, x);
                        else{
                            max = x;
                            x -= (max - min) / 2;
                        }
                    break;
                case 'g':
                    if (i == 3)
                        x = r.Next(x + 1, max);
                    else{
                        min = x;
                        x += (max - min) / 2;
                    }
                break;
                case 'e':
                    Console.WriteLine("The computer win!");
                    goto END;
                }
                ++i;
            }
            Console.WriteLine("The computer cannot find your number.");
        goto END;
            COMPUTER:
                int number = r.Next(100);
                i = 0;
                while(i < 5){
                    Console.WriteLine("\n My guess: ");
                    x = int.Parse(Console.ReadLine());
                    if(x < number){
                        Console.WriteLine("The number is more!");
                    }
                    else if(x > number){
                        Console.WriteLine("The number is less!");
                    }
                    else{
                        Console.WriteLine("You win!");
                        goto END;
                    }
                    ++i;
                }
                Console.WriteLine("\n You lose the number was: {0}.", number);
            goto END;

            END:
            Console.WriteLine("\n Do you want to play one more? i/n");
            switch (Console.ReadKey(true).KeyChar)
            {
                case 'i': goto START;
                case 'n': break;
            }
        }
        public static void Main(string[] args)
        {
            // MultiplicationTable();
            // Calculator();
            // RockPaperScissor();
            guessingGame();
        }
    }
}