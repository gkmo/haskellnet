namespace Data

module Maybe = 
    
    type Maybe<'aa2Q> = 
        | Nothing
        | Just of Lazy<'aa2Q>
    