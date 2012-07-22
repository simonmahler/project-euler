let n =
    seq{1..1000}
    |> Seq.map (fun x -> pown (bigint x) x)
    |> Seq.sum
    |> string

n.Substring(n.Length-10)