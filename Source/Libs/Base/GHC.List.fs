namespace GHC

module List = 
    let private lvlr14M<'bau7> : Lazy<GHC.Tuple.Z2T<GHC.Types.ZMZN<'bau7>, 'bau7>> = 
        lazy (GHC.Err.error<GHC.Tuple.Z2T<GHC.Types.ZMZN<'bau7>, 'bau7>> (lazy GHC.Base.unpackCStringzh ("GHC/List.lhs:212:33-56|(qs@(q : _))")))

    let lvl1<'aatX> : Lazy<GHC.Tuple.Z2T<GHC.Types.ZMZN<'aatX>, 'aatX>> = 
        lazy (GHC.Err.error<GHC.Tuple.Z2T<GHC.Types.ZMZN<'aatX>, 'aatX>> (lazy GHC.Base.unpackCStringzh ("GHC/List.lhs:220:33-54|(qs@(q : _))")))

    let private lvl2r14Q : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.unpackCStringzh ("Prelude.cycle: empty list")

    let lvl3<'aaty> : Lazy<GHC.Types.ZMZN<'aaty>> = 
        lazy(GHC.Err.error<GHC.Types.ZMZN<'aaty>> (lvl2r14Q))

    let private lvl4r14U : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.unpackCStringzh ("Prelude.(!!): negative index\x0a")

    let lvl5<'aar0> : Lazy<'aar0> = 
        lazy(GHC.Err.error<'aar0> (lvl4r14U))

    let private lvl6r14Y : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.unpackCStringzh ("Prelude.(!!): index too large\x0a")

    let private lvl7r150<'aar3> : Lazy<'aar3> = 
        lazy(GHC.Err.error<'aar3> (lvl6r14Y))

    let private lvl8r152 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.unpackCStringzh (": empty list")

    let rec lastzq<'tavf> : Lazy<'tavf> -> Lazy<GHC.Types.ZMZN<'tavf>> -> 'tavf = 
        fun ya7y dsdCP ->            
            (
                let 
                    wildX2a = dsdCP
                in
                    match wildX2a.Force() with
                    | GHC.Types.ZC (y1a7B, ysa7D) ->
                        (lastzq<'tavf> (y1a7B) (ysa7D))
                    | GHC.Types.ZMZN ->
                        ya7y.Force()
            )
    

    let rec initzq<'aav2> : Lazy<'aav2> -> Lazy<GHC.Types.ZMZN<'aav2>> -> GHC.Types.ZMZN<'aav2> = 
        fun dsdCI ds1dCJ ->            
            (
                let 
                    wildX29 = ds1dCJ
                in
                    match wildX29.Force() with
                    | GHC.Types.ZC (zza7R, zzsa7T) ->
                        GHC.Types.ZC (dsdCI, lazy initzq<'aav2> (zza7R) (zzsa7T)) 
                    | GHC.Types.ZMZN ->
                        GHC.Types.ZMZN
            )
    

    let rec zdwlen<'aa82> : Lazy<GHC.Types.ZMZN<'aa82>> -> GHC.Prim.Intzh -> GHC.Prim.Intzh = 
        fun wsSQ w1sSR ->            
            (
                let 
                    wildB1 = wsSQ
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (dsdCy, xsa88) -> (zdwlen<'aa82> (xsa88) (GHC.Prim.zpzh (w1sSR) (1)))
                    | GHC.Types.ZMZN -> w1sSR
            )

    let rec dropzh<'aabX> : GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<'aabX>> -> GHC.Types.ZMZN<'aabX> = 
        fun dsdB8 xsac0 ->
            let 
                ds1XCJ = dsdB8
            in
                match ds1XCJ with
                | 0 -> xsac0.Force()
                | _ ->
                    let 
                        wildX1G = xsac0
                    in
                        match wildX1G.Force() with
                        | GHC.Types.ZC (ds2dB9, xs1ac8) -> (dropzh<'aabX> (GHC.Prim.zmzh (ds1XCJ) (1)) (xs1ac8))
                        | GHC.Types.ZMZN -> GHC.Types.ZMZN

    let rec zdwsplitAtzh<'aach> : GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<'aach>> -> GHC.Prim.Z2H<GHC.Types.ZMZN<'aach>, GHC.Types.ZMZN<'aach>> =
        fun wsSK w1sSL ->
            let 
                dsXCx = wsSK
            in
                match dsXCx with
                | 0 -> GHC.Prim.Z2H (GHC.Types.ZMZN, (w1sSL.Force())) 
                | _ ->
                    let 
                        wildX1G = w1sSL
                    in
                        match wildX1G.Force() with
                        | GHC.Types.ZMZN -> GHC.Prim.Z2H (GHC.Types.ZMZN, GHC.Types.ZMZN) 
                        | GHC.Types.ZC (xacs, xsacu) ->
                            let 
                                ds1sX5 = zdwsplitAtzh (GHC.Prim.zmzh (dsXCx) (1)) (xsacu)
                            in
                                GHC.Prim.Z2H (GHC.Types.ZC (xacs, lazy(
                                                                        let 
                                                                            wild1X1O = ds1sX5
                                                                        in
                                                                            match wild1X1O with
                                                                            | GHC.Prim.Z2H (xszqasQ, xszqzqasS)->
                                                                                xszqasQ
                                                                        )), 
                                                                           (
                                                                            let 
                                                                                wild1X1O = ds1sX5
                                                                            in
                                                                                match wild1X1O with
                                                                                | GHC.Prim.Z2H (xszqasQ, xszqzqasS)->
                                                                                    xszqzqasS
                                                                             ))             
    

    let rec rev<'tas3> : Lazy<GHC.Types.ZMZN<'tas3>> -> Lazy<GHC.Types.ZMZN<'tas3>> -> GHC.Types.ZMZN<'tas3> = 
        fun dsdAC aadc ->            
            (
                let 
                    wildB1 = dsdAC
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xadf, xsadh) -> (rev<'tas3> (xsadh) (lazy(GHC.Types.ZC (xadf, aadc))))
                    | GHC.Types.ZMZN -> aadc.Force()
            )
    

    let rec sub<'aaeu> : Lazy<GHC.Types.ZMZN<'aaeu>> -> GHC.Prim.Intzh -> 'aaeu = 
        fun dsdA5 ds1dA6 ->            
            (
                let 
                    wildX1l = dsdA5
                in
                    match wildX1l.Force() with
                    | GHC.Types.ZC (yaey, ysaeA) ->
                        let 
                            wild1X1s = ds1dA6
                        in
                            match wild1X1s with
                            | 0 -> yaey.Force()
                            | _ -> (sub<'aaeu> (ysaeA) ((GHC.Prim.zmzh (wild1X1s) 1)))
                    
                    | GHC.Types.ZMZN -> lvl7r150<'aaeu>.Force()
            )        

    let rec private prelzulistzustrr4N : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.unpackCStringzh ("Prelude.")

    let rec private lvl9r15i : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.unpackCStringzh ("foldr1")

    let rec private lvl10r15k : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.zpzp<GHC.Types.Char> (lvl9r15i) (lvl8r152)

    let rec private lvl11r15m : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.zpzp<GHC.Types.Char> (prelzulistzustrr4N) (lvl10r15k)

    let lvl12<'aauh> : Lazy<'aauh> = 
        lazy (GHC.Err.error<'aauh> (lvl11r15m))

    let rec private lvl13r15q : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.unpackCStringzh ("init")

    let rec private lvl14r15s : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.zpzp<GHC.Types.Char> (lvl13r15q) (lvl8r152)

    let rec private lvl15r15u : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.zpzp<GHC.Types.Char> (prelzulistzustrr4N) (lvl14r15s)

    let lvl16<'aauS> : Lazy<GHC.Types.ZMZN<'aauS>> = 
        lazy (GHC.Err.error<GHC.Types.ZMZN<'aauS>> (lvl15r15u))

    let rec private lvl17r15y : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.unpackCStringzh ("last")

    let rec private lvl18r15A : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.zpzp<GHC.Types.Char> (lvl17r15y) (lvl8r152)

    let rec private lvl19r15C : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.zpzp<GHC.Types.Char> (prelzulistzustrr4N) (lvl18r15A)

    let lvl20<'aav7> : Lazy<'aav7> = 
        lazy (GHC.Err.error<'aav7> (lvl19r15C))

    let rec private lvl21r15G : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.unpackCStringzh ("tail")

    let rec private lvl22r15I : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.zpzp<GHC.Types.Char> (lvl21r15G) (lvl8r152)

    let rec private lvl23r15K : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.zpzp<GHC.Types.Char> (prelzulistzustrr4N) (lvl22r15I)

    let lvl24<'aavj> : Lazy<GHC.Types.ZMZN<'aavj>> = 
        lazy (GHC.Err.error<GHC.Types.ZMZN<'aavj>> (lvl23r15K))

    let errorEmptyList<'aa4P> : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> 'aa4P = 
        fun funahm ->
            GHC.Err.error<'aa4P> (lazy GHC.Base.zpzp<GHC.Types.Char> (prelzulistzustrr4N) (lazy GHC.Base.zpzp<GHC.Types.Char> (funahm) (lvl8r152)))

//    let inline unzzip3<'aa4R, 'ba4S, 'ca4T> : GHC.Types.ZMZN<GHC.Tuple.Z3T<'aa4R, 'ba4S, 'ca4T>> -> GHC.Tuple.Z3T<GHC.Types.ZMZN<'aa4R>, GHC.Types.ZMZN<'ba4S>, GHC.Types.ZMZN<'ca4T>> = 
//        fun ->
//            GHC.Base.foldr<GHC.Tuple.Z3T<aapk, bapl, capm>, GHC.Tuple.Z3T<GHC.Types.ZMZN<aapk>, GHC.Types.ZMZN<bapl>, GHC.Types.ZMZN<capm>>> (fun dsdzzc ds1dzzd ->
//                let wildB1 = 
//                    dsdzzc
//                in
//                    match wildB1 with
//                    | GHC.Tuple.Z3T (aah9, bahb, cahd)->
//                        GHC.Tuple.Z3T ((GHC.Types.ZC (Lazy((aah9), (
//                        let wild1X1e = 
//                            ds1dzzd
//                        in
//                            match wild1X1e with
//                            | GHC.Tuple.Z3T (asahf, bsahh, csahj)->
//                                asahf
//                        )) ), (GHC.Types.ZC (Lazy((bahb), (let wild1X1e = 
//                            ds1dzzd
//                        in
//                            match wild1X1e with
//                            | GHC.Tuple.Z3T (asahf, bsahh, csahj)->
//                                bsahh
//                        )) ), (GHC.Types.ZC (Lazy((cahd), (let wild1X1e = 
//                            ds1dzzd
//                        in
//                            match wild1X1e with
//                            | GHC.Tuple.Z3T (asahf, bsahh, csahj)->
//                                csahj
//                        )) )) 
//            ) (GHC.Tuple.Z3T ((GHC.Types.ZMZN ), (GHC.Types.ZMZN ), (GHC.Types.ZMZN )) )

//    let inline unzzip<'aa4V, 'ba4W> : GHC.Types.ZMZN<GHC.Tuple.Z2T<'aa4V, 'ba4W>> -> GHC.Tuple.Z2T<GHC.Types.ZMZN<'aa4V>, GHC.Types.ZMZN<'ba4W>> = 
//        fun ->
//            GHC.Base.foldr<GHC.Tuple.Z2T<aapN, bapO>, GHC.Tuple.Z2T<GHC.Types.ZMZN<aapN>, GHC.Types.ZMZN<bapO>>> (fun dsdzzk ds1dzzl ->
//                let wildB1 = 
//                    dsdzzk
//                in
//                    match wildB1 with
//                    | GHC.Tuple.Z2T (aagZZ, bah1)->
//                        GHC.Tuple.Z2T ((GHC.Types.ZC (Lazy((aagZZ), (let wild1X1d = 
//                            ds1dzzl
//                        in
//                            match wild1X1d with
//                            | GHC.Tuple.Z2T (asah3, bsah5)->
//                                asah3
//                        )) ), (GHC.Types.ZC (Lazy((bah1), (let wild1X1d = 
//                            ds1dzzl
//                        in
//                            match wild1X1d with
//                            | GHC.Tuple.Z2T (asah3, bsah5)->
//                                bsah5
//                        )) )) 
//            ) (GHC.Tuple.Z2T ((GHC.Types.ZMZN ), (GHC.Types.ZMZN )) )

    let rec zzipWith3<'aa4Y, 'ba4Z, 'ca50, 'da51> : (Lazy<'aa4Y> -> Lazy<'ba4Z> -> Lazy<'ca50> -> 'da51) -> Lazy<GHC.Types.ZMZN<'aa4Y>> -> Lazy<GHC.Types.ZMZN<'ba4Z>> -> Lazy<GHC.Types.ZMZN<'ca50>> -> GHC.Types.ZMZN<'da51> = 
        fun zzagI dsdzzr ds1dzzs ds2dzzt ->            
            (
                let wildB1 = 
                    dsdzzr
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (aagK, asagM) ->
                        let wild1X1i = 
                            ds1dzzs
                        in
                            match wild1X1i.Force() with
                            | GHC.Types.ZC (bagO, bsagQ) ->
                                let wild2X1o = 
                                    ds2dzzt
                                in
                                    match wild2X1o.Force() with
                                    | GHC.Types.ZC (cagS, csagU) ->
                                        GHC.Types.ZC (lazy(zzagI (aagK) (bagO) (cagS)), lazy zzipWith3<'aa4Y, 'ba4Z, 'ca50, 'da51> (zzagI) (asagM) (bsagQ) (csagU))
                                    | GHC.Types.ZMZN ->
                                        GHC.Types.ZMZN 
                            
                            | GHC.Types.ZMZN ->
                                GHC.Types.ZMZN 
                    
                    | GHC.Types.ZMZN ->
                        GHC.Types.ZMZN 
            )
    

    let inline zzipWithFB<'aa53, 'ba54, 'ca55, 'da56, 'ea57> : Lazy<(Lazy<'aa53> -> Lazy<'ba54> -> 'ca55)> -> Lazy<(Lazy<'da56> -> Lazy<'ea57> -> 'aa53)> -> Lazy<'da56> -> Lazy<'ea57> -> Lazy<'ba54> -> 'ca55 = 
        fun cagx fagzz xagB yagD ragF ->            
            (
                cagx.Force() (lazy(fagzz.Force() (xagB) (yagD))) (ragF)
            )

    let rec zzip3<'aa5d, 'ba5e, 'ca5f> : Lazy<GHC.Types.ZMZN<'aa5d>> -> Lazy<GHC.Types.ZMZN<'ba5e>> -> Lazy<GHC.Types.ZMZN<'ca5f>> -> GHC.Types.ZMZN<GHC.Tuple.Z3T<'aa5d, 'ba5e, 'ca5f>> = 
        fun dsdzzD ds1dzzE ds2dzzF ->            
            (
                let wildB1 = 
                    dsdzzD
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (aag7, asag9) ->
                        let wild1X1i = 
                            ds1dzzE
                        in
                            match wild1X1i.Force() with
                            | GHC.Types.ZC (bagb, bsagd) ->
                                let wild2X1o = 
                                    ds2dzzF
                                in
                                    match wild2X1o.Force() with
                                    | GHC.Types.ZC (cagf, csagh) ->
                                        GHC.Types.ZC (lazy(GHC.Tuple.Z3T ((aag7), (bagb), (cagf))), lazy (zzip3<'aa5d, 'ba5e, 'ca5f> (asag9) (bsagd) (csagh))) 
                                    | GHC.Types.ZMZN ->
                                        GHC.Types.ZMZN 
                            
                            | GHC.Types.ZMZN ->
                                GHC.Types.ZMZN 
                    
                    | GHC.Types.ZMZN ->
                        GHC.Types.ZMZN 
            )

    let inline zzipFB<'aa5h, 'ba5i, 'ca5j, 'da5k> : (Lazy<GHC.Tuple.Z2T<'aa5h, 'ba5i>> -> Lazy<'ca5j> -> 'da5k) -> Lazy<'aa5h> -> Lazy<'ba5i> -> Lazy<'ca5j> -> 'da5k = 
        fun cafY xag0 yag2 rag4 ->            
            (
                cafY (lazy(GHC.Tuple.Z2T (xag0, yag2))) (rag4)
            )

    let foldr2zuright<'aa5p, 'ba5q, 'ca5r, 'da5s> : (Lazy<'aa5p> -> Lazy<'ba5q> -> Lazy<'ca5r> -> 'da5s) -> Lazy<'da5s> -> Lazy<'ba5q> -> (Lazy<GHC.Types.ZMZN<'aa5p>> -> 'ca5r) -> Lazy<GHC.Types.ZMZN<'aa5p>> -> 'da5s = 
        fun zukafs zzafu zuyafw zurafy dsdzzP ->            
            (
                let wildB1 = 
                    dsdzzP
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xafJ, xsafL) ->
                        zukafs (xafJ) (zuyafw) (lazy(zurafy (xsafL)))
                    | GHC.Types.ZMZN ->
                        zzafu.Force()
            )

    let foldr2zuleft<'aa5u, 'ba5v, 'ca5w, 'da5x> : (Lazy<'aa5u> -> Lazy<'ba5v> -> Lazy<'ca5w> -> 'da5x) -> Lazy<'da5x> -> Lazy<'aa5u> -> (Lazy<GHC.Types.ZMZN<'ba5v>> -> 'ca5w) -> Lazy<GHC.Types.ZMZN<'ba5v>> -> 'da5x = 
        fun zukaf6 zzaf8 zuxafa zurafc dsdzzS ->
            (
                let wildB1 = 
                    dsdzzS
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (yafn, ysafp) ->
                        zukaf6 (zuxafa) (yafn) (lazy(zurafc (ysafp)))
                    | GHC.Types.ZMZN ->
                        zzaf8.Force()
            )
    

    let znzn<'aa5D> : Lazy<GHC.Types.ZMZN<'aa5D>> -> Lazy<GHC.Types.Int> -> 'aa5D = 
        fun xsaeo dsdA3 ->            
            (
                let wildB1 = 
                    dsdA3
                in
                    match wildB1.Force() with
                    | GHC.Types.Izh (n0aeq) ->
                        let 
                            wild1X1j = GHC.Prim.zlzh (n0aeq) (0)
                        in
                            match wild1X1j with
                            | true ->
                                lvl5<'aa5D>.Force() 
                            | false ->
                                (sub<'aa5D> (xsaeo) (n0aeq))
            )    
    

    let concatMap<'aa5H, 'ba5I> : (Lazy<'aa5H> -> GHC.Types.ZMZN<'ba5I>) -> Lazy<GHC.Types.ZMZN<'aa5H>> -> GHC.Types.ZMZN<'ba5I> = 
        fun faek etasF6 ->            
            (
                let rec gosXj : Lazy<GHC.Types.ZMZN<'aa5H>> -> GHC.Types.ZMZN<'ba5I>= 
                    fun dsaDn ->
                        let 
                            wildaDo = dsaDn
                        in
                            match wildaDo.Force() with
                            | GHC.Types.ZC (yaDs, ysaDt) ->
                                GHC.Base.zpzp<'ba5I> (lazy(faek (yaDs))) (lazy gosXj (ysaDt))
                            | GHC.Types.ZMZN -> GHC.Types.ZMZN 
                in
                    gosXj (etasF6)
            )
            
//    let lookup<'aa5K, 'ba5L> : GHC.Classes.ZCTEq<'aa5K> -> 'aa5K -> GHC.Types.ZMZN<GHC.Tuple.Z2T<'aa5K, 'ba5L>> -> Data.Maybe.Maybe<'ba5L> = 
//        fun zddEqarw etasFa eta1sFb ->
//            let wildB1 = 
//                eta1sFb
//            in
//                match wildB1 with
//                | GHC.Types.ZC (Lazy(dsdAb, xysaeh) ->
//                    let wild1X1q = 
//                        dsdAb
//                    in
//                        match wild1X1q with
//                        | GHC.Tuple.Z2T (xaed, yaef)->
//                            let tplX4 = 
//                                zddEqarw
//                            in
//                                match tplX4 with
//                                | GHC.Classes.ZCDEq (tpl1B2, tpl2B3)->
//                                    let wild2X1w = 
//                                        tpl1B2 (etasFa) (xaed)
//                                    in
//                                        match wild2X1w with
//                                        | true ->
//                                            Data.Maybe.Just ((yaef)) 
//                                        | false ->
//                                            let rec lookup1sXl = 
//                                                fun zukeyXgR ds1dAa ->
//                                                    let wild3X2M = 
//                                                        ds1dAa
//                                                    in
//                                                        match wild3X2M with
//                                                        | GHC.Types.ZC (Lazy(ds2XCZZ, xys1Xh6) ->
//                                                            let wild4X4h = 
//                                                                ds2XCZZ
//                                                            in
//                                                                match wild4X4h with
//                                                                | GHC.Tuple.Z2T (x1Xh7, y1Xha)->
//                                                                    let wild5X4w = 
//                                                                        tpl1B2 (zukeyXgR) (x1Xh7)
//                                                                    in
//                                                                        match wild5X4w with
//                                                                        | true ->
//                                                                            Data.Maybe.Just ((y1Xha)) 
//                                                                        | false ->
//                                                                            lookup1sXl (zukeyXgR) (xys1Xh6)
//                                                                
//                                                        
//                                                        | GHC.Types.ZMZN ->
//                                                            Data.Maybe.Nothing () 
//                                            in
//                                                lookup1sXl (etasFa) (xysaeh)
//                                
//                        
//                
//                | GHC.Types.ZMZN ->
//                    Data.Maybe.Nothing () 
//    

    let notElem<'aa5N> : Lazy<GHC.Classes.ZCTEq<'aa5N>> -> Lazy<'aa5N> -> Lazy<GHC.Types.ZMZN<'aa5N>> -> GHC.Bool.Bool = 
        fun zddEqarE etasFe eta1sFf ->            
            (
                let 
                    wildB1 = eta1sFf
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (yae3, ysae5) ->
                        let 
                            tplX4 = zddEqarE
                        in
                            match tplX4.Force() with
                            | GHC.Classes.ZCDEq (tpl1B2, tpl2B3) ->
                                let wild1aDH = 
                                    tpl2B3 (etasFe) (yae3)
                                in
                                    match wild1aDH with
                                    | true ->
                                        let rec notElem1sXn = 
                                            fun dsXCT (ds1dAh : Lazy<GHC.Types.ZMZN<'aa5N>>) ->
                                                let wild2X2G = 
                                                    ds1dAh
                                                in
                                                    match wild2X2G.Force() with
                                                    | GHC.Types.ZC (y1XgL, ys1XgO) ->
                                                        let wild3XGv = 
                                                            tpl2B3 (dsXCT) (y1XgL)
                                                        in
                                                            match wild3XGv with
                                                            | true ->
                                                                notElem1sXn (dsXCT) (ys1XgO)
                                                            | false ->
                                                                false
                                                    
                                                    | GHC.Types.ZMZN ->
                                                        true
                                        in
                                            notElem1sXn (etasFe) (ysae5)
                                    | false ->
                                        false
                            
                    
                    | GHC.Types.ZMZN ->
                        true
            )

    let elem<'aa5P> : Lazy<GHC.Classes.ZCTEq<'aa5P>> -> Lazy<'aa5P> -> Lazy<GHC.Types.ZMZN<'aa5P>> -> GHC.Bool.Bool = 
        fun zddEqarM etasFi eta1sFj ->            
            (
                let wildB1 = eta1sFj in
                    match wildB1.Force() with
                    | GHC.Types.ZC (yadV, ysadX) ->
                        let tplX4 = zddEqarM in
                            match tplX4.Force() with
                            | GHC.Classes.ZCDEq (tpl1B2, tpl2B3) ->
                                let wild1aDN = tpl1B2 (etasFi) (yadV) in
                                    match wild1aDN with
                                    | true -> true
                                    | false ->
                                        let rec elem1sXp = 
                                            fun dsXCY (ds1dAl : Lazy<GHC.Types.ZMZN<'aa5P>>) ->
                                                let wild2X2H = ds1dAl in
                                                    match wild2X2H.Force() with
                                                    | GHC.Types.ZC (y1XgE, ys1XgH) ->
                                                        let wild3XGC = tpl1B2 (dsXCY) (y1XgE) in
                                                            match wild3XGC with
                                                            | true -> true
                                                            | false -> elem1sXp (dsXCY) (ys1XgH)                                                
                                                    | GHC.Types.ZMZN -> false
                                        in
                                            elem1sXp (etasFi) (ysadX)
                    | GHC.Types.ZMZN -> false
            )

    let rec all<'aa5R> : (Lazy<'aa5R> -> Lazy<GHC.Bool.Bool>) -> Lazy<GHC.Types.ZMZN<'aa5R>> -> GHC.Bool.Bool = 
        fun dsdAo ds1dAp ->            
            (
                let 
                    wildB1 = ds1dAp
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xadN, xsadP) ->
                        let 
                            wild1aDH = (dsdAo) (xadN)
                        in
                            match wild1aDH.Force() with
                            | true -> (all<'aa5R> (dsdAo) (xsadP))
                            | false -> false
                    
                    | GHC.Types.ZMZN -> true
            )

    let rec any<'aa5T> : (Lazy<'aa5T> -> Lazy<GHC.Bool.Bool>) -> Lazy<GHC.Types.ZMZN<'aa5T>> -> GHC.Bool.Bool = 
        fun dsdAs ds1dAt ->            
            (
                let 
                    wildB1 = ds1dAt
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xadF, xsadH) ->
                        let 
                            wild1aDN = dsdAs (xadF)
                        in
                            match wild1aDN.Force() with
                            | true -> true
                            | false -> (any<'aa5T> (dsdAs) (xsadH))
                    
                    | GHC.Types.ZMZN -> false
            )

    let rec listOr : Lazy<GHC.Types.ZMZN<GHC.Bool.Bool>> -> GHC.Bool.Bool = 
        fun dsdAw ->            
            (
                let 
                    wildB1 = dsdAw
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xadx, xsadzz) ->
                        let 
                            wild1aDN = xadx
                        in
                            match wild1aDN.Force() with
                            | true -> true
                            | false -> (listOr (xsadzz))
                    
                    | GHC.Types.ZMZN -> false
            )
    

    let rec listAnd : Lazy<GHC.Types.ZMZN<GHC.Bool.Bool>> -> GHC.Bool.Bool = 
        fun dsdAzz ->            
            (
                let 
                    wildB1 = dsdAzz
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xadn, xsadp) ->
                        let 
                            wild1aDH = xadn
                        in
                            match wild1aDH.Force() with
                            | true -> (listAnd (xsadp))
                            | false -> false
                    
                    | GHC.Types.ZMZN -> true
            )

    let reverse<'aa5V> : Lazy<GHC.Types.ZMZN<'aa5V>> -> GHC.Types.ZMZN<'aa5V> = 
        fun lad7 ->            
            (
                (rev<'aa5V> (lad7) (lazy GHC.Types.ZMZN))
            )

    let rec listBreak<'aa5X> : (Lazy<'aa5X> -> GHC.Bool.Bool) -> Lazy<GHC.Types.ZMZN<'aa5X>> -> GHC.Tuple.Z2T<GHC.Types.ZMZN<'aa5X>, GHC.Types.ZMZN<'aa5X>> = 
        fun wsSy w1sSzz ->
            let wwsSX = 
                zdwbreak<'aa5X> (wsSy) (w1sSzz)
            in
                match wwsSX with
                | GHC.Prim.Z2H (ww1sSZZ, ww2sT0)->
                    GHC.Tuple.Z2T (lazy (ww1sSZZ), lazy (ww2sT0)) 
    

    and zdwbreak<'aa5X> : (Lazy<'aa5X> -> GHC.Bool.Bool) -> Lazy<GHC.Types.ZMZN<'aa5X>> -> GHC.Prim.Z2H<GHC.Types.ZMZN<'aa5X>, GHC.Types.ZMZN<'aa5X>> = 
        fun wsSy w1sSzz ->
            let 
                wildB1 = w1sSzz
            in
                match wildB1.Force() with
                | GHC.Types.ZC (xacY, xszqad0) ->
                    let wild1X1x = 
                        wsSy (xacY)
                    in
                        match wild1X1x with
                        | true -> GHC.Prim.Z2H ((GHC.Types.ZMZN), (wildB1.Force())) 
                        | false ->
                            let 
                                dssXr = zdwbreak<'aa5X> (wsSy) (xszqad0)
                            in
                                let a = lazy
                                    let 
                                        wild2X1B = dssXr
                                    in
                                        match wild2X1B with
                                        | GHC.Prim.Z2H (ysash, zzsasj) -> ysash                                        
                                let b =
                                    let 
                                        wild2X1B = dssXr
                                    in
                                        match wild2X1B with
                                        | GHC.Prim.Z2H (ysash, zzsasj)-> zzsasj
                                in 
                                    GHC.Prim.Z2H ((GHC.Types.ZC ((xacY), a)), b)
                
                | GHC.Types.ZMZN ->
                    GHC.Prim.Z2H ((GHC.Types.ZMZN ), (GHC.Types.ZMZN )) 
    

    let rec span<'aa5ZZ> : (Lazy<'aa5ZZ> -> GHC.Bool.Bool) -> Lazy<GHC.Types.ZMZN<'aa5ZZ>> -> GHC.Tuple.Z2T<GHC.Types.ZMZN<'aa5ZZ>, GHC.Types.ZMZN<'aa5ZZ>> = 
        fun wsSE w1sSF ->
            match zdwspan wsSE w1sSF with
            | GHC.Prim.Z2H (ww1sT5, ww2sT6) -> GHC.Tuple.Z2T (lazy ww1sT5, lazy ww2sT6)

    and zdwspan<'aa5Z> : (Lazy<'aa5Z> -> GHC.Bool.Bool) -> Lazy<GHC.Types.ZMZN<'aa5Z>> -> GHC.Prim.Z2H<GHC.Types.ZMZN<'aa5Z>, GHC.Types.ZMZN<'aa5Z>> = 
        fun wsSE w1sSF ->
            let 
                wildB1 = w1sSF
            in
                match wildB1.Force() with
                | GHC.Types.ZC (xacI, xszqacK) ->
                    let 
                        wild1X1y = wsSE (xacI)
                    in
                        match wild1X1y with
                        | true ->
                            let 
                                dssXt = zdwspan<'aa5Z> (wsSE) (xszqacK)
                            in
                                let a = lazy
                                    let 
                                        wild2X1C = dssXt
                                    in
                                        match wild2X1C with
                                        | GHC.Prim.Z2H (ysasv, zzsasx) -> ysasv
                                let b = 
                                    let 
                                        wild2X1C = dssXt
                                    in
                                        match wild2X1C with
                                        | GHC.Prim.Z2H (ysasv, zzsasx)-> zzsasx
                                in
                                    GHC.Prim.Z2H (GHC.Types.ZC (xacI, a), b)
                                    
                        | false -> GHC.Prim.Z2H ((GHC.Types.ZMZN), (wildB1.Force())) 
                
                | GHC.Types.ZMZN ->
                    GHC.Prim.Z2H ((GHC.Types.ZMZN), (GHC.Types.ZMZN))         
                    
    let splitAt<'aa6g> : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.ZMZN<'aa6g>> -> GHC.Tuple.Z2T<GHC.Types.ZMZN<'aa6g>, GHC.Types.ZMZN<'aa6g>> = 
        fun dsdAV lsacd ->            
            (
                let 
                    wildB1 = dsdAV
                in
                    match wildB1.Force() with
                    | GHC.Types.Izh (nzhacb)->
                        let 
                            wild1X1zz = GHC.Prim.zlzh (nzhacb) (0)
                        in
                            match wild1X1zz with
                            | true -> GHC.Tuple.Z2T ((lazy GHC.Types.ZMZN), (lsacd)) 
                            | false ->
                                let 
                                    wwsT9 = zdwsplitAtzh<'aa6g> (nzhacb) (lsacd)
                                in
                                    match wwsT9 with
                                    | GHC.Prim.Z2H (ww1sTb, ww2sTc)-> GHC.Tuple.Z2T ((lazy ww1sTb), (lazy ww2sTc)) 
            )


    let drop<'aa6i> : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.ZMZN<'aa6i>> -> GHC.Types.ZMZN<'aa6i> = 
        fun dsdB6 lsabT ->            
            (
                let 
                    wildB1 = dsdB6
                in
                    match wildB1.Force() with
                    | GHC.Types.Izh (nzhabR)->
                        let 
                            wild1X1A = GHC.Prim.zlzh (nzhabR) (0)
                        in
                            match wild1X1A with
                            | true -> lsabT.Force()
                            | false -> (dropzh<'aa6i> (nzhabR) (lsabT))
            )

    let rec takezuunsafezuUIntzuappend<'ba61> : GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<'ba61>> -> Lazy<GHC.Types.ZMZN<'ba61>> -> GHC.Types.ZMZN<'ba61> = 
        fun dsdBh ds1dBi rsabB ->            
            (
                let 
                    ds2XCL = dsdBh
                in
                    match ds2XCL with
                    | 0 -> rsabB.Force()
                    | _ ->
                        let 
                            wildB1 = ds1dBi
                        in
                            match wildB1.Force() with
                            | GHC.Types.ZC (xabM, xsabO) ->
                                GHC.Types.ZC (xabM, lazy takezuunsafezuUIntzuappend<'ba61> (GHC.Prim.zmzh ds2XCL 1) (xsabO) (rsabB))
                            | GHC.Types.ZMZN ->
                                rsabB.Force()
             )   

    let takeUIntzuappend<'ba63> : GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<'ba63>> -> Lazy<GHC.Types.ZMZN<'ba63>> -> GHC.Types.ZMZN<'ba63> = 
        fun nabu xsabw rsaby ->            
            (
                let 
                    wildB1 = GHC.Prim.zgzezh (nabu) (0)
                in
                    match wildB1 with
                    | true -> (takezuunsafezuUIntzuappend<'ba63> (nabu) (xsabw) (rsaby))
                    | false -> GHC.Types.ZMZN 
            )

    let rec takezuunsafezuUInt<'ba65> : GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<'ba65>> -> GHC.Types.ZMZN<'ba65> = 
        fun dsdBo ds1dBp ->            
            (
                let 
                    ds2XCT = dsdBo
                in
                    match ds2XCT with
                    | 0 ->
                        GHC.Types.ZMZN 
                    | _ ->
                        let 
                            wildB1 = ds1dBp
                        in
                            match wildB1.Force() with
                            | GHC.Types.ZC (xabp, xsabr) -> GHC.Types.ZC (xabp, lazy takezuunsafezuUInt<'ba65> ((GHC.Prim.zmzh ds2XCT 1)) (xsabr))
                            | GHC.Types.ZMZN -> GHC.Types.ZMZN 
            )
                
    let takeUInt<'ba67> : GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<'ba67>> -> GHC.Types.ZMZN<'ba67> = 
        fun nabd xsabf ->            
            (
                let 
                    wildB1 = GHC.Prim.zgzezh (nabd) (0)
                in
                    match wildB1 with
                    | true -> (takezuunsafezuUInt<'ba67> (nabd) (xsabf))
                    | false -> GHC.Types.ZMZN 
            )

    let takeFB<'aa69, 'ba6a> : (Lazy<'aa69> -> Lazy<'ba6a> -> 'ba6a) -> Lazy<'ba6a> -> Lazy<'aa69> -> (GHC.Prim.Intzh -> 'ba6a) -> GHC.Prim.Intzh -> 'ba6a = 
        fun caaX naaZZ xab1 xsab3 mab5 ->            
            (
                let 
                    wildB1 = GHC.Prim.zlzezh (mab5) (1)
                in
                    match wildB1 with
                    | true -> (caaX (xab1) (naaZZ))
                    | false -> (caaX (xab1) (lazy xsab3 (GHC.Prim.zmzh mab5 1)))
            )

    let takeConst<'aa6c> : Lazy<'aa6c> -> GHC.Prim.Intzh -> 'aa6c = 
        fun xaaU dsdBv ->
            xaaU.Force()
//
//    let inline takeFoldr<'aa6e> : GHC.Types.Int -> GHC.Types.ZMZN<'aa6e> -> GHC.Types.ZMZN<'aa6e> = 
//        fun dsdBw xsaaM ->
//            let wildB1 = 
//                dsdBw
//            in
//                match wildB1 with
//                | GHC.Types.Izh (nzhaaK)->
//                    GHC.Base.build<aatk> (fun caaP nilaaR ->
//                        let wild1X1I = 
//                            GHC.Prim.zlzezh (nzhaaK) (0)
//                        in
//                            match wild1X1I with
//                            | true ->
//                                nilaaR
//                            | false ->
//                                GHC.Base.foldr<aatk, GHC.Prim.Intzh -> bato> (takeFB<aatk, bato> (caaP) (nilaaR)) (takeConst<bato> (nilaaR)) (xsaaM) (nzhaaK)
//                    )
    

    let inline take<'aa6k> : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.ZMZN<'aa6k>> -> GHC.Types.ZMZN<'aa6k> = 
        fun dsdBs xsaba ->            
            (
                let 
                    wildB1 = dsdBs
                in
                    match wildB1.Force() with
                    | GHC.Types.Izh (nzhab8)-> (takeUInt<'aa6k> (nzhab8) (xsaba))
            )
    

    let rec dropWhile<'aa6m> : (Lazy<'aa6m> -> GHC.Bool.Bool) -> Lazy<GHC.Types.ZMZN<'aa6m>> -> GHC.Types.ZMZN<'aa6m> = 
        fun dsdBy ds1dBzz ->            
            (
                let 
                    wildB1 = ds1dBzz
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xaaF, xszqaaH) ->
                        let 
                            wild1X1K = dsdBy (xaaF)
                        in
                            match wild1X1K with
                            | true -> (dropWhile<'aa6m> (dsdBy) (xszqaaH))
                            | false -> wildB1.Force()
                    
                    | GHC.Types.ZMZN -> GHC.Types.ZMZN 
            )

    let rec takeWhile<'aa6o> : (Lazy<'aa6o> -> GHC.Bool.Bool) -> Lazy<GHC.Types.ZMZN<'aa6o>> -> GHC.Types.ZMZN<'aa6o> = 
        fun dsdBD ds1dBE ->            
            (
                let 
                    wildB1 = ds1dBE
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xaav, xsaax) ->
                        let 
                            wild1X1L = dsdBD (xaav)
                        in
                            match wild1X1L with
                            | true -> GHC.Types.ZC (xaav, lazy takeWhile<'aa6o> (dsdBD) (xsaax)) 
                            | false -> GHC.Types.ZMZN 
                    
                    | GHC.Types.ZMZN -> GHC.Types.ZMZN 
            )
    

//    let cycle<'aa6q> : GHC.Types.ZMZN<'aa6q> -> GHC.Types.ZMZN<'aa6q> = 
//        fun dsdBI ->
//            let wildB1 = 
//                dsdBI
//            in
//                match wildB1 with
//                | GHC.Types.ZC (Lazy(ipvsFK, ipv1sFL) -> GHC.Base.zpzp<'aa6q> (wildB1) (GHC.Base.zpzp<'aa6q> wildB1)
//                | GHC.Types.ZMZN ->
//                    lvl3<'aa6q> 
    

//    let inline repeatFB<'aa6u, 'ba6v> : ('aa6u -> 'ba6v -> 'ba6v) -> 'aa6u -> 'ba6v = 
//        fun caa8 xaaa ->
//            let rec xssJi = 
//                caa8 (xaaa) (xssJi)
//            in
//                xssJi

//    let inline repeat<'aa6x> : 'aa6x -> GHC.Types.ZMZN<'aa6x> = 
//        fun xaa2 ->
//            let rec xssJk = 
//                GHC.Types.ZC (Lazy((xaa2), (xssJk)) in
//                xssJk
//
//    let inline replicate<'aa6s> : GHC.Types.Int -> 'aa6s -> GHC.Types.ZMZN<'aa6s> = 
//        fun naag xaai ->
//            take<'aa6s> (naag) (repeat<'aa6s> (xaai))

    let rec iterate<'aa6C> : (Lazy<'aa6C> -> 'aa6C) -> Lazy<'aa6C> -> GHC.Types.ZMZN<'aa6C> = 
        fun fa9Q xa9S ->            
            (
                GHC.Types.ZC (xa9S, lazy iterate<'aa6C> (fa9Q) (lazy fa9Q (xa9S)))
            )

    let rec iterateFB<'aa6z, 'ba6A> : (Lazy<'aa6z> -> Lazy<'ba6A> -> 'ba6A) -> (Lazy<'aa6z> -> 'aa6z) -> Lazy<'aa6z> -> 'ba6A = 
        fun ca9V fa9X xa9ZZ ->            
            (
                (ca9V (xa9ZZ) (lazy iterateFB<'aa6z, 'ba6A> (ca9V) (fa9X) (lazy fa9X (xa9ZZ))))
            )

    let rec zdsscanr1<'aatX> : Lazy<GHC.Types.ZMZN<'aatX>> -> Lazy<'aatX> -> (Lazy<'aatX> -> Lazy<'aatX> -> 'aatX) -> GHC.Types.ZMZN<'aatX> = 
        fun scs11u sc1s11v sc2s11w ->            
            (
                let 
                    wildX1W = scs11u
                in
                    match wildX1W.Force() with
                    | GHC.Types.ZC (ipvsFX, ipv1sFY) ->
                        let dssXw = 
                            let 
                                wild1X25 = lazy zdsscanr1<'aatX> (ipv1sFY) (ipvsFX) (sc2s11w)
                            in
                                match wild1X25.Force() with
                                | GHC.Types.ZC (qau4, ds1dBT) -> GHC.Tuple.Z2T ((wild1X25), (qau4)) 
                                | GHC.Types.ZMZN -> lvl1<'aatX>.Force() 
                        in
                            GHC.Types.ZC (lazy (sc2s11w (sc1s11v) (
                                            let 
                                                ds1XE1 = dssXw
                                            in
                                                match ds1XE1 with
                                                | GHC.Tuple.Z2T (qsXwa, qau4)-> qau4
                                            )), (
                                          lazy(
                                            let ds1XE1 = 
                                                dssXw
                                            in
                                                match ds1XE1 with
                                                | GHC.Tuple.Z2T (qsXwa, qau4)-> qsXwa.Force()))) 
                                
                    | GHC.Types.ZMZN ->
                        GHC.Types.ZC (sc1s11v, lazy(GHC.Types.ZMZN))
            )

    let scanr1<'aa6E> : (Lazy<'aa6E> -> Lazy<'aa6E> -> 'aa6E) -> Lazy<GHC.Types.ZMZN<'aa6E>> -> GHC.Types.ZMZN<'aa6E> = 
        fun dsdBP ds1dBQ ->            
            (
                let 
                    wildB1 = ds1dBQ
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xa9C, ds2dBR) ->
                        let 
                            wild1X1W = ds2dBR
                        in
                            match wild1X1W.Force() with
                            | GHC.Types.ZC (ipvsFX, ipv1sFY) ->
                                let ds3sXw = 
                                    let 
                                        wild2X25 = lazy zdsscanr1<'aa6E> (ipv1sFY) (ipvsFX) (dsdBP)
                                    in
                                        match wild2X25.Force() with
                                        | GHC.Types.ZC (qau4, ds4dBT) -> GHC.Tuple.Z2T ((wild2X25), (qau4)) 
                                        | GHC.Types.ZMZN -> lvl1<'aa6E>.Force() 
                                in
                                    GHC.Types.ZC (lazy (dsdBP (xa9C) (let ds4XE1 = ds3sXw in
                                                                            match ds4XE1 with
                                                                            | GHC.Tuple.Z2T (qsXwa, qau4)-> qau4)), (
                                                                                lazy(let ds4XE1 = ds3sXw in
                                                                                    match ds4XE1 with
                                                                                    | GHC.Tuple.Z2T (qsXwa, qau4)-> qsXwa.Force()))) 
                            
                            | GHC.Types.ZMZN -> GHC.Types.ZC (xa9C, lazy(GHC.Types.ZMZN ))
                    
                    | GHC.Types.ZMZN -> GHC.Types.ZMZN 
            )

    let rec scanr<'aa6G, 'ba6H> : (Lazy<'aa6G> -> Lazy<'ba6H> -> 'ba6H) -> Lazy<'ba6H> -> Lazy<GHC.Types.ZMZN<'aa6G>> -> GHC.Types.ZMZN<'ba6H> = 
        fun dsdC4 q0a9l ds1dC5 ->
            (
                let wildB1 = 
                    ds1dC5
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xa9s, xsa9u) ->
                        let ds2sXy = 
                            let 
                                wild1X22 = lazy scanr<'aa6G, 'ba6H> (dsdC4) (q0a9l) (xsa9u)
                            in
                                match wild1X22.Force() with
                                | GHC.Types.ZC (qaue, ds3dC7) ->
                                    GHC.Tuple.Z2T ((wild1X22), (qaue)) 
                                | GHC.Types.ZMZN ->
                                    lvlr14M<'ba6H>.Force() 
                        in
                            GHC.Types.ZC (lazy (dsdC4 (xa9s) (
                            let ds3XEc = 
                                ds2sXy
                            in
                                match ds3XEc with
                                | GHC.Tuple.Z2T (qsXwh, qaue)->
                                    qaue
                            )), (lazy(
                            let ds3XEc = 
                                ds2sXy
                            in
                                match ds3XEc with
                                | GHC.Tuple.Z2T (qsXwh, qaue)->
                                    qsXwh.Force()
                            ))) 
                    | GHC.Types.ZMZN ->
                        GHC.Types.ZC (q0a9l, lazy(GHC.Types.ZMZN))
            )

    let rec zdsfoldr1<'aauh> : Lazy<GHC.Types.ZMZN<'aauh>> -> Lazy<'aauh> -> (Lazy<'aauh> -> Lazy<'aauh> -> 'aauh) -> 'aauh = 
        fun scs11K sc1s11L sc2s11M ->            
            (
                let 
                    wildX1Y = scs11K
                in
                    match wildX1Y.Force() with
                    | GHC.Types.ZC (ipvsG8, ipv1sG9) -> (sc2s11M (sc1s11L) (lazy zdsfoldr1<'aauh> (ipv1sG9) (ipvsG8) (sc2s11M)))
                    | GHC.Types.ZMZN -> sc1s11L.Force()
            )

    let foldr1<'aa6J> : (Lazy<'aa6J> -> Lazy<'aa6J> -> 'aa6J) -> Lazy<GHC.Types.ZMZN<'aa6J>> -> 'aa6J = 
        fun dsdCc ds1dCd ->            
            (
                let 
                    wildB1 = ds1dCd
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xa9a, ds2dCe) ->
                        let 
                            wild1X1Y = ds2dCe
                        in
                            match wild1X1Y.Force() with
                            | GHC.Types.ZC (ipvsG8, ipv1sG9) -> (dsdCc (xa9a) (lazy zdsfoldr1<'aa6J> (ipv1sG9) (ipvsG8) (dsdCc)))
                            | GHC.Types.ZMZN -> xa9a.Force()
                    
                    | GHC.Types.ZMZN -> lvl12<'aa6J>.Force() 
            )

    let rec scanl<'aa6N, 'ba6O> : (Lazy<'aa6N> -> Lazy<'ba6O> -> 'aa6N) -> Lazy<'aa6N> -> Lazy<GHC.Types.ZMZN<'ba6O>> -> GHC.Types.ZMZN<'aa6N> = 
        fun fa8P qa8R lsa8T ->
            (
                GHC.Types.ZC (qa8R, lazy(
                let 
                    wildB1 = lsa8T
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xa8X, xsa8ZZ) -> (scanl<'aa6N, 'ba6O> (fa8P) (lazy fa8P (qa8R) (xa8X)) (xsa8ZZ))
                    | GHC.Types.ZMZN -> GHC.Types.ZMZN 
                )) 
            )
            
    let scanl1<'aa6L> : (Lazy<'aa6L> -> Lazy<'aa6L> -> 'aa6L) -> Lazy<GHC.Types.ZMZN<'aa6L>> -> GHC.Types.ZMZN<'aa6L> = 
        fun fa92 dsdCm ->            
            (
                let wildB1 = 
                    dsdCm
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xa94, xsa96) -> (scanl<'aa6L, 'aa6L> (fa92) (xa94) (xsa96))
                    | GHC.Types.ZMZN -> GHC.Types.ZMZN 
            )

    let foldl<'aa6Q, 'ba6R> : (Lazy<'aa6Q> -> Lazy<'ba6R> -> 'aa6Q) -> Lazy<'aa6Q> -> Lazy<GHC.Types.ZMZN<'ba6R>> -> 'aa6Q = 
        fun fa8w zz0a8y xs0a8A ->            
            (
                let rec lgosXA : Lazy<'aa6Q> -> Lazy<GHC.Types.ZMZN<'ba6R>> -> 'aa6Q = 
                    fun zza8F dsdCp ->
                        let 
                            wildB1 = dsdCp
                        in
                            match wildB1.Force() with
                            | GHC.Types.ZC (xa8K, xsa8M) -> lgosXA (lazy fa8w (zza8F) (xa8K)) (xsa8M)
                            | GHC.Types.ZMZN -> zza8F.Force()
                in
                    (lgosXA (zz0a8y) (xs0a8A))
            )

    let filterFB<'aa6T, 'ba6U> : (Lazy<'aa6T> -> Lazy<'ba6U> -> 'ba6U) -> (Lazy<'aa6T> -> GHC.Bool.Bool) -> Lazy<'aa6T> -> Lazy<'ba6U> -> 'ba6U = 
        fun ca8n pa8p xa8r ra8t ->
            (
                let 
                    wildB1 = pa8p (xa8r)
                in
                    match wildB1 with
                    | true -> (ca8n (xa8r) (ra8t))
                    | false -> ra8t.Force()
            )

    let length<'aa6Y> : Lazy<GHC.Types.ZMZN<'aa6Y>> -> GHC.Types.Int = 
        fun la7Y ->            
            (
                GHC.Types.Izh ((zdwlen<'aa6Y> (la7Y) (0)))
            )

    let listNull<'aa70> : Lazy<GHC.Types.ZMZN<'aa70>> -> GHC.Bool.Bool = 
        fun dsdCB ->            
            (
                let 
                    wildB1 = dsdCB
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (ds1dCC, ds2dCD) -> false
                    | GHC.Types.ZMZN -> true
            )
    

    let init<'aa72> : Lazy<GHC.Types.ZMZN<'aa72>> -> GHC.Types.ZMZN<'aa72> = 
        fun dsdCG ->            
            (
                let 
                    wildB1 = dsdCG
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xa7H, xsa7J) -> (initzq<'aa72> (xa7H) (xsa7J))
                    | GHC.Types.ZMZN -> lvl16<'aa72>.Force() 
            )

    let last<'aa74> : Lazy<GHC.Types.ZMZN<'aa74>> -> 'aa74 = 
        fun dsdCN ->            
            (
                let 
                    wildB1 = dsdCN
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xa7r, xsa7t) -> (lastzq<'aa74> (xa7r) (xsa7t))
                    | GHC.Types.ZMZN -> lvl20<'aa74>.Force()
            )
                       

    let tail<'aa76> : Lazy<GHC.Types.ZMZN<'aa76>> -> GHC.Types.ZMZN<'aa76> = 
        fun dsdCT ->            
            (
                let 
                    wildB1 = dsdCT
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (ds1dCU, xsa7m) -> xsa7m.Force()
                    | GHC.Types.ZMZN -> lvl24<'aa76>.Force() 
            )
    

    let rec private lvl25r15W : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.unpackCStringzh ("head")

    let rec private lvl26r15Y : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.zpzp<GHC.Types.Char> (lvl25r15W) (lvl8r152)

    let rec private lvl27r160 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy GHC.Base.zpzp<GHC.Types.Char> (prelzulistzustrr4N) (lvl26r15Y)

    let badHead<'aa78> : Lazy<'aa78> = 
        lazy (GHC.Err.error<'aa78> (lvl27r160))

    let head<'aa7a> : Lazy<GHC.Types.ZMZN<'aa7a>> -> 'aa7a = 
        fun dsdCX ->            
            (
                let 
                    wildB1 = dsdCX
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xa7d, ds1dCY) -> xa7d.Force()
                    | GHC.Types.ZMZN -> badHead<'aa7a>.Force() 
            )
    

    let rec zzipWith<'aa59, 'ba5a, 'ca5b> : (Lazy<'aa59> -> Lazy<'ba5a> -> 'ca5b) -> Lazy<GHC.Types.ZMZN<'aa59>> -> Lazy<GHC.Types.ZMZN<'ba5a>> -> GHC.Types.ZMZN<'ca5b> = 
        fun fagl dsdzzy ds1dzzzz ->            
            (
                let 
                    wildB1 = dsdzzy
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (aagn, asagp) ->
                        let 
                            wild1X2i = ds1dzzzz
                        in
                            match wild1X2i.Force() with
                            | GHC.Types.ZC (bagr, bsagt) -> GHC.Types.ZC (lazy (fagl (aagn) (bagr)), lazy zzipWith (fagl) (asagp) (bsagt))
                            | GHC.Types.ZMZN -> GHC.Types.ZMZN 
                    
                    | GHC.Types.ZMZN -> GHC.Types.ZMZN 
            )

    let rec foldr2<'aa5z, 'ba5A, 'ca5B> : (Lazy<'aa5z> -> Lazy<'ba5A> -> Lazy<'ca5B> -> 'ca5B) -> Lazy<'ca5B> -> Lazy<GHC.Types.ZMZN<'aa5z>> -> Lazy<GHC.Types.ZMZN<'ba5A>> -> 'ca5B = 
        fun zukaeF zzaeH dsdzzV zuysaeJ ->            
            (
                let 
                    wildB1 = dsdzzV
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (ipvsGy, ipv1sGzz) ->
                        let 
                            wild1X2m = zuysaeJ
                        in
                            match wild1X2m.Force() with
                            | GHC.Types.ZC (ipv2sGC, ipv3sGD) -> (zukaeF (ipvsGy) (ipv2sGC) (lazy foldr2 (zukaeF) (zzaeH) (ipv1sGzz) (ipv3sGD)))
                            | GHC.Types.ZMZN -> zzaeH.Force()
                    
                    | GHC.Types.ZMZN -> zzaeH.Force()
            )

    let rec zzip<'aa5m, 'ba5n> : Lazy<GHC.Types.ZMZN<'aa5m>> -> Lazy<GHC.Types.ZMZN<'ba5n>> -> GHC.Types.ZMZN<GHC.Tuple.Z2T<'aa5m, 'ba5n>> = 
        fun dsdzzK ds1dzzL ->            
            (
                let 
                    wildB1 = dsdzzK
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (aafO, asafQ) ->
                        let 
                            wild1X2i = ds1dzzL
                        in
                            match wild1X2i.Force() with
                            | GHC.Types.ZC (bafS, bsafU) -> GHC.Types.ZC (lazy(GHC.Tuple.Z2T ((aafO), (bafS)) ), lazy zzip (asafQ) (bsafU))
                            | GHC.Types.ZMZN -> GHC.Types.ZMZN 
                    
                    | GHC.Types.ZMZN -> GHC.Types.ZMZN 
            )

    let rec filter<'aa6W> : (Lazy<'aa6W> -> GHC.Bool.Bool) -> Lazy<GHC.Types.ZMZN<'aa6W>> -> GHC.Types.ZMZN<'aa6W> = 
        fun zupreda8d dsdCt ->            
            (
                let 
                    wildB1 = dsdCt
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xa8i, xsa8k) ->
                        let 
                            wild1X2j = zupreda8d (xa8i)
                        in
                            match wild1X2j with
                            | true -> GHC.Types.ZC ((xa8i), lazy filter<'aa6W> (zupreda8d) (xsa8k))
                            | false -> (filter<'aa6W> (zupreda8d) (xsa8k))
                    
                    | GHC.Types.ZMZN -> GHC.Types.ZMZN 
            )

    let rec polyzugo<'aar9> : Lazy<GHC.Types.ZMZN<GHC.Types.ZMZN<'aar9>>> -> GHC.Types.ZMZN<'aar9> = 
        fun dsaDn ->            
            (
                let 
                    wildaDo = dsaDn
                in
                    match wildaDo.Force() with
                    | GHC.Types.ZC (yaDs, ysaDt) -> (GHC.Base.zpzp<'aar9> (yaDs) (lazy polyzugo<'aar9> (ysaDt)))
                    | GHC.Types.ZMZN -> GHC.Types.ZMZN
            )

    let concat<'aa5F> : Lazy<GHC.Types.ZMZN<GHC.Types.ZMZN<'aa5F>>> -> GHC.Types.ZMZN<'aa5F> = 
        fun xsaDl ->            
            polyzugo<'aa5F> (xsaDl)

    
