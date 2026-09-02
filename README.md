# Snake

This README is based on the original **Snake User Manual** made for the project. The manual already explains the game well, so I used it as the main structure instead of replacing it with a generic software README.

**Project team:** Jenna Gal, Michael Leone, and Devansh Bhutani

[Open the original Snake User Manual](<Snake User Manual.pdf>)

## History of the game

The game we now know as Snake grew out of earlier arcade games such as *Blockade*. It later became especially popular after Snake was included on Nokia phones, where the simple idea of moving, eating, and growing turned into one of the most recognizable mobile games ever made.

Our version keeps the basic Snake gameplay but adds both **single-player and two-player modes**, speed controls, colour customization, score tracking, and a pause/reset system.

## Objective - Single Player

In single-player mode, use the **WASD** keys to move the snake around the playing area.

The goal is to eat as many apples as possible and grow the snake without:

- Running into the edge of the grid
- Colliding with your own body

There is no final level to beat in solo mode. It is a high-score challenge. Every apple grows the snake and increases the round score.

## Objective - Two Player

Two-player mode turns the game into an outlast-your-opponent challenge.

- **Player 1:** WASD
- **Player 2:** IJKL

Both players move around the same board, compete for apples, and grow their snakes. A player can lose by going out of bounds, colliding with their own body, or colliding with the other player's snake.

The main objective is simple: **stay alive longer than the other player.**

## Controls

| Action | Player 1 / Solo | Player 2 |
| --- | --- | --- |
| Up | `W` | `I` |
| Left | `A` | `J` |
| Down | `S` | `K` |
| Right | `D` | `L` |

The interface also includes buttons for **Start**, **Pause**, **Reset**, colour changes, mode selection, and speed changes.

## Game setup

Before starting a round:

1. Select **Single Player** or **Two Player**.
2. Choose the game speed: default, 1.5x, or 2x.
3. Change the snake or apple colours if you want to, or keep the defaults.
4. Press **Start**.
5. Eat apples and stay away from anything that ends the round.

You can pause the game if you need a break, then unpause and continue.

## Scoreboard

### Single Player

- **Round Score** is the number of apples collected during the current round.
- **High Score** stores the best solo score.
- The high score is written to `GameStat.txt` so it can be loaded again later.

### Two Player

Player 1 and Player 2 have a win counter, and ties are also tracked. The two-player scoreboard can be reset from the interface.

## Game-over conditions

### Single Player

The game ends when the snake:

1. Collides with itself, or
2. Leaves the grid.

When that happens, the round score is compared against the saved high score.

### Two Player

A player loses when they:

1. Collide with their own snake,
2. Collide with the other player's snake, or
3. Go out of bounds.

A tie can happen when both players fail during the same update, such as both crashing or leaving the board at the same time.

## Strategies to win

### Solo - approach edge apples carefully

If an apple appears close to an edge, try to approach it while moving parallel to the wall rather than driving straight toward the boundary. It gives you more room to turn after collecting the apple.

### Solo - save space

Once the snake gets long, avoid filling the board in a way that traps your own head. Leave yourself paths to turn back through the open area.

### Two Player - box in your opponent

A longer snake can be used as a moving barrier. If you can safely force the other player toward a wall or into a smaller area, they have fewer escape options.

### Two Player - pay attention to space, not only the apple

If the other player is already much closer to an apple, chasing the same one may put you in a worse position. Staying near open space can give you a better chance at the next apple and make you harder to trap.

## Troubleshooting

### Colour will not change

Select the object you want to recolour first. The game needs to know whether you are changing Player 1, Player 2, or the apple.

### Both snakes cannot use the same colour

In two-player mode, the game prevents both snakes from using the same colour so they are easier to tell apart.

### Speed will not change

Select one of the speed options first, then apply the speed change before starting the round.

## Running the project

This is a **C# Windows Forms** project targeting **.NET Framework 4.7.2**.

1. Open [`SnakeGameProject.sln`](<SnakeGameProject Devansh Bhutani/SnakeGameProject.sln>) in Visual Studio on Windows.
2. Make sure the .NET Framework 4.7.2 targeting pack is installed.
3. Build and run the solution.

If you run the compiled program from a different working directory, make sure `GameStat.txt` is available where the program expects to read and write the saved high score.

## Main features

- Single-player mode
- Two-player mode
- Shared apple spawning
- Snake growth and collision detection
- Three speed settings
- Snake and apple colour customization
- Persistent solo high score
- Two-player win/tie scoreboard
- Pause and reset controls
