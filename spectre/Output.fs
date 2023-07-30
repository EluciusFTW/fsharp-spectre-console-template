module Output
open Spectre.Console

let primaryStyle = "green"

let markup style content = 
    $"[{style}]{content}[/]"
let emphasize content = 
    markup primaryStyle content

let printMarkedUp content = AnsiConsole.Markup $"{content}{System.Environment.NewLine}"