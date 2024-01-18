# Animal Feast

Welcome to the Animal Feast game repository! In this Unity game, players control a hungry animal trying to catch and consume various types of food. The game offers an exciting challenge of quick reflexes and precision. Let's dive into the details.

## Table of Contents

- [Overview](#overview)
- [Game Mechanics](#game-mechanics)
- [How to Play](#how-to-play)
- [Scripts](#scripts)
- [Contributing](#contributing)
- [License](#license)

## Overview

Animal Feast is a casual Unity game where players control an animal in an immersive 3D environment. The goal is to catch different types of food items while avoiding collisions with other animals. The game brings together simple controls and engaging mechanics for an enjoyable experience.

## Game Mechanics

The game includes the following key mechanics:

- **Animal Spawning:** Different food items spawn randomly at intervals within the 3D environment.
- **Player Movement:** Players control the animal's movement using arrow keys or A/D keys.
- **Food Launch:** Pressing the spacebar launches food projectiles to catch items.
- **Collision Detection:** Collisions with food items trigger their destruction and scoring.
- **Bound Limits:** The game monitors the animal's position, destroying it if it goes out of bounds.

## How to Play

1. **Navigate the Environment:**
   - Use the arrow keys or A/D keys to move the animal left or right in the 3D environment.

2. **Launch Food Projectiles:**
   - Press the spacebar to launch food projectiles and catch items.

3. **Score Points:**
   - Catch different types of food items to score points.

4. **Avoid Collisions:**
   - Colliding with other animals or missing food items may have consequences.

## Scripts

### 1. `SpawnManager.cs`

This script manages the spawning of different food items randomly within the 3D play area.

### 2. `CollisionDetection.cs`

Handles the detection of collisions, destroying both the animal and the collided object.

### 3. `FoodMovement.cs`

Moves the food items forward in the 3D space at a specified speed.

### 4. `PlayerMovement.cs`

Manages the player's ability to control the animal's movement, launch food projectiles, and monitors position bounds.

### 5. `RemoveOutOfBounds.cs`

Destroys game objects (both animals and food items) if they go beyond specified positional limits in the 3D space.

## Contributing

If you're interested in contributing to the Animal Feast game, follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Push to your fork and submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE), allowing for both personal and commercial use.

Feel free to reach out with any questions, feedback, or suggestions.

Enjoy playing and developing Animal Feast!
