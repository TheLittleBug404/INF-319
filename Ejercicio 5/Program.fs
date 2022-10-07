// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

open System
let suma a b = a + b
let resta a b = a - b
let multiplicacion a b = a * b
let division a b = a / b


[<EntryPoint>]
let main argumentos =

    let c=suma 6 6 
    let m=resta 6 6 
    let n=multiplicacion 6 6 
    let o=division 6 6 
    Console.WriteLine("la suma es = "+c.ToString())
    Console.WriteLine("la resta es = "+m.ToString())
    Console.WriteLine("la multiplicacion es = "+n.ToString())
    Console.WriteLine("la division es = "+o.ToString())
    let tecla = Console.ReadKey()

    0 // return an integer exit code