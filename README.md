# Introduction_to_Unity_SS23

### The game
The game is build using Unity version 2022.3.2f1. The character the player is steering is a car placed in a terrain populated by aliens. In this terrain there are also astronauts scattered around. The player has to collect these astronauts while avoiding the alines, as they would damage it.
There are a total of nine astronauts and nine aliens in the game.

### The Astronauts
The astronauts are a prefab from the unity asset store. They were placed manually on the map. This is something that definitely will be adapted but was deemed sufficient for this prototype. Placing them randomly comes with the challenge of the terrain not being a flat surface. 
The astronauts are equipped with a box collider that registers collision, allowing to increment the number of collected astronauts when the player collides with an astronaut. The astronauts are collected by 'bumping' into them.

### The Aliens
The aliens are a prefab from the Unity Asset store. They also were placed manually on the terrain. However, the alines do move around, thus there is no need to place them randomly.
The aliens movement is controlled by the Unity AI Engine. Thus the terrain is a Nav Mesh Surface and the Aliens all are Nav Mesh Agents. Every Alien receives a random destination within a specified distance. The AI Engine then plans the path using the Nav Mesh Surface. This leads to more realistic enemies and also increases the difficulty of the game as the movement of the aliens is not predictable by the player.

### The Player
The player steers are car using the usual `wasd` commands for steering. The space key is used for braking. The body of the car is a free asset from the unity asset store. To allow for more realistic steering of the car, wheel colliders were added to all four of the wheels. This has the advantage that unity already provides a lot of funtionalities to apply motorTorque as well as brakeTorque to individual wheels. It is also possible to rotate and turn the wheel meshed in accordance with the wheel colliders. 
One disadvantage of the wheel colliders is that the car might easily flip over in turns. To avoid this one can play around with the angular drag value. 1.5 seems to work reasonably well for the car used in the game. This doesn't completely prevent the car from flipping over in turns, so turns should be taken with care.

