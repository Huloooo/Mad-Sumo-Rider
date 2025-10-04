Three-in-One Game
📌 Description

This Unity project is a 3-in-1 mini game collection created as part of the Final Exam (CS3434 / CSX4606 / IT4452 / ITX4606 Introduction to Game Development).

It combines three separate games into a single project, accessible from a Main Menu:

Mad Driver – Drive a car down the road while avoiding obstacles.

Fly Like a Bird – Fly a plane through the sky, tilting up and down.

I’m a Sumo and a Ball – Physics-based sumo arena where the player ball must push enemies off the platform.

A Pause Menu is available in each game (press Esc) with options to:

Resume

Restart

Return to Main Menu

🛠️ Features

Main Menu to choose between games.

In-Game Pause Menu (Resume, Restart, Main Menu).

Car driving with physics (Mad Driver).

Plane flying controls (Fly Like a Bird).

Sumo-ball physics battle with enemies (I’m a Sumo and a Ball).

Exit button to close the game.

📂 Project Structure
Assets/
 ├── Scenes/
 │    ├── MainMenu.unity
 │    ├── MadDriver.unity
 │    ├── FlyBird.unity
 │    ├── Sumo.unity
 ├── Scripts/
 │    ├── SceneLoader.cs
 │    ├── PauseMenu.cs
 │    ├── CarController.cs
 │    ├── CameraFollow.cs
 │    ├── PlayerControllerX.cs   (Fly Like a Bird)
 │    ├── FollowPlayerX.cs       (Fly Like a Bird)
 │    ├── PropellerController.cs (Fly Like a Bird)
 │    ├── SumoPlayer.cs
 │    ├── SumoEnemy.cs
 │    ├── FallZone.cs
 │    └── SumoWinCheck.cs
 └── Prefabs/
      ├── PauseCanvas.prefab
      └── UI elements

▶️ How to Play

Launch the game from the Main Menu.

Choose one of the three games:

Mad Driver – Use WASD / Arrow Keys to drive.

Fly Like a Bird – Use W/S or Up/Down arrows to tilt, auto-forward flight.

Sumo – Use WASD / Arrow Keys to roll and push enemies.

Press Esc to open the Pause Menu.

Win/Lose Conditions:

Car/Plane → play for survival.

Sumo → knock enemies off, don’t fall yourself.

⌨️ Controls

WASD / Arrow Keys → Movement

Esc → Pause Menu

👨‍💻 Author

Humam Khurram (Student ID: 6611680)