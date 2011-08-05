// Learn more about F# at http://fsharp.net

namespace StringCalculatorKataInFSharp

type StringCalculator() =

  let safeparse input = 
    match input with 
      | "" -> 0
      | input -> match System.Int32.TryParse(input) with 
                  | (false, _) -> raise (new System.ArgumentException("Unable to parse"))
                  | (true, value) -> value

  member calc.Add (input : string) = 
    input.Split(';') |> 
    Array.map safeparse
