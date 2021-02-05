# HelloWorld
## Setup

We're going to get your first C# console application setup and running so that we can review some basics of the language.

1. Open Visual Studio and create a new project.
2. Select `Console App (.NET Core)`
3. Change the name of the project to `HelloWorld` and choose a directory location for your project.

This will create a new [Solution](https://docs.microsoft.com/en-us/visualstudio/extensibility/internals/solutions-overview) with a new [Project](https://docs.microsoft.com/en-us/visualstudio/extensibility/internals/projects) with a single file in it named `Program.cs`.
`Program.cs` is the file that holds your logic. Think of it as your `App.js` from React. It's where the logic of your application starts; the entry point.

Add this code into your `Program.cs` file inside of the `Main` function, replacing everything there.

```csharp
Console.WriteLine("Howdy Y'all!!");
Console.ReadKey(); // What happens if you run the app without this line?
```

Next, you compile the program. You can do this two ways.

- by a keyboard shortcut : Ctrl+Shift+B
- by going to the `Build` menu and selecting the `Build Solution` option

> ☞ Unlike JavaScript, C# is a pre-compiled language, meaning that you need a compiler to read the source code, parse all the logic, and then construct a new executable file that can be shared and run on other machines.

Now that you have verified that the program will compile without errors, you can execute it. This can be done by hitting the green play button in the toolbar or by pressing the F5 key.

Because this is a console application, a terminal window will open and you should see `Howdy Y'all!!` print out in your console application. Press the any key to continue and exit the application.

Add the following code to your `Main` method.

```csharp
var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

foreach(var animal in animals)
{
	Console.WriteLine(animal);
}
```

Luckily, the `if-then` syntax works exactly like it did in JavaScript. Let's put a condition around what animals get displayed.

> Add a feature to your application that will only print animal names that have ~2 syllables or more.

> Add a feature to your application that will accept an input that asks the user to pick from at least 3 different greetings. Obviously the default option should be "Southern"

HINT: you're going to need to google or ask someone how to pass a command line argument to your console app.
