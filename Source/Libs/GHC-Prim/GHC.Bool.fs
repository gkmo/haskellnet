namespace GHC

module Bool = 
    open Generics

    type Bool = bool        
    
    let lvl = lazy(ZCzpZC<Unit, Unit>.Inr (lazy(Unit)))

    let lvl1 = lazy(ZCzpZC<Unit, Unit>.Inl (lazy(Unit)))

    let zdgtoBool (x : Lazy<ZCzpZC<Unit, Unit>>) =
        (
            match x.Force() with
            | Inl dsd18 -> false
            | Inr dsd19 -> true
        )
    
    let zdgfromBool (x : Lazy<Bool>) = 
        (
            match x.Force() with
            | false -> lvl1.Force()
            | true -> lvl.Force()
        )