# Tic-Tac-Toe Game in C#

This project is a simple console-based implementation of the classic **Tic-Tac-Toe** game, developed using C#. The game supports a two-player mode where two players can play against each other by entering their moves, and the system will check for winning conditions or a draw.

## Features

- **Two-player mode**: The game alternates between Player 1 (X) and Player 2 (O).
- **Visual board representation**: The game board updates dynamically after each move.
- **Win/Draw conditions**: The game checks if any player has won or if it results in a draw.
- **Interactive prompts**: The game asks players to enter their move and shows a message if the move is invalid.

## Gameplay Instructions

1. At the start of the game, Player 1 is assigned 'X' and Player 2 is assigned 'O'.
2. Players take turns selecting a position on the board (1–9) to place their mark (X or O).
3. The game checks after every move if there is a winner or if the game ends in a draw.
4. Once the game ends, it will announce the result: either which player has won or if it's a draw.

### Sample Board Layout

```text
     |     |     
  1  |  2  |  3  
_____|_____|_____
     |     |     
  4  |  5  |  6  
_____|_____|_____
     |     |     
  7  |  8  |  9  
     |     |     
```

Win Conditions
A player wins if they place three of their marks in one of the following patterns:

-Horizontal: (1, 2, 3), (4, 5, 6), (7, 8, 9)
-Vertical: (1, 4, 7), (2, 5, 8), (3, 6, 9)
-Diagonal: (1, 5, 9), (3, 5, 7)


Prerequisites
-.NET Framework (or any C# compiler)
-Basic understanding of how to run C# console applications
