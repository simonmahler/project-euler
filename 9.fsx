let c = [1..500]
let triplets = 
    seq{
        for m in c do
            for n in [1..m] do
                yield ((pown m 2)-(pown n 2), 2*m*n, (pown m 2)+(pown n 2))
    }

triplets 
|> Seq.find (fun (a, b, c) -> a+b+c = 1000)
|> (fun (a, b, c) -> a*b*c) 