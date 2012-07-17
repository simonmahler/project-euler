let isDivisible d x =
    d |> List.fold (fun s i -> s && x % i = 0) true

Seq.initInfinite (fun i -> (i+1)*20) |> Seq.find (isDivisible [2..20])