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
    
    let private a2r15r : Lazy<Wheel> = 
        lazy
        (
            (Wheel  ((ar15l), (lazy (GHC.Types.ZC  ((ar15l), (lazy (GHC.Types.ZMZN ))))), (lazy (GHC.Types.ZMZN ))))
        )
    
    let rec private spiralrft<'aawm> : Lazy<GHC.Types.ZMZN<Wheel>> -> Lazy<GHC.Types.ZMZN<'aawm>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun dsdLo psafS qsafU ->
            match dsdLo.Force() with
            | GHC.Types.ZC (ds1dLp, wsafL) -> 
                match ds1dLp.Force() with
                | Wheel (safF, msafH, nsafJ) ->                                
                    let rec 
                        gos144 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
                            fun ds2aN5 ->
                                match ds2aN5.Force() with
                                | GHC.Types.ZC (yaNa, ysaNb) ->      
                                    match yaNa.Force() with
                                    | GHC.Types.Izh (xaQ6) -> 
                                        match (GHC.List.head<GHC.Types.Int> (qsafU)) with
                                        | GHC.Types.Izh (y1aQa) ->                                                             
                                            match (GHC.Prim.zlzh (xaQ6) (y1aQa)) with
                                            | true -> (GHC.Types.ZC ((yaNa), (lazy (gos144 (ysaNb)))))
                                            | false -> ((spiralrft<'aawm> (wsafL) (lazy (GHC.List.tail<'aawm> (psafS))) (lazy (GHC.List.tail<GHC.Types.Int> (qsafU)))))
                                
                                | GHC.Types.ZMZN -> 
                                    match safF.Force() with
                                    | GHC.Types.Izh (wws120) -> 
                                        let rec 
                                            zdwturns13Q : GHC.Prim.Intzh -> GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ww1s11P ww2s11T w1s11V ->
                                                let 
                                                    xaQm : System.Int32 = (GHC.Prim.zpzh (ww1s11P) (ww2s11T))
                                                in
                                                    match (GHC.Prim.zpzh (ww1s11P) (ww2s11T)) with
                                                    | 2-> 
                                                        (GHC.Types.ZC  ((lazy (GHC.Types.Izh (xaQm))), (w1s11V)))
                                                    |_ -> 
                                                        match (GHC.List.head<GHC.Types.Int> (qsafU)) with
                                                        | GHC.Types.Izh (yaQa) -> 
                                                            match (GHC.Prim.zlzh (xaQm) (yaQa)) with
                                                            | true -> 
                                                                (GHC.Types.ZC  ((lazy (GHC.Types.Izh (xaQm))), (w1s11V)))
                                                            | false -> 
                                                                (GHC.List.dropWhile<GHC.Types.Int> (fun ds2dLr ->
                                                                    match ds2dLr.Force() with
                                                                    | GHC.Types.Izh (x1XRt) -> 
                                                                        (GHC.Prim.zlzh (x1XRt) (xaQm))
                                                                ) (lazy ((spiralrft<'aawm> (wsafL) (lazy (GHC.List.tail<'aawm> (psafS))) (lazy (GHC.List.tail<GHC.Types.Int> (qsafU)))))))                                                                        
                                        in
                                            let rec 
                                                zdwrolls13S : GHC.Prim.Intzh -> GHC.Types.ZMZN<GHC.Types.Int> = 
                                                    fun ww1X12Q ->     
                                                        let rec 
                                                            gos140 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
                                                                fun ds2aN5 ->                                                                        
                                                                    match ds2aN5.Force() with
                                                                    | GHC.Types.ZC (yaNa, ysaNb) -> 
                                                                        match yaNa.Force() with
                                                                        | GHC.Types.Izh (ww2s11T) -> 
                                                                            (zdwturns13Q (ww1X12Q) (ww2s11T) (lazy (gos140 (ysaNb))))
                                                                    
                                                                    | GHC.Types.ZMZN -> 
                                                                        let rec 
                                                                            gos13W : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds2aN5 ->
                                                                                match ds2aN5.Force() with
                                                                                | GHC.Types.ZC (yaNa, ysaNb) -> 
                                                                                    match yaNa.Force() with
                                                                                    | GHC.Types.Izh (ww2s11T) -> 
                                                                                        (zdwturns13Q (ww1X12Q) (ww2s11T) (lazy (gos13W (ysaNb))))                                                                                    
                                                                                | GHC.Types.ZMZN -> 
                                                                                    zdwrolls13S ((GHC.Prim.zpzh (ww1X12Q) (wws120)))
                                                                            
                                                                        in
                                                                            (gos13W (nsafJ))
                                                            
                                                        in
                                                            (gos140 (msafH))
                                            in
                                                (zdwrolls13S (wws120))
                                
                            in
                                (gos144 (nsafJ))
            
            | GHC.Types.ZMZN -> 
                (lvlr15n).Force()
    
    
    let rec private gor15t : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun dsaN5 ->
            match dsaN5.Force() with
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
            match dsdKE.Force() with
            | Wheel (sagq, msags, nsagu) -> 
                let rec 
                    zdwturn0s147 : GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun wws127 ws129 ->
                        match pagw.Force() with
                        | GHC.Types.Izh (ww1aQV) -> 
                            let 
                                wild1aRq : GHC.Prim.Intzh = ww1aQV
                            in
                                match ww1aQV with
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
                                let rec 
                                    go1s14o : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
                                        fun ds2aN5 ->    
                                            match ds2aN5.Force() with
                                            | GHC.Types.ZC (yaNa, ysaNb) ->     
                                                match yaNa.Force() with
                                                | GHC.Types.Izh (wws127) -> 
                                                    (zdwturn0s147 (wws127) (lazy (go1s14o (ysaNb))))
                                        
                                            | GHC.Types.ZMZN -> 
                                                (match pagw.Force() with
                                                | GHC.Types.Izh (xaSB) -> 
                                                    let rec 
                                                        zdwturns14a : GHC.Prim.Intzh -> GHC.Prim.Intzh -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
                                                            fun wws12g ww1s12k ws12m ->
                                                                match xaSB with
                                                                | 0-> 
                                                                    GHC.Err.divZZeroError<GHC.Types.ZMZN<GHC.Types.Int>>.Force()
                                                                |_ -> 
                                                                    let 
                                                                        wild21aRv : System.Int32 = (GHC.Prim.zpzh (wws12g) (ww1s12k))
                                                                    in
                                                                        match wild21aRv with
                                                                        | -2147483648-> 
                                                                            let 
                                                                                wild3aRx : GHC.Prim.Intzh = xaSB
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
                                                                                            match (GHC.Prim.zgzh (wild211aRy) (0)) with
                                                                                            | true -> 
                                                                                                (GHC.Types.ZC  ((lvl1r15v), (ws12m)))
                                                                                            | false -> 
                                                                                                (ws12m).Force()
                                                                        |_ -> 
                                                                            let 
                                                                                wild211aRw : System.Int32 = (GHC.Base.modIntzh (wild21aRv) (xaSB))
                                                                            in
                                                                                match wild211aRw with
                                                                                |_ -> 
                                                                                    match (GHC.Prim.zgzh (wild211aRw) (0)) with
                                                                                    | true -> 
                                                                                        (GHC.Types.ZC  ((lazy (GHC.Types.Izh (wild21aRv))), (ws12m)))
                                                                                    | false -> 
                                                                                        (ws12m).Force()
                                                        in
                                                            let rec 
                                                                zdwrolls14c : GHC.Prim.Intzh -> Lazy<GHC.Types.Int> -> GHC.Types.ZMZN<GHC.Types.Int> = 
                                                                    fun wws12s ws12u ->                                                                    
                                                                        match wws12s with
                                                                        | 0-> 
                                                                            (GHC.Types.ZMZN )
                                                                        |_ -> 
                                                                            let rec 
                                                                                go1s14k : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
                                                                                    fun ds2aN5 ->
                                                                                        match ds2aN5.Force() with
                                                                                        | GHC.Types.ZC (yaNa, ysaNb) -> 
                                                                                            match ws12u.Force() with
                                                                                            | GHC.Types.Izh (ww1s12g) ->                      
                                                                                                match yaNa.Force() with
                                                                                                | GHC.Types.Izh (ww2s12k) -> 
                                                                                                    (zdwturns14a (ww1s12g) (ww2s12k) (lazy (go1s14k (ysaNb))))
                                                                                                                                                                                
                                                                                        | GHC.Types.ZMZN -> 
                                                                                            let rec 
                                                                                                go1s14g : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
                                                                                                    fun ds2aN5 ->
                                                                                                        match ds2aN5.Force() with
                                                                                                        | GHC.Types.ZC (yaNa, ysaNb) -> 
                                                                                                            match ws12u.Force() with
                                                                                                            | GHC.Types.Izh (ww1s12g) -> 
                                                                                                                match yaNa.Force() with
                                                                                                                | GHC.Types.Izh (ww2s12k) -> 
                                                                                                                    (zdwturns14a (ww1s12g) (ww2s12k) (lazy (go1s14g (ysaNb))))
                                                                                                                                                                                                    
                                                                                                        | GHC.Types.ZMZN -> 
                                                                                                            zdwrolls14c ((GHC.Prim.zmzh (wws12s) (1))) (lazy (GHC.Base.plusInt (ws12u) (sagq)))                                                                            
                                                                                            in
                                                                                                (go1s14g (nsagu))
                                                                                    
                                                                                in
                                                                                    (go1s14k (msags))
                                                                
                                                            in
                                                                (zdwrolls14c ((GHC.Prim.zmzh (xaSB) (1))) (sagq)))
                                    
                                in
                                    match (GHC.List.zdwspan<GHC.Types.Int> (fun ds2dKF -> (GHC.Base.leInt (ds2dKF) (qagy))) (lazy (go1s14o (nsagu)))) with
                                    | GHC.Prim.Z2H (ww1aNr, ww2aNs) -> 
                                        (GHC.Tuple.Z2T  ((lazy ww1aNr), (lazy ww2aNs)))
                        )
                    in
                        (Wheel  ((lazy (GHC.Base.timesInt (sagq) (pagw))), (lazy 
                                    let rec 
                                        go1s14u : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
                                            fun ds2aN5 ->
                                                match ds2aN5.Force() with
                                                | GHC.Types.ZC (yaNa, ysaNb) ->      
                                                    match yaNa.Force() with
                                                    | GHC.Types.Izh (wws127) -> 
                                                        (zdwturn0s147 (wws127) (lazy (go1s14u (ysaNb))))
                                                
                                                | GHC.Types.ZMZN -> 
                                                    match ds1s14q.Force() with
                                                    | GHC.Tuple.Z2T (xsavF, nszqavH) -> 
                                                        (xsavF).Force()
                                        
                                    in
                                        (go1s14u (msags))), (lazy                        
                                            match ds1s14q.Force() with
                                            | GHC.Tuple.Z2T (xsavF, nszqavH) -> 
                                                (nszqavH).Force()
                        )))
    
    
    let lvl3 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
           let rec squaresrfv : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
                lazy
                (
                    (gor15t (primes))
                )
            
            and wheelsrfx : Lazy<GHC.Types.ZMZN<Wheel>> = 
                lazy
                (
                    (GHC.Types.ZC  ((a2r15r), (lazy (GHC.List.zzipWith3<Wheel, GHC.Types.Int, GHC.Types.Int, Wheel> (lvl2r15x) (wheelsrfx) (primes) (squaresrfv)))))
                )    
            
            and primes : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
                lazy
                (
                    (spiralrft<GHC.Types.Int> (wheelsrfx) (primes) (squaresrfv))
                )
            in
                match (GHC.List.sub<GHC.Types.Int> (primes) (80000)) with
                | GHC.Types.Izh (wwaZZ6) -> 
                    (GHC.Show.zdwshowSignedInt (0) (wwaZZ6) (lazy (GHC.Types.ZMZN )))
        )
    
    let a4 : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        fun etaaST ->
            match (GHC.IO.a29 (GHC.Handle.stdout) (lvl3) (etaaST)) with
            | GHC.Prim.Z2H (newzusaYV, a89aYW) -> 
                (GHC.IO.zdwa10 (GHC.Handle.stdout) ('\x0a') (newzusaYV))    
    
    let zcmain : GHC.IOBase.IO<GHC.Unit.Z0T> = 
        (GHC.TopHandler.a4<GHC.Unit.Z0T> (a4))     
    
    System.Console.WriteLine("Press ENTER to continue...")  
    System.Console.ReadLine() |> ignore        
    System.Console.WriteLine("Wheel Sieve 2")
    
    zcmain (GHC.Prim.State (())) |> ignore