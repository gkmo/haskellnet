namespace Primes

module Main = 
    let private lvl : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
        lazy
        (
            (Control.Exception.Base.patError<GHC.Types.ZMZN<GHC.Types.Int>> ("Main.hs:8:0-39|function the_filter"))
        )
    
    let private lvl1 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun xaIB ysaIC ->
            (GHC.Types.ZC  ((lazy (GHC.List.head<GHC.Types.Int> (xaIB))), (ysaIC)))
    
    let private lvl2 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun dsdCy ->
            let 
                wildB1 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = dsdCy
            in
                match wildB1.Force() with
                | GHC.Types.ZC (nafH, nsafJ) -> 
                    (GHC.List.filter<GHC.Types.Int> (fun xafB ->
                        let 
                            waJM : Lazy<GHC.Types.Int> = nafH
                        in
                            match waJM.Force() with
                            | GHC.Types.Izh (wwaJO) -> 
                                let 
                                    wild1aJS : GHC.Prim.Intzh = wwaJO
                                in
                                    match wild1aJS with
                                    | 0-> 
                                        GHC.Err.divZZeroError<GHC.Bool.Bool>.Force()
                                    |_ -> 
                                        let 
                                            wild11aJT : Lazy<GHC.Types.Int> = xafB
                                        in
                                            match wild11aJT.Force() with
                                            | GHC.Types.Izh (x1aJV) -> 
                                                let 
                                                    wild2aJX : GHC.Prim.Intzh = x1aJV
                                                in
                                                    match wild2aJX with
                                                    | -2147483648-> 
                                                        let 
                                                            wild3aJZZ : GHC.Prim.Intzh = wild1aJS
                                                        in
                                                            match wild3aJZZ with
                                                            | -1-> 
                                                                GHC.Err.overflowError<GHC.Bool.Bool>.Force()
                                                            |_ -> 
                                                                let 
                                                                    wild21aK0 : System.Int32 = (GHC.Base.modIntzh (-2147483648) (wild3aJZZ))
                                                                in
                                                                    match wild21aK0 with
                                                                    | 0-> 
                                                                        false 
                                                                    |_ -> 
                                                                        true 
                                                            
                                                    
                                                    |_ -> 
                                                        let 
                                                            wild21aJY : System.Int32 = (GHC.Base.modIntzh (wild2aJX) (wild1aJS))
                                                        in
                                                            match wild21aJY with
                                                            | 0-> 
                                                                false 
                                                            |_ -> 
                                                                true 
                                                    
                                            
                                    
                            
                    ) (nsafJ))
                | GHC.Types.ZMZN -> 
                    (lvl).Force()
    
    
    let private lvl3 : Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun xafx ->
            let 
                wildaKS : Lazy<GHC.Types.Int> = xafx
            in
                match wildaKS.Force() with
                | GHC.Types.Izh (x1aKU) -> 
                    (GHC.Types.Izh ((GHC.Prim.zpzh (x1aKU) (1))))
    
    
    let private lvl4 : Lazy<GHC.Types.Int> = 
        lazy
        (
            (GHC.Types.Izh (2))
        )        
    
    let private lvl7 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
            let 
                waRk : GHC.Types.Int = (GHC.List.sub<GHC.Types.Int> (lazy (GHC.List.iterateFB<GHC.Types.ZMZN<GHC.Types.Int>, GHC.Types.ZMZN<GHC.Types.Int>> (lvl1) (lvl2) (lazy (GHC.List.iterate<GHC.Types.Int> (lvl3) (lvl4))))) (4500))
            in
                match waRk with
                | GHC.Types.Izh (wwaRm) -> 
                    (GHC.Show.zdwshowSignedInt (0) (wwaRm) (lazy (GHC.Types.ZMZN )))
        )
    
    let private a : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        fun etaaL9 ->
            let 
                wildaR9 : GHC.Prim.Z2H<GHC.Prim.Statezh<Microsoft.FSharp.Core.Unit>, GHC.Unit.Z0T> = (GHC.IO.a29 (GHC.Handle.stdout) (lvl7) (etaaL9))
            in
                match wildaR9 with
                | GHC.Prim.Z2H (newzusaRb, a89aRc) -> 
                    (GHC.IO.zdwa10 (GHC.Handle.stdout) ('\x0a') (newzusaRb))
    
    
    let private a1 : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        (GHC.TopHandler.a4<GHC.Unit.Z0T> (a))
    
    let zcmain : GHC.IOBase.IO<GHC.Unit.Z0T> = 
        a1           
    
    System.Console.WriteLine("Press ENTER to continue...")  
    System.Console.ReadLine() |> ignore        
    System.Console.WriteLine("Primes")
    
    zcmain (GHC.Prim.State (())) |> ignore
