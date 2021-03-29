CS50 Final Project

Name of the game: Jumpy Cat


Assets used:

Clouds - Aligned Games - Unity Asset Store

Skybox - Customizable Skybox - Unity Asset Store

Coin - PolygonStarte - Unity Asset Store

Cat, flowers and trees - VoxelAnimals - Unity Asset Store


Sounds used:

Main menu music - "Analog-Nostalgia" - https://soundimage.org/looping-music/

Background music - "Trancyvania" - https://soundimage.org/looping-music/

Jump, Collision and Pickup - BFXR


Jumpy Cat consists of an infinite scroller where the player has to avoid obstacles and pick up coins.
All objects move towards the camera to give the impression that the cat is moving forward. The speed at which the objects move is determined inside the ObstacleSpawner class.
To avoid the effect of seeing objects popping in game, fog is applied near the back of the game.
Since the Cat asset I imported has an idle animation when not moving, I modified its animations so as to always be playing the walking animation, thus giving the effect that the cat is running forwards.


Jumpy Cat has three different scenes. The Start Scene, the Play Scene and the Game Over Scene.

The Start Scene consists of a couple of tree, flower and cloud prefabs aswell as the player character, the cat. I used a ProBuilder plane to work as the ground and manually placed the prefabs. In order to avoid having the player be able to move the cat around in this scene, I removed its player controller script and also disabled the animator component that has the cat looping the 'walk' animation. This Scene has a canvas that includes the title and a press enter text with the Scene Management script to transition into the Play Scene.

The Play Scene started out by placing a ProBuilder plane as the ground and two ProBuilder arches to the sides creating some sort of pathway. All prefabs in this scene get moved towards the camera through a script that transforms their Z position. The camera is placed at a position that prevents from seing the begining of these objects while it also has script called Camera Follow that moves along the X axis according to the X position of the player. To maintain a certain perspective of the 'pathway' I decided that the camera would not move along the Y axis whenever the player jumped since it resulted in having some of the obstacles getting in the way and obstructing the view of the other incoming obstacles. The flowers in this scene were placed randomly by hand at diferent points throughout the 'ground' object and when they get behind the view of the camera, their position gets moved towards the end of the 'pathway' and its X position gets a random value between -5.5 and 5, measured by hand so as to get randomly placed flowers all along the ground. In the case of the trees, I selected by hand four different X and Y positions where to spawn them, making sure that they would appear over the arches as if they had 'grown' over them. When they get behind the view of the camera, a random value would be used to determine to which of these four positions the tree would end up at the back of the 'pathway'. When the clouds get behind the view of the camera, two random values get chosen to determine the new X and Y position the cloud will end up in. 

While the former prefabs get assigned a position and afterwards sent to the back of the 'pathway', obstacles and coins get instatiated as new objects and deleted after reaching a certain point near the camera view. Both get assigned a random value calculated so as to always apear inside the pathway and either a 'top' or 'bottom' position according to the Y value. This way we get obstacles that have to be jumped over or not. Each time a new 'obstacle' gets instantiated, there is a random chance that the speed at with the prefabs move will increase up to a determined limit where the game can still be playable. The interval at which the obstacles spawn depends on the speed at which they are moving, thus increasing the time needed to spawn the next obstacle whenever the speed increases. 

The player controller has an OnCollisionEnter function where it checks if the player has collided with an obstacle or a coin. In the former case, the speed at which the objects move becomes 0, new obstacles and coins stop spawning, the background music stops playing, a collision sound plays and the Game Over Scene gets loaded. Score in this game is increased through the use of Time.deltaTime and a scoreIncrement variable of 10f or when picking up coins which increases the score by 50.

The Game Over Scene has a "Game Over" text, another text showing the player's score up to the point where they lost, and a prompt for the player yo restart the game. When the game restarts, the score turns into 0 and the background music starts playing again.



Jumpy Cat includes concepts learnt throughout the course such as instantiating and deleting objects, applying fog, creating 3D objects with the ProBuilder tool, utilizing the Scene Manager, displaying text over the screen, importing assets from the Unity Asset Store, executing functions when a collision is detected, playing sound files on the background as well as when a certain event occurs, creating prefabs of objects with added components and applying materials to objects.

Functionally, this game is similar to the 3D Helicopter Game since both have objects to collect that increase the score and are infinitely playable until the player crashes with an obstacle. The differences between both are the following:

The 3D Helicopter Game is a 2.5D game since it uses 3D models that interact in a 2D world whereas Jumpy Cat is a game with 3D models that move in the Z axis while the player moves along the X and Y axis.

One game uses an image that is scrolled to simulate a moving background while the other uses static objects as a ground and hills and moves all objects in the same direction to pretend like the player is moving forwards.

3D Helicopter Game has a static camera while the camera in Jumpy Cat follows the X position of the player. 

In Jumpy Cat the score is increased as you progress or collect coins while in 3D Helicopter Game the score only increases when you collect coins or gems.# CS50-Final-Project
