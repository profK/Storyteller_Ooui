// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp
open System
open Ooui

// Define a function to construct a message to print


[<EntryPoint>]
let main argv =
     let button = Button("Click me!");

        // Add some logic to it
     let mutable count = 0;
     button.Click.Add(
         fun evt ->
            count <- count + 1
            button.Text <- $"Clicked {count} times"
            ()
     )

        // Publishing makes an object available at a given URL
        // The user should be directed to http://localhost:8080/shared-button
     UI.Port <- 5370   
     UI.Publish ("/shared-button", button)

        // Don't exit the app until someone hits return
     Console.ReadLine()
     0
