<!-- TABLE OF CONTENTS -->
  <summary>Table of Contents</summary>
  <ol>
    <li><a href="#introduction">Introduction</a></li>
    <li><a href="#project-tasks">Project Tasks</a>
	<ul>
            <li><a href="#character-creation">Character Creation</a></li>
            <li><a href="#character-rigging">Character Rigging</a></li>
	    <li><a href="#animation-creation">Animation Creation</a></li>
	    <li><a href="#animation-state-machine">Animation State Machine</a></li>
            <li><a href="#blend-tree">Blend Tree</a></li>
            <li><a href="#meta-channels">Meta Channels</a></li>
            <li><a href="#ragdoll">Ragdoll</a></li>
        </ul>
    </li>
  </ol>

<!-- Introduction -->
## Introduction

The objectives of this project is to create an interactive animation demo using the tools in Unity as well as Blender. In this report I will detail the step by step work involved.

<!-- Project Tasks -->
## Project Tasks
### Character Creation

I created my character using MakeHuman. MakeHuman is a free open source software that enables you to customise a humanoid character. In order to do this you must select the feature on your character that you want to customise, and use the slider to modify the character. MakeHuman also allows you to select what clothes you want the character to wear<br/><br/>
One I finished creating my character I exported it as a .stl and imported it into blender.

![alt text](Screenshots/makehuman.PNG)

### Character Rigging

The character I imported from MakeHuman was just a mesh without any bones. I used Rigify to generate a humanoid armature, and then manually scaled and moved the bones from this armature into the correct positions inside my mesh.<br/><br/>

![alt text](Screenshots/armature.PNG)

Once I was happy with the placement of the armature I used the automatic weight paint option in blender to attach the armature to the mesh. I then had to use the weight paint tool to correct some vertex weighting problems that occured after the automatic weight painting.

![alt text](Screenshots/weightpaint.PNG)

To make animations easier I added IK solvers onto my Armature in blender. This enabled me to move the characters leg by dragging 1 bone on the characters foot, rather than individually moving the thigh, shin and feet bones. It also made sure that the knee joint could only bend the correct way.   

![alt text](Screenshots/IK.PNG)

### Animation Creation

I made a number of animations for this project (walkforward, walkbackwards, stafeleft, staferight, wave, kick, block)<br/><br/>
In order to make animations I had to use the animation timeline in blender, to do this I started off at frame one and saved the characters position, I would then move down a coupld of frames and change the characters pose again and save as a keyframe. I would continue this until the character appears to be doing an action.

Examples of two of my animations for walking forward and strafing left:
![alt text](Screenshots/walk.gif)

![alt text](Screenshots/strafe.gif)

### Animation State Machine

### Blend Tree

### Meta Channels

### Ragdoll

main scene uses snap turning because continuous turning causes motion sickness.



















