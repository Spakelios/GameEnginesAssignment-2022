# GameEnginesAssignment-2022
# Project Title

Names: Gabriele Lenzi, Kellie Meagher, Joelle Tierney

Student Numbers: C20743749, C20454772, C20504119

Class Group: DT508 (TU984) Game Design

Video:


# Description of the project

insert new one here

# Instructions for use

the player will spawn in front of a device with screens and buttons, they will be able to interact with said items by pointing at the buttons which will make the screen activate and show different toggles and sliders, using the buttons on the controllers and the pointing lasers, the player wil be able to interact with the toggles and the sliders to change the effects

# How it works 

- Particle System for visual effects
- Shaders to change colours
- Custom Models for the machine itself
- XR Controls for player control and interaction
- Unity Animator to animate the machine



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
| Hand Model | oculus starter kit |
| FlickeringLights.cs | From [reference](https://www.dropbox.com/s/vf20awjj3nul1w0/FlickeringLight.cs?dl=0)|
| Rainy Vibes.wav| Self made |
| Cloudy Vibes.wav| Self made |
| Thundering Vibes.wav| Self made |
| Snow Vibes.wav| Self made |
| VinylHologram.prefab| Self made using ProBuilder |
| Weather Machine.prefab| Self made using Probuilder |
| Hologram.shadergraph| From [reference](https://www.youtube.com/watch?v=KGGB5LFEejg)|
| Cloud.shadergraph| From [reference](https://www.youtube.com/watch?v=xxhvUyvIH6s&t=912s) |




# References
* [Gradient](https://docs.unity3d.com/ScriptReference/Gradient.html)
* [Audio Analyser](https://github.com/skooter500/GE1-2022-2023/blob/master/GE1%20Examples%202022/Assets/AudioViz3.cs)
* [Lightning Timer](https://www.youtube.com/watch?v=hCP5w5vTsDc&t=1094s)
* [Flickering Lights](https://www.dropbox.com/s/vf20awjj3nul1w0/FlickeringLight.cs?dl=0)
* [Hologram Shadergraph](https://www.youtube.com/watch?v=KGGB5LFEejg)
* [Cloud Shadergraph](https://www.youtube.com/watch?v=xxhvUyvIH6s&t=912s)

# What I am most proud of in the assignment

the overall use of the particle system made us realize its potential and how it can become a powerfull tool if mixed with code and other tools that unity provides. 

# What I learned

how to better use the particle system and how implementing code to iit increase its value and makes it more interesting both to create with and to witness.

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

## This is how to markdown text:

This is *emphasis*

This is a bulleted list

- Item
- Item

This is a numbered list

1. Item
1. Item

This is a [hyperlink](http://bryanduggan.org)

# Headings
## Headings
#### Headings
##### Headings

This is code:

```Java
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

So is this without specifying the language:

```
public void render()
{
	ui.noFill();
	ui.stroke(255);
	ui.rect(x, y, width, height);
	ui.textAlign(PApplet.CENTER, PApplet.CENTER);
	ui.text(text, x + width * 0.5f, y + height * 0.5f);
}
```

This is an image using a relative URL:


This is an image using an absolute URL:


This is a youtube video:



This is a table:

| Heading 1 | Heading 2 |
|-----------|-----------|
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
|Some stuff | Some more stuff in this column |
