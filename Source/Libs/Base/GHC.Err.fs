namespace GHC

module Err = 

    let absentErr<'aa4d> : Lazy<'aa4d> =         
        lazy (raise<'aa4d> (System.ArgumentException "Oops! The program has entered an `absent\x27 argument!\x0a"))
        
    let undefined<'aa4f> : Lazy<'aa4f> = 
        lazy (raise<'aa4f> (System.NotImplementedException ()))

    let overflowError<'aa49> : Lazy<'aa49> = 
        lazy (raise<'aa49> (System.OverflowException ()))

    let divZZeroError<'aa4b> : Lazy<'aa4b> = 
        lazy (raise<'aa4b> (System.DivideByZeroException ()))

    let error<'aa4h> : Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> 'aa4h = 
        fun str -> (failwithf "Error %A" (GHC.Base.packCStringzh (str.Force()))); Unchecked.defaultof<'aa4h>

