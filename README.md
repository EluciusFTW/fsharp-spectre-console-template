# FSharp Spectre.Console Template

This repository contains a small, ready-to-go starting point for developing a console application in F#, using the [Spectre.Console.Cli](https://spectreconsole.net/cli/) library.

Spectre.Console.Cli uses _commands_ and _settings_ to create strongly typed bindings to console arguments. 
It also provides help and documentation and default values in a simple manner.

## Sample
This template contains one sample command, _greet_, to which you can provide your name (using `-n|--name`) as a parameter:

```PS
dotnet run greet -n "John"
````

Feel free to clone it and start your application from here!

## Spectre.Console & SpectreCoff
This template is just about _Spectre.Console.Cli_, i.e., using the commands and parameter bindings package.

We do recommend using it together _Spectre.Console_ via [SpectreCoff](https://github.com/EluciusFTW/SpectreCoff), our F# wrapper.

## Feedback and Contributing
All feedback welcome!
All contributions are welcome!
