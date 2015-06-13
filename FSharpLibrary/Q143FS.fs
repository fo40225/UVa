namespace FSharpLibrary

open System.Numerics

// Q143 in F#
module Q143FS = 
    let public GetAnswer input = 
        let verticesX = 
            [ Array.get input 0
              Array.get input 2
              Array.get input 4 ]
        
        let verticesY = 
            [ Array.get input 1
              Array.get input 3
              Array.get input 5 ]
        
        let vertices = List.zip verticesX verticesY
        
        let CheckInside triangle point = 
            let rec GetPointToVertexVector vs p acc = 
                match vs with
                | head :: tail -> 
                    GetPointToVertexVector tail p 
                        (new Vector2(float32 ((fst head) - (float (fst p))), float32 ((snd head) - float ((snd p)))) 
                         :: acc)
                | [] -> acc
            
            let pointToVertexVectors = GetPointToVertexVector triangle point []
            let vectorsCrossResult = 
                List.map2 (fun a b -> Vector3.Cross(new Vector3(a, 0.0F), new Vector3(b, 0.0F))) pointToVertexVectors 
                    (List.tail (pointToVertexVectors @ [ (List.head pointToVertexVectors) ]))
            let counterclockwise = List.map (fun (x : Vector3) -> x.Z <= 0.0F) vectorsCrossResult
            let clockwise = List.map (fun (x : Vector3) -> x.Z >= 0.0F) vectorsCrossResult
            List.forall (fun x -> x) counterclockwise || List.forall (fun x -> x) clockwise
        
        let trees = 
            [ for i in 1..99 do
                  for j in 1..99 do
                      yield (i, j) ]
        
        trees
        |> List.filter (fun x -> CheckInside vertices x)
        |> List.length
