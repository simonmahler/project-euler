let divisors = [2..20]
let isDivisible divs x =
    divs |> List.fold (fun s d -> x%d=0) true 

Seq.initInfinite (fun i -> i*20) 
|> Seq.filter (isDivisible divisors)
|> Seq.min

