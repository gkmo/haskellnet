namespace GHC

module IOBase =

    type ZCCoIO<'a> = GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, 'a>
        
    type IO<'a> = ZCCoIO<'a>
        
    type IOMode =
        | ReadMode
        | WriteMode
        | AppendMode
        | ReadWriteMode
        
    
    type IOErrorType = 
        |AlreadyExists
        |NoSuchThing
        |ResourceBusy
        |ResourceExhausted
        |EOF
        |IllegalOperation
        |PermissionDenied
        |UserError
        |UnsatisfiedConstraints
        |SystemError
        |ProtocolError
        |OtherError
        |InvalidArgument
        |InappropriateType
        |HardwareFault
        |UnsupportedOperation
        |TimeExpired
        |ResourceVanished
        |Interrupted
        
    type IOException =
        | IOError of (IOErrorType * GHC.Types.ZMZN<GHC.Types.Char> * GHC.Types.ZMZN<GHC.Types.Char>)
        
    type ExitCode = 
        | ExitSuccess
        | ExitFailure of GHC.Types.Int
        
//  %data base:GHCziIOBase.IOException =
//    {base:GHCziIOBase.IOError ((base:DataziMaybe.Maybe
//                                base:GHCziIOBase.Handle))
//                              base:GHCziIOBase.IOErrorType
//                              ((ghczmprim:GHCziTypes.ZMZN ghczmprim:GHCziTypes.Char))
//                              ((ghczmprim:GHCziTypes.ZMZN ghczmprim:GHCziTypes.Char))
//                              ((base:DataziMaybe.Maybe
//                                ((ghczmprim:GHCziTypes.ZMZN ghczmprim:GHCziTypes.Char))))};

//    type Handle = 
//        | FileHandle of GHC.Types.ZMZN<GHC.Types.Char> * GHC.Prim.MVarzh<GHC.Prim.RealWorld>
//        | DuplexHandle of GHC.Types.ZMZN<GHC.Types.Char> * GHC.Prim.MVarzh<GHC.Prim.RealWorld> * GHC.Prim.MVarzh<GHC.Prim.RealWorld>

//  %data base:GHCziIOBase.Handle =
//    {base:GHCziIOBase.FileHandle ((ghczmprim:GHCziTypes.ZMZN
//                                   ghczmprim:GHCziTypes.Char))
//                                 ((ghczmprim:GHCziPrim.MVarzh
//                                   ghczmprim:GHCziPrim.RealWorld
//                                   base:GHCziIOBase.Handlezuzu));
//     base:GHCziIOBase.DuplexHandle ((ghczmprim:GHCziTypes.ZMZN
//                                     ghczmprim:GHCziTypes.Char))
//                                   ((ghczmprim:GHCziPrim.MVarzh
//                                     ghczmprim:GHCziPrim.RealWorld
//                                     base:GHCziIOBase.Handlezuzu))
//                                   ((ghczmprim:GHCziPrim.MVarzh
//                                     ghczmprim:GHCziPrim.RealWorld
//                                     base:GHCziIOBase.Handlezuzu))};    
        
    let unsafePerformIO<'aaPA> : IO<'aaPA> -> 'aaPA =
        fun maR1 ->
            match maR1 (GHC.Prim.realWorldzh) with
            | GHC.Prim.Z2H (r, x) -> x