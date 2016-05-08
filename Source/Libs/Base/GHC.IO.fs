namespace GHC

module IO = 
    
    let a29 : System.IO.TextWriter -> Lazy<GHC.Types.ZMZN<GHC.Types.Char>> -> GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        fun writer value world ->
            writer.Write(GHC.Base.packCStringzh (value.Force())) |> ignore; GHC.Prim.Z2H(world, ())
            
    let zdwa10 : System.IO.TextWriter -> GHC.Prim.Charzh -> GHC.Prim.Statezh<GHC.Prim.RealWorld> -> GHC.Prim.Z2H<GHC.Prim.Statezh<GHC.Prim.RealWorld>, GHC.Unit.Z0T> = 
        fun writer value world ->
            writer.Write(value) |> ignore; GHC.Prim.Z2H(world, ())