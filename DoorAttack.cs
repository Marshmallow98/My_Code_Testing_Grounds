using System;

  class DoorAttack
  {
    static void Main(string[] args)
    {     
       Console.WriteLine("you face a large sturdy door and you want through it");
       bool hasWon = false;
       bool throughDoor = false;
       int doorHealth = 100;
       int roomSearched = 0;
       bool hasKey = false;
       string response = null;

        while (hasWon == false)
        {
            

        if(throughDoor == false)
            {
                Console.WriteLine("choose one of these options");
                Console.WriteLine("sword");
                Console.WriteLine("fire spell");
                Console.WriteLine("check door");
                Console.WriteLine("search room");
                Console.WriteLine("walk through door");
                response = Console.ReadLine();

            
            
                if (doorHealth <= 0)
                {
                    Console.WriteLine("youve broken through the door!");
                    throughDoor = true;

                }
                
                if (response == "sword")
                {
                    Console.WriteLine("you strike the door with a foracious blow");
                    doorHealth = doorHealth - 3;
                }
                else if (response == "fire spell")
                {
                    Console.WriteLine("you hit the door with a fiery force");
                    doorHealth = doorHealth - 5;
                }
                else if (response == "check door")
                {
                    
                    if (doorHealth > 80)
                    {
                        Console.WriteLine($"the door barely has a dent, and its integrity looks to be about {doorHealth}%");
                    }
                    else if (doorHealth > 50)
                    {
                        Console.WriteLine($"the door is starting to show its wear, its integrity only feels about {doorHealth}%");
                    }
                    else if (doorHealth > 20)
                    {
                        Console.WriteLine($"the door is severely warped and starting to shatter, its integrity is only at {doorHealth}%");
                    }
                    else if (doorHealth >= 1)
                    {
                        Console.WriteLine($"im not quite sure how this door is still standing, its only at {doorHealth}% integrity");
                    }
                    else
                    {
                        Console.WriteLine("the door is broken down");
                    }
                
                }
                else if (response == "search room")
                {
                        if (roomSearched == 0)
                        {
                            Console.WriteLine("cant find anything useful, maybe i should look again");
                            roomSearched = roomSearched + 1;
                        }
                        else if (roomSearched == 1)
                        {
                            Console.WriteLine("i have found a key to the door");
                            roomSearched = roomSearched + 1;
                        }
                        else if (roomSearched == 2)
                        {
                            Console.WriteLine("i've already searched this room thouroughly and i wont find anything else");
                        }
                }
                else if (response == "walk through door")
                {
                    if (throughDoor == true)
                    {
                        Console.WriteLine("youve done it! you walked through the door");
                        hasWon = true;
                    }
                    else if (hasKey == true)
                    {
                        Console.WriteLine("you unlocked the door and finally walked into the warm embrace of the other side");
                        hasWon = true;
                    }
                    else if (throughDoor == false)
                    {
                        Console.WriteLine("thats sure is a door, and its locked");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                }
               
                else
                {
                    Console.WriteLine("choose one of the options");
                }
        }
    }
  }
}
