# 🐦 Flappy Bird Clone

A simple yet polished 2D Flappy Bird-style game developed in Unity using C#.
This project focuses on physics-based movement, procedural obstacle spawning, collision handling, and responsive gameplay mechanics.

## 🎮 Features

* Physics-based bird movement using `Rigidbody2D`
* Smooth tap/click impulse controls
* Randomized obstacle generation
* Real-time score tracking with TextMeshPro
* Collision-based game-over system
* Instant level restart and state reset
* Tuned gameplay difficulty for responsive controls

## 🛠️ Tech Stack

* Unity 2D
* C#
* Physics2D
* TextMeshPro
* Scene Management

## ⚙️ Gameplay Mechanics

### Bird Movement

The bird movement is powered using `Rigidbody2D.AddForce()` with `ForceMode2D.Impulse`, creating responsive upward movement while gravity naturally pulls the player downward between inputs.

### Obstacle Generation

Pipe obstacles are generated dynamically through a trigger-based spawning system. Each new pipe pair receives a randomized vertical position using `Random.Range()` to keep gameplay unpredictable.

### Collision System

`OnTriggerEnter2D()` is used to differentiate between:

* Score zones → increase player score
* Pipe collisions → trigger game over

### Score Management

The score counter updates in real time using TextMeshPro whenever the player successfully passes through pipe gaps.

### Restart System

The game-over flow is handled through `SceneManager.LoadScene()`, allowing the scene to reload cleanly without manual object resetting.

## 📂 Project Structure

* `Scripts/` → Gameplay and manager scripts
* `Scenes/` → Main game scene
* `Prefabs/` → Bird and pipe prefabs
* `UI/` → Score and game-over interface
* `Audio/` → Sound effects

## 🎯 Learning Outcomes

This project helped improve understanding of:

* Unity 2D physics
* Rigidbody2D movement
* Trigger and collision systems
* Procedural obstacle spawning
* Scene management
* UI integration with TextMeshPro
* Gameplay balancing and tuning

## 🚧 Future Improvements

* Main menu and pause system
* High score saving
* Mobile touch optimization
* Difficulty scaling over time
* Sound and animation polish
