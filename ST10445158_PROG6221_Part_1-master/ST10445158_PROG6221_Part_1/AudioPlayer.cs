namespace ST10445158_PROG6221_Part_1
{
    using System;
    using System.Media;
    using System.IO;

    class AudioPlayer
    {
        public void PlayGreeting()
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Greeting.wav");
            try
            {
                using (SoundPlayer player = new SoundPlayer(filePath))
                {
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[Error] Unable to play greeting: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}