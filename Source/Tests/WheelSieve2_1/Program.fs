namespace WheelSieve2

module Main = 
    type Wheel = 
        | Wheel of (Lazy<GHC.Types.Int> * Lazy<GHC.Types.ZMZN<GHC.Types.Int>> * Lazy<GHC.Types.ZMZN<GHC.Types.Int>>)
    
    
    let private ar15l : Lazy<GHC.Types.Int> = 
        lazy
        (
            (GHC.Types.Izh (1))
        )
    
    let private lvlr15n : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
        lazy
        (
            (Control.Exception.Base.patError<GHC.Types.ZMZN<GHC.Types.Int>> ("Main.hs:(8,0)-(18,12)|function spiral"))
        )
    
    let private a1r15p : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
        lazy
        (
            (GHC.Types.ZC  ((ar15l), (lazy (GHC.Types.ZMZN ))))
        )
    
    let private a2r15r : Lazy<Wheel> = 
        lazy
        (
            (Wheel  ((ar15l), (a1r15p), (lazy (GHC.Types.ZMZN ))))
        )
    
    let rec private spiralrft<'aawm> : Lazy<GHC.Types.ZMZN<Wheel>> -> Lazy<GHC.Types.ZMZN<'aawm>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun dsdLo psafS qsafU ->
            let 
                wildB1 : Lazy<GHC.Types.ZMZN<Wheel>> = dsdLo
            in
                match wildB1.Force() with
                | GHC.Types.ZC (ds1dLp, wsafL) -> 
                    let 
                        wild1XS : Lazy<Wheel> = ds1dLp
                    in
                        match wild1XS.Force() with
                        | Wheel (safF, msafH, nsafJ) -> 
                            let 
                                qs13O : Lazy<GHC.Types.Int> = lazy ((GHC.List.head<GHC.Types.Int> (qsafU)))
                            in
                                let 
                                    sps13M : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = lazy ((spiralrft<'aawm> (wsafL) (lazy (GHC.List.tail<'aawm> (psafS))) (lazy (GHC.List.tail<GHC.Types.Int> (qsafU)))))
                                in
                                    let 
                                        zzs142 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = lazy (
                                            let 
                                                wX12M : Lazy<GHC.Types.Int> = safF
                                            in
                                                match wX12M.Force() with
                                                | GHC.Types.Izh (wws120) -> 
                                                    let rec 
                                                        zdwturns13Q : GHC.Prim.Intzh -> GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ww1s11P ww2s11T w1s11V ->
                                                            let 
                                                                xaQm : System.Int32 = (GHC.Prim.zpzh (ww1s11P) (ww2s11T))
                                                            in
                                                                let 
                                                                    wild2X1a : System.Int32 = (GHC.Prim.zpzh (ww1s11P) (ww2s11T))
                                                                in
                                                                    match wild2X1a with
                                                                    | 2-> 
                                                                        (GHC.Types.ZC  ((lazy (GHC.Types.Izh (xaQm))), (w1s11V)))
                                                                    |_ -> 
                                                                        let 
                                                                            wild11aQ8 : Lazy<GHC.Types.Int> = qs13O
                                                                        in
                                                                            match wild11aQ8.Force() with
                                                                            | GHC.Types.Izh (yaQa) -> 
                                                                                let 
                                                                                    wild3X19 : System.Boolean = (GHC.Prim.zlzh (xaQm) (yaQa))
                                                                                in
                                                                                    match wild3X19 with
                                                                                    | true -> 
                                                                                        (GHC.Types.ZC  ((lazy (GHC.Types.Izh (xaQm))), (w1s11V)))
                                                                                    | false -> 
                                                                                        (GHC.List.dropWhile<GHC.Types.Int> (fun ds2dLr ->
                                                                                            let 
                                                                                                wild4XRo : Lazy<GHC.Types.Int> = ds2dLr
                                                                                            in
                                                                                                match wild4XRo.Force() with
                                                                                                | GHC.Types.Izh (x1XRt) -> 
                                                                                                    (GHC.Prim.zlzh (x1XRt) (xaQm))
                                                                                        ) (sps13M))
                                                                            
                                                                    
                                                        
                                                    in
                                                        let rec 
                                                            zdwrolls13S : GHC.Prim.Intzh -> GHC.Types.ZMZN<GHC.Types.Int> = fun ww1X12Q ->
                                                                let 
                                                                    zz1s13Y : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = lazy (
                                                                        let 
                                                                            zz2s13U : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = lazy ((zdwrolls13S ((GHC.Prim.zpzh (ww1X12Q) (wws120)))))
                                                                        in
                                                                            let rec 
                                                                                gos13W : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds2aN5 ->
                                                                                    let 
                                                                                        wild2aN6 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ds2aN5
                                                                                    in
                                                                                        match wild2aN6.Force() with
                                                                                        | GHC.Types.ZC (yaNa, ysaNb) -> 
                                                                                            let 
                                                                                                w1X12I : Lazy<GHC.Types.Int> = yaNa
                                                                                            in
                                                                                                match w1X12I.Force() with
                                                                                                | GHC.Types.Izh (ww2s11T) -> 
                                                                                                    (zdwturns13Q (ww1X12Q) (ww2s11T) (lazy (gos13W (ysaNb))))
                                                                                        
                                                                                        | GHC.Types.ZMZN -> 
                                                                                            (zz2s13U).Force()
                                                                                
                                                                            in
                                                                                (gos13W (nsafJ)))
                                                                in
                                                                    let rec 
                                                                        gos140 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds2aN5 ->
                                                                            let 
                                                                                wild2aN6 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ds2aN5
                                                                            in
                                                                                match wild2aN6.Force() with
                                                                                | GHC.Types.ZC (yaNa, ysaNb) -> 
                                                                                    let 
                                                                                        w1X12I : Lazy<GHC.Types.Int> = yaNa
                                                                                    in
                                                                                        match w1X12I.Force() with
                                                                                        | GHC.Types.Izh (ww2s11T) -> 
                                                                                            (zdwturns13Q (ww1X12Q) (ww2s11T) (lazy (gos140 (ysaNb))))
                                                                                
                                                                                | GHC.Types.ZMZN -> 
                                                                                    (zz1s13Y).Force()
                                                                        
                                                                    in
                                                                        (gos140 (msafH))
                                                        in
                                                            (zdwrolls13S (wws120))
                                        )
                                    in
                                        let rec 
                                            gos144 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds2aN5 ->
                                                let 
                                                    wild2aN6 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ds2aN5
                                                in
                                                    match wild2aN6.Force() with
                                                    | GHC.Types.ZC (yaNa, ysaNb) -> 
                                                        let 
                                                            wild3aQ4 : Lazy<GHC.Types.Int> = yaNa
                                                        in
                                                            match wild3aQ4.Force() with
                                                            | GHC.Types.Izh (xaQ6) -> 
                                                                let 
                                                                    wild11aQ8 : Lazy<GHC.Types.Int> = qs13O
                                                                in
                                                                    match wild11aQ8.Force() with
                                                                    | GHC.Types.Izh (y1aQa) -> 
                                                                        let 
                                                                            wild4X1a : System.Boolean = (GHC.Prim.zlzh (xaQ6) (y1aQa))
                                                                        in
                                                                            match wild4X1a with
                                                                            | true -> 
                                                                                (GHC.Types.ZC  ((wild3aQ4), (lazy (gos144 (ysaNb)))))
                                                                            | false -> 
                                                                                (sps13M).Force()
                                                                    
                                                            
                                                    
                                                    | GHC.Types.ZMZN -> 
                                                        (zzs142).Force()
                                            
                                        in
                                            (gos144 (nsafJ))
                
                | GHC.Types.ZMZN -> 
                    (lvlr15n).Force()
    
    
    let rec private gor15t : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun dsaN5 ->
            let 
                wildaN6 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = dsaN5
            in
                match wildaN6.Force() with
                | GHC.Types.ZC (yaNa, ysaNb) -> 
                    (GHC.Types.ZC  ((lazy (GHC.Base.timesInt (yaNa) (yaNa))), (lazy (gor15t (ysaNb)))))
                | GHC.Types.ZMZN -> 
                    (GHC.Types.ZMZN )
    
    
    let private lvl1r15v : Lazy<GHC.Types.Int> = 
        lazy
        (
            (GHC.Types.Izh (-2147483648))
        )
    
    let private lvl2r15x : Lazy<Wheel> -> Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> Wheel = 
        fun dsdKE pagw qagy ->
            let 
                wildB1 : Lazy<Wheel> = dsdKE
            in
                match wildB1.Force() with
                | Wheel (sagq, msags, nsagu) -> 
                    let rec 
                        zdwturn0s147 : GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun wws127 ws129 ->
                            let 
                                w1aQT : Lazy<GHC.Types.Int> = pagw
                            in
                                match w1aQT.Force() with
                                | GHC.Types.Izh (ww1aQV) -> 
                                    let 
                                        wild1aRq : GHC.Prim.Intzh = ww1aQV
                                    in
                                        match wild1aRq with
                                        | 0-> 
                                            GHC.Err.divZZeroError<GHC.Types.ZMZN<GHC.Types.Int>>.Force()
                                        |_ -> 
                                            let 
                                                wild2aRv : GHC.Prim.Intzh = wws127
                                            in
                                                match wild2aRv with
                                                | -2147483648-> 
                                                    let 
                                                        wild3aRx : GHC.Prim.Intzh = wild1aRq
                                                    in
                                                        match wild3aRx with
                                                        | -1-> 
                                                            GHC.Err.overflowError<GHC.Types.ZMZN<GHC.Types.Int>>.Force()
                                                        |_ -> 
                                                            let 
                                                                wild21aRy : System.Int32 = (GHC.Base.modIntzh (-2147483648) (wild3aRx))
                                                            in
                                                                match wild21aRy with
                                                                |_ -> 
                                                                    let 
                                                                        wild211XZZ : System.Boolean = (GHC.Prim.zgzh (wild21aRy) (0))
                                                                    in
                                                                        match wild211XZZ with
                                                                        | true -> 
                                                                            (GHC.Types.ZC  ((lvl1r15v), (ws129)))
                                                                        | false -> 
                                                                            (ws129).Force()
                                                                
                                                        
                                                
                                                |_ -> 
                                                    let 
                                                        wild21aRw : System.Int32 = (GHC.Base.modIntzh (wild2aRv) (wild1aRq))
                                                    in
                                                        match wild21aRw with
                                                        |_ -> 
                                                            let 
                                                                wild211XZZ : System.Boolean = (GHC.Prim.zgzh (wild21aRw) (0))
                                                            in
                                                                match wild211XZZ with
                                                                | true -> 
                                                                    (GHC.Types.ZC  ((lazy (GHC.Types.Izh (wild2aRv))), (ws129)))
                                                                | false -> 
                                                                    (ws129).Force()
                                                        
                                                
                                        
                                
                        
                    in
                        let 
                            ds1s14q : Lazy<GHC.Tuple.Z2T<GHC.Types.ZMZN<GHC.Types.Int>, GHC.Types.ZMZN<GHC.Types.Int>>> = lazy (
                                let 
                                    zzs14m : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = lazy (
                                        let 
                                            wild1aSzz : Lazy<GHC.Types.Int> = pagw
                                        in
                                            match wild1aSzz.Force() with
                                            | GHC.Types.Izh (xaSB) -> 
                                                let rec 
                                                    zdwturns14a : GHC.Prim.Intzh -> GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun wws12g ww1s12k ws12m ->
                                                        let 
                                                            wild2aRq : GHC.Prim.Intzh = xaSB
                                                        in
                                                            match wild2aRq with
                                                            | 0-> 
                                                                GHC.Err.divZZeroError<GHC.Types.ZMZN<GHC.Types.Int>>.Force()
                                                            |_ -> 
                                                                let 
                                                                    wild21aRv : System.Int32 = (GHC.Prim.zpzh (wws12g) (ww1s12k))
                                                                in
                                                                    match wild21aRv with
                                                                    | -2147483648-> 
                                                                        let 
                                                                            wild3aRx : GHC.Prim.Intzh = wild2aRq
                                                                        in
                                                                            match wild3aRx with
                                                                            | -1-> 
                                                                                GHC.Err.overflowError<GHC.Types.ZMZN<GHC.Types.Int>>.Force()
                                                                            |_ -> 
                                                                                let 
                                                                                    wild211aRy : System.Int32 = (GHC.Base.modIntzh (-2147483648) (wild3aRx))
                                                                                in
                                                                                    match wild211aRy with
                                                                                    |_ -> 
                                                                                        let 
                                                                                            wild31X10 : System.Boolean = (GHC.Prim.zgzh (wild211aRy) (0))
                                                                                        in
                                                                                            match wild31X10 with
                                                                                            | true -> 
                                                                                                (GHC.Types.ZC  ((lvl1r15v), (ws12m)))
                                                                                            | false -> 
                                                                                                (ws12m).Force()
                                                                                    
                                                                            
                                                                    
                                                                    |_ -> 
                                                                        let 
                                                                            wild211aRw : System.Int32 = (GHC.Base.modIntzh (wild21aRv) (wild2aRq))
                                                                        in
                                                                            match wild211aRw with
                                                                            |_ -> 
                                                                                let 
                                                                                    wild3X10 : System.Boolean = (GHC.Prim.zgzh (wild211aRw) (0))
                                                                                in
                                                                                    match wild3X10 with
                                                                                    | true -> 
                                                                                        (GHC.Types.ZC  ((lazy (GHC.Types.Izh (wild21aRv))), (ws12m)))
                                                                                    | false -> 
                                                                                        (ws12m).Force()
                                                                            
                                                                    
                                                            
                                                    
                                                in
                                                    let rec 
                                                        zdwrolls14c : GHC.Prim.Intzh -> Lazy<GHC.Types.Int> -> GHC.Types.ZMZN<GHC.Types.Int> = fun wws12s ws12u ->
                                                            let 
                                                                wild2X1b : GHC.Prim.Intzh = wws12s
                                                            in
                                                                match wild2X1b with
                                                                | 0-> 
                                                                    (GHC.Types.ZMZN )
                                                                |_ -> 
                                                                    let 
                                                                        zz1s14i : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = lazy (
                                                                            let 
                                                                                zz2s14e : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = lazy ((zdwrolls14c ((GHC.Prim.zmzh (wild2X1b) (1))) (lazy (GHC.Base.plusInt (ws12u) (sagq)))))
                                                                            in
                                                                                let rec 
                                                                                    go1s14g : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds2aN5 ->
                                                                                        let 
                                                                                            wild3aN6 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ds2aN5
                                                                                        in
                                                                                            match wild3aN6.Force() with
                                                                                            | GHC.Types.ZC (yaNa, ysaNb) -> 
                                                                                                let 
                                                                                                    w1X12ZZ : Lazy<GHC.Types.Int> = ws12u
                                                                                                in
                                                                                                    match w1X12ZZ.Force() with
                                                                                                    | GHC.Types.Izh (ww1s12g) -> 
                                                                                                        let 
                                                                                                            w2X138 : Lazy<GHC.Types.Int> = yaNa
                                                                                                        in
                                                                                                            match w2X138.Force() with
                                                                                                            | GHC.Types.Izh (ww2s12k) -> 
                                                                                                                (zdwturns14a (ww1s12g) (ww2s12k) (lazy (go1s14g (ysaNb))))
                                                                                                    
                                                                                            
                                                                                            | GHC.Types.ZMZN -> 
                                                                                                (zz2s14e).Force()
                                                                                    
                                                                                in
                                                                                    (go1s14g (nsagu)))
                                                                    in
                                                                        let rec 
                                                                            go1s14k : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds2aN5 ->
                                                                                let 
                                                                                    wild3aN6 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ds2aN5
                                                                                in
                                                                                    match wild3aN6.Force() with
                                                                                    | GHC.Types.ZC (yaNa, ysaNb) -> 
                                                                                        let 
                                                                                            w1X12ZZ : Lazy<GHC.Types.Int> = ws12u
                                                                                        in
                                                                                            match w1X12ZZ.Force() with
                                                                                            | GHC.Types.Izh (ww1s12g) -> 
                                                                                                let 
                                                                                                    w2X138 : Lazy<GHC.Types.Int> = yaNa
                                                                                                in
                                                                                                    match w2X138.Force() with
                                                                                                    | GHC.Types.Izh (ww2s12k) -> 
                                                                                                        (zdwturns14a (ww1s12g) (ww2s12k) (lazy (go1s14k (ysaNb))))
                                                                                            
                                                                                    
                                                                                    | GHC.Types.ZMZN -> 
                                                                                        (zz1s14i).Force()
                                                                            
                                                                        in
                                                                            (go1s14k (msags))
                                                        
                                                    in
                                                        (zdwrolls14c ((GHC.Prim.zmzh (xaSB) (1))) (sagq))
                                    )
                                in
                                    let rec 
                                        go1s14o : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds2aN5 ->
                                            let 
                                                wild1aN6 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ds2aN5
                                            in
                                                match wild1aN6.Force() with
                                                | GHC.Types.ZC (yaNa, ysaNb) -> 
                                                    let 
                                                        wX12J : Lazy<GHC.Types.Int> = yaNa
                                                    in
                                                        match wX12J.Force() with
                                                        | GHC.Types.Izh (wws127) -> 
                                                            (zdwturn0s147 (wws127) (lazy (go1s14o (ysaNb))))
                                                
                                                | GHC.Types.ZMZN -> 
                                                    (zzs14m).Force()
                                        
                                    in
                                        let 
                                            wwaNp : GHC.Prim.Z2H<GHC.Types.ZMZN<GHC.Types.Int>, GHC.Types.ZMZN<GHC.Types.Int>> = (GHC.List.zdwspan<GHC.Types.Int> (fun ds2dKF ->
                                                (GHC.Base.leInt (ds2dKF) (qagy))) (lazy (go1s14o (nsagu))))
                                        in
                                            match wwaNp with
                                            | GHC.Prim.Z2H (ww1aNr, ww2aNs) -> 
                                                (GHC.Tuple.Z2T  ((lazy ww1aNr), (lazy ww2aNs)))
                            )
                        in
                            (Wheel  ((lazy (GHC.Base.timesInt (sagq) (pagw))), (lazy 
                                let 
                                    zzs14s : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = lazy (
                                        let 
                                            wild1X10 : Lazy<GHC.Tuple.Z2T<GHC.Types.ZMZN<GHC.Types.Int>, GHC.Types.ZMZN<GHC.Types.Int>>> = ds1s14q
                                        in
                                            match wild1X10.Force() with
                                            | GHC.Tuple.Z2T (xsavF, nszqavH) -> 
                                                (xsavF).Force()
                                    )
                                in
                                    let rec 
                                        go1s14u : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds2aN5 ->
                                            let 
                                                wild1aN6 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ds2aN5
                                            in
                                                match wild1aN6.Force() with
                                                | GHC.Types.ZC (yaNa, ysaNb) -> 
                                                    let 
                                                        wX12J : Lazy<GHC.Types.Int> = yaNa
                                                    in
                                                        match wX12J.Force() with
                                                        | GHC.Types.Izh (wws127) -> 
                                                            (zdwturn0s147 (wws127) (lazy (go1s14u (ysaNb))))
                                                
                                                | GHC.Types.ZMZN -> 
                                                    (zzs14s).Force()
                                        
                                    in
                                        (go1s14u (msags))), (lazy 
                                let 
                                    wild1X10 : Lazy<GHC.Tuple.Z2T<GHC.Types.ZMZN<GHC.Types.Int>, GHC.Types.ZMZN<GHC.Types.Int>>> = ds1s14q
                                in
                                    match wild1X10.Force() with
                                    | GHC.Tuple.Z2T (xsavF, nszqavH) -> 
                                        (nszqavH).Force()
                            )))
    
    
    let rec private squaresrfv : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
        lazy
        (
            (gor15t (primes))
        )
    
    and private wheelsrfx : Lazy<GHC.Types.ZMZN<Wheel>> = 
        lazy
        (
            (GHC.Types.ZC  ((a2r15r), (a3r15zz)))
        )
    
    and private a3r15zz : Lazy<GHC.Types.ZMZN<Wheel>> = 
        lazy
        (
            (GHC.List.zzipWith3<Wheel, GHC.Types.Int, GHC.Types.Int, Wheel> (lvl2r15x) (wheelsrfx) (primes) (squaresrfv))
        )
    
    and primes : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
        lazy
        (
            (spiralrft<GHC.Types.Int> (wheelsrfx) (primes) (squaresrfv))
        )
    
    let lvl3 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
            let 
                waZZ4 : GHC.Types.Int = (GHC.List.sub<GHC.Types.Int> (primes) (80000))
            in
                match waZZ4 with
                | GHC.Types.Izh (wwaZZ6) -> 
                    (GHC.Show.zdwshowSignedInt (0) (wwaZZ6) (lazy (GHC.Types.ZMZN )))
        )
    
    let a4 : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        fun etaaST ->
            let 
                wildaYT : GHC.Prim.Z2H<GHC.Prim.Statezh<Microsoft.FSharp.Core.Unit>, GHC.Unit.Z0T> = (GHC.IO.a29 (GHC.Handle.stdout) (lvl3) (etaaST))
            in
                match wildaYT with
                | GHC.Prim.Z2H (newzusaYV, a89aYW) -> 
                    (GHC.IO.zdwa10 (GHC.Handle.stdout) ('\x0a') (newzusaYV))
    
    
    let main : Lazy<GHC.IOBase.IO<GHC.Unit.Z0T>> = 
        lazy
        (
            a4
        )
    
    let a5 : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        (GHC.TopHandler.a4<GHC.Unit.Z0T> (a4))
    
    let zcmain : GHC.IOBase.IO<GHC.Unit.Z0T> = 
        a5
        
    System.Console.WriteLine("Press ENTER to continue...")  
    System.Console.ReadLine() |> ignore        
    System.Console.WriteLine("Wheel Sieve 2")
    
    zcmain (GHC.Prim.State (())) |> ignore            