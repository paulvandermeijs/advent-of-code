open System

let rec count last total =
    let a, b, c = last
    match box a, box b, box c, box (Console.ReadLine()) with
    | (:? string as a), (:? string as b), (:? string as c), (:? string as d) -> 
        count (b, c, d) (total + Convert.ToInt32(((int) b + (int) c + (int) d) > ((int) a + (int) b + (int) c)))
    | _, _, _, (:? string as d) -> count (b, c, d) total
    | _ -> total

printfn "%i" (count (null, null, Console.ReadLine()) 0)
