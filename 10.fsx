let isPrime c =
    seq{for i in 2I::[3I..2I..(bigint (System.Math.Sqrt (float c)))] do yield i}
    |> Seq.fold (fun s i -> s && c % i <> 0I) true

(seq{3I..2000000I}
|> Seq.filter isPrime
|> Seq.sum) + 2I

