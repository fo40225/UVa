namespace FSharpLibrary

/// Q263 Number Chains in F#
module public Q263FS = 
    let private GetMin input = 
        string input
        |> Seq.toArray
        |> Array.map (fun x -> string x |> int)
        |> Array.sort
        |> Array.map string
        |> String.concat System.String.Empty
        |> int
    
    let private GetMax input = 
        string input
        |> Seq.toArray
        |> Array.map (fun x -> string x |> int)
        |> Array.sort
        |> Array.rev
        |> Array.map string
        |> String.concat System.String.Empty
        |> int
    
    let rec private Calc input set = 
        let max = GetMax input
        let min = GetMin input
        let ans = max - min
        printfn "%d - %d = %d" max min ans
        if Set.contains ans set then Set.count set
        else Set.add ans set |> Calc ans
    
    let public GetAnswer input = 
        let set = Set.empty.Add input
        printfn "Original number was %d" input
        let chainLenght = Calc input set
        printfn "Chain length %d" chainLenght
        0 // return an integer exit code
