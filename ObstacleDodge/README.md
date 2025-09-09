## Time.deltaTime

This is a crucial property within the Time class that represents the time in seconds it took to complete the last frame.
It essentially measures the time elapsed between the current frame and the previous one.

### Purpose

The primary purpose is to ensure that game logic, particularly movement and animation, remains consistent regardless of the frame rate.

### Example

Consider moving an object at a speed of 5 units per second. Instead of directly adding 5 units to its position in Update(), which would make it move much faster at higher frame rates, one would multiply the speed by Time.deltaTime.

`transform.Translate(Vector3.forward * 5f * Time.deltaTime);`