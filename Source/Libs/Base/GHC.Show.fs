namespace GHC   
    
module Show = 
    open GHC.Types
    open GHC.Prim    
    open GHC.Base
             
    type ZCTShow<'aa4T> = 
        | ZCDShow of (Lazy<Int> -> Lazy<'aa4T> -> Lazy<ZMZN<Char>> -> ZMZN<Char>) * (Lazy<'aa4T> -> ZMZN<Char>) * (Lazy<ZMZN<'aa4T>> -> Lazy<ZMZN<Char>> -> ZMZN<Char>)

    let showsPrec<'aa4T> : Lazy<ZCTShow<'aa4T>> -> Lazy<Int> -> Lazy<'aa4T> -> Lazy<ZMZN<Char>> -> ZMZN<Char> = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDShow (tpl2B2, tpl3B3, tpl4B4) ->
                    tpl2B2
    

    let show<'aa4T> : Lazy<ZCTShow<'aa4T>> -> Lazy<'aa4T> -> ZMZN<Char> = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDShow (tpl2B2, tpl3B3, tpl4B4) ->
                    tpl3B3
    

    let showList<'aa4T> : Lazy<ZCTShow<'aa4T>> -> Lazy<ZMZN<'aa4T>> -> Lazy<ZMZN<Char>> -> ZMZN<Char> = 
        fun tplB1 ->
            let tpl1X4 = tplB1 in
                match tpl1X4.Force() with
                | ZCDShow (tpl2B2, tpl3B3, tpl4B4) ->
                    tpl4B4
    
    let shows<'aa5a> : Lazy<ZCTShow<'aa5a>> -> Lazy<'aa5a> -> Lazy<ZMZN<Char>> -> ZMZN<Char> =
        fun zddShowaoI ->
            match zddShowaoI.Force() with
            | ZCDShow (tpl1B2, tpl2B3, tpl3B4) -> 
                tpl1B2 GHC.Base.zzeroInt

                  

    let a : Lazy<ZMZN<Char>> = lazy unpackCStringzh "SP"

    let a1 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a, lazy(ZMZN)))

    let a2 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "US"

    let a3 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a2, a1))

    let a4 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "RS"

    let a5 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a4, a3))

    let a6 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "GS"

    let a7 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a6, a5))

    let a8 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "FS"

    let a9 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a8, a7))

    let a10 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "ESC"

    let a11 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a10, a9))

    let a12 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "SUB"

    let a13 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a12, a11))

    let a14 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "EM"

    let a15 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a14, a13))

    let a16 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "CAN"

    let a17 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a16, a15))

    let a18 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "ETB"

    let a19 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a18, a17))

    let a20 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "SYN"

    let a21 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a20, a19))

    let a22 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "NAK"

    let a23 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a22, a21))

    let a24 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "DC4"

    let a25 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a24, a23))

    let a26 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "DC3"

    let a27 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a26, a25))

    let a28 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "DC2"

    let a29 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a28, a27))

    let a30 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "DC1"

    let a31 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a30, a29))

    let a32 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "DLE"

    let a33 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a32, a31))

    let a34 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "SI"

    let a35 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a34, a33))

    let a36 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "SO"

    let a37 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a36, a35))

    let a38 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "CR"

    let a39 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a38, a37))

    let a40 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "FF"

    let a41 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a40, a39))

    let a42 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "VT"

    let a43 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a42, a41))

    let a44 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "LF"

    let a45 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a44, a43))

    let a46 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "HT"

    let a47 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a46, a45))

    let a48 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "BS"

    let a49 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a48, a47))

    let a50 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "BEL"

    let a51 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a50, a49))

    let a52 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "ACK"

    let a53 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a52, a51))

    let a54 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "ENQ"

    let a55 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a54, a53))

    let a56 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "EOT"

    let a57 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a56, a55))

    let a58 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "ETX"

    let a59 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a58, a57))

    let a60 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "STX"

    let a61 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a60, a59))

    let a62 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "SOH"

    let a63 : Lazy<ZMZN<ZMZN<Char>>> = lazy (ZC (a62, a61))

    let a64 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "NUL"

    let a65 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "Just "

    let a66 = lazy(Czh (')'))

    let a67 = lazy(Czh (','))
    
    let a68 = lazy(Czh ('('))
            
    let a69 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "()"

    let a70 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "False"

    let a71 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "True"

    let a72 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "LT"

    let a73 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "EQ"

    let a74 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "GT"

    let a76 = lazy(Czh ('\x27'))
   
    let a77 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x27\x5c\x27\x27"

    let a78 = lazy(Czh ('\x22'))

    let asciiTab : Lazy<ZMZN<ZMZN<Char>>> =  lazy (GHC.Types.ZC (a64, a63))
     
    let lvl5r1DT  = (lazy Czh ('\x5c'))
     
    let lvl6r1DV : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5cDEL"
     
    let lvl7r1DX : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5c\x5c"
     
    let lvl4r1DR : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5c\x22"
          
    let a75r1DB : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5cSO"

    let lvl8r1DZZ : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5cr"
     
    let lvl9r1E1 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5cf"
    
    let lvl10r1E3: Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5cv"
    
    let lvl11r1E5 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5cn"
    
    let lvl12r1E7 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5ct"
    
    let lvl13r1E9 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5cb"
    
    let lvl14r1Eb : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5ca"
     
    let lvl3 = lazy(Czh (' '))
    
    let lvl15 = lazy(Czh ('['))
    
    let lvl16 = lazy(Czh (']'))
     
    let lvl17 = lazy unpackCStringzh "[]"

    let lvl18 : Lazy<ZMZN<Char>> = lazy unpackCStringzh "\x5c&"
     
    let lvl19 = lazy(Czh ('-'))

    let rec itoszq : Intzh -> Lazy<ZMZN<Char>> -> ZMZN<Char> = 
        fun xzha7n cszqa7p ->            
            (
                let wildB1 = zlzh xzha7n 10  in
                    match wildB1 with
                    | true ->
                        ZC (lazy(Czh (chrzh (zpzh (48) (xzha7n)))), cszqa7p)
                    | false ->
                        (itoszq (quotIntzh (xzha7n) (10)) (lazy(ZC (lazy((Czh (chrzh (zpzh 48 (remIntzh xzha7n 10))))), cszqa7p))))
            )

    let zdsshows : Lazy<GHC.Unit.Z0T> -> Lazy<ZMZN<Char>> -> ZMZN<Char> = 
        fun dsdDM etas15K ->            
            (
                let wildB1 = dsdDM in
                    match wildB1.Force() with
                    | _ ->
                        (zpzp<Char> a69 etas15K)
            )

    let zdsshows2 : Lazy<GHC.Bool.Bool> -> Lazy<ZMZN<Char>> -> ZMZN<Char> = 
        fun dsdDH etas15M ->            
            (
                let wildB1 = dsdDH in
                    match wildB1.Force() with
                    | true -> (zpzp<Char> (a71) etas15M)
                    | false -> (zpzp<Char> (a70) etas15M)
            )

    let zdszddmshow : Lazy<GHC.Unit.Z0T> -> ZMZN<Char> = 
        fun xa52 ->            
            (            
                let wildB1 = xa52 in
                    match wildB1.Force() with
                    | _ ->
                        a69.Force()
            )

    let lvl20 : Lazy<ZMZN<Char>> = lazy zpzp<Char> (a72) (lazy ZMZN)

    let lvl21 : Lazy<ZMZN<Char>> = lazy zpzp<Char> (a73) (lazy ZMZN)

    let lvl22 : Lazy<ZMZN<Char>> = lazy zpzp<Char> (a74) (lazy ZMZN)

    let zdszddmshow2 : Lazy<GHC.Bool.Bool> -> ZMZN<Char> = 
        fun xa52 ->            
            (
                let wildB1 = xa52 in
                    match wildB1.Force() with
                    | true ->
                        a71.Force()
                    | false ->
                        a70.Force()  
            )           
                        
    let zddmshowsPrec<'aa4T> : Lazy<ZCTShow<'aa4T>> -> Lazy<GHC.Types.Int> -> Lazy<'aa4T> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun zddShowapr dsdBL xa4X sa4ZZ ->            
            (
                let tplX4 = zddShowapr in
                    match tplX4.Force() with
                    | ZCDShow (tpl1B2, tpl2B3, tpl3B4) ->
                        (GHC.Base.zpzp<GHC.Types.Char> (lazy tpl2B3 xa4X) sa4ZZ)
            )

    let itos : GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun nzha7g csa7i ->            
            (
                let wildB1 = GHC.Prim.zlzh (nzha7g) (0)  in
                    match wildB1 with
                    | true ->
                        let wild1X1v = nzha7g in
                            match wild1X1v with
                            | Intzh.MaxValue ->
                                GHC.Types.ZC (lvl19, lazy itoszq (214748364) (lazy itoszq (8) csa7i))
                            | _ ->
                                GHC.Types.ZC (lvl19, lazy itoszq (GHC.Prim.negateIntzh (wild1X1v)) csa7i)
                    
                    | false ->
                        itoszq nzha7g csa7i
            )
            
    let zdwshowSignedInt : GHC.Prim.Intzh -> GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun wws1nn ww1s1nr ws1nt ->            
            (
                let wildaE7 = GHC.Prim.zlzh ww1s1nr 0  in
                    match wildaE7 with
                    | true ->
                        let wild1X1B = GHC.Prim.zgzh (wws1nn) (6) in
                            match wild1X1B with
                            | true -> GHC.Types.ZC (a68, lazy itos ww1s1nr (lazy(GHC.Types.ZC (a66, ws1nt))))
                            | false -> (itos ww1s1nr ws1nt)
                    
                    | false -> itos ww1s1nr ws1nt
            )

    let showSignedInt : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun ws1nl w1s1np w2s1nt ->            
            (
                let w3X1so = ws1nl in
                    match w3X1so.Force() with
                    | GHC.Types.Izh (wws1nn)->
                        let w4X1sx = w1s1np in
                            match w4X1sx.Force() with
                            | GHC.Types.Izh (ww1s1nr) ->
                                (zdwshowSignedInt (wws1nn)(ww1s1nr) w2s1nt)
            )
                    
    

    let zdszddmshowList3 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun lsa55 sa57 ->            
            (
                let 
                    wildB1 = lsa55 
                in
                    match wildB1.Force() with
                    | GHC.Types.ZC (xa5k, xsa5m) ->
                        GHC.Types.ZC (lvl15, 
                            let 
                                wX1sx = xa5k 
                            in
                                match wX1sx.Force() with
                                | GHC.Types.Izh (wws1nr)->
                                    lazy (zdwshowSignedInt (0) (wws1nr) (
                                                                        let lvl23s1ti = lazy (GHC.Types.ZC (lvl16, sa57)) in
                                                                            let rec showls1tk : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
                                                                                fun dsdBH ->
                                                                                    let wild1X1Q = dsdBH in
                                                                                        match wild1X1Q.Force() with
                                                                                        | GHC.Types.ZC (ya5y, ysa5A) ->
                                                                                            lazy (GHC.Types.ZC (a67, let w1X1xZZ = ya5y in
                                                                                                    match w1X1xZZ.Force() with
                                                                                                    | GHC.Types.Izh (ww1X1sW)->
                                                                                                        lazy zdwshowSignedInt (0) (ww1X1sW) ((showls1tk ysa5A ))))
                                                                                             
                                                                                        | GHC.Types.ZMZN -> lvl23s1ti
                                                                            in
                                                                                showls1tk xsa5m  )))
                    
                    | GHC.Types.ZMZN -> (GHC.Base.zpzp<GHC.Types.Char> lvl17 sa57)
            )
        
    let zdszddmshow3 : Lazy<GHC.Types.Int> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun xa52 ->             
            (
                let wX1sx = xa52 in
                    match wX1sx.Force() with
                    | GHC.Types.Izh (wws1nr)->
                        (zdwshowSignedInt (0) (wws1nr) (lazy GHC.Types.ZMZN))
            )

    let zdfShowInt : Lazy<ZCTShow<GHC.Types.Int>> = 
        lazy(ZCDShow ((showSignedInt), (zdszddmshow3), (zdszddmshowList3)))

    let zddmshow<'aa4T> : Lazy<ZCTShow<'aa4T>> -> Lazy<'aa4T> -> GHC.Types.ZMZN<Char> =
        fun zddShowapr xa52 ->             
            (
                let shows1s1tw = shows zddShowapr in
                    (shows1s1tw xa52 (lazy ZMZN))
            )
            
    let zddmshowList<'aa4T> : Lazy<ZCTShow<'aa4T>> -> Lazy<GHC.Types.ZMZN<'aa4T>> -> Lazy<GHC.Types.ZMZN<Char>> -> GHC.Types.ZMZN<Char> =
        fun zddShowapr lsa55 sa57 ->            
            (
                let shows1s1ty = shows zddShowapr in
                    match lsa55.Force() with
                    | GHC.Types.ZMZN -> (GHC.Base.zpzp lvl17 sa57)
                    | GHC.Types.ZC (xa5k, xsa5m) -> 
                        GHC.Types.ZC (lvl15, lazy shows1s1ty xa5k 
                            (
                                let lvl23s1tA = GHC.Types.ZC (lvl16, sa57) in
                                    let rec showl1s1tC : Lazy<GHC.Types.ZMZN<'aa4T>> -> Lazy<GHC.Types.ZMZN<Char>> = 
                                        fun dsdBH ->
                                            lazy
                                            (
                                                match dsdBH.Force() with
                                                | GHC.Types.ZMZN -> lvl23s1tA
                                                | GHC.Types.ZC (ya5y,ysa5A) -> GHC.Types.ZC (a67, lazy shows1s1ty ya5y (showl1s1tC ysa5A))
                                            )
                                    in
                                        showl1s1tC xsa5m
                             ))
            )
        

    let zdwshowLitChar : GHC.Prim.Charzh -> Lazy<GHC.Types.ZMZN<Char>> -> GHC.Types.ZMZN<Char> =
        fun wws1nzz ws1nB ->            
            (
                match (GHC.Prim.gtCharzh (wws1nzz) ('\x7f')) with
                | false ->
                    match wws1nzz with
                    | '\x5c' -> (GHC.Base.zpzp (lvl7r1DX) ws1nB)
                    | '\x7f' -> (GHC.Base.zpzp (lvl6r1DV) ws1nB)
                    | dsXE5 ->
                        match (GHC.Prim.geCharzh (wws1nzz) (' ')) with
                        | false -> 
                            match dsXE5 with
                            | '\x07' -> (GHC.Base.zpzp (lvl14r1Eb) ws1nB)
                            | '\x08' -> (GHC.Base.zpzp (lvl13r1E9) ws1nB)
                            | '\x09' -> (GHC.Base.zpzp (lvl12r1E7) ws1nB)
                            | '\x0a' -> (GHC.Base.zpzp (lvl11r1E5) ws1nB)
                            | '\x0b' -> (GHC.Base.zpzp (lvl10r1E3) ws1nB)
                            | '\x0c' -> (GHC.Base.zpzp (lvl9r1E1) ws1nB)
                            | '\x0d' -> (GHC.Base.zpzp (lvl8r1DZZ) ws1nB)
                            | '\x0e' -> (GHC.Base.zpzp (a75r1DB) (
                                                                    match ws1nB.Force() with
                                                                    | GHC.Types.ZMZN -> lazy GHC.Types.ZMZN
                                                                    | GHC.Types.ZC (ca6Y, ds2dBr) -> 
                                                                        match ca6Y.Force() with
                                                                        | Czh c1a15b -> 
                                                                            match c1a15b with
                                                                            | 'H' -> lazy GHC.Base.zpzp (lvl18) ws1nB
                                                                            | _ -> ws1nB
                                                                        ))
                            | ds1XEe ->  (GHC.Base.zpzp (lazy(GHC.Types.ZC (lvl5r1DT, lazy (
                                                                                        let n0aI7 = (GHC.Prim.ordzh (wws1nzz)) in
                                                                                            match (GHC.Prim.zlzh (n0aI7) (0)) with
                                                                                            | false -> GHC.List.sub (asciiTab) n0aI7
                                                                                            | true -> GHC.List.lvl5.Force())))) ws1nB)
                                                                            
                        | true -> GHC.Types.ZC (lazy (GHC.Types.Czh (dsXE5)), ws1nB)
                
                | true -> GHC.Types.ZC (lvl5r1DT, 
                                                  (lazy zdwshowSignedInt (0) ((GHC.Prim.ordzh (wws1nzz)))
                                                        (lazy(
                                                            match ws1nB.Force() with
                                                            | ZMZN -> ZMZN
                                                            | ZC (ca6Y, dsdBr) -> 
                                                                match ca6Y.Force() with
                                                                | Czh c1a15n ->
                                                                    match (GHC.Prim.geCharzh (c1a15n) ('0')) with
                                                                    | false -> ws1nB.Force()
                                                                    | true -> 
                                                                        match (GHC.Prim.leCharzh (c1a15n) ('9')) with
                                                                        | false -> ws1nB.Force()
                                                                        | true -> (GHC.Base.zpzp (lvl18) ws1nB)
                                                        ))))
            )

    let showsPrec2<'aaeT> : Lazy<ZCTShow<'aaeT>> -> Lazy<GHC.Types.Int> -> Lazy<GHC.Types.ZMZN<'aaeT>> -> Lazy<GHC.Types.ZMZN<Char>> -> GHC.Types.ZMZN<Char> =
        fun zddShowaAP etasFc ->
            match zddShowaAP.Force() with
            | ZCDShow (tpl1B2, tpl2B3, tpl3B4) -> 
                tpl3B4

    let rec showl : Lazy<GHC.Types.ZMZN<Char>> -> Lazy<GHC.Types.ZMZN<Char>> -> GHC.Types.ZMZN<Char> =
        fun dsdDu saeA ->            
            (
                match dsdDu.Force() with
                | ZMZN -> ZC (a78, saeA)
                | ZC (ds1dDv, xsaeD) -> 
                    match ds1dDv.Force() with
                    | Czh ds2dDw ->
                        match ds2dDw with
                        | '\x22' -> (GHC.Base.zpzp (lvl4r1DR) ((lazy showl xsaeD saeA)))
                        | ds3XGd -> (zdwshowLitChar (ds2dDw) ((lazy showl xsaeD saeA)))
            )
                     
    let zdwshowsPrec : GHC.Prim.Charzh -> Lazy<GHC.Types.ZMZN<Char>> -> GHC.Types.ZMZN<Char> =
        fun wws1nJ ws1nL ->            
            (
                match wws1nJ with            
                | '\x27' -> (GHC.Base.zpzp (a77) ws1nL)
                | dsXFY -> GHC.Types.ZC (a76, (lazy zdwshowLitChar wws1nJ (lazy(ZC (a76, ws1nL)))))
            )
                                      
    let showList1 : Lazy<GHC.Types.ZMZN<Char>> -> Lazy<GHC.Types.ZMZN<Char>> -> GHC.Types.ZMZN<Char> =
        fun csaev xaEw ->             
            (
                GHC.Types.ZC (a78, lazy (showl csaev xaEw))
            )
            
    let showsPrec5 : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Char> -> Lazy<GHC.Types.ZMZN<Char>> -> GHC.Types.ZMZN<Char> =
        fun ws1nG w1s1nH w2s1nL ->            
            (
                match w1s1nH.Force() with
                | GHC.Types.Czh wws1nJ -> (zdwshowsPrec (wws1nJ) w2s1nL)
            )
            
    let zdszddmshow4 : Lazy<GHC.Types.Char> -> GHC.Types.ZMZN<Char> =
        fun xa52 ->            
            (
                match xa52.Force() with
                | GHC.Types.Czh wws1nJ -> (zdwshowsPrec (wws1nJ) (lazy ZMZN))
            )
              
    let zdfShowChar : Lazy<ZCTShow<Char>> = //zdf17
        lazy(ZCDShow ((showsPrec5), (zdszddmshow4), (showList1)))

    let rec zdfShowZMZN<'aaeT> : Lazy<ZCTShow<'aaeT>> -> ZCTShow<GHC.Types.ZMZN<'aaeT>> =
        fun zddShowaAP ->            
            (
                let a79sRd : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.ZMZN<'aaeT>> -> Lazy<GHC.Types.ZMZN<Char>> -> GHC.Types.ZMZN<Char> =                
                    showsPrec2 zddShowaAP
                in
                    let rec zddShow1sRa = lazy (ZCDShow ((a79sRd), a80sRc, a81sRb))
                        and a80sRc = (zddmshow zddShow1sRa)
                        and a81sRb = (zddmshowList zddShow1sRa)
                    in
                        zddShow1sRa.Force()
            )
            
    let showSpace : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> =
        fun xsa5W ->            
            (
                GHC.Types.ZC (lvl3, xsa5W)
            )
            
    let showParen : Lazy<GHC.Bool.Bool> -> (Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char>) -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> =
        fun ba5Q pa5S ->            
            (
                match ba5Q.Force() with
                | false -> pa5S
                | true -> 
                    fun xaEw -> 
                        (GHC.Types.ZC (a68, (lazy pa5S (lazy(GHC.Types.ZC(a66, xaEw))))))
            )
            
    let showString : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        GHC.Base.zpzp
                                             
    let showChar : Lazy<GHC.Types.Char> -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun ch str ->             
            (
                GHC.Types.ZC (ch, str)
            )
        
        
    let showListzuzu<'aa5c> : (Lazy<'aa5c> -> Lazy<ZMZN<Char>> -> ZMZN<Char>) -> Lazy<ZMZN<'aa5c>> -> Lazy<ZMZN<Char>> -> ZMZN<Char> =
        fun dsdBE ds1dBF sa5f ->            
            (
                match ds1dBF.Force() with
                | ZMZN -> GHC.Base.zpzp lvl17 sa5f
                | ZC (xa5k, xsa5m) -> 
                    ZC (lvl15, lazy dsdBE xa5k 
                                                (lazy(
                                                    let lvl23s1ts = ZC (lvl16, sa5f) in
                                                        let rec showl1s1tu (ds2dBH : Lazy<ZMZN<'aa5c>>) =
                                                            match ds2dBH.Force() with
                                                            | ZMZN -> lvl23s1ts
                                                            | ZC (ya5y, ysa5A) -> ZC (a67, lazy dsdBE ya5y (lazy(showl1s1tu ysa5A)))
                                                        in
                                                            showl1s1tu xsa5m
                                                )))
            )      