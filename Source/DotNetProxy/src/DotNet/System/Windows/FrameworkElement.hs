-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows.FrameworkElement
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

module DotNet.System.Windows.FrameworkElement (
    FrameworkElement,
    SubFrameworkElement,
    findName
) where

import Data.Typeable

import DotNet.System
import DotNet.System.Object

data FrameworkElement = FrameworkElement
class SubFrameworkElement a
instance SubFrameworkElement FrameworkElement
instance SubObject FrameworkElement

instance Typeable FrameworkElement where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Windows.FrameworkElement.FrameworkElement") []

findName :: SubFrameworkElement w => String -> w -> IO Object
findName _ _ = error "NotImplemented"
