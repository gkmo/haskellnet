namespace Exp3_8

module Main = 
    type Nat = 
        | ZZ
        | S of (Lazy<Nat>)
    
    
    let a : Lazy<GHC.Types.Int> = 
        lazy
        (
            (GHC.Types.Izh (0))
        )
    
    let private a1rVS : Lazy<GHC.Types.Char> = 
        lazy
        (
            (GHC.Types.Czh ('Z'))
        )
    
    let private a2rVU : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
            (GHC.Types.ZC  ((a1rVS), (lazy (GHC.Types.ZMZN ))))
        )
    
    let private a3rVW : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
            (GHC.Base.unpackCStringzh ("S "))
        )
    
    let private lvlrVY : Lazy<Nat> = 
        lazy
        (
            (S (lazy ZZ ))
        )
    
    let private lvl1rW0 : Lazy<GHC.Integer.Internals.Integer> = 
        lazy
        (
            (GHC.Integer.Internals.Szh (1))
        )
    
    let private lvl2rW2 : Lazy<GHC.Types.Int> = 
        lazy
        (
            (GHC.Types.Izh (11))
        )
    
    let private lvl3rW4 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        (GHC.Base.zpzp<GHC.Types.Char> (a2rVU))
    
    let a4 : Lazy<Nat> -> Nat = 
        (Control.Exception.Base.noMethodBindingError<Lazy<Nat> -> Nat> ("Main.hs:23:9-15|GHC.Num.signum"))
    
    let a5 : Lazy<Nat> -> Nat = 
        (Control.Exception.Base.noMethodBindingError<Lazy<Nat> -> Nat> ("Main.hs:23:9-15|GHC.Num.abs"))
    
    let rec zdwint : Lazy<Nat> -> GHC.Prim.Intzh = 
        fun wsSV ->
            let 
                wildB1 : Lazy<Nat> = wsSV
            in
                match wildB1.Force() with
                | S (xafC) -> 
                    let 
                        wwsSY : GHC.Prim.Intzh = (zdwint (xafC))
                    in
                        match wwsSY with
                        |_ -> 
                            (GHC.Prim.zpzh (1) (wwsSY))
                
                | ZZ -> 
                    0
    
    
    let rec fromInteger : Lazy<GHC.Integer.Internals.Integer> -> Nat = 
        fun xafW ->
            let 
                wildB1 : System.Boolean = (GHC.HInteger.ltInteger (xafW) (lvl1rW0))
            in
                match wildB1 with
                | true -> 
                    ZZ 
                | false -> 
                    (S (lazy (fromInteger (lazy (GHC.HInteger.minusInteger (xafW) (lvl1rW0))))))
    
    
    let lit : Lazy<Nat> = 
        lazy
        (
            (fromInteger (GHC.Num.lvl))
        )
    
    let rec zp : Lazy<Nat> -> Lazy<Nat> -> Nat = 
        fun dsdAO yafK ->
            let 
                wildB1 : Lazy<Nat> = dsdAO
            in
                match wildB1.Force() with
                | S (xafM) -> 
                    (S (lazy (zp (xafM) (yafK))))
                | ZZ -> 
                    (yafK).Force()
    
    
    let rec zt : Lazy<Nat> -> Lazy<Nat> -> Nat = 
        fun xafQ dsdAR ->
            let 
                wildB1 : Lazy<Nat> = dsdAR
            in
                match wildB1.Force() with
                | S (yafU) -> 
                    (zp (lazy (zt (xafQ) (yafU))) (xafQ))
                | ZZ -> 
                    ZZ 
    
    
    let rec zczczc : Lazy<Nat> -> Lazy<Nat> -> Nat = 
        fun xafE dsdzzI ->
            let 
                wildB1 : Lazy<Nat> = dsdzzI
            in
                match wildB1.Force() with
                | S (yafI) -> 
                    (zt (xafE) (lazy (zczczc (xafE) (yafI))))
                | ZZ -> 
                    (lvlrVY).Force()
    
    
    let lvl4 : Lazy<GHC.Integer.Internals.Integer> = 
        lazy
        (
            (GHC.Integer.Internals.Szh (3))
        )
    
    let lvl5 : Lazy<Nat> = 
        lazy
        (
            (fromInteger (lvl4))
        )
    
    let lvl6 : Lazy<GHC.Integer.Internals.Integer> = 
        lazy
        (
            (GHC.Integer.Internals.Szh (8))
        )
    
    let lvl7 : Lazy<Nat> = 
        lazy
        (
            (fromInteger (lvl6))
        )
    
    let lvl8 : Lazy<Nat> = 
        lazy
        (
            (zczczc (lvl5) (lvl7))
        )
    
    let lvl9 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
            let 
                wwsSY : GHC.Prim.Intzh = (zdwint (lvl8))
            in
                match wwsSY with
                |_ -> 
                    (GHC.Show.zdwshowSignedInt (0) (wwsSY) (lazy (GHC.Types.ZMZN )))
        )
    
    let a6 : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        fun etaaJO ->
            let 
                wildaPR : GHC.Prim.Z2H<GHC.Prim.Statezh<Microsoft.FSharp.Core.Unit>, GHC.Unit.Z0T> = (GHC.IO.a29 (GHC.Handle.stdout) (lvl9) (etaaJO))
            in
                match wildaPR with
                | GHC.Prim.Z2H (newzusaPT, a89aPU) -> 
                    (GHC.IO.zdwa10 (GHC.Handle.stdout) ('\x0a') (newzusaPT))
    
    
    let main : Lazy<GHC.IOBase.IO<GHC.Unit.Z0T>> = 
        lazy
        (
            a6
        )
    
    let a7 : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        (GHC.TopHandler.a4<GHC.Unit.Z0T> (a6))
    
    let rec lvl10 : Lazy<Nat> = 
        lazy
        (
            (zdwa (lit))
        )
    
    and zdwa : Lazy<Nat> -> Nat = 
        fun wsSR ->
            (zp (wsSR) (lvl10))
    
    let a8 : Lazy<Nat> -> Nat = 
        fun xaEw ->
            (lvl10).Force()
    
    let a9 : Lazy<Nat> -> Lazy<Nat> -> Nat = 
        fun wsSR w1sSS ->
            (zdwa (wsSR))
    
    let rec showsPrec : Lazy<GHC.Types.Int> -> Lazy<Nat> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun dsdAK ds1dAL ->
            let 
                wildB1 : Lazy<Nat> = ds1dAL
            in
                match wildB1.Force() with
                | S (b1ajI) -> 
                    let 
                        wild1aHx : Lazy<GHC.Types.Int> = dsdAK
                    in
                        match wild1aHx.Force() with
                        | GHC.Types.Izh (xaHzz) -> 
                            let rec 
                                gsUzz : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = (showsPrec (lvl2rW2) (b1ajI))
                            in
                                let 
                                    wild2aBx : System.Boolean = (GHC.Prim.zgzezh (xaHzz) (11))
                                in
                                    match wild2aBx with
                                    | true -> 
                                        fun x1aBB ->
                                            (GHC.Types.ZC  ((GHC.Show.a68), (lazy (GHC.Base.zpzp<GHC.Types.Char> (a3rVW) (lazy (gsUzz (lazy (GHC.Types.ZC  ((GHC.Show.a66), (x1aBB))))))))))
                                    | false -> 
                                        fun x1aBI ->
                                            (GHC.Base.zpzp<GHC.Types.Char> (a3rVW) (lazy (gsUzz (x1aBI))))
                        
                
                | ZZ -> 
                    lvl3rW4
    
    
    let showList : Lazy<GHC.Types.ZMZN<Nat>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun ds1aB9 saBa ->
            let 
                wildaBb : Lazy<GHC.Types.ZMZN<Nat>> = ds1aB9
            in
                match wildaBb.Force() with
                | GHC.Types.ZC (xaBg, xsaBh) -> 
                    (GHC.Types.ZC  ((GHC.Show.lvl15), (lazy (showsPrec (a) (xaBg) (lazy 
                        let 
                            lvl23sUB : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = lazy ((GHC.Types.ZC  ((GHC.Show.lvl16), (saBa))))
                        in
                            let rec 
                                showl1sUD : Lazy<GHC.Types.ZMZN<Nat>> -> GHC.Types.ZMZN<GHC.Types.Char> = fun ds2aBl ->
                                    let 
                                        wild1aBm : Lazy<GHC.Types.ZMZN<Nat>> = ds2aBl
                                    in
                                        match wild1aBm.Force() with
                                        | GHC.Types.ZC (yaBq, ysaBr) -> 
                                            (GHC.Types.ZC  ((GHC.Show.a67), (lazy (showsPrec (a) (yaBq) (lazy (showl1sUD (ysaBr)))))))
                                        | GHC.Types.ZMZN -> 
                                            (lvl23sUB).Force()
                                
                            in
                                (showl1sUD (xsaBh)))))))
                | GHC.Types.ZMZN -> 
                    (GHC.Base.zpzp<GHC.Types.Char> (GHC.Show.lvl17) (saBa))
    
    
    let a10 : Lazy<Nat> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun xaB4 ->
            (showsPrec (GHC.Base.zzeroInt) (xaB4) (lazy (GHC.Types.ZMZN )))
    
    let zdf4 : Lazy<GHC.Show.ZCTShow<Nat>> = 
        lazy
        (
            (GHC.Show.ZCDShow  ((showsPrec), (a10), (showList)))
        )
    
    let rec compare : Lazy<Nat> -> Lazy<Nat> -> GHC.Ordering.Ordering = 
        fun a11ajs baju ->
            let rec 
                zdjsUH : GHC.Prim.Intzh -> GHC.Ordering.Ordering = fun azhajC ->
                    let rec 
                        zdj1sUF : GHC.Prim.Intzh -> GHC.Ordering.Ordering = fun bzhajE ->
                            let 
                                wildB1 : System.Boolean = (GHC.Prim.zezezh (azhajC) (bzhajE))
                            in
                                match wildB1 with
                                | true -> 
                                    let 
                                        wild1X1p : Lazy<Nat> = a11ajs
                                    in
                                        match wild1X1p.Force() with
                                        | S (a111ajy) -> 
                                            let 
                                                wild2X1u : Lazy<Nat> = baju
                                            in
                                                match wild2X1u.Force() with
                                                | S (b1ajA) -> 
                                                    (compare (a111ajy) (b1ajA))
                                                | ZZ -> 
                                                    GHC.Ordering.EQ 
                                        
                                        | ZZ -> 
                                            GHC.Ordering.EQ 
                                
                                | false -> 
                                    let 
                                        wild1X1o : System.Boolean = (GHC.Prim.zlzh (azhajC) (bzhajE))
                                    in
                                        match wild1X1o with
                                        | true -> 
                                            GHC.Ordering.LT 
                                        | false -> 
                                            GHC.Ordering.GT 
                                
                        
                    in
                        let 
                            wildB1 : Lazy<Nat> = baju
                        in
                            match wildB1.Force() with
                            | S (dsdAx) -> 
                                (zdj1sUF (1))
                            | ZZ -> 
                                (zdj1sUF (0))
                
            in
                let 
                    wildB1 : Lazy<Nat> = a11ajs
                in
                    match wildB1.Force() with
                    | S (dsdAx) -> 
                        (zdjsUH (1))
                    | ZZ -> 
                        (zdjsUH (0))
    
    
    let a11 : Lazy<Nat> -> Lazy<Nat> -> GHC.Bool.Bool = 
        fun xaC1 yaC2 ->
            let 
                wildaCe : GHC.Ordering.Ordering = (compare (xaC1) (yaC2))
            in
                match wildaCe with
                | GHC.Ordering.LT -> 
                    true 
                |_ -> 
                    false 
    
    
    let a12 : Lazy<Nat> -> Lazy<Nat> -> GHC.Bool.Bool = 
        fun xaCi yaCj ->
            let 
                wildaCv : GHC.Ordering.Ordering = (compare (xaCi) (yaCj))
            in
                match wildaCv with
                | GHC.Ordering.LT -> 
                    false 
                |_ -> 
                    true 
    
    
    let a13 : Lazy<Nat> -> Lazy<Nat> -> GHC.Bool.Bool = 
        fun xaCzz yaCA ->
            let 
                wildaCM : GHC.Ordering.Ordering = (compare (xaCzz) (yaCA))
            in
                match wildaCM with
                | GHC.Ordering.GT -> 
                    true 
                |_ -> 
                    false 
    
    
    let a14 : Lazy<Nat> -> Lazy<Nat> -> GHC.Bool.Bool = 
        fun xaCQ yaCR ->
            let 
                wildaD3 : GHC.Ordering.Ordering = (compare (xaCQ) (yaCR))
            in
                match wildaD3 with
                | GHC.Ordering.GT -> 
                    false 
                |_ -> 
                    true 
    
    
    let a15 : Lazy<Nat> -> Lazy<Nat> -> Nat = 
        fun xaD7 yaD8 ->
            let 
                wildaD3 : GHC.Ordering.Ordering = (compare (xaD7) (yaD8))
            in
                match wildaD3 with
                | GHC.Ordering.GT -> 
                    (xaD7).Force()
                |_ -> 
                    (yaD8).Force()
    
    
    let a16 : Lazy<Nat> -> Lazy<Nat> -> Nat = 
        fun xaDr yaDs ->
            let 
                wildaD3 : GHC.Ordering.Ordering = (compare (xaDr) (yaDs))
            in
                match wildaD3 with
                | GHC.Ordering.GT -> 
                    (yaDs).Force()
                |_ -> 
                    (xaDr).Force()
    
    
    let rec zeze : Lazy<Nat> -> Lazy<Nat> -> GHC.Bool.Bool = 
        fun dsdAA ds1dAB ->
            let 
                wildB1 : Lazy<Nat> = dsdAA
            in
                match wildB1.Force() with
                | S (a111aja) -> 
                    let 
                        wild1X1g : Lazy<Nat> = ds1dAB
                    in
                        match wild1X1g.Force() with
                        | S (b1ajc) -> 
                            (zeze (a111aja) (b1ajc))
                        | ZZ -> 
                            false 
                
                | ZZ -> 
                    let 
                        wild1X19 : Lazy<Nat> = ds1dAB
                    in
                        match wild1X19.Force() with
                        | S (ds2dAx) -> 
                            false 
                        | ZZ -> 
                            true 
                
    
    
    let zsze : Lazy<Nat> -> Lazy<Nat> -> GHC.Bool.Bool = 
        fun a17ajo bajq ->
            let 
                wildaBP : GHC.Bool.Bool = (zeze (a17ajo) (bajq))
            in
                match wildaBP with
                | true -> 
                    false 
                | false -> 
                    true 
    
    
    let zdf2 : Lazy<GHC.Classes.ZCTEq<Nat>> = 
        lazy
        (
            (GHC.Classes.ZCDEq  ((zeze), (zsze)))
        )
    
    let zdf1 : Lazy<GHC.Num.ZCTNum<Nat>> = 
        lazy
        (
            (GHC.Num.ZCDNum  ((zdf2), (zdf4), (zp), (zt), (a9), (a8), (a5), (a4), (fromInteger)))
        )
    
    let zdf3 : Lazy<GHC.Classes.ZCTOrd<Nat>> = 
        lazy
        (
            (GHC.Classes.ZCDOrd  ((zdf2), (compare), (a11), (a12), (a13), (a14), (a15), (a16)))
        )
    
    let zcmain : GHC.IOBase.IO<GHC.Unit.Z0T> = 
        a7