namespace StringCalculatorKataInFSharp.Tests

open StringCalculatorKataInFSharp
open NUnit.Framework
open FsUnit

[<TestFixture>] 
type ``Given a calculator``()=
    let calc = new StringCalculator()
    let addAndAssert input expected = 
      calc.Add input |> should equal expected

    [<Test>] member test.
     ``when adding an empty input it returns 0`` ()=
            addAndAssert "" 0

    [<Test>] member test.
      ``when adding a "0" input it returns 0`` ()=
         addAndAssert "0" 0
         
    [<Test>] member test.
     ``when adding a 1 alone it returns 1`` () =
        addAndAssert "1" 1
 
    [<Test>] member test.
     ``when adding a 2 alone it returns 2`` () =
        addAndAssert "2" 2

    [<Test>] member test.
      ``when adding an A it throws`` () =
        (fun () -> calc.Add "A" |> ignore) |> should throw typeof<System.ArgumentException>

