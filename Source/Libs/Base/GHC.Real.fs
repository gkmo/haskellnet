namespace GHC

module Real = 
    
    type Ratio<'aafk> = 
        | ZCzv of Lazy<'aafk> * Lazy<'aafk>

    type ZCTReal<'aafg> = 
        | ZCDReal of Lazy<GHC.Num.ZCTNum<'aafg>> * Lazy<GHC.Classes.ZCTOrd<'aafg>> * (Lazy<'aafg> -> Ratio<GHC.Integer.Internals.Integer>)

    type ZCTFractional<'aaep> = 
        | ZCDFractional of Lazy<GHC.Num.ZCTNum<'aaep>> * (Lazy<'aaep> -> Lazy<'aaep> -> 'aaep) * (Lazy<'aaep> -> 'aaep) * (Lazy<Ratio<GHC.Integer.Internals.Integer>> -> 'aaep)

    type ZCTIntegral<'aaeA> = 
        | ZCDIntegral of Lazy<ZCTReal<'aaeA>> * Lazy<GHC.Enum.ZCTEnum<'aaeA>> * (Lazy<'aaeA> -> Lazy<'aaeA> -> 'aaeA) * (Lazy<'aaeA> -> Lazy<'aaeA> -> 'aaeA) * (Lazy<'aaeA> -> Lazy<'aaeA> -> 'aaeA) * (Lazy<'aaeA> -> Lazy<'aaeA> -> 'aaeA) * (Lazy<'aaeA> -> Lazy<'aaeA> -> GHC.Tuple.Z2T<'aaeA, 'aaeA>) * (Lazy<'aaeA> -> Lazy<'aaeA> -> GHC.Tuple.Z2T<'aaeA, 'aaeA>) * (Lazy<'aaeA> -> GHC.Integer.Internals.Integer)

//    type ZCTRealFrac<'aadB> = 
//        | ZCDRealFrac of (ZCTReal<'aadB>) * (ZCTFractional<'aadB>) * (ZCTIntegral<badD> -> 'aadB -> GHC.Tuple.Z2T<badD, 'aadB>) * (ZCTIntegral<badF> -> 'aadB -> badF) * (ZCTIntegral<badH> -> 'aadB -> badH) * (ZCTIntegral<badJ> -> 'aadB -> badJ) * (ZCTIntegral<badL> -> 'aadB -> badL)

    let zdWZCzv<'aafk> : Lazy<'aafk> -> Lazy<'aafk> -> Ratio<'aafk> = 
        fun tplB1 tpl1B2 ->            
            (
                let tpl2X5 = tplB1 in
                    match tpl2X5 with
                    | _ ->
                            let tpl3X7 = tpl1B2 in
                                match tpl3X7 with
                                | _ ->
                                    ZCzv( tpl2X5, tpl3X7 )                    
            )

    let zdp1Fractional<'aaep> : Lazy<ZCTFractional<'aaep>> -> GHC.Num.ZCTNum<'aaep> = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDFractional (tpl2B2, tpl3B3, tpl4B4, tpl5B5)->
                        tpl2B2.Force()
            )

    let zs<'aaep> : Lazy<ZCTFractional<'aaep>> -> Lazy<'aaep> -> Lazy<'aaep> -> 'aaep = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDFractional (tpl2B2, tpl3B3, tpl4B4, tpl5B5)->
                        tpl3B3
            )

    let recip<'aaep> : Lazy<ZCTFractional<'aaep>> -> Lazy<'aaep> -> 'aaep = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDFractional (tpl2B2, tpl3B3, tpl4B4, tpl5B5)->
                        tpl4B4
            )

    let fromRational<'aaep> : Lazy<ZCTFractional<'aaep>> -> Lazy<Ratio<GHC.Integer.Internals.Integer>> -> 'aaep = 
        fun tplB1 ->
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDFractional (tpl2B2, tpl3B3, tpl4B4, tpl5B5)->
                        tpl5B5
            )

    let zdp1Integral<'aaeA> : Lazy<ZCTIntegral<'aaeA>> -> ZCTReal<'aaeA> = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDIntegral (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba)->
                        tpl2B2.Force()
            )

    let zdp2Integral<'aaeA> : Lazy<ZCTIntegral<'aaeA>> -> GHC.Enum.ZCTEnum<'aaeA> = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDIntegral (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba)->
                        tpl3B3.Force()
            )

    let quot<'aaeA> : Lazy<ZCTIntegral<'aaeA>> -> Lazy<'aaeA> -> Lazy<'aaeA> -> 'aaeA = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDIntegral (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba)->
                        tpl4B4
            )

    let rem<'aaeA> : Lazy<ZCTIntegral<'aaeA>> -> Lazy<'aaeA> -> Lazy<'aaeA> -> 'aaeA = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDIntegral (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba)->
                        tpl5B5
            )

    let div<'aaeA> : Lazy<ZCTIntegral<'aaeA>> -> Lazy<'aaeA> -> Lazy<'aaeA> -> 'aaeA = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDIntegral (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba)->
                        tpl6B6
            )

    let hmod<'aaeA> : Lazy<ZCTIntegral<'aaeA>> -> Lazy<'aaeA> -> Lazy<'aaeA> -> 'aaeA = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDIntegral (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba)->
                        tpl7B7
            )

    let quotRem<'aaeA> : Lazy<ZCTIntegral<'aaeA>> -> Lazy<'aaeA> -> Lazy<'aaeA> -> GHC.Tuple.Z2T<'aaeA, 'aaeA> = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDIntegral (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba)->
                        tpl8B8
            )

    let divMod<'aaeA> : Lazy<ZCTIntegral<'aaeA>> -> Lazy<'aaeA> -> Lazy<'aaeA> -> GHC.Tuple.Z2T<'aaeA, 'aaeA> = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDIntegral (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba)->
                        tpl9B9
            )

    let toInteger<'aaeA> : Lazy<ZCTIntegral<'aaeA>> -> Lazy<'aaeA> -> GHC.Integer.Internals.Integer = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDIntegral (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8, tpl9B9, tpl10Ba)->
                        tpl10Ba
            )

    let zdp1Real<'aafg> : Lazy<ZCTReal<'aafg>> -> GHC.Num.ZCTNum<'aafg> = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDReal (tpl2B2, tpl3B3, tpl4B4)->
                        tpl2B2.Force()
            )

    let zdp2Real<'aafg> : Lazy<ZCTReal<'aafg>> -> GHC.Classes.ZCTOrd<'aafg> = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDReal (tpl2B2, tpl3B3, tpl4B4)->
                        tpl3B3.Force()
            )

    let toRational<'aafg> : Lazy<ZCTReal<'aafg>> -> Lazy<'aafg> -> Ratio<GHC.Integer.Internals.Integer> = 
        fun tplB1 ->            
            (
                let tpl1X4 = tplB1 in
                    match tpl1X4.Force() with
                    | ZCDReal (tpl2B2, tpl3B3, tpl4B4)->
                        tpl4B4
            )

//    let zdp1RealFrac<'aadB> : ZCTRealFrac<'aadB> -> ZCTReal<'aadB> = 
//        fun tplB1 ->
//                let tpl1X4 = tplB1 in
//                    match tpl1X4 with
//                    | ZCDRealFrac (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8)->
//                        tpl2B2
//    
//
//    let zdp2RealFrac<'aadB> : ZCTRealFrac<'aadB> -> ZCTFractional<'aadB> = 
//        fun tplB1 ->
//                let tpl1X4 = tplB1 in
//                    match tpl1X4 with
//                    | ZCDRealFrac (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8)->
//                        tpl3B3
//    
//
//    let properFraction<'aadB> : ZCTRealFrac<'aadB> -> ZCTIntegral<badD> -> 'aadB -> GHC.Tuple.Z2T<badD, 'aadB> = 
//        fun tplB1 ->
//                let tpl1X4 = tplB1 in
//                    match tpl1X4 with
//                    | ZCDRealFrac (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8)->
//                        tpl4B4
//    
//
//    let truncate<'aadB> : ZCTRealFrac<'aadB> -> ZCTIntegral<badF> -> 'aadB -> badF = 
//        fun tplB1 ->
//                let tpl1X4 = tplB1 in
//                    match tpl1X4 with
//                    | ZCDRealFrac (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8)->
//                        tpl5B5
//    
//
//    let round<'aadB> : ZCTRealFrac<'aadB> -> ZCTIntegral<badH> -> 'aadB -> badH = 
//        fun tplB1 ->
//                let tpl1X4 = tplB1 in
//                    match tpl1X4 with
//                    | ZCDRealFrac (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8)->
//                        tpl6B6
//    
//
//    let ceiling<'aadB> : ZCTRealFrac<'aadB> -> ZCTIntegral<badJ> -> 'aadB -> badJ = 
//        fun tplB1 ->
//                let tpl1X4 = tplB1 in
//                    match tpl1X4 with
//                    | ZCDRealFrac (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8)->
//                        tpl7B7
//    
//
//    let floor<'aadB> : ZCTRealFrac<'aadB> -> ZCTIntegral<badL> -> 'aadB -> badL = 
//        fun tplB1 ->
//                let tpl1X4 = tplB1 in
//                    match tpl1X4 with
//                    | ZCDRealFrac (tpl2B2, tpl3B3, tpl4B4, tpl5B5, tpl6B6, tpl7B7, tpl8B8)->
//                        tpl8B8
//    

//    let zdwzdsnegate : GHC.Integer.Internals.Integer -> GHC.Integer.Internals.Integer -> GHC.Prim.Z2H<GHC.Integer.Internals.Integer, GHC.Integer.Internals.Integer> = 
//        fun wws2H2 ww1s2H3 ->
//            let tplXaX =     
//                let wilda24u = wws2H2 in
//                    match wilda24u with
//                    | GHC.Integer.Internals.Jzh (sa24A, da24B)->
//                        GHC.Integer.Internals.Jzh ((GHC.Prim.negateIntzh sa24A ), da24B) 
//                    | GHC.Integer.Internals.Szh (ds1a24w)->
//                            let ds2a24y = ds1a24w in
//                                match ds2a24y with
//                                | GHC.Prim.Intzh.MinValue ->
//                                    GHC.Integer.lvl3
//                                | _ ->
//                                    GHC.Integer.Internals.Szh (GHC.Prim.negateIntzh ds2a24y ) 
//                    
//             in
//                match tplXaX with
//                | _ ->
//                        GHC.Prim.Z2H( tplXaX, ww1s2H3 )
    
//
//    let lvl : GHC.Integer.Internals.Integer = 
//            let wild2a23x = GHC.Prim.addIntCzh GHC.Prim.Intzh.MaxValue 1  in
//                match wild2a23x with
//                | GHC.Prim.Z2H (ra23zz, ca23A)->
//                        let wild3a23C = ca23A in
//                            match wild3a23C with
//                            | 0 ->
//                                GHC.Integer.Internals.Szh ra23zz 
//                            | _ ->
//                                    let wild4a23D = GHC.Prim.int2Integerzh GHC.Prim.Intzh.MaxValue  in
//                                        match wild4a23D with
//                                        | GHC.Prim.Z2H (sa23F, da23G)->
//                                                let wild5a23I = GHC.Prim.int2Integerzh 1  in
//                                                    match wild5a23I with
//                                                    | GHC.Prim.Z2H (s1a23K, d1a23L)->
//                                                        GHC.Integer.zdsplusInteger d1a23L s1a23K da23G sa23F 
                                        
                            
                
    

//    let zdwzdsabs : GHC.Integer.Internals.Integer -> GHC.Integer.Internals.Integer -> GHC.Prim.Z2H<GHC.Integer.Internals.Integer, GHC.Integer.Internals.Integer> = 
//        fun wws2GU ww1s2GV ->
//            let tplX6p =     
//                let wilda1Yu = wws2GU in
//                    match wilda1Yu with
//                    | GHC.Integer.Internals.Jzh (sa1YF, da1YG)->
//                            let wild1a1YI = GHC.Prim.zgzezh sa1YF 0  in
//                                match wild1a1YI with
//                                | true ->
//                                    wilda1Yu
//                                | false ->
//                                    GHC.Integer.Internals.Jzh ((GHC.Prim.negateIntzh sa1YF ), da1YG)
//                    
//                    | GHC.Integer.Internals.Szh (ds1a1Yw)->
//                            let ds2a1Yy = ds1a1Yw in
//                                match ds2a1Yy with
//                                | -2147483648 ->
//                                    lvl
//                                | _ ->
//                                        let wild1a1Yzz = GHC.Prim.zgzezh ds2a1Yy 0  in
//                                            match wild1a1Yzz with
//                                            | true ->
//                                                wilda1Yu
//                                            | false ->
//                                                GHC.Integer.Internals.Szh (GHC.Prim.negateIntzh ds2a1Yy ) 
//                                
//                    
//             in
//                    match tplX6p with
//                    | _ ->
//                        GHC.Prim.Z2H (tplX6p, ww1s2GV)
    

    let zdwzeze<'aafk> : Lazy<ZCTIntegral<'aafk>> -> Lazy<'aafk> -> Lazy<'aafk> -> Lazy<'aafk> -> Lazy<'aafk> -> GHC.Bool.Bool = 
        fun ws2Gd wws2Gg ww1s2Gh ww2s2Gl ww3s2Gm ->            
            (
                let tplX4 = ws2Gd in
                    match tplX4.Force() with
                    | ZCDIntegral (tpl1B2, tpl2B3, tpl3B4, tpl4B5, tpl5B6, tpl6B7, tpl7B8, tpl8B9, tpl9Ba)->
                            let tpl10X9D = tpl1B2 in
                                match tpl10X9D.Force() with
                                | ZCDReal (tpl11X9E, tpl12X9G, tpl13X9I)->
                                        let tpl14X9K = tpl12X9G in
                                            match tpl14X9K.Force() with
                                            | GHC.Classes.ZCDOrd (tpl15X9L, tpl16X9N, tpl17X9P, tpl18X9R, tpl19X9T, tpl20X9V, tpl21X9X, tpl22X9ZZ) ->
                                                    let tpl23X9W = tpl15X9L in
                                                        match tpl23X9W.Force() with
                                                        | GHC.Classes.ZCDEq (tpl24XjS, tpl25XjV) ->
                                                                let wilda1g1 = tpl24XjS wws2Gg ww2s2Gl  in
                                                                    match wilda1g1 with
                                                                    | true ->
                                                                        (tpl24XjS ww1s2Gh ww3s2Gm)
                                                                    | false ->
                                                                        false
            )                                                                                                                                                   


    let zdwquot : Lazy<GHC.Types.Int> -> GHC.Prim.Intzh -> GHC.Types.Int = 
        fun ws2Eg wws2Ej ->            
            (
                let wildB1 = wws2Ej in
                    match wildB1 with
                    | 0 ->
                        GHC.Err.divZZeroError<GHC.Types.Int>.Force() 
                    | _ ->
                            let wild1X22b = ws2Eg in
                                match wild1X22b.Force() with
                                | GHC.Types.Izh (xX22g)->
                                        let wild2X8A = xX22g in
                                            match wild2X8A with
                                            | -2147483648 ->
                                                    let wild3X8E = wildB1 in
                                                        match wild3X8E with
                                                        | -1 ->
                                                            GHC.Err.overflowError<GHC.Types.Int>.Force()
                                                        | _ ->
                                                                let wild21a1hj = GHC.Prim.quotIntzh (-2147483648) (wild3X8E)  in
                                                                    match wild21a1hj with
                                                                    | _ ->
                                                                        GHC.Types.Izh wild21a1hj 
                                                        
                                            
                                            | _ ->
                                                    let wild21a1hj = GHC.Prim.quotIntzh wild2X8A (wildB1)  in
                                                        match wild21a1hj with
                                                        | _ ->
                                                            GHC.Types.Izh wild21a1hj 
             )
                                

    let zdwrem : Lazy<GHC.Types.Int> -> GHC.Prim.Intzh -> GHC.Types.Int = 
        fun ws2E8 wws2Eb ->            
            (
                let wildB1 = wws2Eb in
                    match wildB1 with
                    | 0 ->
                        GHC.Err.divZZeroError<GHC.Types.Int>.Force()
                    | _ ->
                            let wild1X22a = ws2E8 in
                                match wild1X22a.Force() with
                                | GHC.Types.Izh (xX22f)->
                                        let wild2X8zz = xX22f in
                                            match wild2X8zz with
                                            | -2147483648 ->
                                                    let wild3X8D = wildB1 in
                                                        match wild3X8D with
                                                        | -1 ->
                                                            GHC.Err.overflowError<GHC.Types.Int>.Force()
                                                        | _ ->
                                                                let wild21a1h7 = GHC.Prim.remIntzh (-2147483648) (wild3X8D)  in
                                                                    match wild21a1h7 with
                                                                    | _ ->
                                                                        GHC.Types.Izh wild21a1h7 
                                                        
                                            
                                            | _ ->
                                                    let wild21a1h7 = GHC.Prim.remIntzh wild2X8zz (wildB1)  in
                                                        match wild21a1h7 with
                                                        | _ ->
                                                            GHC.Types.Izh wild21a1h7                                                                            
            )        
    

    let zdwdiv : Lazy<GHC.Types.Int> -> GHC.Prim.Intzh -> GHC.Types.Int = 
        fun ws2E0 wws2E3 ->            
            (
                let wildB1 = wws2E3 in
                    match wildB1 with
                    | 0 ->
                        GHC.Err.divZZeroError<GHC.Types.Int>.Force()
                    | _ ->
                            let wild1X229 = ws2E0 in
                                match wild1X229.Force() with
                                | GHC.Types.Izh (xX22e)->
                                        let wild2X8y = xX22e in
                                            match wild2X8y with
                                            | -2147483648 ->
                                                    let wild3X8C = wildB1 in
                                                        match wild3X8C with
                                                        | -1 ->
                                                            GHC.Err.overflowError<GHC.Types.Int>.Force()
                                                        | _ ->
                                                                let wild21a1gV = GHC.Base.divIntzh (-2147483648) (wild3X8C)  in
                                                                    match wild21a1gV with
                                                                    | _ ->
                                                                        GHC.Types.Izh wild21a1gV 
                                                        
                                            
                                            | _ ->
                                                    let wild21a1gV = GHC.Base.divIntzh wild2X8y (wildB1)  in
                                                        match wild21a1gV with
                                                        | _ ->
                                                            GHC.Types.Izh wild21a1gV                                            
            )                            
                    
    

    let zdwmod : Lazy<GHC.Types.Int> -> GHC.Prim.Intzh -> GHC.Types.Int = 
        fun ws2DS wws2DV ->            
            (
                let wildB1 = wws2DV in
                    match wildB1 with
                    | 0 ->
                        GHC.Err.divZZeroError<GHC.Types.Int>.Force()
                    | _ ->
                            let wild1X228 = ws2DS in
                                match wild1X228.Force() with
                                | GHC.Types.Izh (xX22d)->
                                        let wild2X8x = xX22d in
                                            match wild2X8x with
                                            | -2147483648 ->
                                                    let wild3X8B = wildB1 in
                                                        match wild3X8B with
                                                        | -1 ->
                                                            GHC.Err.overflowError<GHC.Types.Int>.Force()
                                                        | _ ->
                                                                let wild21a1gJ = GHC.Base.modIntzh (-2147483648) (wild3X8B)  in
                                                                    match wild21a1gJ with
                                                                    | _ ->
                                                                        GHC.Types.Izh wild21a1gJ 
                                                        
                                            
                                            | _ ->
                                                    let wild21a1gJ = GHC.Base.modIntzh wild2X8x (wildB1)  in
                                                        match wild21a1gJ with
                                                        | _ ->
                                                            GHC.Types.Izh wild21a1gJ                                            
            )                    
                    
    

    let zdwquotRem : Lazy<GHC.Types.Int> -> GHC.Prim.Intzh -> GHC.Tuple.Z2T<GHC.Types.Int, GHC.Types.Int> = 
        fun ws2DK wws2DN ->            
            (
                let wildB1 = wws2DN in
                    match wildB1 with
                    | 0 ->
                        GHC.Err.divZZeroError<GHC.Tuple.Z2T<GHC.Types.Int, GHC.Types.Int>>.Force()
                    | _ ->
                            let wild1X227 = ws2DK in
                                match wild1X227.Force() with
                                | GHC.Types.Izh (xX22c)->
                                        let wild2X8w = xX22c in
                                            match wild2X8w with
                                            | -2147483648 ->
                                                    let wild3X8A = wildB1 in
                                                        match wild3X8A with
                                                        | -1 ->
                                                            GHC.Err.overflowError<GHC.Tuple.Z2T<GHC.Types.Int, GHC.Types.Int>>.Force()
                                                        | _ ->
                                                            GHC.Tuple.Z2T
                                                                (
                                                                lazy let wild21a1gw = GHC.Prim.quotIntzh (-2147483648) (wild3X8A)  in
                                                                        match wild21a1gw with
                                                                        | _ ->
                                                                             (GHC.Types.Izh wild21a1gw)
                                                                ,
                                                                lazy let wild21a1gx = GHC.Prim.remIntzh (-2147483648) (wild3X8A)  in
                                                                        match wild21a1gx with
                                                                        | _ ->
                                                                             (GHC.Types.Izh wild21a1gx)
                                                                )
                                                             
                                            
                                            | _ ->
                                                GHC.Tuple.Z2T 
                                                    (
                                                    lazy let wild21a1gw = GHC.Prim.quotIntzh wild2X8w (wildB1)  in
                                                            match wild21a1gw with
                                                            | _ ->
                                                                (GHC.Types.Izh wild21a1gw)
                                                    ,
                                                    lazy let wild21a1gx = GHC.Prim.remIntzh wild2X8w (wildB1)  in
                                                            match wild21a1gx with
                                                            | _ ->
                                                                (GHC.Types.Izh wild21a1gx)
                                                    )                                                 
            )

    let zdwdivMod : Lazy<GHC.Types.Int> -> GHC.Prim.Intzh -> GHC.Tuple.Z2T<GHC.Types.Int, GHC.Types.Int> = 
        fun ws2DC wws2DF ->            
            (
                let wildB1 = wws2DF in
                    match wildB1 with
                    | 0 ->
                        GHC.Err.divZZeroError<GHC.Tuple.Z2T<GHC.Types.Int, GHC.Types.Int>>.Force()
                    | _ ->
                            let wild1X226 = ws2DC in
                                match wild1X226.Force() with
                                | GHC.Types.Izh (xX22b)->
                                        let wild2X8u = xX22b in
                                            match wild2X8u with
                                            | -2147483648 ->
                                                    let wild3X8zz = wildB1 in
                                                        match wild3X8zz with
                                                        | -1 ->
                                                            GHC.Err.overflowError<GHC.Tuple.Z2T<GHC.Types.Int, GHC.Types.Int>>.Force()
                                                        | _ ->
                                                            GHC.Tuple.Z2T (
                                                                lazy (
                                                                    let wild21a1TY = GHC.Base.divIntzh (-2147483648) (wild3X8zz)  in
                                                                        match wild21a1TY with
                                                                        | _ ->
                                                                            GHC.Types.Izh wild21a1TY), 
                                                                lazy (
                                                                    let wild21a1TZZ = GHC.Base.modIntzh (-2147483648) (wild3X8zz)  in
                                                                        match wild21a1TZZ with
                                                                        | _ ->
                                                                            GHC.Types.Izh wild21a1TZZ) )
                                                             
                                            
                                            | _ ->
                                                GHC.Tuple.Z2T(
                                                    lazy (
                                                            let wild21a1TY = GHC.Base.divIntzh wild2X8u (wildB1)  in
                                                                match wild21a1TY with
                                                                | _ ->
                                                                    GHC.Types.Izh wild21a1TY) ,
                                                    lazy (
                                                            let wild21a1TZZ = GHC.Base.modIntzh wild2X8u (wildB1)  in
                                                                match wild21a1TZZ with
                                                                | _ ->
                                                                    GHC.Types.Izh wild21a1TZZ) )
            )                

    let a : Lazy<GHC.Types.Char> = lazy (GHC.Types.Czh ('-'))
   
    let a1 : Lazy<GHC.Integer.Internals.Integer> = lazy (GHC.Integer.Internals.Szh (2))
   
    let a2 : Lazy<GHC.Integer.Internals.Integer> = lazy (GHC.Integer.Internals.Szh (1))
   
    let lvl1 : Lazy<GHC.Integer.Internals.Integer> = lazy (GHC.Integer.Internals.Szh (0))
     
    let lvl7r3yj : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = lazy GHC.Base.unpackCStringzh "Ratio.%: zero denominator"
          
    let lvl9 : Lazy<GHC.Prim.Z2H<GHC.Integer.Internals.Integer, GHC.Integer.Internals.Integer>> =
        lazy (GHC.Err.error<GHC.Prim.Z2H<GHC.Integer.Internals.Integer, GHC.Integer.Internals.Integer>> (lvl7r3yj))
          
    let lvl12r3yt : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = lazy GHC.Base.unpackCStringzh "GHC.Real.gcdInteger: gcd 0 0 is undefined"
          
    let lvl13 : Lazy<GHC.Integer.Internals.Integer> =
        lazy (GHC.Err.error<GHC.Integer.Internals.Integer> (lvl12r3yt))
               
    let gcdIntegerzq : Lazy<GHC.Integer.Internals.Integer> -> Lazy<GHC.Integer.Internals.Integer> -> GHC.Integer.Internals.Integer =
        fun dsd1aO ds1daP ->            
            (
                match (GHC.HInteger.eqInteger dsd1aO lvl1) with
                | false -> (GHC.HInteger.gcdInteger dsd1aO ds1daP)
                | true -> 
                    match (GHC.HInteger.eqInteger ds1daP lvl1) with
                    | false -> (GHC.HInteger.gcdInteger dsd1aO ds1daP)
                    | true -> lvl13.Force()    
            )
               
                               
    let zdwreduce : Lazy<GHC.Integer.Internals.Integer> -> Lazy<GHC.Integer.Internals.Integer> -> GHC.Prim.Z2H<GHC.Integer.Internals.Integer, GHC.Integer.Internals.Integer> = 
        fun ws2Eo w1s2Ep ->            
            (
                let wildB1 = GHC.HInteger.eqInteger w1s2Ep lvl1  in
                    match wildB1 with
                    | true -> lvl9.Force()
                    | false ->
                        let ds363 = lazy gcdIntegerzq ws2Eo w1s2Ep in
                            let tplX5t =     
                                let wild1a1WH = ds363 in
                                    match wild1a1WH.Force() with
                                    | GHC.Integer.Internals.Jzh (sa1WV, d1a1WW)->
                                        let wild2a1X2 = GHC.Prim.cmpIntegerIntzh sa1WV d1a1WW (0)  in
                                            match wild2a1X2 with
                                            | 0 -> (GHC.Err.divZZeroError<GHC.Integer.Internals.Integer>).Force()
                                            | _ -> (GHC.HInteger.quotInteger ws2Eo wild1a1WH)
                                        
                                    | GHC.Integer.Internals.Szh (ia1WJ)->
                                        let wild2X8P = ia1WJ in
                                            match wild2X8P with
                                            | 0 -> GHC.Err.divZZeroError<GHC.Integer.Internals.Integer>.Force()
                                            | _ -> (GHC.HInteger.quotInteger ws2Eo wild1a1WH)
                                in
                                    match tplX5t with
                                    | _ -> let tpl1X5x =     
                                                let wild1a1WH = ds363 in
                                                    match wild1a1WH.Force() with
                                                    | GHC.Integer.Internals.Jzh (sa1WV, d1a1WW)->
                                                            let wild2a1X2 = GHC.Prim.cmpIntegerIntzh sa1WV d1a1WW (0) in
                                                                match wild2a1X2 with
                                                                | 0 -> GHC.Err.divZZeroError<GHC.Integer.Internals.Integer>.Force()
                                                                | _ -> (GHC.HInteger.quotInteger w1s2Ep wild1a1WH)
                                                    
                                                    | GHC.Integer.Internals.Szh (ia1WJ)->
                                                            let wild2X8T = ia1WJ in
                                                                match wild2X8T with
                                                                | 0 -> GHC.Err.divZZeroError<GHC.Integer.Internals.Integer>.Force()
                                                                | _ -> GHC.HInteger.quotInteger w1s2Ep wild1a1WH
                                                    
                                            in
                                                match tpl1X5x with
                                                | _ -> GHC.Prim.Z2H (tplX5t, tpl1X5x)
            )
                    
    let zdwtoRational : GHC.Prim.Intzh -> GHC.Prim.Z2H<GHC.Integer.Internals.Integer, GHC.Integer.Internals.Integer> =
        fun wws2Ha ->             
            (
                let opa = 
                    lazy
                    (
                        match (GHC.Prim.mulIntMayOflozh (wws2Ha) (1)) with
                        | 0 -> GHC.Integer.Internals.Szh (wws2Ha)
                        | _ -> failwith "NotImplementedException"
                    )
                in
                    (zdwreduce opa a2)
            )
                                     
    let toRational3 : Lazy<GHC.Types.Int> -> Ratio<GHC.Integer.Internals.Integer> =
        fun w1X2Pr ->            
            (
                match w1X2Pr.Force() with
                | GHC.Types.Izh wws2Ga ->
                    match (zdwtoRational (wws2Ga)) with
                    | GHC.Prim.Z2H (ww2s2M4, ww3s2M5) -> ZCzv (lazy ww2s2M4, lazy ww3s2M5)
            )
                
    let zdfRealInt : Lazy<ZCTReal<GHC.Types.Int>> = // zdf11
        lazy (ZCDReal ((GHC.Num.zdfNumInt), (GHC.Base.zdfOrdInt), (toRational3)))

    let toInteger1 : Lazy<GHC.Types.Int> -> GHC.Integer.Internals.Integer = 
        fun dsd1dV ->            
            (
                let wildB1 = 
                    dsd1dV
                in
                    match wildB1.Force() with
                    | GHC.Types.Izh (ialI)->
                        GHC.Integer.Internals.Szh ((ialI)) 
            )
            
    let divMod1 : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Tuple.Z2T<GHC.Types.Int, GHC.Types.Int> = 
        fun ws2DC w1s2DD ->            
            (
                let w2X2KW = 
                    w1s2DD
                in
                    match w2X2KW.Force() with
                    | GHC.Types.Izh (wws2DF)->
                        (zdwdivMod (ws2DC) (wws2DF))
            )

    let quotRem1 : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Tuple.Z2T<GHC.Types.Int, GHC.Types.Int> = 
        fun ws2DK w1s2DL ->            
            (
                let w2X2L5 = 
                    w1s2DL
                in
                    match w2X2L5.Force() with
                    | GHC.Types.Izh (wws2DN)->
                        (zdwquotRem (ws2DK) (wws2DN))
            )

    let mod1 : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun ws2DS w1s2DT ->            
            (
                let w2X2Le = 
                    w1s2DT
                in
                    match w2X2Le.Force() with
                    | GHC.Types.Izh (wws2DV)->
                        (zdwmod (ws2DS) (wws2DV))
            )

    let div1 : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun ws2E0 w1s2E1 ->            
            (
                let w2X2Ln = 
                    w1s2E1
                in
                    match w2X2Ln.Force() with
                    | GHC.Types.Izh (wws2E3)->
                        (zdwdiv (ws2E0) (wws2E3))
            )

    let rem1 : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun ws2E8 w1s2E9 ->            
            (
                let w2X2Lw = 
                    w1s2E9
                in
                    match w2X2Lw.Force() with
                    | GHC.Types.Izh (wws2Eb)->
                        (zdwrem (ws2E8) (wws2Eb))
            )

    let quot1 : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun ws2Eg w1s2Eh ->            
            (
                let w2X2LF = 
                    w1s2Eh
                in
                    match w2X2LF.Force() with
                    | GHC.Types.Izh (wws2Ej)->
                        (zdwquot (ws2Eg) (wws2Ej))
            )
                                        
    let zdfIntegralInt : Lazy<ZCTIntegral<GHC.Types.Int>> = 
        lazy (ZCDIntegral ((zdfRealInt), (GHC.Enum.zdfEnumInt), (quot1), (rem1), (div1), (mod1), (quotRem1), (divMod1), (toInteger1)))
