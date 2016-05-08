namespace RFib

module Main = 
    let rec zdwnfib : GHC.Prim.Intzh -> GHC.Prim.Intzh = 
        fun wwsDX ->
            let 
                wildB1 : System.Boolean = (GHC.Prim.zlzezh (wwsDX) (1))
            in
                match wildB1 with
                | true -> 
                    1
                | false -> 
                    let 
                        ww1sE1 : GHC.Prim.Intzh = (zdwnfib ((GHC.Prim.zmzh (wwsDX) (1))))
                    in
                        match ww1sE1 with
                        |_ -> 
                            let 
                                ww2XEq : GHC.Prim.Intzh = (zdwnfib ((GHC.Prim.zmzh (wwsDX) (2))))
                            in
                                match ww2XEq with
                                |_ -> 
                                    (GHC.Prim.zpzh ((GHC.Prim.zpzh (ww1sE1) (ww2XEq))) (1))
                        
                
    
    
    let lvl : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
            let 
                wwsE1 : GHC.Prim.Intzh = (zdwnfib (30))
            in
                match wwsE1 with
                |_ -> 
                    (GHC.Show.zdwshowSignedInt (0) (wwsE1) (lazy (GHC.Types.ZMZN )))
        )
    
    let a : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        fun etaawW ->
            let 
                wildaD4 : GHC.Prim.Z2H<GHC.Prim.Statezh<Microsoft.FSharp.Core.Unit>, GHC.Unit.Z0T> = (GHC.IO.a29 (GHC.Handle.stdout) (lvl) (etaawW))
            in
                match wildaD4 with
                | GHC.Prim.Z2H (newzusaD6, a89aD7) -> 
                    (GHC.IO.zdwa10 (GHC.Handle.stdout) ('\x0a') (newzusaD6))
    
    
    let a1 : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        (GHC.TopHandler.a4<GHC.Unit.Z0T> (a))
    
    let main : Lazy<GHC.IOBase.IO<GHC.Unit.Z0T>> = 
        lazy
        (
            a
        )
    
    let zcmain : GHC.IOBase.IO<GHC.Unit.Z0T> = 
        a1