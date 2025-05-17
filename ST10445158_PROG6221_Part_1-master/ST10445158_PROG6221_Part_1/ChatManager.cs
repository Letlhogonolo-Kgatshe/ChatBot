namespace ST10445158_PROG6221_Part_1
{
    using System;

    class ChatManager
    {
        private readonly ResponseGenerator responseGenerator;
        private readonly ResponseDisplayer responseDisplayer;

        public ChatManager()
        {
            responseGenerator = new ResponseGenerator();
            responseDisplayer = new ResponseDisplayer();
        }

        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Hello! What's your name? ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nYou: ");
            string userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "Cyber Explorer";
            }
            else if (userName.ToLower() == "exit")
            {
                responseDisplayer.Display("Goodbye! Have a great day!", ConsoleColor.Yellow);
                return;
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nWelcome, {userName}! I'm your Cyber Aware Chatbot, here to help you stay safe online.");
            Console.WriteLine("How can I assist you today?");
            Console.ResetColor();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string userInput = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(userInput))
                {
                    responseDisplayer.Display("Oops! You didn't type anything.", ConsoleColor.Red);
                    continue;
                }

                if (userInput == "exit")
                {
                    responseDisplayer.Display("Goodbye! Stay cyber aware!", ConsoleColor.Yellow);
                    break;
                }

                string response = responseGenerator.Generate(userInput);
                responseDisplayer.Display(response, ConsoleColor.Cyan);
            }
        }
    }
}