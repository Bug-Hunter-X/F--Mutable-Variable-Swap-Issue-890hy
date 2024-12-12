let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

swap x y
printf "%d %d" x y //This will print 20 20, not 20 10 as expected in other languages like C# or Java because of the immutability of the variables in F#