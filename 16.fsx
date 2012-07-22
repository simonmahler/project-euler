(string (pown 2I 1000)).ToCharArray()
|> Array.map (fun c -> (int c)-(int '0'))
|> Array.sum