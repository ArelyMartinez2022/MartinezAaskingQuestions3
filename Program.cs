/* See https://aka.ms/new-console-template for more information
ARELY MARTINEZ
OCT 18 2022 3:21 PM
THIS PROGRAM WILL ASK THE USER FOR THEIR 
NAME THEN THE TIME THEY WOKE UP IF THEY 
WOKE UP. THE TEMIAL WILL THEN DISPLAY 
THIER NAME AND WHAT TIME THEY WOKE UP
WHATS UR NAME : ARELY 
WHAT TIME DID U WAKE UP: 7:20PM
EXAMPLE: "YOUR NAME IS ARELY & YOU WOKE
UP AT 7:20 AM"

PEER REVIEW: NAME -- REVIEW
*/

Console.Clear();
bool playAgain = true;
while (playAgain) {

    Console.WriteLine("WHAT IS UR NAME? ");
    string name = Console.ReadLine().ToUpper();

    Console.WriteLine(" ");     
    Console.WriteLine("WHAT TIME DID U WAKE UP? ");
    string time = Console.ReadLine().ToUpper();

    Console.WriteLine("");
    Console.WriteLine("YOUR NAME IS " + name + " & YOU WOKE UP AT " + time);
    
    Console.WriteLine("");

    bool converted = true;
    while (converted){
        Console.WriteLine("Would you like to play again? Yes or No");
        string rePlay = Console.ReadLine();

        if(rePlay == "YES" || rePlay == "Yes" || rePlay == "yes"){
            playAgain = true;
            converted = false;
            Console.Clear();
            Console.WriteLine( "LETS PLAY AGAIN!!" );
            Console.WriteLine( " " );
            break;
        } 
        if(rePlay == "NO" || rePlay == "no"){
            playAgain = false;
            converted = false;
            Console.WriteLine(" ");
            Console.WriteLine( "THANK YOU FOR PLAYING!!! " );
            break;
        }
        else{
            converted = true;
            Console.WriteLine(" ");
            Console.WriteLine( "INVAILD RESPONSE TRY AGAIN!!" );
            Console.WriteLine(" ");
        }
    } 
}
