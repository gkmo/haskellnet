namespace GHC

module Generics = 
    type ZCztZC<'aag, 'bah> = 
        | ZCztZC of Lazy<'aag> * Lazy<'bah>

    type ZCzpZC<'aak, 'bal> = 
        | Inl of Lazy<'aak>
        | Inr of Lazy<'bal>

    type Unit = 
        | Unit

    let zdgtoUnit : Lazy<Unit> -> Lazy<Unit> = 
        fun dsd2f ->
            dsd2f

    let zdgfromUnit : Lazy<Unit> -> Lazy<Unit> = 
        fun dsd2g ->
            dsd2g

    let zdgtoZCzpZC<'ta1A, 'ba1E> : Lazy<ZCzpZC<'ta1A, 'ba1E>> -> Lazy<ZCzpZC<'ta1A, 'ba1E>> = 
        fun g1a1c ->
            g1a1c

    let zdgfromZCzpZC<'ta1N, 'ba1Q> : Lazy<ZCzpZC<'ta1N, 'ba1Q>> -> Lazy<ZCzpZC<'ta1N, 'ba1Q>> = 
        fun dsd2l ->
            dsd2l

    let zdgtoZCztZC<'ta20, 't1a21> : Lazy<ZCztZC<'ta20, 't1a21>> -> Lazy<ZCztZC<'ta20, 't1a21>> = 
        fun g3aY ->
            g3aY

    let zdgfromZCztZC<'ta2a, 't1a2b> : Lazy<ZCztZC<'ta2a, 't1a2b>> -> Lazy<ZCztZC<'ta2a, 't1a2b>> = 
        fun dsd2q ->
            dsd2q

