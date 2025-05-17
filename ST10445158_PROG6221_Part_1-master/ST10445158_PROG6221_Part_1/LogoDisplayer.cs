    namespace ST10445158_PROG6221_Part_1
    {
        using System;

        class LogoDisplayer
        {
            public void Display()
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@"

        _____       _                      _           _   _           _   
       /  __ \     | |                    | |         | | | |         | |  
       | /  \/_   _| |__   ___ _ __    ___| |__   __ _| |_| |__   ___ | |_ 
       | |   | | | | '_ \ / _ \ '__|  / __| '_ \ / _` | __| '_ \ / _ \| __|
       | \__/\ |_| | |_) |  __/ |    | (__| | | | (_| | |_| |_) | (_) | |_ 
        \____/\__, |_.__/ \___|_|     \___|_| |_|\__,_|\__|_.__/ \___/ \__|
               __/ |                                                       
              |___/                                                        
  
                ");
                Console.ResetColor();
                Console.WriteLine("\n━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Welcome to Cyber Aware Chatbot! Type 'exit' to quit.");
                Console.ResetColor();
                Console.WriteLine("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━\n");
            }
        }
    }