namespace Commands

module Greet =
    open Spectre.Console.Cli
    open Output

    type HelloSettings() =
        inherit CommandSettings()

        [<CommandOption("-n|--name")>]
        member val name = "friend" with get, set
    
    type Hello() =
        inherit Command<HelloSettings>()
        interface ICommandLimiter<HelloSettings>

        override _.Execute(_context, settings) = 
            printMarkedUp $"Hello {emphasize settings.name}! Enjoy the Spectre.Console starter template for F#."
            0