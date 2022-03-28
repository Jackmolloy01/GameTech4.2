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

### Character Creation

### Animation Creation

### Animation State Machine

### Blend Tree

### Meta Channels

### Ragdoll

main scene uses snap turning because continuous turning causes motion sickness.

![alt text](Screenshots/walk.gif)

















