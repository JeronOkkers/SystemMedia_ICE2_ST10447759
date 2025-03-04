/*
 * Jeron Okkers
 * ST10447759
 * PROG6221
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace SystemMedia
{
    class SelectWav
    {
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//
        // Method that gets the sound file path.
        private string GetSoundPath(string fileName)
        {
            // Get the directory where the executable is running
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            return Path.Combine(basePath, "Songs", fileName);
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//
        // Methods that gets the sound file and plays it.
        public void Wav1()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = GetSoundPath("Greeting.wav");
            player.PlaySync();
            Console.WriteLine("Press any key to stop the sound...");
            Console.ReadKey();
            player.Stop();
        }

        public void Wav2()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = GetSoundPath("bat-time_x.wav");
            player.PlaySync();
            Console.WriteLine("Press any key to stop the sound...");
            Console.ReadKey();
            player.Stop();
        }

        public void Wav3()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = GetSoundPath("batman_theme_x.wav");
            player.PlaySync();
            Console.WriteLine("Press any key to stop the sound...");
            Console.ReadKey();
            player.Stop();
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//
        // Method for colorChange changes the color of the text to green.
        public void colorChange(string soundName)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nNow playing: {soundName}");
            Console.ResetColor();
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------//
        // Method for UserChoice allows the user to select a sound file to play.
        public void UserChoice()
        {
            int choice;
            do
            {
                Console.WriteLine("\nSelect a sound to play: ");
                Console.WriteLine("1. Greeting.wav");
                Console.WriteLine("2. batman-time_x.wav");
                Console.WriteLine("3. batman_theme_x.wav");
                Console.WriteLine("4. Exit");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            colorChange("Greeting.wav");
                            Wav1();
                            break;
                        case 2:
                            colorChange("batman-time_x.wav");
                            Wav2();
                            break;
                        case 3:
                            colorChange("batman_theme_x.wav");
                            Wav3();
                            break;
                        case 4:
                            Console.WriteLine("Exiting...");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            } while (choice != 4);
        }
    }
}
//================================================================================================================================================================//
