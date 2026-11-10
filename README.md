# Unity Essentials (Tutorial Project)

My project from Unity's **Unity Essentials** learning pathway. It's a small collection of scenes, each one teaching a basic part of Unity:

- **Kids Room (3D):** walk around and pick up collectibles
- **Kitchen (Audio):** sound effects and background audio
- **Living Room (Programming):** simple C# scripts, like a door that opens when you walk up to it
- **Top-Down (2D):** a small 2D scene with an animated cat character
- **Bonus scene:** a custom scene of my own

A web build is in the `Web_Builds` folder.

## My Own Addition: Door Closing
The tutorial only made the door **open** when the player walks into its trigger. I added the **closing** part myself:

- **Script:** In [DoorOpener.cs](Assets/_Unity%20Essentials/Scripts/DoorOpener.cs) I added `OnTriggerExit`, which fires a `Door_Close` trigger when the player leaves the door area.
- **Animator:** In the [Door animator controller](Assets/_Unity%20Essentials/Source%20Files/Animation/Door/Door.controller) I added a `Door_Close` trigger parameter, a `Door_Close` animation state, and a transition from the open state to it.

So now the door opens when you walk up and closes again when you walk away.

## Details
- **Unity version:** Unity 6.6 (6000.6.0f1)
