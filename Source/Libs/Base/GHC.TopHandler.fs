// Learn more about F# at http://fsharp.net
        
namespace GHC
     
module TopHandler =               
        
    let runMainIO<'a> : Lazy<IOBase.IO<'a>> -> IOBase.IO<'a> = 
        fun main -> 
            main.Force() 
            
    let a4<'a> : GHC.IOBase.IO<'a> -> GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, 'a> = 
        fun io world ->
            io (world)