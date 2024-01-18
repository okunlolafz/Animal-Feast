# Doggy Dodge Game

Welcome to the Doggy Dodge game repository! This Unity game challenges players to dodge balls while launching their adorable pet dogs into the sky. The game is designed with simplicity and fun in mind. Let's dive into the details.

## Table of Contents

- [Overview](#overview)
- [Game Mechanics](#game-mechanics)
- [How to Play](#how-to-play)
- [Scripts](#scripts)
- [Contributing](#contributing)
- [License](#license)

## Overview

Doggy Dodge is a casual Unity game where players control a character to dodge incoming balls and launch cute dogs into the air. The game features a straightforward gameplay loop and is suitable for players of all ages.

## Game Mechanics

The game includes the following key mechanics:

- **Spawn Management:** Balls are spawned at random intervals from the top of the play area.
- **Dog Launch:** Players can launch their pet dog into the air using the spacebar. Dogs can only be launched when positioned at the spawn origin.
- **Collision Detection:** Collisions with balls trigger their destruction, providing a satisfying experience for the player.
- **Destruction Limits:** Both balls and dogs are destroyed if they go beyond specific positional limits.

## How to Play

1. **Dodge Balls:**
   - Use your arrow keys or A/D keys to move your character left or right to dodge incoming balls.

2. **Launch Dogs:**
   - Press the spacebar to launch your adorable pet dog into the air. Be strategic as the dog can only be launched from the spawn origin.

3. **Scoring:**
   - The game is endless, and the challenge is to achieve the highest score possible by dodging balls and launching dogs.

## Scripts

### 1. `SpawnManagerX.cs`

This script manages the spawning of random balls at the top of the play area.

### 2. `PlayerControllerX.cs`

Controls the player's ability to launch their dog into the air using the spacebar.

### 3. `MoveForwardX.cs`

Moves game objects forward at a specified speed.

### 4. `DetectCollisionsX.cs`

Handles the detection of collisions, destroying the game object upon contact.

### 5. `DestroyOutOfBoundsX.cs`

Destroys game objects if they go beyond specified positional limits.

## Contributing

If you're interested in contributing to the Doggy Dodge game, follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them.
4. Push to your fork and submit a pull request.

## License

This project is licensed under the [MIT License](LICENSE), allowing for both personal and commercial use.

Feel free to reach out with any questions, feedback, or suggestions.

Have a great time playing and developing Doggy Dodge!
