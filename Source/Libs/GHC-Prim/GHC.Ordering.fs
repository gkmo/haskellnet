namespace GHC

module Ordering = 

    type Ordering = 
        | LT
        | EQ
        | GT

    let a : Lazy<GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>> = 
        lazy(GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>.Inr (lazy(GHC.Generics.Unit)))

    let a1 : Lazy<GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>> = 
        lazy(GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>.Inl (lazy(GHC.Generics.Unit)))

    let lvl : Lazy<GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>>> = 
        lazy(GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>>.Inr a)

    let lvl1 : Lazy<GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>>> = 
        lazy(GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>>.Inr a1)

    let lvl2 : Lazy<GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>>> = 
        lazy(GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>>.Inl (lazy(GHC.Generics.Unit)))

    let zdgtoOrdering : Lazy<GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>>> -> Lazy<Ordering> = 
        fun g1aK ->
            lazy
            (
                let wildB1 = g1aK in
                    match wildB1.Force() with
                    | GHC.Generics.Inr g2aS ->
                            let wild1Xa = g2aS in
                                match wild1Xa.Force() with
                                | GHC.Generics.Inr dsd1F ->
                                    GT
                                | GHC.Generics.Inl dsd1E ->
                                    EQ
                    
                    | GHC.Generics.Inl dsd1J ->
                        LT
            )
    

    let zdgfromOrdering : Lazy<Ordering> -> Lazy<GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.ZCzpZC<GHC.Generics.Unit, GHC.Generics.Unit>>> = 
        fun dsd1M ->
            lazy
            (                
                let wildB1 = dsd1M in
                    match wildB1.Force() with
                    | GT ->
                        lvl.Force()
                    | EQ ->
                        lvl1.Force()
                    | LT ->
                        lvl2.Force()
            )
    

