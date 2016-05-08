namespace WheelSieve1

module Main = 
    type Wheel = 
        | Wheel of (Lazy<GHC.Types.Int> * Lazy<GHC.Types.ZMZN<GHC.Types.Int>>)
    
    
    let private ar15C : Lazy<GHC.Types.Int> = 
        lazy
        (
            (GHC.Types.Izh (1))
        )
    
    let private lvlr15E : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
        lazy
        (
            (Control.Exception.Base.patError<GHC.Types.ZMZN<GHC.Types.Int>> ("Main.hs:(10,0)-(17,55)|function sieve"))
        )
    
    let private failr15G : Lazy<GHC.Bool.Bool> = 
        lazy
        (
            (Control.Exception.Base.patError<GHC.Bool.Bool> ("Main.hs:(19,0)-(20,43)|function notDivBy"))
        )
    
    let private a1r15I : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
        lazy
        (
            (GHC.Types.ZC  ((ar15C), (lazy (GHC.Types.ZMZN ))))
        )
    
    let private a2r15K : Lazy<Wheel> = 
        lazy
        (
            (Wheel  ((ar15C), (a1r15I)))
        )
    
    let rec private zdwnotDivByr15M : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Prim.Intzh -> GHC.Bool.Bool = 
        fun ws13zz w1s13A wws13D ->
            let 
                wildB1 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ws13zz
            in
                match wildB1.Force() with
                | GHC.Types.ZC (pag8, psaga) -> 
                    let 
                        wild1X15 : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = w1s13A
                    in
                        match wild1X15.Force() with
                        | GHC.Types.ZC (qagc, qsage) -> 
                            let 
                                wild2aPC : Lazy<GHC.Types.Int> = qagc
                            in
                                match wild2aPC.Force() with
                                | GHC.Types.Izh (xaPE) -> 
                                    let 
                                        wild3aLd : System.Boolean = (GHC.Prim.zgzh (xaPE) (wws13D))
                                    in
                                        match wild3aLd with
                                        | true -> 
                                            true 
                                        | false -> 
                                            let 
                                                w2aPQ : Lazy<GHC.Types.Int> = pag8
                                            in
                                                match w2aPQ.Force() with
                                                | GHC.Types.Izh (ww1aPS) -> 
                                                    let 
                                                        wild4aPW : GHC.Prim.Intzh = ww1aPS
                                                    in
                                                        match wild4aPW with
                                                        | 0-> 
                                                            GHC.Err.divZZeroError<GHC.Bool.Bool>.Force()
                                                        |_ -> 
                                                            let 
                                                                wild21aQ1 : GHC.Prim.Intzh = wws13D
                                                            in
                                                                match wild21aQ1 with
                                                                | -2147483648-> 
                                                                    let 
                                                                        wild31aQ3 : GHC.Prim.Intzh = wild4aPW
                                                                    in
                                                                        match wild31aQ3 with
                                                                        | -1-> 
                                                                            GHC.Err.overflowError<GHC.Bool.Bool>.Force()
                                                                        |_ -> 
                                                                            let 
                                                                                wild211aQ4 : System.Int32 = (GHC.Base.modIntzh (-2147483648) (wild31aQ3))
                                                                            in
                                                                                match wild211aQ4 with
                                                                                |_ -> 
                                                                                    let 
                                                                                        wild5aLj : System.Boolean = (GHC.Prim.zgzh (wild211aQ4) (0))
                                                                                    in
                                                                                        match wild5aLj with
                                                                                        | true -> 
                                                                                            (zdwnotDivByr15M (psaga) (qsage) (-2147483648))
                                                                                        | false -> 
                                                                                            false 
                                                                                
                                                                        
                                                                
                                                                |_ -> 
                                                                    let 
                                                                        wild211aQ2 : System.Int32 = (GHC.Base.modIntzh (wild21aQ1) (wild4aPW))
                                                                    in
                                                                        match wild211aQ2 with
                                                                        |_ -> 
                                                                            let 
                                                                                wild5aLj : System.Boolean = (GHC.Prim.zgzh (wild211aQ2) (0))
                                                                            in
                                                                                match wild5aLj with
                                                                                | true -> 
                                                                                    (zdwnotDivByr15M (psaga) (qsage) (wild21aQ1))
                                                                                | false -> 
                                                                                    false 
                                                                        
                                                                
                                                        
                                                
                                        
                                
                        
                        | GHC.Types.ZMZN -> 
                            (failr15G).Force()
                
                | GHC.Types.ZMZN -> 
                    (failr15G).Force()
    
    
    let rec private sieverft : Lazy<GHC.Types.ZMZN<Wheel>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun dsdGS psafS qsafU ->
            let 
                wildB1 : Lazy<GHC.Types.ZMZN<Wheel>> = dsdGS
            in
                match wildB1.Force() with
                | GHC.Types.ZC (ds1dGT, wsafL) -> 
                    let 
                        wild1X14 : Lazy<Wheel> = ds1dGT
                    in
                        match wild1X14.Force() with
                        | Wheel (safH, nsafJ) -> 
                            let 
                                zzs14zz : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = lazy ((sieverft (wsafL) (lazy (GHC.List.tail<GHC.Types.Int> (psafS))) (lazy (GHC.List.tail<GHC.Types.Int> (qsafU)))))
                            in
                                let rec 
                                    gos14B : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds2aLF ->
                                        let 
                                            wild2aLG : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ds2aLF
                                        in
                                            match wild2aLG.Force() with
                                            | GHC.Types.ZC (yaLK, ysaLL) -> 
                                                let 
                                                    zz1s14D : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = lazy ((gos14B (ysaLL)))
                                                in
                                                    let rec 
                                                        go1s14F : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds3XMr ->
                                                            let 
                                                                wild3XMt : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ds3XMr
                                                            in
                                                                match wild3XMt.Force() with
                                                                | GHC.Types.ZC (y1XMA, ys1XMC) -> 
                                                                    let 
                                                                        wild4aRf : Lazy<GHC.Types.Int> = safH
                                                                    in
                                                                        match wild4aRf.Force() with
                                                                        | GHC.Types.Izh (xaRh) -> 
                                                                            let 
                                                                                wild5X1b : System.Boolean = (GHC.Prim.zlzezh (xaRh) (2))
                                                                            in
                                                                                match wild5X1b with
                                                                                | true -> 
                                                                                    (GHC.Types.ZC  ((lazy (GHC.Base.plusInt (y1XMA) (yaLK))), (lazy (go1s14F (ys1XMC)))))
                                                                                | false -> 
                                                                                    let 
                                                                                        wild6aOzz : Lazy<GHC.Types.Int> = y1XMA
                                                                                    in
                                                                                        match wild6aOzz.Force() with
                                                                                        | GHC.Types.Izh (x1aOB) -> 
                                                                                            let 
                                                                                                wild11aOD : Lazy<GHC.Types.Int> = yaLK
                                                                                            in
                                                                                                match wild11aOD.Force() with
                                                                                                | GHC.Types.Izh (y2aOF) -> 
                                                                                                    let 
                                                                                                        wws13D : System.Int32 = (GHC.Prim.zpzh (x1aOB) (y2aOF))
                                                                                                    in
                                                                                                        let 
                                                                                                            wild7X1n : GHC.Bool.Bool = (zdwnotDivByr15M (psafS) (qsafU) (wws13D))
                                                                                                        in
                                                                                                            match wild7X1n with
                                                                                                            | true -> 
                                                                                                                (GHC.Types.ZC  ((lazy (GHC.Types.Izh (wws13D))), (lazy (go1s14F (ys1XMC)))))
                                                                                                            | false -> 
                                                                                                                (go1s14F (ys1XMC))
                                                                                                
                                                                                        
                                                                                
                                                                        
                                                                
                                                                | GHC.Types.ZMZN -> 
                                                                    (zz1s14D).Force()
                                                        
                                                    in
                                                        (go1s14F (nsafJ))
                                            | GHC.Types.ZMZN -> 
                                                (zzs14zz).Force()
                                    
                                in
                                    (gos14B (lazy (GHC.Types.ZC  ((safH), (lazy 
                                        let 
                                            wild2aP8 : Lazy<GHC.Types.Int> = safH
                                        in
                                            match wild2aP8.Force() with
                                            | GHC.Types.Izh (xaPa) -> 
                                                let 
                                                    wild3aMu : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = psafS
                                                in
                                                    match wild3aMu.Force() with
                                                    | GHC.Types.ZC (x1aMx, ds11aMy) -> 
                                                        let 
                                                            wild4aOY : Lazy<GHC.Types.Int> = x1aMx
                                                        in
                                                            match wild4aOY.Force() with
                                                            | GHC.Types.Izh (x2aP0) -> 
                                                                let 
                                                                    x21a115 : System.Int32 = (GHC.Prim.ztzh (xaPa) (3))
                                                                in
                                                                    let 
                                                                        x11a114 : System.Int32 = (GHC.Prim.ztzh (xaPa) (2))
                                                                    in
                                                                        let 
                                                                            wild5a117 : System.Boolean = (GHC.Prim.zgzezh (x21a115) (x11a114))
                                                                        in
                                                                            match wild5a117 with
                                                                            | true -> 
                                                                                (GHC.Enum.efdtIntUp (x11a114) (x21a115) ((GHC.Prim.ztzh ((GHC.Prim.zmzh (x2aP0) (1))) (xaPa))))
                                                                            | false -> 
                                                                                (GHC.Enum.efdtIntDn (x11a114) (x21a115) ((GHC.Prim.ztzh ((GHC.Prim.zmzh (x2aP0) (1))) (xaPa))))
                                                            
                                                    
                                                    | GHC.Types.ZMZN -> 
                                                        GHC.List.badHead<GHC.Types.ZMZN<GHC.Types.Int>>.Force()
                                            
                                    )))))
                
                | GHC.Types.ZMZN -> 
                    (lvlr15E).Force()
    
    
    let private lvl1r15O : Lazy<GHC.Types.Int> = 
        lazy
        (
            (GHC.Types.Izh (0))
        )
    
    let private lvl2r15Q : Lazy<GHC.Types.Int> = 
        lazy
        (
            (GHC.Types.Izh (-2147483648))
        )
    
    let private lvl3r15S : Lazy<Wheel> -> Lazy<GHC.Types.Int> -> Wheel = 
        fun dsdFM pajR ->
            let 
                wildB1 : Lazy<Wheel> = dsdFM
            in
                match wildB1.Force() with
                | Wheel (sajN, nsajP) -> 
                    (Wheel  ((lazy (GHC.Base.timesInt (sajN) (pajR))), (lazy 
                        let 
                            wild1aOO : Lazy<GHC.Types.Int> = sajN
                        in
                            match wild1aOO.Force() with
                            | GHC.Types.Izh (x2aOQ) -> 
                                let 
                                    wild11aOY : Lazy<GHC.Types.Int> = pajR
                                in
                                    match wild11aOY.Force() with
                                    | GHC.Types.Izh (xaP0) -> 
                                        let rec 
                                            cs14K : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds1dFS ds2dFR ->
                                                let rec 
                                                    gos14H : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = fun ds3aLF ->
                                                        let 
                                                            wild2aLG : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = ds3aLF
                                                        in
                                                            match wild2aLG.Force() with
                                                            | GHC.Types.ZC (yaLK, ysaLL) -> 
                                                                let 
                                                                    wild3aPW : GHC.Prim.Intzh = xaP0
                                                                in
                                                                    match wild3aPW with
                                                                    | 0-> 
                                                                        GHC.Err.divZZeroError<GHC.Types.ZMZN<GHC.Types.Int>>.Force()
                                                                    |_ -> 
                                                                        let 
                                                                            wild4aOzz : Lazy<GHC.Types.Int> = yaLK
                                                                        in
                                                                            match wild4aOzz.Force() with
                                                                            | GHC.Types.Izh (x1aOB) -> 
                                                                                let 
                                                                                    wild12aOD : Lazy<GHC.Types.Int> = ds1dFS
                                                                                in
                                                                                    match wild12aOD.Force() with
                                                                                    | GHC.Types.Izh (y1aOF) -> 
                                                                                        let 
                                                                                            wild21aQ1 : System.Int32 = (GHC.Prim.zpzh (x1aOB) (y1aOF))
                                                                                        in
                                                                                            match wild21aQ1 with
                                                                                            | -2147483648-> 
                                                                                                let 
                                                                                                    wild31aQ3 : GHC.Prim.Intzh = wild3aPW
                                                                                                in
                                                                                                    match wild31aQ3 with
                                                                                                    | -1-> 
                                                                                                        GHC.Err.overflowError<GHC.Types.ZMZN<GHC.Types.Int>>.Force()
                                                                                                    |_ -> 
                                                                                                        let 
                                                                                                            wild211aQ4 : System.Int32 = (GHC.Base.modIntzh (-2147483648) (wild31aQ3))
                                                                                                        in
                                                                                                            match wild211aQ4 with
                                                                                                            |_ -> 
                                                                                                                let 
                                                                                                                    wild5X1f : System.Boolean = (GHC.Prim.zgzh (wild211aQ4) (0))
                                                                                                                in
                                                                                                                    match wild5X1f with
                                                                                                                    | true -> 
                                                                                                                        (GHC.Types.ZC  ((lvl2r15Q), (lazy (gos14H (ysaLL)))))
                                                                                                                    | false -> 
                                                                                                                        (gos14H (ysaLL))
                                                                                                            
                                                                                                    
                                                                                            
                                                                                            |_ -> 
                                                                                                let 
                                                                                                    wild211aQ2 : System.Int32 = (GHC.Base.modIntzh (wild21aQ1) (wild3aPW))
                                                                                                in
                                                                                                    match wild211aQ2 with
                                                                                                    |_ -> 
                                                                                                        let 
                                                                                                            wild5X1f : System.Boolean = (GHC.Prim.zgzh (wild211aQ2) (0))
                                                                                                        in
                                                                                                            match wild5X1f with
                                                                                                            | true -> 
                                                                                                                (GHC.Types.ZC  ((lazy (GHC.Types.Izh (wild21aQ1))), (lazy (gos14H (ysaLL)))))
                                                                                                            | false -> 
                                                                                                                (gos14H (ysaLL))
                                                                                                    
                                                                                            
                                                                                    
                                                                            
                                                                    
                                                            
                                                            | GHC.Types.ZMZN -> 
                                                                (ds2dFR).Force()
                                                    
                                                in
                                                    (gos14H (nsajP))
                                        in
                                            let 
                                                wild2aRM : System.Boolean = (GHC.Prim.zgzezh (x2aOQ) (0))
                                            in
                                                match wild2aRM with
                                                | true -> 
                                                    let 
                                                        ya12T : System.Int32 = (GHC.Prim.ztzh ((GHC.Prim.zmzh (xaP0) (1))) (x2aOQ))
                                                    in
                                                        let 
                                                            wild3a12U : System.Boolean = (GHC.Prim.zlzh (ya12T) (x2aOQ))
                                                        in
                                                            match wild3a12U with
                                                            | true -> 
                                                                let 
                                                                    wild12a138 : System.Boolean = (GHC.Prim.zlzh (ya12T) (0))
                                                                in
                                                                    match wild12a138 with
                                                                    | true -> 
                                                                        (GHC.Types.ZMZN )
                                                                    | false -> 
                                                                        (cs14K (lvl1r15O) (lazy (GHC.Types.ZMZN )))
                                                            
                                                            | false -> 
                                                                (cs14K (lvl1r15O) (lazy 
                                                                    let 
                                                                        yzqa12Y : System.Int32 = (GHC.Prim.zmzh (ya12T) (x2aOQ))
                                                                    in
                                                                        let rec 
                                                                            gozuups14R : GHC.Prim.Intzh -> GHC.Types.ZMZN<GHC.Types.Int> = fun x1a130 ->
                                                                                let 
                                                                                    wild12a131 : System.Boolean = (GHC.Prim.zgzh (x1a130) (yzqa12Y))
                                                                                in
                                                                                    match wild12a131 with
                                                                                    | true -> 
                                                                                        (cs14K (lazy (GHC.Types.Izh (x1a130))) (lazy (GHC.Types.ZMZN )))
                                                                                    | false -> 
                                                                                        (cs14K (lazy (GHC.Types.Izh (x1a130))) (lazy (gozuups14R ((GHC.Prim.zpzh (x1a130) (x2aOQ))))))
                                                                            
                                                                        in
                                                                            (gozuups14R (x2aOQ))))
                                                
                                                | false -> 
                                                    let 
                                                        ya12t : System.Int32 = (GHC.Prim.ztzh ((GHC.Prim.zmzh (xaP0) (1))) (x2aOQ))
                                                    in
                                                        let 
                                                            wild3a12u : System.Boolean = (GHC.Prim.zgzh (ya12t) (x2aOQ))
                                                        in
                                                            match wild3a12u with
                                                            | true -> 
                                                                let 
                                                                    wild12a12I : System.Boolean = (GHC.Prim.zgzh (ya12t) (0))
                                                                in
                                                                    match wild12a12I with
                                                                    | true -> 
                                                                        (GHC.Types.ZMZN )
                                                                    | false -> 
                                                                        (cs14K (lvl1r15O) (lazy (GHC.Types.ZMZN )))
                                                            
                                                            | false -> 
                                                                (cs14K (lvl1r15O) (lazy 
                                                                    let 
                                                                        yzqa12y : System.Int32 = (GHC.Prim.zmzh (ya12t) (x2aOQ))
                                                                    in
                                                                        let rec 
                                                                            gozudns14N : GHC.Prim.Intzh -> GHC.Types.ZMZN<GHC.Types.Int> = fun x1a12A ->
                                                                                let 
                                                                                    wild12a12B : System.Boolean = (GHC.Prim.zlzh (x1a12A) (yzqa12y))
                                                                                in
                                                                                    match wild12a12B with
                                                                                    | true -> 
                                                                                        (cs14K (lazy (GHC.Types.Izh (x1a12A))) (lazy (GHC.Types.ZMZN )))
                                                                                    | false -> 
                                                                                        (cs14K (lazy (GHC.Types.Izh (x1a12A))) (lazy (gozudns14N ((GHC.Prim.zpzh (x1a12A) (x2aOQ))))))
                                                                            
                                                                        in
                                                                            (gozudns14N (x2aOQ))))
                                                
                                    
                            
                    )))
    
    
    let rec private gor15U : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> -> GHC.Types.ZMZN<GHC.Types.Int> = 
        fun dsaLF ->
            let 
                wildaLG : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = dsaLF
            in
                match wildaLG.Force() with
                | GHC.Types.ZC (yaLK, ysaLL) -> 
                    (GHC.Types.ZC  ((lazy (GHC.Base.timesInt (yaLK) (yaLK))), (lazy (gor15U (ysaLL)))))
                | GHC.Types.ZMZN -> 
                    (GHC.Types.ZMZN )
    
    
    let rec private lvl4r15W : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
        lazy
        (
            (gor15U (primes))
        )
    
    and private wheelsrfzz : Lazy<GHC.Types.ZMZN<Wheel>> = 
        lazy
        (
            (GHC.Types.ZC  ((a2r15K), (a3r15Y)))
        )
    
    and private a3r15Y : Lazy<GHC.Types.ZMZN<Wheel>> = 
        lazy
        (
            (GHC.List.zzipWith<Wheel, GHC.Types.Int, Wheel> (lvl3r15S) (wheelsrfzz) (primes))
        )
    
    and primes : Lazy<GHC.Types.ZMZN<GHC.Types.Int>> = 
        lazy
        (
            (sieverft (wheelsrfzz) (primes) (lvl4r15W))
        )
    
    let lvl5 : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> = 
        lazy
        (
            let 
                waZZr : GHC.Types.Int = (GHC.List.sub<GHC.Types.Int> (primes) (100000))
            in
                match waZZr with
                | GHC.Types.Izh (wwaZZt) -> 
                    (GHC.Show.zdwshowSignedInt (0) (wwaZZt) (lazy (GHC.Types.ZMZN )))
        )
    
    let a4 : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        fun etaaTg ->
            let 
                wildaZZg : GHC.Prim.Z2H<GHC.Prim.Statezh<Microsoft.FSharp.Core.Unit>, GHC.Unit.Z0T> = (GHC.IO.a29 (GHC.Handle.stdout) (lvl5) (etaaTg))
            in
                match wildaZZg with
                | GHC.Prim.Z2H (newzusaZZi, a89aZZj) -> 
                    (GHC.IO.zdwa10 (GHC.Handle.stdout) ('\x0a') (newzusaZZi))
    
    
    let main : Lazy<GHC.IOBase.IO<GHC.Unit.Z0T>> = 
        lazy
        (
            a4
        )
    
    let a5 : GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        (GHC.TopHandler.a4<GHC.Unit.Z0T> (a4))
    
    let zcmain : GHC.IOBase.IO<GHC.Unit.Z0T> = 
        a5