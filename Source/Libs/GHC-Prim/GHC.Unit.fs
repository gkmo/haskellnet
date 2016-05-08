namespace GHC

module Unit = 
    open Generics    
    
    type Z0T = unit        
        
    let zdgtoZLZR (dsdF : Lazy<GHC.Generics.Unit>) = 
        lazy(dsdF.Force() |> ignore; ())
    
    let zdgfromZLZR (dsdG : Lazy<Z0T>) = 
        lazy
        (
            match dsdG.Force() with
            | _ -> GHC.Generics.Unit
        )