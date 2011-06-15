namespace HappyNumbersInFSharp.Specs

open NUnit.Framework
open FsUnit
open System

type StringCalculator() =
  let Add' (input:string) =
  
//    let getDelimiter (input:String) = if (input.[0] = '/' && input.[1] = '/') then (Array.create 1, input.[2]) else [|','; '\n'|]

    let parseInt s = Int32.Parse(s)
    let extractNumbers (input:String) d = 
      input.Split(d)

    match input.Length with  
    | 0 -> 0
    | _ -> 0


  member c.Add input = 
    Add' input


[<TestFixture>] 
type ``String Calculator Specs`` ()=
  let calc = StringCalculator()

  [<Test>] member test.
    ``when adding an empty string`` ()=
      calc.Add "" |> should equal 0

  [<Test>] member test.
    ``when adding a 1`` () =
      calc.Add "1" |> should equal 1

  [<Test>] member test.
    ``when adding a 2`` () =
      calc.Add "2" |> should equal 2

  [<Test>] member test.
    ``when adding a 1,2`` () =
      calc.Add "1,2" |> should equal 3
  
  [<Test>] member test.
    ``when adding 2 2s`` () =
      calc.Add "2,2" |> should equal 4
  
  [<Test>] member test.
    ``when adding 2 2s delimited by a new line`` () =
      calc.Add "2\n2" |> should equal 4

  [<Test>] member test.
    ``when adding 4 numbers delimited by a new line`` () =
      calc.Add "1\n2\n3\n4" |> should equal 10

  [<Test>] member test.
    ``asdfasdfasdf`` () =
      [0..9]
      |> List.map(fun(x) -> x+1)
      |> List.sum 
      |> should equal 55
