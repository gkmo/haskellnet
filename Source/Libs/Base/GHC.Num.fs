namespace GHC

module Num = 
    type ZCTNum<'aab4> = 
        | ZCDNum of Lazy<(GHC.Classes.ZCTEq<'aab4>)> * Lazy<(GHC.Show.ZCTShow<'aab4>)> * (Lazy<'aab4> -> Lazy<'aab4> -> 'aab4) * (Lazy<'aab4> -> Lazy<'aab4> -> 'aab4) * (Lazy<'aab4> -> Lazy<'aab4> -> 'aab4) * (Lazy<'aab4> -> 'aab4) * (Lazy<'aab4> -> 'aab4) * (Lazy<'aab4> -> 'aab4) * (Lazy<GHC.Integer.Internals.Integer> -> 'aab4)

    let zdp1Num<'aab4> : Lazy<ZCTNum<'aab4>> -> GHC.Classes.ZCTEq<'aab4> = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDNum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba) ->
                    tpl2B2.Force()
    

    let zdp2Num<'aab4> : Lazy<ZCTNum<'aab4>> -> GHC.Show.ZCTShow<'aab4> = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDNum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba) ->
                    tpl3B3.Force()
    

    let zp<'aab4> : Lazy<ZCTNum<'aab4>> -> Lazy<'aab4> -> Lazy<'aab4> -> 'aab4 = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDNum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba) ->
                    tpl4B4
    

    let zt<'aab4> : Lazy<ZCTNum<'aab4>> -> Lazy<'aab4> -> Lazy<'aab4> -> 'aab4 = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDNum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba) ->
                    tpl5B5
    

    let zm<'aab4> : Lazy<ZCTNum<'aab4>> -> Lazy<'aab4> -> Lazy<'aab4> -> 'aab4 = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDNum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba) ->
                    tpl6B6
    

    let negate<'aab4> : Lazy<ZCTNum<'aab4>> -> Lazy<'aab4> -> 'aab4 = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDNum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba) ->
                    tpl7B7
    

    let abs<'aab4> : Lazy<ZCTNum<'aab4>> -> Lazy<'aab4> -> 'aab4 = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDNum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba) ->
                    tpl8B8
    

    let signum<'aab4> : Lazy<ZCTNum<'aab4>> -> Lazy<'aab4> -> 'aab4 = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDNum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba) ->
                    tpl9B9
    

    let fromInteger<'aab4> : Lazy<ZCTNum<'aab4>> -> Lazy<GHC.Integer.Internals.Integer> -> 'aab4 = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDNum (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba) ->
                    tpl10Ba
    

    let zdwfromEnum : Lazy<GHC.Integer.Internals.Integer> -> GHC.Prim.Intzh = 
        fun wsTk ->
            (
                let wildavV = wsTk in
                    match wildavV.Force() with
                    | GHC.Integer.Internals.Jzh (saw0, daw1)->
                        (GHC.Prim.integer2Intzh saw0 daw1)
                    | GHC.Integer.Internals.Szh (iavX)->
                        (iavX)
            )

    let zdwfromInteger : Lazy<GHC.Integer.Internals.Integer> -> GHC.Prim.Intzh = 
        fun wsTe ->
            (
                let wildavV = wsTe in
                    match wildavV.Force() with
                    | GHC.Integer.Internals.Jzh (saw0, daw1) ->
                        GHC.Prim.integer2Intzh saw0 daw1 
                    | GHC.Integer.Internals.Szh (iavX)->
                        iavX
            )

    let zdwdivModInt : GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Prim.Z2H<GHC.Types.Int, GHC.Types.Int> = 
        fun wwsT5 ww1sT9 ->
            GHC.Prim.Z2H ((GHC.Types.Izh (GHC.Base.divIntzh (wwsT5) (ww1sT9))), (GHC.Types.Izh (GHC.Base.modIntzh (wwsT5) (ww1sT9))))
                            
    let lvl : Lazy<GHC.Integer.Internals.Integer> = 
        lazy(GHC.Integer.Internals.Szh (0))

    let lvl1 : Lazy<GHC.Integer.Internals.Integer> = 
        lazy(GHC.Integer.Internals.Szh (1))
        
    let lvl9 : Lazy<GHC.Types.Char> =
        lazy (GHC.Types.Czh (')'))

    let lvl10 : Lazy<GHC.Types.Char> =
        lazy (GHC.Types.Czh ('('))

    let lvl11 : Lazy<GHC.Types.Int> = 
        lazy (GHC.Types.Izh (-1))

    let lvl12 : Lazy<GHC.Types.Int> = 
        lazy (GHC.Types.Izh (0))

    let lvl13 : Lazy<GHC.Types.Int> = 
        lazy (GHC.Types.Izh (1))
        
    let signum1 : Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun nagn ->
            (
                let wildaw6 = nagn in
                    match wildaw6.Force() with
                    | GHC.Types.Izh (xaw8)->
                            let wild1B1 = GHC.Prim.zlzh xaw8 0  in
                                match wild1B1 with
                                | true ->
                                    lvl11.Force()
                                | false ->
                                        let wild2X1Q = xaw8 in
                                            match wild2X1Q with
                                            | 0 ->
                                                lvl12.Force()
                                            | _ ->
                                                lvl13.Force()
             )
                                                    
    let abs1 : Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun nagk ->
            (
                let wildaww = nagk in
                    match wildaww.Force() with
                    | GHC.Types.Izh (xawy)->
                            let wild1B1 = GHC.Prim.zgzezh xawy 0  in
                                match wild1B1 with
                                | true ->
                                    wildaww.Force()
                                | false ->
                                    GHC.Types.Izh (GHC.Prim.negateIntzh xawy ) 
             )
                    
    let fromInteger1 : Lazy<GHC.Integer.Internals.Integer> -> GHC.Types.Int = 
        fun x ->             
            (
                GHC.Types.Izh ((zdwfromInteger x))
            )
                                                  
    let zdfNumInt : Lazy<ZCTNum<GHC.Types.Int>> = 
        lazy(ZCDNum (GHC.Base.zdfEqInt, GHC.Show.zdfShowInt, (GHC.Base.plusInt), (GHC.Base.timesInt), (GHC.Base.minusInt), (GHC.Base.negateInt), (abs1), (signum1), (fromInteger1)))
        
        
    let zddmnegate<'aab4> : Lazy<ZCTNum<'aab4>> -> Lazy<'aab4> -> 'aab4 =
        fun zddNumapZZ xabd ->            
            (
                let litsW1 =
                    match zddNumapZZ.Force() with
                    | ZCDNum (tpl1B2, tpl2B3, tpl3B4, tpl4B5, tpl5B6, tpl6B7, tpl7B8, tpl8B9, tpl9Ba) -> lazy (tpl9Ba (lvl))
                in
                    match zddNumapZZ.Force() with
                    | ZCDNum (tpl1B2, tpl2B3, tpl3B4, tpl4B5, tpl5B6, tpl6B7, tpl7B8, tpl8B9, tpl9Ba) -> (tpl5B6 litsW1 xabd)
            )
                                
    let zddmzm<'aab4> : Lazy<ZCTNum<'aab4>> -> Lazy<'aab4> -> Lazy<'aab4> -> 'aab4 =
        fun zddNumapZZ xab8 yaba ->            
            (
                match zddNumapZZ.Force() with
                | ZCDNum (tpl1B2, tpl2B3, tpl3B4, tpl4B5, tpl5B6, tpl6B7, tpl7B8, tpl8B9, tpl9Ba) -> 
                    (tpl3B4 xab8 (lazy (tpl6B7 yaba)))
            )    
            
    let zdfEqInteger : Lazy<GHC.Classes.ZCTEq<GHC.Integer.Internals.Integer>> = // zdf5
        lazy(GHC.Classes.ZCDEq ((GHC.HInteger.eqInteger), (GHC.HInteger.neqInteger)))
        

    let a : Lazy<GHC.Integer.Internals.Integer> -> Lazy<GHC.Integer.Internals.Integer> -> GHC.Integer.Internals.Integer =
        fun xaAk yaAl ->            
            (
                match (GHC.HInteger.leInteger xaAk yaAl) with
                | false -> yaAl.Force()
                | true -> xaAk.Force()
            )
            
    let a1 : Lazy<GHC.Integer.Internals.Integer> -> Lazy<GHC.Integer.Internals.Integer> -> GHC.Integer.Internals.Integer =
        fun xaA0 yaA1 ->            
            (
                match (GHC.HInteger.leInteger xaA0 yaA1) with
                | false -> xaA0.Force()
                | true -> yaA1.Force()
            )   
            
    let lvl2 = lazy (GHC.Types.Czh ('-'))
                        
    let lvl3rZZB = lazy (GHC.Integer.Internals.Szh (1000000000))
         
    let lvl4rZZD : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = lazy GHC.Base.unpackCStringzh "jprinth []"
    
    let lvl5rZZF : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = lazy (GHC.Err.error (lvl4rZZD))
                     
    let lvl6rZZH : Lazy<GHC.Integer.Internals.Integer> =
        lazy 
        (
            match (GHC.Prim.mulIntMayOflozh (1000000000) (1000000000)) with
            | 0 -> GHC.Integer.Internals.Szh (-1486618624)
            | _ -> match (GHC.Prim.int2Integerzh (1000000000)) with
                   | GHC.Prim.Z2H (saCD, daCE) -> (GHC.HInteger.zdstimesInteger (daCE) (saCD) (daCE) (saCD))
        )
                 
        
    let lvl7rZZJ : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = lazy GHC.Base.unpackCStringzh "jsplith: []"
                   
    let lvl8rZZL : Lazy<GHC.Types.ZMZN<GHC.Integer.Internals.Integer>> = lazy (GHC.Err.error (lvl7rZZJ))
            
    let rec private jsplitbrZZX : Lazy<GHC.Integer.Internals.Integer> -> Lazy<GHC.Types.ZMZN<GHC.Integer.Internals.Integer>> -> GHC.Types.ZMZN<GHC.Integer.Internals.Integer> = 
        fun dsdue ds1duf ->            
            (
                let wildB1 = ds1duf in
                    match wildB1.Force() with
                    | GHC.Types.ZC (nacD, nsacF) ->
                        let wild1X2D = GHC.HInteger.quotRemInteger nacD dsdue in
                            match wild1X2D with
                            | GHC.Prim.Z2H (qacI, racK) -> GHC.Types.ZC (lazy qacI, lazy (GHC.Types.ZC (lazy racK, lazy (jsplitbrZZX dsdue nsacF))))                 
                    | GHC.Types.ZMZN -> GHC.Types.ZMZN
            )
            
    let rec private zdwjblockzqr103 : GHC.Prim.Intzh -> GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun wwsTC ww1sTG wsTI ->            
            (
                let wildB1 = wwsTC in
                    match wildB1 with
                    | 1 -> GHC.Types.ZC (lazy((GHC.Types.Czh ((GHC.Prim.chrzh (GHC.Prim.zpzh (48) (ww1sTG)))))), wsTI) 
                    | _ -> (zdwjblockzqr103 (GHC.Prim.zmzh (wildB1) (1)) (GHC.Prim.quotIntzh (ww1sTG) (10)) (lazy (GHC.Types.ZC (lazy((GHC.Types.Czh ((GHC.Prim.chrzh (GHC.Prim.zpzh (48) (GHC.Prim.remIntzh ww1sTG (10))))))), wsTI))))
            )
                                                 
    let rec private jsplitfrZZZZ : Lazy<GHC.Integer.Internals.Integer> -> Lazy<GHC.Integer.Internals.Integer> -> GHC.Types.ZMZN<GHC.Integer.Internals.Integer> = 
        fun pacb nacd ->            
            (
                let wildB1 = GHC.HInteger.gtInteger (pacb) (nacd) in
                    match wildB1 with
                    | true -> GHC.Types.ZC ((nacd), (lazy GHC.Types.ZMZN)) 
                    | false ->
                        let wild1X2I = jsplitfrZZZZ (lazy GHC.HInteger.timesInteger (pacb) (pacb)) (nacd) in
                            match wild1X2I with
                            | GHC.Types.ZC (n1aci, nsack) ->
                                let wild2X2M = GHC.HInteger.quotRemInteger (n1aci) (pacb) in
                                    match wild2X2M with
                                    | GHC.Prim.Z2H (qacu, racw)->
                                        let wild3X5J = GHC.HInteger.gtInteger (lazy qacu) (lvl) in
                                            match wild3X5J with
                                            | true -> GHC.Types.ZC ((lazy qacu), lazy((GHC.Types.ZC ((lazy racw), lazy (jsplitbrZZX (pacb) (nsack)))))) 
                                            | false -> GHC.Types.ZC ((lazy racw), lazy (jsplitbrZZX (pacb) (nsack))) 
                                                            
                            | GHC.Types.ZMZN -> lvl8rZZL.Force()
             )
                    
    let rec private zdwjheadr101 : GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun wwsTt wsTv ->
            let wildB1 = GHC.Prim.zlzh (wwsTt) (10) in
                    match wildB1 with
                    | true -> GHC.Types.ZC (lazy((GHC.Types.Czh ((GHC.Prim.chrzh (GHC.Prim.zpzh (48) (wwsTt)))))), (wsTv)) 
                    | false -> (zdwjheadr101 (GHC.Prim.quotIntzh (wwsTt) (10)) (lazy (GHC.Types.ZC (lazy((GHC.Types.Czh ((GHC.Prim.chrzh (GHC.Prim.zpzh (48) (GHC.Prim.remIntzh (wwsTt) (10))))))), (wsTv)))))
                    
    let rec private jprintbr10b : Lazy<GHC.Types.ZMZN<GHC.Integer.Internals.Integer>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun dsdup csad6 ->            
            (
                let wildB1 = dsdup in
                    match wildB1.Force() with
                    | GHC.Types.ZC (nad9, nsadb) ->
                        let wild1X2w = GHC.HInteger.quotRemInteger (nad9) (lvl3rZZB) in
                            match wild1X2w with
                            | GHC.Prim.Z2H (qzqadg, rzqadi)->
                                let zdjsWb = 
                                    fun wwsTG ->
                                        zdwjblockzqr103 (9) wwsTG (
                                                                    let wild2avV = rzqadi in
                                                                        match wild2avV with
                                                                        | GHC.Integer.Internals.Jzh (saw0, daw1)->
                                                                            let ww1sTh = GHC.Prim.integer2Intzh (saw0) (daw1) in
                                                                                match ww1sTh with
                                                                                | _ -> lazy zdwjblockzqr103 (9) ww1sTh (lazy jprintbr10b nsadb csad6)                                                                            
                                                                        | GHC.Integer.Internals.Szh iavX -> lazy zdwjblockzqr103 (9) iavX (lazy jprintbr10b nsadb csad6))
                                 in
                                    let wild2avV = qzqadg in
                                        match wild2avV with
                                        | GHC.Integer.Internals.Jzh (saw0, daw1)->
                                            let wwsTh = GHC.Prim.integer2Intzh (saw0) (daw1) in
                                                match wwsTh with
                                                | _ -> (zdjsWb wwsTh)
                                        | GHC.Integer.Internals.Szh iavX -> (zdjsWb iavX)
                    | GHC.Types.ZMZN -> csad6.Force()
               )
                    
    let rec private integerToStringzq : Lazy<GHC.Integer.Internals.Integer> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun nac2 csac4 ->            
            (
                let wildB1 = GHC.HInteger.ltInteger (nac2) (lvl3rZZB) in
                    match wildB1 with
                    | true ->
                        let wild1avV = nac2 in
                            match wild1avV.Force() with
                            | GHC.Integer.Internals.Jzh (saw0, daw1)->
                                let wwsTh = GHC.Prim.integer2Intzh (saw0) (daw1) in
                                    (zdwjheadr101 (wwsTh) (csac4))
                            | GHC.Integer.Internals.Szh (iavX)-> 
                                (zdwjheadr101 (iavX) (csac4))
                    
                    | false ->
                        let wild1X2N = jsplitfrZZZZ (lvl6rZZH) (nac2) in
                            match wild1X2N with
                            | GHC.Types.ZC (n1acN, nsacP) ->
                                let wild2X2R = GHC.HInteger.quotRemInteger (n1acN) (lvl3rZZB) in
                                    match wild2X2R with
                                    | GHC.Prim.Z2H (qzqacU, rzqacW)->
                                        let zdjsWd = 
                                            fun wild3aMb xaMd ->
                                                let wild4X62 = GHC.Prim.zgzh (xaMd) (0) in
                                                    match wild4X62 with
                                                    | true ->
                                                        let wXV3 = wild3aMb in
                                                            match wXV3 with
                                                            | GHC.Types.Izh (wwsTt) -> zdwjheadr101 (wwsTt) (
                                                                lazy let wild5avV = rzqacW in
                                                                        match wild5avV with
                                                                        | GHC.Integer.Internals.Jzh (saw0, daw1)->
                                                                            let ww1sTh = GHC.Prim.integer2Intzh (saw0) (daw1) in
                                                                                match ww1sTh with
                                                                                | _ -> zdwjblockzqr103 (9) (ww1sTh) (lazy jprintbr10b (nsacP) (csac4))
                                                                                                                                                
                                                                        | GHC.Integer.Internals.Szh (iavX)-> zdwjblockzqr103 (9) (iavX) (lazy jprintbr10b (nsacP) (csac4))
                                                                )
                                                    
                                                    | false ->
                                                        let wild5avV = rzqacW in
                                                            match wild5avV with
                                                            | GHC.Integer.Internals.Jzh (saw0, daw1)->
                                                                let wwsTh = GHC.Prim.integer2Intzh (saw0) (daw1) in
                                                                    match wwsTh with
                                                                    | _ -> zdwjheadr101 (wwsTh) (lazy jprintbr10b (nsacP) (csac4))
                                                            
                                                            | GHC.Integer.Internals.Szh (iavX)-> zdwjheadr101 (iavX) (lazy jprintbr10b (nsacP) (csac4))
                                                    
                                        in
                                            let wild3avV = qzqacU in
                                                match wild3avV with
                                                | GHC.Integer.Internals.Jzh (saw0, daw1)->
                                                    let wild4X21 = GHC.Prim.integer2Intzh (saw0) (daw1) in
                                                        match wild4X21 with
                                                        | _ -> (zdjsWd (GHC.Types.Izh ((wild4X21)) ) (wild4X21))
                                                
                                                | GHC.Integer.Internals.Szh (iavX)-> (zdjsWd (GHC.Types.Izh ((iavX)) ) (iavX))
                                                            
                            | GHC.Types.ZMZN -> lvl5rZZF.Force()
            )
    

    let rec private integerToString : Lazy<GHC.Integer.Internals.Integer> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun n0abF cs0abH ->            
            (
                let wildB1 = GHC.HInteger.ltInteger (n0abF) (lvl) in
                    match wildB1 with
                    | true -> GHC.Types.ZC ((lvl2), lazy integerToStringzq (lazy GHC.HInteger.negateInteger (n0abF)) (cs0abH)) 
                    | false -> (integerToStringzq (n0abF) (cs0abH))
            )
                      
    let zdwshowsPrec : GHC.Prim.Intzh -> Lazy<GHC.Integer.Internals.Integer> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> =
        fun wwsTP wsTR w1sTS ->            
            (
                match (GHC.Prim.zgzh (wwsTP) (6)) with
                | false -> (integerToString wsTR w1sTS)
                | true -> 
                    match (GHC.HInteger.ltInteger wsTR (lvl)) with
                    | false -> (integerToString wsTR w1sTS)                    
                    | true -> GHC.Types.ZC (lvl10, lazy integerToString wsTR (lazy GHC.Types.ZC(lvl9, w1sTS)))
            )                                
            
    let zdfShowIntegerzushowsPrec : Lazy<GHC.Types.Int> -> Lazy<GHC.Integer.Internals.Integer> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> =
        fun wsTN w1sTR w2sTS ->            
            (
                match wsTN.Force() with
                | GHC.Types.Izh wwsTP -> (zdwshowsPrec (wwsTP) w1sTR w2sTS)
            )
            
    let zdfShowIntegerzushowList : Lazy<GHC.Types.ZMZN<GHC.Integer.Internals.Integer>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> =
        fun ds1aEt saEu ->
            (
                match ds1aEt.Force() with
                | GHC.Types.ZMZN -> (GHC.Base.zpzp GHC.Show.lvl17 saEu)
                | GHC.Types.ZC (xaEA, xsaEB) -> 
                        GHC.Types.ZC (GHC.Show.lvl15, lazy zdwshowsPrec (0) xaEA (let lvl23sWf = lazy GHC.Types.ZC (GHC.Show.lvl16, saEu) in                                                                                
                                                                                    let rec showl1sWh : Lazy<GHC.Types.ZMZN<GHC.Integer.Internals.Integer>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> =
                                                                                        fun ds2aEF ->
                                                                                            match ds2aEF.Force() with
                                                                                            | GHC.Types.ZMZN -> lvl23sWf
                                                                                            | GHC.Types.ZC (yaEK, ysaEL) -> lazy (GHC.Types.ZC (GHC.Show.a67, lazy zdwshowsPrec (0) yaEK (showl1sWh ysaEL)))
                                                                                    in
                                                                                        showl1sWh xsaEB
                                                                                ))
            )                     
            
    let zdfShowInteger3 : Lazy<GHC.Integer.Internals.Integer> -> GHC.Types.ZMZN<GHC.Types.Char> =
        fun xaEo ->
            (
                (zdwshowsPrec (0) xaEo (lazy GHC.Types.ZMZN))
            )
            
    let zdfShowInteger : Lazy<GHC.Show.ZCTShow<GHC.Integer.Internals.Integer>> = // zdf3
        lazy(GHC.Show.ZCDShow ((zdfShowIntegerzushowsPrec), (zdfShowInteger3), (zdfShowIntegerzushowList)))
        
    let zdfNumIntegerzufromInteger : Lazy<GHC.Integer.Internals.Integer> -> GHC.Integer.Internals.Integer =
        fun xafW -> xafW.Force()
        
    let zdfNumInteger : Lazy<ZCTNum<GHC.Integer.Internals.Integer>> = // zdf2
        lazy(ZCDNum (zdfEqInteger, zdfShowInteger, (GHC.HInteger.plusInteger), (GHC.HInteger.timesInteger), (GHC.HInteger.minusInteger), (GHC.HInteger.negateInteger), 
                     (GHC.HInteger.absInteger), (GHC.HInteger.signumInteger), (zdfNumIntegerzufromInteger)))
                           
    let zdfOrdInteger : Lazy<GHC.Classes.ZCTOrd<GHC.Integer.Internals.Integer>> = // zdf4
        lazy(GHC.Classes.ZCDOrd (zdfEqInteger, (GHC.HInteger.compareInteger), (GHC.HInteger.ltInteger), (GHC.HInteger.geInteger), (GHC.HInteger.gtInteger), (GHC.HInteger.leInteger), (a1), (a)))