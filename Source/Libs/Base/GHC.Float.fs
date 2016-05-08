namespace GHC

module Float = 

    let foo : Lazy<GHC.Types.Float> -> Lazy<string> =
        fun f -> 
            lazy
            (
                match f.Force() with
                | GHC.Types.Fzh v -> v.ToString()
            )