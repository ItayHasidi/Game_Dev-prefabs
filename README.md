# Unity week 2: Formal elements
In this Game I added 3 Lives for the spaceship.
Plus a Bomb that kills all enemies near the spaceship, but this can be used only once.
itch.io: https://amitay2022.itch.io/spaceship

## Changes

1. https://github.com/ItayHasidi/Game_Dev-prefabs/blob/master/Assets/Scripts/4-levels/HeartRemover.cs - a change to DestroyOnTrigger2D.cs, I added an array of GameObjects that represent the hearts of the player. And instead of destroying the ship on first impact I destroyed a heart, for three time. Nad only on the last destroyed heart does the game end.

2. https://github.com/ItayHasidi/Game_Dev-prefabs/blob/master/Assets/Scripts/2-spawners/LaserShooter.cs : In this script I added two SerializeFields that represent the type of weapon used, the player can shoot lasers or deploy a one time use bomb that kills nearby enemies. In order to do this I added a string with the weapon type and a boolean field that represents wether or not the bomb has been used. After that i moved the spawning of the weapon to a seperate function, and added a simple if statment. 

## Credits

Programming:
* Maoz Grossman
* Erel Segal-Halevi

Online courses:
* [The Ultimate Guide to Game Development with Unity 2019](https://www.udemy.com/the-ultimate-guide-to-game-development-with-unity/), by Jonathan Weinberger

Graphics:
* [Matt Whitehead](https://ccsearch.creativecommons.org/photos/7fd4a37b-8d1a-4d4c-80a2-4ca4a3839941)
* [Kenney's space kit](https://kenney.nl/assets/space-kit)
* [Ductman's 2D Animated Spacehips](https://assetstore.unity.com/packages/2d/characters/2d-animated-spaceships-96852)
* [Franc from the Noun Project](https://commons.wikimedia.org/w/index.php?curid=64661575)
* [Greek-arrow-animated.gif by Andrikkos is licensed under CC BY-SA 3.0](https://search.creativecommons.org/photos/2db102af-80d0-4ec8-9171-1ac77d2565ce)
