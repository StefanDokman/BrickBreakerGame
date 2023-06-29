# BrickBreakerGame
edgeDetection add EdgeCollider2D to camera and calculates angles from the middle of the screen to the edges so the ballMovement can calucate normal comparded to where it hits
Brick2 add EdgeCollider2D to bricks and calculates angles from the middle of the brick to the edges so the ballMovement can calucate normal comparded to where it hits
BlockMovementRB moves the paddle and calculates the bounce of the ball when it hits him
BallMovement moves the ball and calculates the bounce
Death moves the ball to th emiddle of the screen when the ball hits objects its attached to 

These scripts don't use any rigid body or physics material to callulate anything just their position and rotation, 
so the most of this code would work on plain c# if you add collision detection
