namespace GHC

module Classes = 
    type ZCTEq<'aa1t> = 
        | ZCDEq of (Lazy<'aa1t> -> Lazy<'aa1t> -> GHC.Bool.Bool) 
                 * (Lazy<'aa1t> -> Lazy<'aa1t> -> GHC.Bool.Bool)

    type ZCTOrd<'aaJ> = 
        | ZCDOrd of Lazy<ZCTEq<'aaJ>> 
                  * (Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Ordering.Ordering) 
                  * (Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool) 
                  * (Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool) 
                  * (Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool) 
                  * (Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool) 
                  * (Lazy<'aaJ> -> Lazy<'aaJ> -> 'aaJ) 
                  * (Lazy<'aaJ> -> Lazy<'aaJ> -> 'aaJ)

    let zeze<'aa1t> : Lazy<ZCTEq<'aa1t>> -> Lazy<'aa1t> -> Lazy<'aa1t> -> GHC.Bool.Bool = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDEq (tpl2B2, tpl3B3) ->
                    tpl2B2
    

    let zsze<'aa1t> : Lazy<ZCTEq<'aa1t>> -> Lazy<'aa1t> -> Lazy<'aa1t> -> GHC.Bool.Bool = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDEq (tpl2B2, tpl3B3) ->
                    tpl3B3
    

    let zdp1Ord<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> ZCTEq<'aaJ> = 
        fun tplB1 ->
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDOrd (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9) ->
                        tpl2B2.Force()
    

    let compare<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Ordering.Ordering = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDOrd (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9) ->
                    tpl3B3
    

    let zl<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDOrd (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9) ->
                    tpl4B4
    

    let zgze<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool = 
        fun tplB1 ->
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDOrd (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9) ->
                        tpl5B5
    

    let zg<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool = 
        fun tplB1 ->
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDOrd (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9) ->
                        tpl6B6
    

    let zlze<'aaJ> : Lazy<ZCTOrd<'aaJ>> ->  Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool = 
        fun tplB1 ->
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDOrd (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9) ->
                        tpl7B7
    

    let max<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> 'aaJ = 
        fun tplB1 ->
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDOrd (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9) ->
                        tpl8B8
    

    let min<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> 'aaJ = 
        fun tplB1 ->
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDOrd (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9) ->
                        tpl9B9
    

    let zddmzsze<'aa1t> : Lazy<ZCTEq<'aa1t>> -> Lazy<'aa1t> -> Lazy<'aa1t> -> GHC.Bool.Bool = 
        fun zddEqa37 xa1x ya1zz ->
            (
                let tplX4 = zddEqa37 in
                    match tplX4.Force() with
                    | ZCDEq (tpl1B2, tpl2B3) ->
                        let wildB1 = tpl1B2 xa1x ya1zz  in
                            match wildB1 with
                            | true ->
                                false
                            | false ->
                                true
            )
                    
    

    let zddmzeze<'aa1t> : Lazy<ZCTEq<'aa1t>> -> Lazy<'aa1t> -> Lazy<'aa1t> -> GHC.Bool.Bool = 
        fun zddEqa37 xa1C ya1E ->            
            (
                let tplX4 = zddEqa37 in
                    match tplX4.Force() with
                    | ZCDEq (tpl1B2, tpl2B3) ->
                            let wildB1 = tpl2B3 xa1C ya1E  in
                                match wildB1 with
                                | true ->
                                    false
                                | false ->
                                    true
             )       
    

    let zddmmin<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> 'aaJ = 
        fun zddOrda2j xa1p ya1r ->            
            (
                let tplX4 = zddOrda2j in
                    match tplX4.Force() with
                    | ZCDOrd (tpl1B2, tpl2B3, tpl3B4, tpl4B5, tpl5B6, tpl6B7, tpl7B8, tpl8B9) ->
                            let wildB1 = tpl6B7 xa1p ya1r  in
                                match wildB1 with
                                | true ->
                                    xa1p.Force()
                                | false ->
                                    ya1r.Force()
             )       
    

    let zddmmax<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> 'aaJ = 
        fun zddOrda2j xa1k ya1m ->            
            (
                let tplX4 = zddOrda2j in
                    match tplX4.Force() with
                    | ZCDOrd (tpl1B2, tpl2B3, tpl3B4, tpl4B5, tpl5B6, tpl6B7, tpl7B8, tpl8B9) ->
                            let wildB1 = tpl6B7 xa1k ya1m  in
                                match wildB1 with
                                | true ->
                                    ya1m.Force()
                                | false ->
                                    xa1k.Force()
             )       
    

    let zddmzlze<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool = 
        fun zddOrda2j xaZZ ya11 ->            
            (
                let tplX4 = zddOrda2j in
                    match tplX4.Force() with
                    | ZCDOrd (tpl1B2, tpl2B3, tpl3B4, tpl4B5, tpl5B6, tpl6B7, tpl7B8, tpl8B9) ->
                            let wildB1 = tpl2B3 xaZZ ya11  in
                                match wildB1 with
                                | GHC.Ordering.GT ->
                                    false
                                | _ ->
                                    true
             )       
    

    let zddmzg<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool = 
        fun zddOrda2j xa16 ya18 ->            
            (
                let tplX4 = zddOrda2j in
                    match tplX4.Force() with
                    | ZCDOrd (tpl1B2, tpl2B3, tpl3B4, tpl4B5, tpl5B6, tpl6B7, tpl7B8, tpl8B9) ->
                            let wildB1 = tpl2B3 xa16 ya18  in
                                match wildB1 with
                                | GHC.Ordering.GT ->
                                    true
                                | _ ->
                                    false
             )
                    
    let zddmzgze<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool = 
        fun zddOrda2j xa1d ya1f ->            
            (
                let tplX4 = zddOrda2j in
                    match tplX4.Force() with
                    | ZCDOrd (tpl1B2, tpl2B3, tpl3B4, tpl4B5, tpl5B6, tpl6B7, tpl7B8, tpl8B9) ->
                            let wildB1 = tpl2B3 xa1d ya1f in
                                match wildB1 with
                                | GHC.Ordering.LT -> false
                                | _ -> true
            )
                    
    let zddmzl<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Bool.Bool = 
        fun zddOrda2j xaS yaU ->            
            (
                let tplX4 = zddOrda2j in
                    match tplX4.Force() with
                    | ZCDOrd (tpl1B2, tpl2B3, tpl3B4, tpl4B5, tpl5B6, tpl6B7, tpl7B8, tpl8B9) ->
                            let wildB1 = tpl2B3 xaS yaU  in
                                match wildB1 with
                                | GHC.Ordering.LT ->
                                    true
                                | _ ->
                                    false
             )
                    
    let zddmcompare<'aaJ> : Lazy<ZCTOrd<'aaJ>> -> Lazy<'aaJ> -> Lazy<'aaJ> -> GHC.Ordering.Ordering = 
        fun zddOrda2j xaN yaP ->            
            (
                let tplX4 = zddOrda2j in
                    match tplX4.Force() with
                    | ZCDOrd (tpl1B2, tpl2B3, tpl3B4, tpl4B5, tpl5B6, tpl6B7, tpl7B8, tpl8B9) ->
                            let tpl9XD = tpl1B2 in
                                match tpl9XD.Force() with
                                | ZCDEq (tpl10XE, tpl11XG) ->
                                        let wildB1 = tpl10XE xaN yaP  in
                                            match wildB1 with
                                            | true ->
                                                GHC.Ordering.EQ
                                            | false ->
                                                    let wild1Xs = tpl6B7 xaN yaP in
                                                        match wild1Xs with
                                                        | true ->
                                                            GHC.Ordering.LT
                                                        | false ->
                                                            GHC.Ordering.GT
            )

    let not : Lazy<GHC.Bool.Bool> -> GHC.Bool.Bool = 
        fun dsd3A ->            
            (
                let wildB1 = dsd3A in
                    match wildB1.Force() with
                    | true ->
                        false
                    | false ->
                        true
            )

    let zbzb : Lazy<GHC.Bool.Bool> -> Lazy<GHC.Bool.Bool> -> GHC.Bool.Bool = 
        fun dsd3D ds1d3E ->            
            (
                let wildB1 = dsd3D in
                    match wildB1.Force() with
                    | true ->
                        true
                    | false ->
                        ds1d3E.Force()
            )
    

    let zaza : Lazy<GHC.Bool.Bool> -> Lazy<GHC.Bool.Bool> -> GHC.Bool.Bool = 
        fun dsd3H xa1H ->            
            (
                let wildB1 = dsd3H in
                    match wildB1.Force() with
                    | true ->
                        xa1H.Force()
                    | false ->
                        false
            )