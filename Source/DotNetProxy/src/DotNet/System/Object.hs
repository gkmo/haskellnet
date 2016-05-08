-----------------------------------------------------------------------------
--
-- Module      :  System.Object
-- Copyright   :
-- License     :  AllRightsReserved
--
-- Maintainer  :  Guilherme Oliveira
-- Stability   :
-- Portability :
--
-- |
--
-----------------------------------------------------------------------------

module DotNet.System.Object (
    Object,
    SubObject,
    newObject,
    equals
) where

import Data.Typeable

newtype Object = Object ()
class SubObject a
instance SubObject Object

instance Typeable Object where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Object") []

newObject :: IO Object
newObject = undefined

equals :: SubObject o => o -> o -> IO Bool
equals obj1 obj2 = undefined
