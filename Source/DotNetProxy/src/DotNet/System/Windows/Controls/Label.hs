-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows.Controls.Label
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

module DotNet.System.Windows.Controls.Label (
    Label,
    SubLabel,
    newLabel
) where

import Data.Typeable

import DotNet.System.Object
import DotNet.System.Windows.FrameworkElement
import DotNet.System.Windows.RoutedEventHandler
import DotNet.System.Windows.Controls.ContentControl

data Label = Label

class SubLabel a

instance SubLabel Label
instance SubObject Label
instance SubContentControl Label
instance SubFrameworkElement Label

instance Typeable Label where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Windows.Controls.Label.Label") []

newLabel :: () -> IO Label
newLabel = error "NotImplemented"
