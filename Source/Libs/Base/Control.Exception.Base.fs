namespace Control.Exception

module Base = 
    open Microsoft.FSharp.Reflection
    
    let patError<'aazzr> : GHC.Prim.Addrzh -> 'aazzr = 
        fun saCi -> 
            (
                raise<'aazzr> (System.NotImplementedException saCi)
            )                   

    let private createErrorFunction<'aazzt> : GHC.Prim.Addrzh -> 'aazzt =
        fun aaKR ->
            let 
                f : GHC.Prim.Addrzh -> 'a -> 'b = 
                    fun aaKR arg1 ->
                        raise<'b> (System.MissingMethodException aaKR) 
            in
                FSharpValue.MakeFunction(typeof<'aazzt>, f aaKR) |> unbox<'aazzt>
            
    let noMethodBindingError<'aazzt> : GHC.Prim.Addrzh -> 'aazzt =
        fun aaKR ->            
            createErrorFunction<'aazzt> aaKR
    
//base:ControlziExceptionziBase.noMethodBindingError :: %forall aazzt . ghczmprim:GHCziPrim.Addrzh
//                                                                         -> aazzt =
//     \ @ aaKR (saCf::ghczmprim:GHCziPrim.Addrzh) ->
//         base:GHCziException.throw
//         @ base:ControlziExceptionziBase.NoMethodError @ aaKR
//         base:ControlziExceptionziBase.zdf8
//         (base:ControlziExceptionziBase.NoMethodError
//          (base:GHCziIOBase.untangle saCf lvl1r1Fm));
              
//base:ControlziExceptionziBase.patError :: %forall aazzr . ghczmprim:GHCziPrim.Addrzh
//                                                             -> aazzr =
//     \ @ aaKH (saCi::ghczmprim:GHCziPrim.Addrzh) ->
//         base:GHCziException.throw
//         @ base:ControlziExceptionziBase.PatternMatchFail @ aaKH
//         base:ControlziExceptionziBase.zdf20
//         (base:ControlziExceptionziBase.PatternMatchFail
//          (base:GHCziIOBase.untangle saCi lvl3r1Fq));    