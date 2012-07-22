let nextTerm  = function
    | a when a % 2I = 0I -> a/2I
    | a -> 3I * a + 1I

let rec findLength len (n:bigint) =
    match n with
    | a when a = 1I -> len
    | _ -> findLength (len+1) (nextTerm n)

seq{1I..1000000I}
|> Seq.map (fun x -> (x, (findLength 1 x)))
|> Seq.maxBy (fun (a, b) -> b)