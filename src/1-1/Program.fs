open System

let rec count last total =
    match box last, box (Console.ReadLine()) with
    | (:? string as a), (:? string as b) -> count b (total + Convert.ToInt32((int) b > (int) a))
    | _ -> total

printfn "%i" (count (Console.ReadLine()) 0)
