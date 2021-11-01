# Lightsaber-Parry
 Hyper Casual Game Prototype Test<br>
 Demo<br>
 ![demo](https://user-images.githubusercontent.com/72542528/139655096-596a98b5-fb40-4a3d-8498-23c9a517909b.gif)<br>
 <br>
 Scene Hierarchy&Project<br>
![Hierarchy](https://user-images.githubusercontent.com/72542528/139654504-93a72f7d-39eb-49f7-8a19-ce9755670061.png)
<br>
Class Diagram
![classDiagram](https://user-images.githubusercontent.com/72542528/139654853-bff8a61d-cf74-4065-9ffe-83bae2a66aa7.png)
<br>
Gameplay: Lightsaber Parry 3D
<hr>
Short description:
Two characters facing each other engage in a lightsaber fight. The 
characters start to swing from their left side. The player sets the angle of 
each lightsaber. A message appears on the screen to show if the 
lightsabers will collide or not. The player will have the option to simulate 
the swing.
<br>
Mechanics:
<li> Use two sliders for the angles
<li>The collision prediction message will update after each valid angle change
<li> (Optional) Spawn a particle where the lightsabers collide
<li>Expose all the configurable parameters to something easily modifiable by Game 
Designers (SO, JSON, static class, etc)
