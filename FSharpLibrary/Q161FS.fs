namespace FSharpLibrary

type private LightStatus = 
    | Green = 0
    | Yellow = 1
    | Red = 2

/// Q161 Traffic Lights in F#
module Q161FS = 
    let private TtrafficLightStatus period nowSec = 
        let greenToYellow p = p - 5
        let yellowToRed p = p
        let redToGreen p = p * 2
        let getInCycleSec input = input % redToGreen period
        
        let inCycleSecToStatus sec = 
            match sec with
            | x when nowSec = 0 && x = 0 -> LightStatus.Green
            | x when 0 < x && x <= greenToYellow period -> LightStatus.Green
            | x when greenToYellow period < x && x <= yellowToRed period -> LightStatus.Yellow
            | x when yellowToRed period < x || x = 0 -> LightStatus.Red
            | _ -> failwith "error"
        getInCycleSec nowSec |> inCycleSecToStatus
    
    let rec private FindNextAllGreen periods passedSec = 
        if periods
           |> Array.map (fun x -> TtrafficLightStatus x passedSec)
           |> Array.forall (fun x -> x = LightStatus.Green)
        then passedSec
        else if passedSec < 18001 then FindNextAllGreen periods (passedSec + 1)
        else raise (System.TimeoutException("Signals fail to synchronise in 5 hours"))
    
    let rec private FindFirstNotAllGreenSec periods startSec = 
        if periods
           |> Array.map (fun x -> TtrafficLightStatus x startSec)
           |> Array.forall (fun x -> x = LightStatus.Green)
        then FindFirstNotAllGreenSec periods (startSec + 1)
        else startSec
    
    let public GetAnswer input = 
        if not (Array.forall (fun x -> 10 <= x && x <= 90) input) then 
            raise (System.ArgumentException("Cycle times will not be less than 10 seconds, nor more than 90 seconds."))
        if not (2 <= Array.length input && Array.length input <= 100) then 
            raise 
                (System.ArgumentException
                     ("There will always be at least two signals in a scenario and never more than 100."))
        let nextAllGreenSec = FindFirstNotAllGreenSec input 0 |> FindNextAllGreen input
        new System.TimeSpan(0, 0, nextAllGreenSec - 1)
