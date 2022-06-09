
// Type
let age = 65 // int
let PI = 3.14 // float
let name1 = "my name" // string

let sum:float = 0.0

// String interpolation
let name = "Luis"
let company = "Microsoft"
printfn $"Name: {name}, Company: {company}"

let firstNumber = 2000
let secondNumber = 21
printfn $"The year is: {firstNumber + secondNumber}"

let name3 = "Chris"
printf "Hi %s" name3
// prints: Hi Chris

// %s string 
// %d, %i decimal 
// %b true false 

// Define a new function to print a name.
let printGreeting name =
    printfn $"Hello {name} from F#!"

// Call your new function!
printGreeting "Ailen"

// For more information see https://aka.ms/fsharp-console-apps
// printfn "Hello from F#"



