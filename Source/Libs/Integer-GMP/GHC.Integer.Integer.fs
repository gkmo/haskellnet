namespace GHC

// Module name cannot have the same name of the type Integer, so for now it will be renamed to HInteger
module HInteger =
    open GHC.Prim
    open GHC.Integer.Internals
    
    let smallInteger : Intzh -> Integer = 
        fun i ->             
            (
                Szh (i)
            )        
                            
    let toInt : Integer -> Intzh =
        fun x ->            
            (
                match x with
                    | Szh i -> i
                    | Jzh (i, b) -> (integer2Intzh (i) (b))
            )
            

    let compareInteger : Lazy<Integer> -> Lazy<Integer> -> GHC.Ordering.Ordering =
        fun x y ->            
            (
                match x.Force(), y.Force() with
                | Szh a, Szh b -> 
                    match a = b with
                    | true -> GHC.Ordering.EQ
                    | false -> 
                        match a < b with
                        | true -> GHC.Ordering.LT
                        | false -> GHC.Ordering.GT
                | _, _ -> raise (System.NotImplementedException "compareInteger for BigNumber")
            )
            
    let eqInteger : Lazy<Integer> -> Lazy<Integer> -> GHC.Bool.Bool =
        fun x y ->            
            (
                match x.Force(), y.Force() with
                | Szh a, Szh b -> a = b
                | _, _ -> raise (System.NotImplementedException "eqInteger for BigNumber")
            )

    let neqInteger : Lazy<Integer> -> Lazy<Integer> -> GHC.Bool.Bool =
        fun x y ->            
            (
                match x.Force(), y.Force() with
                | Szh a, Szh b -> a <> b
                | _, _ -> raise (System.NotImplementedException "neqInteger for BigNumber")
            )

    let leInteger : Lazy<Integer> -> Lazy<Integer> -> GHC.Bool.Bool =
        fun x y ->            
            (
                match x.Force(), y.Force() with
                | Szh a, Szh b -> a <= b
                | _, _ -> raise (System.NotImplementedException "leInteger for BigNumber")
            )
            
    let ltInteger : Lazy<Integer> -> Lazy<Integer> -> GHC.Bool.Bool =
        fun x y ->            
            (
                match x.Force(), y.Force() with
                | Szh a, Szh b -> a < b
                | _, _ -> raise (System.NotImplementedException "ltInteger for BigNumber")
            )

    let gtInteger : Lazy<Integer> -> Lazy<Integer> -> GHC.Bool.Bool =
        fun x y ->            
            (
                match x.Force(), y.Force() with
                | Szh a, Szh b -> a > b
                | _, _ -> raise (System.NotImplementedException "gtInteger for BigNumber")
            )
            
    let geInteger : Lazy<Integer> -> Lazy<Integer> -> GHC.Bool.Bool =
        fun x y ->            
            (
                match x.Force(), y.Force() with
                | Szh a, Szh b -> a >= b
                | _, _ -> raise (System.NotImplementedException "geInteger for BigNumber")
            )
                     
    let plusInteger : Lazy<Integer> -> Lazy<Integer> -> Integer =
        fun x y ->            
            (
                match x.Force(), y.Force() with
                | Szh a, Szh b -> Szh (a + b)
                | _, _ -> raise (System.NotImplementedException "plusInteger for BigNumber")            
            )
            
    let timesInteger : Lazy<Integer> -> Lazy<Integer> -> Integer =
        fun x y ->
            (
                match x.Force(), y.Force() with
                | Szh a, Szh b -> Szh (a * b)
                | _, _ -> raise (System.NotImplementedException "timesInteger for BigNumber")
            )
                    
    let minusInteger : Lazy<Integer> -> Lazy<Integer> -> Integer =
        fun x y ->            
            (
                match x.Force(), y.Force() with
                | Szh a, Szh b -> Szh (a - b)
                | _, _ -> raise (System.NotImplementedException "minusInteger for BigNumber")  
            )
                          
    let negateInteger : Lazy<Integer> -> Integer =
        fun x ->            
            (
                match x.Force() with
                | Szh a -> Szh (-a)
                | _ -> raise (System.NotImplementedException "negateInteger for BigNumber")  
            )

    let absInteger : Lazy<Integer> -> Integer =
        fun x ->            
            (
                match x.Force() with
                | Szh a -> Szh (System.Math.Abs (a))
                | _ -> raise (System.NotImplementedException "absInteger for BigNumber")  
            )
                           
    let signumInteger : Lazy<Integer> -> Integer =
        fun x ->            
            (
                match x.Force() with
                | Szh a -> Szh (System.Math.Sign (a))
                | _ -> raise (System.NotImplementedException "signumInteger for BigNumber")  
            )
                                                                        
    let quotInteger : Lazy<Integer> -> Lazy<Integer> -> Integer =
        fun x y -> raise (System.NotImplementedException "quotInteger")
        
    let gcdInteger : Lazy<Integer> -> Lazy<Integer> -> Integer =
        fun x y -> raise (System.NotImplementedException "gcdInteger")
        

    let zdstimesInteger : GHC.Prim.ByteArrayzh -> GHC.Prim.Intzh -> GHC.Prim.ByteArrayzh -> GHC.Prim.Intzh -> Integer =
        fun scsC7 sc1sC8 sc2sC9 sc3sCa ->            
            (
                match (GHC.Prim.timesIntegerzh (sc3sCa) (sc2sC9) (sc1sC8) (scsC7)) with
                | GHC.Prim.Z2H (saci, dack) -> Jzh (saci, dack)
            )
              
    let zdsquotRemInteger : GHC.Prim.ByteArrayzh -> GHC.Prim.Intzh -> GHC.Prim.ByteArrayzh -> GHC.Prim.Intzh -> GHC.Prim.Z2H<GHC.Integer.Internals.Integer, GHC.Integer.Internals.Integer> = 
        fun scsBzz sc1sBA sc2sBB sc3sBC ->            
            (
                let wildX1g = GHC.Prim.quotRemIntegerzh (sc3sBC) (sc2sBB) (sc1sBA) (scsBzz) in
                    match wildX1g with
                    | GHC.Prim.Z4H (s3a3O, d3a3Q, s4a3S, d4a3U)->
                        GHC.Prim.Z2H (GHC.Integer.Internals.Jzh ((s3a3O), (d3a3Q)), GHC.Integer.Internals.Jzh ((s4a3S), (d4a3U))) 
            )
    

    let zdsquotRemInteger1 : Lazy<GHC.Integer.Internals.Integer> -> GHC.Prim.ByteArrayzh -> GHC.Prim.Intzh -> GHC.Prim.Z2H<GHC.Integer.Internals.Integer, GHC.Integer.Internals.Integer> = 
        fun scsBw sc1sBx sc2sBy ->            
            (
                let wildX1a = scsBw in
                    match wildX1a.Force() with
                    | GHC.Integer.Internals.Jzh (s2a3K, d2a3M)->
                        let wild1X1g = GHC.Prim.quotRemIntegerzh (sc2sBy) (sc1sBx) (s2a3K) (d2a3M) in
                            match wild1X1g with
                            | GHC.Prim.Z4H (s3a3O, d3a3Q, s4a3S, d4a3U)->
                                GHC.Prim.Z2H (GHC.Integer.Internals.Jzh ((s3a3O), (d3a3Q)), GHC.Integer.Internals.Jzh ((s4a3S), (d4a3U))) 
                    
                    | GHC.Integer.Internals.Szh (dsdig)->
                        let wild1X16 = GHC.Prim.int2Integerzh (dsdig) in
                            match wild1X16 with
                            | GHC.Prim.Z2H (sa3g, da3i)->
                                (zdsquotRemInteger (da3i) (sa3g) (sc1sBx) (sc2sBy))
            )
            
    let quotRemInteger : Lazy<GHC.Integer.Internals.Integer> -> Lazy<GHC.Integer.Internals.Integer> -> GHC.Prim.Z2H<GHC.Integer.Internals.Integer, GHC.Integer.Internals.Integer> = 
        fun aa3m ba3o ->            
            (
                let wildB1 = aa3m in
                    match wildB1.Force() with
                    | GHC.Integer.Internals.Jzh (dsdie, ds1dif)->
                        let wild1X1a = ba3o in
                            match wild1X1a.Force() with
                            | GHC.Integer.Internals.Jzh (s2a3K, d2a3M)->
                                let wild2X1g = GHC.Prim.quotRemIntegerzh (dsdie) (ds1dif) (s2a3K) (d2a3M) in
                                    match wild2X1g with
                                    | GHC.Prim.Z4H (s3a3O, d3a3Q, s4a3S, d4a3U) ->
                                        GHC.Prim.Z2H (GHC.Integer.Internals.Jzh ((s3a3O), (d3a3Q)), GHC.Integer.Internals.Jzh ((s4a3S), (d4a3U))) 
                            
                            | GHC.Integer.Internals.Szh (ds2dig)->
                                let wild2X16 = GHC.Prim.int2Integerzh (ds2dig) in
                                    match wild2X16 with
                                    | GHC.Prim.Z2H (sa3g, da3i)-> (zdsquotRemInteger (da3i) (sa3g) (ds1dif) (dsdie))
                                            
                    | GHC.Integer.Internals.Szh (dsdib)->
                        let ds1Xjk = dsdib in
                            match ds1Xjk with
                            | GHC.Prim.Intzh.MinValue ->
                                let wild1X16 = GHC.Prim.int2Integerzh (-2147483648) in
                                    match wild1X16 with
                                    | GHC.Prim.Z2H (sa3g, da3i)-> (zdsquotRemInteger1 (ba3o) (da3i) (sa3g))
                            
                            | _ -> let wild1X1e = ba3o in
                                    match wild1X1e.Force() with
                                    | GHC.Integer.Internals.Jzh (ds2dic, ds3did)->
                                        let wild2X16 = GHC.Prim.int2Integerzh (ds1Xjk) in
                                            match wild2X16 with
                                            | GHC.Prim.Z2H (sa3g, da3i)-> (zdsquotRemInteger (ds3did) (ds2dic) (da3i) (sa3g))
                                    
                                    | GHC.Integer.Internals.Szh (ja3s)->
                                        let rafj = GHC.Prim.remIntzh (ds1Xjk) (ja3s) in
                                            match rafj with
                                            | _ -> let qafl = GHC.Prim.quotIntzh (ds1Xjk) (ja3s) in
                                                    match qafl with
                                                    | _ -> GHC.Prim.Z2H (GHC.Integer.Internals.Szh (qafl), GHC.Integer.Internals.Szh (rafj))
            )