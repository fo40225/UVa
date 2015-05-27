namespace FSharpLibrary

// ----------------------------------------------------
//                       result, p                     
//                        v                            
//                       3 0 7                         
//                      ------                         
//                  3   |94249 <- num (group by 100: 3)
// d, guessResult ->3   |90000 <- value                
//     (p*20+d)*d ->60  | 4249 <- test, next           
//                   0  |  0                           
//                  607 | 4249                         
//                    7 | 4249                         
// ----------------------------------------------------
// Q10023 Square root in F#
module Q10023FS = 
    let public GetAnswer input = 
        let rec GetSqrtRoot num times p = 
            let rec Pow x y t = 
                match y with
                | 0 -> 1I
                | 1 -> t
                | _ -> Pow x (y - 1) (x * t)
            
            let rec guess digi = 
                let d = bigint (int digi)
                let value = (((20I * p) + d) * d) * (Pow 100I times 100I)
                let test = num - value
                if (digi <> 0) && (test < 0I) then guess (digi - 1)
                else (((10I * p) + d), test)
            
            let guessResult = guess 9
            let next = snd guessResult
            let result = fst guessResult
            if next = 0I || times = 0 then result * (Pow 10I times 10I)
            else GetSqrtRoot next (times - 1) result
        
        let rec div100 input tail = 
            if (input / 100I) = 0I then tail
            else div100 (input / 100I) (tail + 1)
        
        let groups = div100 input 0
        GetSqrtRoot input groups 0I
