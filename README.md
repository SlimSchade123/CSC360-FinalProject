# CSC360-FinalProject
## Temple Run


This is my clone of temple run. 

## Software Designs Implemented

### Singleton - [Game Manager](Assets/Scripts/GameManager.cs)



GameManager in this project makes sure that every class can call GetInstance statically. If the Instance is null, it will find the GameManager component. Otherwise it returns the private instance variable.
This makes sense so I am able to reference the same instance of the GameManager.


### State - [StateManager](Assets/Scripts/StateManager.cs)

The StateManager is only technically part of the pattern.

Here are all classes associated with this pattern:

- [StateManager](Assets/Scripts/StateManager.cs)
- [IState](Assets/Scripts/States/IState.cs)
- [TitleState](Assets/Scripts/States/TitleState.cs)
- [GameState](Assets/Scripts/States/GameState.cs)

This pattern is especially helpful for games to switch between different states. For instance, I have a state for when the player is playing the game or when they are on the title screen. It works by having the context (StateManager) handle the current state and switching between them. This means that now at any point I can extend the IState class in order to add a new state.
