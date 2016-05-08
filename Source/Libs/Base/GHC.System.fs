
namespace HaskellSystem

module IO =    

    let private printString : string -> GHC.Prim.Statezh<GHC.Prim.RealWorld> -> (GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T>) =
        fun value state ->
            System.Console.Write(value); GHC.Prim.Z2H (state, ())
            
    let print<'a> : Lazy<GHC.Show.ZCTShow<'a>> -> Lazy<'a> -> GHC.IOBase.IO<GHC.Unit.Z0T> = 
        fun show value ->            
            (
                match show.Force() with
                | GHC.Show.ZCDShow (showA, showB, showC) -> 
                    (printString (GHC.Base.packCStringzh (showB value)))
            )