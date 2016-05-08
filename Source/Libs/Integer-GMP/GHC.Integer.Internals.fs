namespace GHC.Integer

module Internals =

    type Integer = 
        | Szh of GHC.Prim.Intzh
        | Jzh of GHC.Prim.Intzh * GHC.Prim.ByteArrayzh // BigInteger não existe mais no .NET 3.5