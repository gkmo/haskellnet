namespace Teste

module Program =                
          
    let state = (GHC.Prim.State (()))      
        
    System.Console.WriteLine("Rfib")
    RFib.Main.zcmain state |> ignore
    
//    System.Console.WriteLine("Exp3_8")    
//    Exp3_8.Main.zcmain state |> ignore
    
//    System.Console.WriteLine("Queens")    
//    Queens.Main.zcmain state |> ignore
    
//    System.Console.WriteLine("Primes")
//    Primes.Main.zcmain state |> ignore
//
//    System.Console.WriteLine("Tak")
//    Tak.Main.zcmain state |> ignore    
//
//    System.Console.WriteLine("Wheel Sieve 1")
//    WheelSieve1.Main.zcmain state |> ignore    
//      
//    System.Console.WriteLine("Wheel Sieve 2")
//    WheelSieve2.Main.zcmain state |> ignore        

    System.Console.ReadLine() |> ignore