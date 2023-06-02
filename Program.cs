//Roan Andrei D. Uson 
//BSCPE 1-1
//GAME BOY(Intalling games that required no wifi)
//with methods

using System;
class Program {
  static void Main() 
    {
     
     bool top = true; // bool is the key of THIS TYPE of loop
    
    
    Console.WriteLine("---------------------------");
    Console.WriteLine("\\\\WELCOME TO GAME BOY////");
    Console.WriteLine("---------------------------");
    while(top) // starting point of loop, Dito ulit mag loloop kung saan mo nilagay ang While
    {

    Coder();//method 1


    string Gamer1 = Console.ReadLine() ?? "";
    if(Gamer1.ToLower() == ("action") )
    {

    Coder2();//method 2


     string Gamer1Mortal = Console.ReadLine() ?? "";
     if(Gamer1Mortal.ToLower() == "1" || Gamer1Mortal.ToLower() == "mortal combat x" || Gamer1Mortal.ToLower() == "mortal combat 10" )
     {
         Console.WriteLine("Are you sure you want to install Mortal combat X? yes or no?");
         string Gamer2Mortal = Console.ReadLine() ?? "";
         if(Gamer2Mortal.ToLower() == "yes")
         {
             
         }
         else if (Gamer2Mortal.ToLower() == "no")
         {
              continue; // Babalik sa while loop
         }
         else
         {
            Correction();
         } 
         
      }
      else if(Gamer1Mortal.ToLower()== "2" || Gamer1Mortal.ToLower()=="marvel Vs capcom")
      {
         Console.WriteLine("Are you sure you want to install Marvel Vs Capcom? yes or no?");
         string Gamer2Marvel = Console.ReadLine() ?? "";
         if(Gamer2Marvel.ToLower() == "yes")
         {
             Coder5();
             top = false;
         }
         else if(Gamer2Marvel.ToLower() == "no")
         {
             continue;
         }
         else{
            Correction();
         }
     }
     else if(Gamer1Mortal.ToLower()== "3"||Gamer1Mortal.ToLower()== "ghostrider v.25")
     {
         Console.WriteLine("Are you sure you want to install Ghostrider V.25? yes or no?");
         string Gamer2Ghost = Console.ReadLine() ?? "";
         if(Gamer2Ghost.ToLower() == "yes")
         {
            Coder5();
            top = false;
         }
         else if(Gamer2Ghost.ToLower() == "no")
         {
             continue;
         }
         else
         {
            Correction(); 
         }
         
     }
     else if(Gamer1Mortal == "0")
     {
        continue; 
     }
     else
     {
        Correction();
     }
     
    }
    else if(Gamer1.ToUpper() == "RPG")
    {
        
      Coder3();//method



     string Gamer2Fantasy = Console.ReadLine() ?? "";
     if(Gamer2Fantasy.ToLower() == "1" || Gamer2Fantasy.ToLower()=="final fantasy x")
     {
         Console.WriteLine("Are you sure you want to install Final Fantasy X? yes or no?");
         string Gamer2Fantasy1 = Console.ReadLine() ?? "";
         if(Gamer2Fantasy1.ToLower() == "yes")
         {
            Coder5();
            top = false ;
         }
         else if(Gamer2Fantasy1.ToLower() == "no")
         {
            continue; 
         }
         else
         {
            Correction();
         } 
         
         
     }
     else if(Gamer2Fantasy == "2" || Gamer2Fantasy.ToLower()=="elden ring")
     {
        Console.WriteLine("Are you sure you want to install Elden ring? yes or no?");
        string Gamer2Elden = Console.ReadLine() ?? "";
        if(Gamer2Elden == "yes")
        {
            
            top = false;
        }
        else if(Gamer2Elden.ToLower() == "no")
        {
         continue;   
        }
        else{
           Correction();
        }
     }
     else if(Gamer2Fantasy == "3" ||  Gamer2Fantasy.ToLower() == "dying light 2")
     {
        Console.WriteLine("Are you sure you want to install Dying Light 2? yes or no?");
        string Gamer2Dying = Console.ReadLine() ?? "";
        if(Gamer2Dying.ToLower() == "yes")
        {
            Coder5();
            top = false;
        }
        else if(Gamer2Dying.ToLower() == "no")
        {
            continue;
        }
        else
        {
            Correction();
        }
     }
     else if(Gamer2Fantasy == "0")
     {
        continue; 
     }
     else
     {
        Console.WriteLine("Invalid command, select approriate keys.");
     }
    }
    else if(Gamer1.ToLower() == ("shooting") )
    {
        
       Coder4();//Method 4

        string Gamer3Red = Console.ReadLine() ?? "";
        if(Gamer3Red == "1" || Gamer3Red == "red dead redemption" || Gamer3Red.ToLower() == "red dead redemption 2")
        {
            Console.WriteLine("Are you sure you want to install Red dead redemption 2? yes or no?");
            string Gamer3Red1 = Console.ReadLine() ?? "";
            if(Gamer3Red1.ToLower() == "yes")
            {
            Coder5();
            top = false;
            }
            else if(Gamer3Red1.ToLower() == "no")
            {
                continue;
            }
            else
            {
            Correction();
            }
        }
        else if(Gamer3Red == "2" || Gamer3Red.ToLower() =="halo")
        {
            Console.WriteLine("Are you sure you want to install Halo? yes or no?");
            string Gamer3Halo = Console.ReadLine() ?? "";
            if(Gamer3Halo.ToLower() == "yes")
            {
             Coder5();
             top = false;
            }
            else if(Gamer3Halo.ToLower() == "no")
            {
                continue;
            }
            else
            {
             Correction();
            }
        }
        else if(Gamer3Red == "3" || Gamer3Red.ToLower() == "cod"  || Gamer3Red.ToLower() == "call of duty"  || Gamer3Red.ToLower() == "warzone"
         || Gamer3Red.ToLower() == "call of duty warzone"  || Gamer3Red.ToLower() == "call of duty:warzone"|| Gamer3Red.ToLower() == "call of duty: warzone")
        {
            Console.WriteLine("Are you sure you want to install Call of duty:Warzone? yes or no?");
            string Gamer3Call = Console.ReadLine() ?? "";
            if(Gamer3Call.ToLower() == "yes")
            {
             Coder5();
             top = false;
            }
            else if(Gamer3Call.ToLower() == "no")
            {
                continue;
            }
            else
            {
            Correction();
            }
    
        }
        else if(Gamer3Red == "0" || Gamer3Red.ToLower() == "back")
        {
            continue;
        }
        else
        {
            Console.WriteLine("Invalid command, select approriate keys.");
        }
    
    }
    else if(Gamer1 == "0" ||Gamer1.ToLower() == "exit"||Gamer1.ToLower() == "close" )
    {
       Correction2();
        top = false;
    }
    else 
    {
        Console.WriteLine("Invalid command, select approriate keys.");
    }
//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Methods are in below










    static void Coder2()
    {
     Console.WriteLine("---------------------------");
     Console.WriteLine("|Selection of Action Games|");
     Console.WriteLine("---------------------------");
     Console.WriteLine("1. Mortal combat X");
     Console.WriteLine("2. Marvel Vs Capcom");
     Console.WriteLine("3. Ghostrider V.25");
     Console.WriteLine("0. Back");
     }
     static void Coder()
    {
     Console.WriteLine("");
     Console.WriteLine("-------------------------");
     Console.WriteLine("|SELECT GAMES TO INSTALL|");
     Console.WriteLine("-------------------------");
     Console.WriteLine("Action");
     Console.WriteLine("RPG");
     Console.WriteLine("Shooting");
     Console.WriteLine("Press 0 to Close");
     Console.WriteLine("");
     }
     static void Correction()
     { 
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Erorr. It restarted due to your inapproriate action.");
     }

       static void Coder3()
    {
         Console.WriteLine("------------------------");
        Console.WriteLine(" |Selection of RPG Games|");
         Console.WriteLine("------------------------");
        Console.WriteLine("1. Final Fanstasy X");
        Console.WriteLine("2. Elden ring");
        Console.WriteLine("3. Dying Light 2");
        Console.WriteLine("0. Back");
     }
     static void Coder4()
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine("|Selection of Shooting Games|");
        Console.WriteLine("-----------------------------");
        Console.WriteLine("1. Red dead redemption 2");
        Console.WriteLine("2. Halo");
        Console.WriteLine("3. Call of duty:Warzone");
        Console.WriteLine("0. Back");
    }
    static void Coder5()
    {
        Console.WriteLine("");
        Console.WriteLine("Installing... Please do not turn off device.");
    }
    static void Correction2()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Press run, to open the app again.");
    }

    

  }
    
}  


    }








   