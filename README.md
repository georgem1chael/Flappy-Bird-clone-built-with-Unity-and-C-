# Flappy Bird Clone in Unity

This is a simple 2D Flappy Bird clone developed using Unity and C#.  
It was built as a personal project to explore the fundamentals of 2D game development and scripting in Unity.

---

## Features

- Bird movement using Rigidbody2D physics
- Random pipe spawning with variable heights
- Score tracking and high score using PlayerPrefs
- Game over detection on collision or out-of-bounds
- Manual gameplay mode using spacebar input
- Restart and title screen navigation

---

## How to Run

1. Clone or download the repository
2. Open the project with Unity Hub
3. Load the `Scenes/TitleScreen.unity` scene
4. Press the Play button in the Unity editor to start the game

---

## Author

Georgios Michael  
(https://github.com/georgem1chael)

## License

This project is intended for educational and personal use only.  

## Project Structure

```plaintext
Assets/
├── Audio/
├── Fonts/
├── Prefabs/
├── Scenes/
│   ├── TitleScreen.unity
│   └── FlappyBird.unity
├── Scripts/
│   ├── BirdScript.cs
│   ├── pipeSpawnerScript.cs
│   ├── logicScript.cs
│   └── ...

