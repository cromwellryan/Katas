// Learn more about F# at http://fsharp.net

namespace StringCalculatorKataInFSharp

type StringCalculator() =
  member calc.Add input = 
    match input with 
    | "" -> 0
    | "0" -> 0
    | "1" -> 1
    | "2" -> 2
    | _ -> raise (System.ArgumentException())