let sumOfSquares x =
    x |> Seq.map (fun i -> i*i) |> Seq.sum
let squareOfSum x =
    x |> Seq.sum |> (fun i -> i*i)
let s = [1..100]
let d = (squareOfSum s) - (sumOfSquares s)