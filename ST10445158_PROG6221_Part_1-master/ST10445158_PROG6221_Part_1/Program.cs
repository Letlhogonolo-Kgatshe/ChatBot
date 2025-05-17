// Letlhogonolo Kgatshe
// ST10445158
// Group 1

// References: List your references here
// Delayed Response to simulate actual thinking                      https://ironpdf.com/blog/net-help/csharp-wait-for-seconds/#:~:text=The%20Sleep%20Command&text=Here%2C%20the%20program%20starts%20by,3%20seconds%22%20to%20the%20console.
// Error Handling                                                    https://www.w3schools.com/cs/cs_exceptions.php
// Playing Audio in WAV format                                       https://stackoverflow.com/questions/14491431/playing-wav-file-with-c-sharp
// Sample data for the possible Cyber security questions and answers https://chatgpt.com/c/67e542f0-9300-8004-81a7-a8abe4e47228
// ASCII ARTWORK LOGO                                                https://patorjk.com/software/taag/#p=display&f=Graffiti&t=Cyber%20Chat%0A

    //------------------------------------------...ooo000 START OF FILE 000ooo...------------------------------------------------------//
    namespace ST10445158_PROG6221_Part_1
    {
        using System;
        using System.Media;
        using System.Threading;

        class Chatbot
        {
            static void Main()
            {
                Console.Title = "Cyber Aware Chatbot";
                Console.ForegroundColor = ConsoleColor.Cyan;

                var logoDisplayer = new LogoDisplayer();
                var audioPlayer = new AudioPlayer();
                var chatManager = new ChatManager();

                logoDisplayer.Display();
                audioPlayer.PlayGreeting();
                chatManager.Start();
            }
        }
    }
    //------------------------------------------...ooo000 END OF FILE 000ooo...------------------------------------------------------//