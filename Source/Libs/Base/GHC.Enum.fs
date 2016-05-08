namespace GHC   

module Enum = 
    type ZCTEnum<'aa4P> = 
        | ZCDEnum of (Lazy<'aa4P> -> 'aa4P) * (Lazy<'aa4P> -> 'aa4P) * (Lazy<GHC.Types.Int> -> 'aa4P) * (Lazy<'aa4P> -> GHC.Types.Int) * (Lazy<'aa4P> -> GHC.Types.ZMZN<'aa4P>) * (Lazy<'aa4P> -> Lazy<'aa4P> -> GHC.Types.ZMZN<'aa4P>) * (Lazy<'aa4P> -> Lazy<'aa4P> -> GHC.Types.ZMZN<'aa4P>) * (Lazy<'aa4P> -> Lazy<'aa4P> -> Lazy<'aa4P> -> GHC.Types.ZMZN<'aa4P>)

    type ZCTBounded<'aa5e> = 
        | ZCDBounded of Lazy<'aa5e> * Lazy<'aa5e>

    let minBound<'aa5e> : Lazy<ZCTBounded<'aa5e>> -> 'aa5e = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDBounded (tpl2B2, tpl3B3)->
                        tpl2B2.Force()
            )

    let maxBound<'aa5e> : Lazy<ZCTBounded<'aa5e>> -> 'aa5e = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDBounded (tpl2B2, tpl3B3)->
                        tpl3B3.Force()
            )

    let succ<'aa4P> : Lazy<ZCTEnum<'aa4P>> -> Lazy<'aa4P> -> 'aa4P = 
        fun tplB1 ->
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDEnum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9)->
                        tpl2B2
            )

    let pred<'aa4P> : Lazy<ZCTEnum<'aa4P>> -> Lazy<'aa4P> -> 'aa4P = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDEnum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9)->
                        tpl3B3
            )

    let toEnum<'aa4P> : Lazy<ZCTEnum<'aa4P>> -> Lazy<GHC.Types.Int> -> 'aa4P = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDEnum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9)->
                        tpl4B4
            )

    let fromEnum<'aa4P> : Lazy<ZCTEnum<'aa4P>> -> Lazy<'aa4P> -> GHC.Types.Int = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDEnum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9)->
                        tpl5B5
            )

    let enumFrom<'aa4P> : Lazy<ZCTEnum<'aa4P>> -> Lazy<'aa4P> -> GHC.Types.ZMZN<'aa4P> = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDEnum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9)->
                        tpl6B6
            )

    let enumFromThen<'aa4P> : Lazy<ZCTEnum<'aa4P>> -> Lazy<'aa4P> -> Lazy<'aa4P> -> GHC.Types.ZMZN<'aa4P> = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDEnum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9)->
                        tpl7B7
            )

    let enumFromTo<'aa4P> : Lazy<ZCTEnum<'aa4P>> -> Lazy<'aa4P> -> Lazy<'aa4P> -> GHC.Types.ZMZN<'aa4P> = 
        fun tplB1 ->
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDEnum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9)->
                        tpl8B8
            )

    let enumFromThenTo<'aa4P> : Lazy<ZCTEnum<'aa4P>> -> Lazy<'aa4P> -> Lazy<'aa4P> -> Lazy<'aa4P> -> GHC.Types.ZMZN<'aa4P> = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDEnum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9)->
                        tpl9B9
            )
            
    let lvl11r1NQ : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = lazy GHC.Base.unpackCStringzh "Prelude.Enum.succ{Int}: tried to take 'succ' of maxBound"
        
    let lvl13r1NU : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = lazy GHC.Base.unpackCStringzh "Prelude.Enum.pred{Int}: tried to take 'pred' of minBound"
                 
    let efdtIntUp : GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun x1a8P x2a8R ya8T ->            
            (
                let wildB1 = GHC.Prim.zlzh (ya8T) (x2a8R)  in
                    match wildB1 with
                    | true ->
                            let wild1X2I = GHC.Prim.zlzh (ya8T) (x1a8P)  in
                                match wild1X2I with
                                | true -> GHC.Types.ZMZN
                                | false -> GHC.Types.ZC (lazy(GHC.Types.Izh (x1a8P) ), lazy(GHC.Types.ZMZN))
                    
                    | false ->
                        GHC.Types.ZC (lazy(GHC.Types.Izh (x1a8P)), 
                            let deltas13l = (GHC.Prim.zmzh (x2a8R) (x1a8P)) in
                                let yzqs13k = (GHC.Prim.zmzh (ya8T) deltas13l) in
                                    let rec gozuups1E1 = 
                                        fun xa94 ->
                                            let wild1X2P = GHC.Prim.zgzh xa94 yzqs13k  in
                                                match wild1X2P with
                                                | true ->
                                                    lazy (GHC.Types.ZC (lazy(GHC.Types.Izh xa94 ), lazy(GHC.Types.ZMZN)))
                                                | false ->
                                                    lazy (GHC.Types.ZC (lazy(GHC.Types.Izh xa94 ), (gozuups1E1 (GHC.Prim.zpzh xa94 deltas13l))))
                                    in
                                        gozuups1E1 (x2a8R))
            )

    let efdtIntDn : GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun x1a9t x2a9v ya9x ->            
            (
                let wildB1 = GHC.Prim.zgzh (ya9x) (x2a9v) in
                    match wildB1 with
                    | true ->
                            let wild1X2G = GHC.Prim.zgzh (ya9x) (x1a9t)  in
                                match wild1X2G with
                                | true -> GHC.Types.ZMZN 
                                | false -> GHC.Types.ZC (lazy(GHC.Types.Izh (x1a9t)), lazy(GHC.Types.ZMZN))
                    
                    | false ->
                        GHC.Types.ZC (lazy(GHC.Types.Izh (x1a9t)), 
                            let deltas13x = GHC.Prim.zmzh (x2a9v) (x1a9t) in
                                let yzqs13w = GHC.Prim.zmzh (ya9x) deltas13x in
                                    let rec gozudns1DX = 
                                        fun xa9I ->
                                            let wild1X2N = GHC.Prim.zlzh xa9I yzqs13w  in
                                                match wild1X2N with
                                                | true ->
                                                    lazy (GHC.Types.ZC (lazy(GHC.Types.Izh xa9I), lazy(GHC.Types.ZMZN)))
                                                | false ->
                                                    lazy (GHC.Types.ZC (lazy(GHC.Types.Izh xa9I), (gozudns1DX (GHC.Prim.zpzh xa9I deltas13x ))))
                                    in
                                        gozudns1DX (x2a9v))    
            )
                        
    let efdtInt : GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun x1a8x x2a8zz ya8B ->            
            (
                let wildB1 = GHC.Prim.zgzezh (x2a8zz) (x1a8x)  in
                    match wildB1 with
                    | true ->
                        (efdtIntUp x1a8x x2a8zz ya8B)
                    | false ->
                        (efdtIntDn x1a8x x2a8zz ya8B)
            )

    let efdInt : GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun x1a8m x2a8o ->            
            (
                let wildB1 = GHC.Prim.zgzezh (x2a8o) (x1a8m)  in
                    match wildB1 with
                    | true ->
                        (efdtIntUp x1a8m x2a8o (GHC.Prim.Intzh.MaxValue))
                    | false ->
                        (efdtIntDn x1a8m x2a8o (GHC.Prim.Intzh.MinValue))
            )
            
    let eftInt : GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun x0a7Y ya80 ->            
            (
                let wildB1 = GHC.Prim.zgzh (x0a7Y) (ya80)  in
                    match wildB1 with
                    | true -> GHC.Types.ZMZN
                    | false ->
                        let rec gos1E3 : GHC.Prim.Intzh -> GHC.Types.ZMZN<GHC.Types.Int> = 
                            fun xa85 ->                                
                                (
                                    GHC.Types.ZC (lazy(GHC.Types.Izh (xa85)) , 
                                        lazy (let wild1X3n = GHC.Prim.zezezh (xa85) (ya80)  in
                                                match wild1X3n with
                                                | true -> GHC.Types.ZMZN
                                                | false -> gos1E3 ((GHC.Prim.zpzh (xa85) (1)))))
                                )
                        in
                            (gos1E3 x0a7Y)
             )
                                                    
    let zdfEnumIntzuenumFromThenTo : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.ZMZN<GHC.Types.Int> = // enumFromThenTo3
        fun dsdSC ds1dSD ds2dSE ->            
            (
                let wildB1 = dsdSC in
                    match wildB1.Force() with
                    | GHC.Types.Izh (x1aay)->
                            let wild1X4o = ds1dSD in
                                match wild1X4o.Force() with
                                | GHC.Types.Izh (x2aaA)->
                                        let wild2X4t = ds2dSE in
                                            match wild2X4t.Force() with
                                            | GHC.Types.Izh (yaaC)->
                                                (efdtInt (x1aay) (x2aaA) (yaaC))
            )
            
    let zdfEnumIntzuenumFromTo : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.ZMZN<GHC.Types.Int> = // enumFromTo3
        fun dsdSy ds1dSzz ->            
            (
                let wildB1 = dsdSy in
                    match wildB1.Force() with
                    | GHC.Types.Izh (xaao)->
                            let wild1X4o = ds1dSzz in
                                match wild1X4o.Force() with
                                | GHC.Types.Izh (yaaq)->
                                    (eftInt (xaao) (yaaq))
            )
            
    let zdfEnumIntzuenumFromThen : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.ZMZN<GHC.Types.Int> = // enumFromThen3
        fun dsdSu ds1dSv ->            
            (
                let wildB1 = dsdSu in
                    match wildB1.Force() with
                    | GHC.Types.Izh (x1aat)->
                        let wild1X4p = ds1dSv in
                            match wild1X4p.Force() with
                            | GHC.Types.Izh (x2aav)->
                                (efdInt (x1aat) (x2aav))
             )       
    

    let zdfEnumIntzuenumFrom : Lazy<GHC.Types.Int> -> GHC.Types.ZMZN<GHC.Types.Int> = // enumFrom3
        fun dsdSq ->            
            (
                let wildB1 = dsdSq in
                    match wildB1.Force() with
                    | GHC.Types.Izh (xaaj) -> (eftInt (xaaj) (GHC.Prim.Intzh.MaxValue))
            )

    let zdfEnumIntzufromEnum : Lazy<GHC.Types.Int> -> GHC.Types.Int = //fromEnum4
        fun xaag ->
            xaag.Force()

    let zdfEnumIntzutoEnum : Lazy<GHC.Types.Int> -> GHC.Types.Int = //toEnum4
        fun xaad ->
            xaad.Force()

    let zdfEnumIntzupred : Lazy<GHC.Types.Int> -> GHC.Types.Int =  // pred5
        fun xaaa ->            
            (
                let wilda16ZZ = xaaa in
                    match wilda16ZZ.Force() with
                    | GHC.Types.Izh (x1a171)->
                            let wild1B1 = x1a171 in
                                match wild1B1 with
                                | GHC.Prim.Intzh.MinValue -> GHC.Err.error (lvl13r1NU)
                                | _ -> GHC.Types.Izh (GHC.Prim.zmzh wild1B1 (1))
            )

    let zdfEnumIntzusucc : Lazy<GHC.Types.Int> -> GHC.Types.Int = // succ5
        fun xaa7 ->            
            (
                let wilda16ZZ = xaa7 in
                    match wilda16ZZ.Force() with
                    | GHC.Types.Izh (x1a171)->
                            let wild1B1 = x1a171 in
                                match wild1B1 with
                                | GHC.Prim.Intzh.MaxValue -> GHC.Err.error (lvl11r1NQ)
                                | _ -> GHC.Types.Izh (GHC.Prim.zpzh wild1B1 (1))
             )       
                        
    let zdfEnumInt : Lazy<ZCTEnum<GHC.Types.Int>> = 
        lazy (ZCDEnum ((zdfEnumIntzusucc), (zdfEnumIntzupred), (zdfEnumIntzutoEnum), (zdfEnumIntzufromEnum), (zdfEnumIntzuenumFrom), (zdfEnumIntzuenumFromThen), (zdfEnumIntzuenumFromTo), (zdfEnumIntzuenumFromThenTo)))
        
        
