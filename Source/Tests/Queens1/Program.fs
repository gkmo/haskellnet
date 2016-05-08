namespace Queens

module Main = 
    let private lvlrLC : Lazy<GHC.Types.ZMZN<GHC.Types.ZMZN<GHC.Types.Int>>> = 
        lazy
        (
            (GHC.Types.ZC  ((lazy (GHC.Types.ZMZN )), (lazy (GHC.Types.ZMZN ))))
        )
    
    let private lvl1rLE : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
        lazy
        (
            (GHC.Enum.eftInt (1) (13))
        )
    
    let private lvl2rLG : Lazy<GHC.Types.Int> = 
        lazy
        (
            (GHC.Types.Izh (1))
        )
    
    let rec private saferLI : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Bool.Bool = 
        fun xafx dafzz dsdzzy ->
            let 
                wildB1 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = dsdzzy
            in
                match wildB1.Force() with
                | GHC.Types.ZC (qafF, lafH) -> 
                    let 
                        wild1aBA : Lazy<GHC.Types.Int> = xafx
                    in
                        match wild1aBA.Force() with
                        | GHC.Types.Izh (x1aBC) -> 
                            let 
                                wild11aBE : Lazy<GHC.Types.Int> = qafF
                            in
                                match wild11aBE.Force() with
                                | GHC.Types.Izh (yaBG) -> 
                                    let 
                                        wild2azzJ : System.Boolean = (GHC.Prim.zszezh (x1aBC) (yaBG))
                                    in
                                        match wild2azzJ with
                                        | true -> 
                                            let 
                                                wild12aBu : Lazy<GHC.Types.Int> = dafzz
                                            in
                                                match wild12aBu.Force() with
                                                | GHC.Types.Izh (y1aBw) -> 
                                                    let 
                                                        wild3XAx : System.Boolean = (GHC.Prim.zszezh (x1aBC) ((GHC.Prim.zpzh (yaBG) (y1aBw))))
                                                    in
                                                        match wild3XAx with
                                                        | true -> 
                                                            let 
                                                                wild4XAS : System.Boolean = (GHC.Prim.zszezh (x1aBC) ((GHC.Prim.zmzh (yaBG) (y1aBw))))
                                                            in
                                                                match wild4XAS with
                                                                | true -> 
                                                                    (saferLI (wild1aBA) (lazy (GHC.Types.Izh ((GHC.Prim.zpzh (y1aBw) (1))))) (lafH))
                                                                | false -> 
                                                                    false 
                                                        
                                                        | false -> 
                                                            false 
                                                
                                        
                                        | false -> 
                                            false 
                                
                        
                
                | GHC.Types.ZMZN -> 
                    true 
    
    
    let rec private gorLK : Lazy<GHC.Types.ZMZN<GHC.Types.ZMZN<GHC.Types.Int>>> -> GHC.Types.ZMZN<GHC.Types.ZMZN<GHC.Types.Int>> = 
        fun dsaAv ->
            let 
                wildaAw : Lazy<GHC.Types.ZMZN<GHC.Types.ZMZN<GHC.Types.Int>>> = dsaAv
            in
                match wildaAw.Force() with
                | GHC.Types.ZC (yaAA, ysaAB) -> 
                    let 
                        zzsLb : Lazy<GHC.Types.ZMZN<GHC.Types.ZMZN<GHC.Types.Int>>> = lazy ((gorLK (ysaAB)))
                    in
                        let rec 
                            go1sLd : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.ZMZN<GHC.Types.Int>> = fun ds1XB6 ->
                                let 
                                    wild1XB8 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ds1XB6
                                in
                                    match wild1XB8.Force() with
                                    | GHC.Types.ZC (y1XBf, ys1XBh) -> 
                                        let 
                                            wild2XG : GHC.Bool.Bool = (saferLI (y1XBf) (lvl2rLG) (yaAA))
                                        in
                                            match wild2XG with
                                            | true -> 
                                                (GHC.Types.ZC  ((lazy (GHC.Types.ZC  ((y1XBf), (yaAA)))), (lazy (go1sLd (ys1XBh)))))
                                            | false -> 
                                                (go1sLd (ys1XBh))
                                    
                                    | GHC.Types.ZMZN -> 
                                        (zzsLb).Force()
                            
                        in
                            (go1sLd (lvl1rLE))
                | GHC.Types.ZMZN -> 
                    (GHC.Types.ZMZN )
    
    
    let rec zdwgen : GHC.Prim.Intzh -> GHC.Types.ZMZN<GHC.Types.ZMZN<GHC.Types.Int>> = 
        fun wwsKL ->
            let 
                dsXzzV : GHC.Prim.Intzh = wwsKL
            in
                match dsXzzV with
                | 0-> 
                    (lvlrLC).Force()
                |_ -> 
                    (gorLK (lazy (zdwgen ((GHC.Prim.zmzh (dsXzzV) (1))))))
    
    
    let lvl3 : Lazy<GHC.Types.ZMZN<GHC.Types.ZMZN<GHC.Types.Int>>> = 
        lazy
        (
            (zdwgen (13))
        )
    
    let lvl4 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
            let 
                wwaAL : System.Int32 = (GHC.List.zdwlen<GHC.Types.ZMZN<GHC.Types.Int>> (lvl3) (0))
            in
                match wwaAL with
                |_ -> 
                    (GHC.Show.zdwshowSignedInt (0) (wwaAL) (lazy (GHC.Types.ZMZN )))
        )
    
    let a : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        fun etaaCM ->
            let 
                wildaIO : GHC.Prim.Z2H<GHC.Prim.Statezh<Microsoft.FSharp.Core.Unit>, GHC.Unit.Z0T> = (GHC.IO.a29 (GHC.Handle.stdout) (lvl4) (etaaCM))
            in
                match wildaIO with
                | GHC.Prim.Z2H (newzusaIQ, a89aIR) -> 
                    (GHC.IO.zdwa10 (GHC.Handle.stdout) ('\x0a') (newzusaIQ))
    
    
    let main : Lazy<GHC.IOBase.IO<GHC.Unit.Z0T>> = 
        lazy
        (
            a
        )
    
    let a1 : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        (GHC.TopHandler.a4<GHC.Unit.Z0T> (a))
    
    let zcmain : GHC.IOBase.IO<GHC.Unit.Z0T> = 
        a1
        
    System.Console.WriteLine("Press ENTER to continue...")  
    System.Console.ReadLine() |> ignore        
    System.Console.WriteLine("Queens")
    
    zcmain (GHC.Prim.State (())) |> ignore             