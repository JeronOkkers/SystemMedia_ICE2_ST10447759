# SystemMedia - WAV Sound Player

## 📌 About
SystemMedia is a simple C# console application that allows users to select and play different `.wav` sound files. The program provides an interactive menu where users can choose a sound, and the currently playing sound name is displayed in green.

## 🔧 Features
- 🎵 Play `.wav` sound files
- 🎨 Changes text color to **green** when a sound is playing
- 🔄 Loops until the user selects **Exit**
- ❌ Handles invalid input gracefully

## 🖥️ How to Run
### Prerequisites
- Windows OS
- .NET Framework installed

### Steps
1. Clone the repository:
   ```sh
   git clone https://github.com/your-username/SystemMedia.git
   ```
2. Open the project in **Visual Studio** or any compatible C# IDE.
3. Ensure the `.wav` files exist in the correct directory.
4. Build and run the program.

## 📜 Usage
When the program runs, you will see:
```
Select a sound to play:
1. Greeting.wav
2. batman-time_x.wav
3. batman_theme_x.wav
4. Exit
```
- Choose a number **(1-3)** to play a sound.
- The text turns **green** while a sound is playing.
- Press any key to stop the sound.
- Enter **4** to exit the program.

## 📂 Project Structure
```
SystemMedia/
│── Program.cs
│── SelectWav.cs
│── Greeting.wav
│── batman-time_x.wav
│── batman_theme_x.wav
│── README.md
```

## 🛠️ Built With
- **C#** - Programming language
- **.NET Framework** - Required for running the application
- **SoundPlayer Class** - Used for playing `.wav` files

## 📝 License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 💡 Author
- **Jeron Okkers** - *Developer*  
  [GitHub](https://github.com/your-username) | [LinkedIn](https://linkedin.com/in/your-profile)

---

📢 **Contributions & Feedback**: If you have suggestions or improvements, feel free to create an issue or a pull request! 🚀

