-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Uri
-- Copyright   :
-- License     :  AllRightsReserved
--
-- Maintainer  :  Guilherme Oliveira
-- Stability   :  Alfa
-- Portability :
--
-- |
--
-----------------------------------------------------------------------------

module DotNet.System.Uri (
    Uri,
    SubUri,
    UriKind(..),
    newUri
) where

import Prelude
import Data.Typeable

import DotNet.System.Object

data Uri = Uri
class SubUri a
instance SubUri Uri
instance SubObject Uri
instance Typeable Uri where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Uri.Uri") []

data UriKind = RelativeOrAbsolute
             | Absolute
             | Relative

newUri :: String -> UriKind -> IO Uri
newUri _ _ = error "NotImplemented"
