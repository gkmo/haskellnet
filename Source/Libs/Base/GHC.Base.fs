namespace GHC

module Base = 
    
    type ZCTFunctor<'fa, 'a, 'fb, 'b> = 
        | ZCCoZCTFunctor of ((Lazy<'a> -> 'b) -> Lazy<'fa> -> 'fb)
              
    type ZCTMonad<'ma, 'a, 'mb, 'mc, 'md, 'me, 'e, 'mf> = 
        | ZCDMonad of (Lazy<'ma> -> (Lazy<'a> -> 'mb) -> 'mb) 
                    * (Lazy<'mc> -> Lazy<'md> -> 'md) 
                    * (Lazy<'e> -> 'me) 
                    * (Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> 'mf)

    let zgzgze<'ma, 'a, 'mb, 'mc, 'md, 'me, 'e, 'mf> : Lazy<ZCTMonad<'ma, 'a, 'mb, 'mc, 'md, 'me, 'e, 'mf>> -> (Lazy<'ma> -> (Lazy<'a> -> 'mb) -> 'mb) =
        fun tplB1 ->
            match tplB1.Force() with
            | ZCDMonad (tpl2B2, tpl3B3, tpl4B4, tpl5B5) -> tpl2B2
    
    let zgzg<'ma, 'a, 'mb, 'mc, 'md, 'me, 'e, 'mf> : Lazy<ZCTMonad<'ma, 'a, 'mb, 'mc, 'md, 'me, 'e, 'mf>> -> (Lazy<'mc> -> Lazy<'md> -> 'md) =
        fun tplB1 ->
            match tplB1.Force() with
            | ZCDMonad (tpl2B2, tpl3B3, tpl4B4, tpl5B5) -> tpl3B3

    let hreturn<'ma, 'a, 'mb, 'mc, 'md, 'me, 'e, 'mf> : Lazy<ZCTMonad<'ma, 'a, 'mb, 'mc, 'md, 'me, 'e, 'mf>> -> (Lazy<'e> -> 'me) =
        fun tplB1 ->
            match tplB1.Force() with
            | ZCDMonad (tpl2B2, tpl3B3, tpl4B4, tpl5B5) -> tpl4B4
    
    let fail<'ma, 'a, 'mb, 'mc, 'md, 'me, 'e, 'mf> : Lazy<ZCTMonad<'ma, 'a, 'mb, 'mc, 'md, 'me, 'e, 'mf>> -> (Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> 'mf) =
        fun tplB1 ->
            match tplB1.Force() with
            | ZCDMonad (tpl2B2, tpl3B3, tpl4B4, tpl5B5) -> tpl5B5    
                     
    let rec zpzp<'aa3zz> : Lazy<GHC.Types.ZMZN<'aa3zz>> -> Lazy<GHC.Types.ZMZN<'aa3zz>> -> GHC.Types.ZMZN<'aa3zz> =
        fun dsds4 ysa4y ->            
            (
                match dsds4.Force() with
                | GHC.Types.ZMZN -> ysa4y.Force()
                | GHC.Types.ZC (xa4B, xsa4D) -> GHC.Types.ZC (xa4B, lazy zpzp xsa4D ysa4y)
            )
                                                               
    let zgzgze1<'aa2B, 'ba2C> : Lazy<GHC.Types.ZMZN<'aa2B>> -> (Lazy<'aa2B> -> GHC.Types.ZMZN<'ba2C>) -> GHC.Types.ZMZN<'ba2C> =
        fun maa9 kaab ->            
            ( 
                let rec gos105 : Lazy<GHC.Types.ZMZN<'aa2B>> -> GHC.Types.ZMZN<'ba2C> = 
                    fun dsdsb -> 
                        match dsdsb.Force() with
                        | GHC.Types.ZMZN -> GHC.Types.ZMZN
                        | GHC.Types.ZC (ya44, ysa46) -> zpzp<'ba2C> (lazy kaab ya44) (lazy gos105 ysa46)
                in 
                    (gos105 maa9)
            )
                    

    let zgzg1<'aa2E, 'ba2F> : Lazy<GHC.Types.ZMZN<'aa2E>> -> Lazy<GHC.Types.ZMZN<'ba2F>> -> GHC.Types.ZMZN<'ba2F> =
        fun maae kaag ->            
            (
                let rec gos107 : Lazy<GHC.Types.ZMZN<'aa2E>> -> GHC.Types.ZMZN<'ba2F> =
                    fun dsdsb ->
                        match dsdsb.Force() with
                        | GHC.Types.ZMZN -> GHC.Types.ZMZN
                        | GHC.Types.ZC (ya44, ysa46) -> zpzp<'ba2F> kaag (lazy gos107 ysa46)
                in 
                    gos107 maae
            )
            

    let fail1<'aa2J> : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Types.ZMZN<'aa2J> = 
        fun dsdsti ->
            (GHC.Types.ZMZN)

    let return1<'aa2H> : Lazy<'aa2H> -> GHC.Types.ZMZN<'aa2H> =
        fun xaak ->
            (GHC.Types.ZC (xaak, lazy(GHC.Types.ZMZN)))
                                                                               
    let zdfMonadZMZN<'a, 'b, 'c, 'd, 'e, 'f> : Lazy<ZCTMonad<GHC.Types.ZMZN<'a>, 'a, GHC.Types.ZMZN<'b>, GHC.Types.ZMZN<'c>, GHC.Types.ZMZN<'d>, GHC.Types.ZMZN<'e>, 'e, GHC.Types.ZMZN<'f>>> = 
        lazy(ZCDMonad ((zgzgze1), (zgzg1), (return1), (fail1)))
              
    let rec private toGhcCharList : char list -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun l -> match l with
                 | [] -> GHC.Types.ZMZN
                 | x::xs -> GHC.Types.ZC (lazy(GHC.Types.Czh (x)), lazy(toGhcCharList xs))
        
    let unpackCStringzh : GHC.Prim.Addrzh -> GHC.Types.ZMZN<GHC.Types.Char> = 
        fun str -> 
            toGhcCharList(Array.toList(str.ToCharArray()))
        
    let rec packCStringzh : GHC.Types.ZMZN<GHC.Types.Char> -> GHC.Prim.Addrzh = 
        fun list ->             
            (
                match list with
                | GHC.Types.ZMZN -> ""
                | GHC.Types.ZC (ch, xs) -> ch.Force().ToString() + (packCStringzh (xs.Force()))
            )
        
    let a : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun xawJ yawK ->            
            (
                let wildB1 = xawJ in
                    match wildB1.Force() with
                    | GHC.Types.Izh (x1a7J)->
                            let wild1X25 = yawK in
                                match wild1X25.Force() with
                                | GHC.Types.Izh (y1a7L)->
                                        let wild2awW = GHC.Prim.zlzezh (x1a7J) (y1a7L)  in
                                            match wild2awW with
                                            | true ->
                                                wildB1.Force()
                                            | false ->
                                                wild1X25.Force()
             )
                                                       
    let a1 : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun xawp yawq ->
            (
                let wildB1 = xawp in
                    match wildB1.Force() with
                    | GHC.Types.Izh (x1a7J)->
                            let wild1X25 = yawq in
                                match wild1X25.Force() with
                                | GHC.Types.Izh (y1a7L)->
                                        let wild2awC = GHC.Prim.zlzezh (x1a7J) (y1a7L)  in
                                            match wild2awC with
                                            | true ->
                                                wild1X25.Force()
                                            | false ->
                                                wildB1.Force()
             )
                                                        
    let leInt : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Bool.Bool = 
        fun dsdqg ds1dqh ->            
            (
                let wildB1 = dsdqg in
                    match wildB1.Force() with
                    | GHC.Types.Izh (xa7J)->
                        let wild1X25 = ds1dqh in
                            match wild1X25.Force() with
                            | GHC.Types.Izh (ya7L)->
                                (GHC.Prim.zlzezh (xa7J) (ya7L))
            )
                                                       
    let ltInt : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Bool.Bool = 
        fun dsdqk ds1dql ->
            (
                let wildB1 = dsdqk in
                    match wildB1.Force() with
                    | GHC.Types.Izh (xa7E)->
                            let wild1X26 = ds1dql in
                                match wild1X26.Force() with
                                | GHC.Types.Izh (ya7G)->
                                    (GHC.Prim.zlzh (xa7E) (ya7G))
            )
                        
    let neInt : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Bool.Bool = 
        fun dsdqo ds1dqp ->
            (
                let wildB1 = dsdqo in
                    match wildB1.Force() with
                    | GHC.Types.Izh (xa7zz)->
                            let wild1X27 = ds1dqp in
                                match wild1X27.Force() with
                                | GHC.Types.Izh (ya7B)->
                                    (GHC.Prim.zszezh (xa7zz) (ya7B))
             )
                        
    let eqInt : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Bool.Bool = 
        fun dsdqs ds1dqt ->
            (
                let wildB1 = dsdqs in
                    match wildB1.Force() with
                    | GHC.Types.Izh (xa7u)->
                            let wild1X28 = ds1dqt in
                                match wild1X28.Force() with
                                | GHC.Types.Izh (ya7w)->
                                    (GHC.Prim.zezezh (xa7u) (ya7w))
             )
                        
    let zdfEqInt : Lazy<GHC.Classes.ZCTEq<GHC.Types.Int>> = // zdf2
        lazy(GHC.Classes.ZCTEq<GHC.Types.Int>.ZCDEq ((eqInt), (neInt)))

    let geInt : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Bool.Bool = 
        fun dsdqw ds1dqx ->
            (
                let wildB1 = dsdqw in
                    match wildB1.Force() with
                    | GHC.Types.Izh (xa7p)->
                            let wild1X29 = ds1dqx in
                                match wild1X29.Force() with
                                | GHC.Types.Izh (ya7r)->
                                    (GHC.Prim.zgzezh (xa7p) (ya7r))
             )
                                        
    let gtInt : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Bool.Bool = 
        fun dsdqA ds1dqB ->
            (
                let wildB1 = dsdqA in
                    match wildB1.Force() with
                    | GHC.Types.Izh (xa7k)->
                            let wild1X2a = ds1dqB in
                                match wild1X2a.Force() with
                                | GHC.Types.Izh (ya7m)->
                                    (GHC.Prim.zgzh (xa7k) (ya7m))
             )
                        
    let plusInt : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun a b ->
            (
                match a.Force(), b.Force() with
                | GHC.Types.Izh x, GHC.Types.Izh y -> 
                    GHC.Types.Izh (x + y)
            )
            
    let timesInt : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun a b ->
            (
                match a.Force(), b.Force() with
                | GHC.Types.Izh x, GHC.Types.Izh y -> GHC.Types.Izh (x * y)
            )
            
    let minusInt : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun a b ->            
            (
                match a.Force(), b.Force() with
                | GHC.Types.Izh x, GHC.Types.Izh y -> GHC.Types.Izh (x - y)
            )
            
    let negateInt : Lazy<GHC.Types.Int> -> GHC.Types.Int = 
        fun dsdqE ->            
            (
                let wildB1 = dsdqE in
                    match wildB1.Force() with
                    | GHC.Types.Izh (xa7h)->
                        GHC.Types.Izh (GHC.Prim.negateIntzh (xa7h))
             )
                        
    let compareIntzh : GHC.Prim.Intzh -> GHC.Prim.Intzh -> GHC.Ordering.Ordering = 
        fun xzha5d yzha5f ->
            let wildB1 = GHC.Prim.zlzh (xzha5d) (yzha5f) in
                match wildB1 with
                | true ->
                    GHC.Ordering.LT
                | false ->
                        let wild1X2q = GHC.Prim.zezezh (xzha5d) (yzha5f) in
                            match wild1X2q with
                            | true ->
                                GHC.Ordering.EQ
                            | false ->
                                GHC.Ordering.GT

    let compareInt : Lazy<GHC.Types.Int> -> Lazy<GHC.Types.Int> -> GHC.Ordering.Ordering = 
        fun dsdrr ds1drs ->
            (
                let wildB1 = dsdrr in
                    match wildB1.Force() with
                    | GHC.Types.Izh (xzha58)->
                            let wild1X2u = ds1drs in
                                match wild1X2u.Force() with
                                | GHC.Types.Izh (yzha5a)->
                                    (compareIntzh xzha58 yzha5a)
             )
                                                            
    let zdfOrdInt : Lazy<GHC.Classes.ZCTOrd<GHC.Types.Int>> = // zdf1
        lazy(GHC.Classes.ZCTOrd<GHC.Types.Int>.ZCDOrd (zdfEqInt, (compareInt), (ltInt), (geInt), (gtInt), (leInt), (a1), (a)))
        
    let inline divIntzh (a : GHC.Prim.Intzh) (b : GHC.Prim.Intzh) = a / b
        
    let inline modIntzh (a : GHC.Prim.Intzh) (b : GHC.Prim.Intzh) = a % b
        
    let zzeroInt : Lazy<GHC.Types.Int> = 
        lazy(GHC.Types.Izh (0))
        
    let inline zi<'ba3g, 'ca3h, 'aa3i> : (Lazy<'ba3g> -> 'ca3h) -> (Lazy<'aa3i> -> 'ba3g) -> Lazy<'aa3i> -> 'ca3h =
        fun fa5F ga5H xa5J ->             
            (
                (fa5F (lazy ga5H xa5J))
            )
        
    let hconst<'aa3k, 'ba3l> : Lazy<'aa3k> -> Lazy<'ba3l> -> 'aa3k =
        fun xa5C dsdr9 -> 
            xa5C.Force()
    
    let asTypeOf<'aa35> : Lazy<'aa35> -> Lazy<'aa35> -> 'aa35 = 
        hconst
   
    let id<'a> : Lazy<'a> -> 'a =
        fun xa5i -> 
            xa5i.Force()

    let rec map<'a, 'b> : (Lazy<'a> -> 'b) -> Lazy<GHC.Types.ZMZN<'a>> -> GHC.Types.ZMZN<'b> = 
        fun dsds7 ds1ds8 ->
            (
                match ds1ds8.Force() with
                | GHC.Types.ZMZN -> GHC.Types.ZMZN
                | GHC.Types.ZC (xa4k, xsa4m) -> GHC.Types.ZC (lazy (dsds7 xa4k), lazy (map dsds7 xsa4m))
            )                  
                                
    let foldr<'a, 'b> : (Lazy<'a> -> Lazy<'b> -> 'b) -> Lazy<'b> -> Lazy<GHC.Types.ZMZN<'a>> -> 'b =
        fun ka3U zza3W xsa3Y ->
            let rec gosCi : Lazy<GHC.Types.ZMZN<'a>> -> 'b =
                fun dsdsb ->
                    match dsdsb.Force() with
                    | GHC.Types.ZMZN -> zza3W.Force()
                    | GHC.Types.ZC (ya44, ysa46) -> ka3U ya44 (lazy gosCi ysa46)
            in
                gosCi xsa3Y

    let zdfFunctorZMZN<'a, 'b> : Lazy<ZCTFunctor<GHC.Types.ZMZN<'a>, 'a, GHC.Types.ZMZN<'b>, 'b>> =
        lazy (ZCCoZCTFunctor(map))
        
    let a88<'aa1wk, 'ba1wl> : Lazy<GHC.IOBase.IO<'aa1wk>> -> (Lazy<'aa1wk> -> GHC.IOBase.IO<'ba1wl>) -> GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, 'ba1wl> =
        fun dsd22zz kaQk saQn ->
            match ((dsd22zz.Force()) saQn) with
            | GHC.Prim.Z2H (newzusaQq, a89aQs) -> (kaQk (lazy (a89aQs))) newzusaQq
                
    let zdfMonadIO2<'aa1w9> : Lazy<'aa1w9> -> GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, 'aa1w9> = 
        fun xaQG saQJ ->
            GHC.Prim.Z2H (saQJ, (xaQG.Force()))
                         
    let zdfMonadIO1<'aa1wg> : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, 'aa1wg> = 
        fun saQ4 ->
            raise (System.IO.IOException (packCStringzh (saQ4.Force())))

    let zdfMonadIOzuzgzg<'aa1tP, 'ba1tQ> : Lazy<GHC.IOBase.IO<'aa1tP>> -> Lazy<GHC.IOBase.IO<'ba1tQ>> -> GHC.IOBase.IO<'ba1tQ> =
        fun maWy kaWA ->
            a88<'aa1tP, 'ba1tQ> maWy (fun _ -> kaWA.Force()) 
                    
    let zdfMonadIO<'a, 'b, 'c, 'd, 'e, 'f> : Lazy<ZCTMonad<GHC.IOBase.IO<'a>, 'a, GHC.IOBase.IO<'b>, GHC.IOBase.IO<'c>, GHC.IOBase.IO<'d>, GHC.IOBase.IO<'e>, 'e, GHC.IOBase.IO<'f>>> =
        lazy (ZCDMonad (a88, zdfMonadIOzuzgzg, zdfMonadIO2, zdfMonadIO1))
        