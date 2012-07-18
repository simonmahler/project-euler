(1I, 1I) |> Seq.unfold (fun (x, y) -> Some(x, (y, x + y)))
|> Seq.mapi (fun i x -> (i+1, x))
|> Seq.find (fun (i, x) -> x.ToString().Length = 1000) 
|> fst