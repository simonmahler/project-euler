open System
let n = 10000
let mutable primes = Array.create (n+1) 0
let isPrime (nth:int) (c:int) =
    seq{for i in [0..(nth-1)] do yield i}
    |> Seq.filter (fun i -> primes.[i] <= (int (Math.Sqrt (float c))))
    |> Seq.fold (fun s i -> s && c % primes.[i] <> 0) true

//seed
primes.[0..1] <- [|2; 3|]

let getPrime (nth:int) =
    Seq.initInfinite (fun i -> primes.[nth-1]+i+1)
    |> Seq.find (isPrime nth)

seq{2..n}
|> Seq.iter(fun i -> 
    primes.[i] <- getPrime i)

primes.[n]



//104743