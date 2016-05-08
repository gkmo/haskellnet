namespace Tak

module Main = 
    let rec zdwtak : GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Prim.Intzh = 
        fun wwsF0 ww1sF4 ww2sF8 ->
            let 
                wildavY : System.Boolean = (GHC.Prim.zlzh (ww1sF4) (wwsF0))
            in
                match wildavY with
                | true -> 
                    let 
                        ww3sFc : GHC.Prim.Intzh = (zdwtak ((GHC.Prim.zmzh (wwsF0) (1))) (ww1sF4) (ww2sF8))
                    in
                        match ww3sFc with
                        |_ -> 
                            let 
                                ww4XFP : GHC.Prim.Intzh = (zdwtak ((GHC.Prim.zmzh (ww1sF4) (1))) (ww2sF8) (wwsF0))
                            in
                                match ww4XFP with
                                |_ -> 
                                    let 
                                        ww5XGS : GHC.Prim.Intzh = (zdwtak ((GHC.Prim.zmzh (ww2sF8) (1))) (wwsF0) (ww1sF4))
                                    in
                                        match ww5XGS with
                                        |_ -> 
                                            (zdwtak (ww3sFc) (ww4XFP) (ww5XGS))
                                
                        
                
                | false -> 
                    ww2sF8
    
    
    let lvl : Lazy<GHC.Types.Char> = 
        lazy
        (
            (GHC.Types.Czh ('\x0a'))
        )
    
    let lvl1 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
            (GHC.Types.ZC  ((lvl), (lazy (GHC.Types.ZMZN ))))
        )
    
    let lvl2 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
            let 
                wwsFc : GHC.Prim.Intzh = (zdwtak (24) (16) (8))
            in
                match wwsFc with
                |_ -> 
                    (GHC.Show.showl (lazy (GHC.Show.zdwshowSignedInt (0) (wwsFc) (lvl1))) (lazy (GHC.Types.ZMZN )))
        )
    
    let lvl3 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
            (GHC.Types.ZC  ((GHC.Show.a78), (lvl2)))
        )
    
    let a : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        fun etaayf ->
            let 
                wildaEn : GHC.Prim.Z2H<GHC.Prim.Statezh<Microsoft.FSharp.Core.Unit>, GHC.Unit.Z0T> = (GHC.IO.a29 (GHC.Handle.stdout) (lvl3) (etaayf))
            in
                match wildaEn with
                | GHC.Prim.Z2H (newzusaEp, a89aEq) -> 
                    (GHC.IO.zdwa10 (GHC.Handle.stdout) ('\x0a') (newzusaEp))
    
    
    let main : Lazy<GHC.IOBase.IO<GHC.Unit.Z0T>> = 
        lazy
        (
            a
        )
    
    let a1 : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        (GHC.TopHandler.a4<GHC.Unit.Z0T> (a))
    
    let zcmain : GHC.IOBase.IO<GHC.Unit.Z0T> = 
        a1
