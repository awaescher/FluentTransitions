# FluentTransitions

FluentTransitions lets you create animated transitions of any property of user-interface elements in .NET. It provides a simple API to perform UI animations in a similar way to Apple's Core Animation library for iOS, iPadOS and macOS.

## Simple API

Animate one or multiple properties from one or multiple objects simultaneously:

```csharp
Transition()
    With(button1, nameof(Left), 300)
    With(button1, nameof(Top), 200)
    EaseInEaseOut(TimeSpan.FromSeconds(2));
```

This code animates the movement of button1 from its initial location to (300, 200) over the course of two seconds.

## Acknowledgements

Idea and initial implementation by [Richard S. Shepherd on Google Code](https://code.google.com/p/dot-net-transitions/). The code was mirrored to GitHub by [Uwe Keim](https://github.com/UweKeim) to prevent it from disappearing as Google announced the shut down of Google Code.

2020-10-07 [Andreas Wäscher](https://github.com/awaescher)
- Migrated to .NET Core 3.1 and .NET Framework 4.8
- Updated namespaces, class names and the code itself to meet modern code standards
- Added fluent syntax to build and run transitions
- Switched from "dot-net-transitions" to "SharpTransitions" to "FluentTransitions"

2020-04-20 [zhenyuan0502](https://github.com/zhenyuan0502)
- Migrated to .NET Core 3.0

2015-07-16 [Uwe Keim](https://github.com/UweKeim)
- Copied this repository from [Google Code](https://code.google.com/p/dot-net-transitions/) to save it from disappearing when Google Code shuts down.

&copy; 2009 Richard S. Shepherd.
Thanks to Maxim Gready for writing the critical-damping transition method.
