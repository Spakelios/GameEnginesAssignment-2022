# GameEnginesAssignment-2022
# Weather Machine

Names: Gabriele Lenzi, Kellie Meagher, Joelle Tierney

Student Numbers: C20743749, C20454772, C20504119

Class Group: DT508 (TU984) Game Design

Video:

[![YouTube](https://media.discordapp.net/attachments/1027932423108956230/1055242132820082779/image.png?width=971&height=701)](https://youtu.be/oc226q2gxTA)


# Description of the project

A machine with a monitor and buttons which will bring up UI on the centre monitor that lets you control a weather system, with three distinct weather effects (rain, snow, and thunder & lightning), each customizable to the user needs and custom music depending on the selected weather effect. The player will also be able to use special features depending on the effect chosen, such as bouncing rain or colourful snow. There's also a spinning holographic vinyl record, which will react to the music currently being played in the scene.

# Instructions for use

The player will spawn in front of a desk with monitors & buttons. They will be able to interact with said items by pointing at the buttons with their VR controllers, which will make the screen activate and show different toggles and sliders. Using the left and right triggers on the VR controllers and the in-game pointers (red lines), the player wil be able to interact with the toggles and the sliders to change the effects and toggle special features.

# How it works 

- Particle System for weather effects
- Shaders for the clouds & hologram effect
- Custom Models for the machine itself & the vinyl record
- XR Controls for player control and interaction
- Unity Animator to animate the machine's buttons
- Unity UI to create the control panel for each effect



# List of classes/assets in the project

| Class/asset | Source |
|-----------|-----------|
| Middle point calculator.cs | Self written |
| rotatewind.cs | Self written |
| snowController.cs | Self written |
| followind.cs | Self written |
| buttonVR.cs | Self written |
| snow.cs | Self written |
| MusicManager.cs | Self written |
| RainBehaviourController.cs | Modified from [reference](https://docs.unity3d.com/ScriptReference/Gradient.html)|
| VinylHologram.cs |From [reference](https://github.com/skooter500/GE1-2022-2023/blob/master/GE1%20Examples%202022/Assets/AudioViz3.cs)|
| AnimateHand.cs | Self written |
| BoltColourChange.cs | Self written |
| Lightening.cs | From [reference](https://www.youtube.com/watch?v=hCP5w5vTsDc&t=1094s)|
| MaterialEditor.cs | Self written |
| PlayAnimation.cs | Self written |
| TriggerBox.cs | Self written |
| Hand Model | From [reference](https://drive.google.com/file/d/10b39IekUdpBHlcTslZ-BlNRyH5uqPUe1/view)|
| FlickeringLights.cs | From [reference](https://www.dropbox.com/s/vf20awjj3nul1w0/FlickeringLight.cs?dl=0)|
| Rainy Vibes.wav| Self made using BeepBox |
| Cloudy Vibes.wav| Self made using BeepBox |
| Thundering Vibes.wav| Self made using BeepBox|
| Snow Vibes.wav| Self made using BeepBox |
| VinylHologram.prefab| Self made using ProBuilder |
| Weather Machine.prefab| Self made using Probuilder |
| Hologram.shadergraph| From [reference](https://www.youtube.com/watch?v=KGGB5LFEejg)|
| Cloud.shadergraph| From [reference](https://www.youtube.com/watch?v=xxhvUyvIH6s&t=912s) |
|ButtonPress1.anim| Self made using Unity Animator |
|Rain_Collision.png| Self made in Photoshop|
|HologramLines_Cool.psd| From [reference]([https://www.youtube.com/watch?v=KGGB5LFEejg](https://github.com/Brackeys/Shader-Graph-Tutorials/blob/master/Shader%20Graph/Assets/Textures/HologramLines_Cool.psd))|
|Rain Particles| Self made using Unity Particle System|
|Snow Particles| Self made using Unity Particle System|
|Lightning Bolt Particles| Self made using Unity Particle System|





# References
* [Colour Gradient](https://docs.unity3d.com/ScriptReference/Gradient.html)
* [Audio Analyser](https://github.com/skooter500/GE1-2022-2023/blob/master/GE1%20Examples%202022/Assets/AudioViz3.cs)
* [Lightning Manager](https://www.youtube.com/watch?v=hCP5w5vTsDc&t=1094s)
* [Flickering Lights](https://www.dropbox.com/s/vf20awjj3nul1w0/FlickeringLight.cs?dl=0)
* [Hologram Shadergraph](https://www.youtube.com/watch?v=KGGB5LFEejg)
* [Hologram Texture](https://github.com/Brackeys/Shader-Graph-Tutorials/blob/master/Shader%20Graph/Assets/Textures/HologramLines_Cool.psd)
* [Cloud Shadergraph](https://www.youtube.com/watch?v=xxhvUyvIH6s&t=912s)
* [Oculus Hands](https://drive.google.com/file/d/10b39IekUdpBHlcTslZ-BlNRyH5uqPUe1/view)

# What we are most proud of in the assignment

* Gabriele: The overall use of the particle system made me realize its potential and how it can become a powerful tool if mixed with code and other tools that unity provides.
* Joelle: I'm happy with how the music turned out; I believe that making one main melody with accompaniment and then changing the instruments to suit the weather effect worked really well.
* Kellie: The implementation and manipulation of elements of the shader graph and skybox, the clouds turned out espcially well as it reacted to the lightning effect.

# What we learned

* Gabriele: How to better use the particle system and how implementing code to it increases its value and makes it more interesting both to create and witness.
* Joelle: I got a better look into how shadergraphs worked using the hologram tutorial, and how useful they truly are when it comes to making materials for GameObjects.
* Kellie: I got to better understand how to set up and implement VR in unity. As well as a more indept look at manipulating elements of shader graphs and materials through c#.

# Proposal submitted earlier can go here:

#### Description of the project

A weather machine that has a variety of levers and buttons that allows you to manipulate & change the weather in the environment. There will be regular weather effects such as clouds & sunshine, along with more unique weather effects like rainbow rain & snow that falls upwards.

#### How it works (How we plan to implement it)

- Procedurally generated weather patterns
- Particle System for visual effects
- Shaders to change colours
- Custom Models for the machine itself
- XR Controls for player control and interaction
- Unity Animator to animate the machine
