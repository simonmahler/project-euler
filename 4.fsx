open System

//get n-th digit (right to left)
let getNthDigit (x : int) (n : int) =
    let ld = x % (pown 10 n) //strip front
    (ld - ld % (pown 10 (n-1))) / (pown 10 (n-1))

let digitsEqual (x : int) (len : int) (n : int) =
    (getNthDigit x n) = (getNthDigit x (len-n+1))

//is pelindrome?
let isP (n : int) =
    let len = int (Math.Log10 (float n))+1
    let i = [1..len/2]
    i |> List.fold (fun s i -> s && (digitsEqual n len i)) true

let p = seq{100..999}    
let q = seq{for i in p do for j in p do yield i*j}

//solution
q |> Seq.filter (fun x -> isP x) |> Seq.max
