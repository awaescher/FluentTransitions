# SharpTransitions

A library for animated UI transitions for .NET.

[![Build state](https://travis-ci.org/UweKeim/dot-net-transitions.svg?branch=master)](https://travis-ci.org/UweKeim/dot-net-transitions "Travis CI build status")

## Overview

The Transitions library lets you create animated transitions of any properties of user-interface elements for .NET. It provides an easy way to perform UI animations in .NET in a similar way to the Core Animation library for Apple and the iPhone.

## Getting started

You can animate a single property of an object with a single line of code like this:

```
Transition.Run(this, nameof(BackColor), Color.Red, new Methods.Linear(1000));
```

If this code is in a form class, it animates the background color from its initial color to red over the course of 1000ms.

You can animate multiple properties (maybe across multiple objects) simultaneously with code like this:

```csharp
var transition = new Transition(new Methods.EaseInEaseOut(2000));
transition.Add(pictureBox1, nameof(Left), 300);
transition.Add(pictureBox1, nameof(Top), 200);
transition.Run();
```

This animates the movement of pictureBox1 from its initial location to (300, 200) over the course of 2000ms.

## Coding with Transitions

The TestApp project demonstrates a number of different transitions. It is fairly well commented, and can act as a tutorial to help get you started.

For more information on how to code with the Transitions library see the coding reference.

## Acknowledgements

&copy; 2009 Richard S. Shepherd.

2020-10-07 Andreas Wäscher
- Migrated to .NET Core 3.1 and .NET Framework 4.8
- Updated namespaces, class names and the code itself to meet modern code standards
- Switched from "dot-net-transitions" to "SharpTransitions"

2015-07-16 Uwe Keim
- Copied this repository from [Google Code](https://code.google.com/p/dot-net-transitions/) to save it from disappearing when Google Code shuts down.

Thanks to Maxim Gready for writing the critical-damping transition-type.
