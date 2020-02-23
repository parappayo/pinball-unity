# pinball-unity

Sandbox for experimental pinball components in Unity3d engine

## Pinball Facts

Typical measures:

* Pinballs are 2.7 cm in diameter and 80 g in mass
* Table slope is 6.5 degrees, varies by half a degree
* Table dimensions are 130 cm long by 72 cm wide by 192 cm heigh
* Flipper dimensions are 7 cm long with a 1.5 cm diameter that tapers to 5 cm
* Flipper angle is 115 degrees with a swing of 55 degress, varies by 5 degrees

## Physics Setup

Ball mass is set to 80 and scale is set to 2.7, so our units are grams and centimeters. Accordingly, gravity is set to -981 cm / s^2.

Many physical quantities in Unity3d are represented as single precision floating point numbers, so some accuracy is lost when dealing with numbers between 0.0f and 1.0f. This is known as the "hole at zero" and has to do with the implied leading 1 bit in the mantissa.

## Links

* [Pinball Flippers - Unity Forums Thread](https://forum.unity.com/threads/pinball-flippers-swatting-objects-using-physics.220281/)
* [Dimensions of Standard Pinball Flippers - Reddit Thread](https://www.reddit.com/r/pinball/comments/3j1c5x/dimensions_of_standard_pinball_flippers/)
* [Common Angular Extents for Flippers - Reddit Thread](https://www.reddit.com/r/pinball/comments/3jc29f/what_are_the_most_common_angular_extents_used_for/)
