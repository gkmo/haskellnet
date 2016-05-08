-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows.Controls.Button
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

module DotNet.System.Windows.Controls.Button (
    Button,
    SubButton,
    newButton,
    addClick,
    removeClick
) where

import Data.Typeable

import DotNet.System.Object
import DotNet.System.Windows.FrameworkElement
import DotNet.System.Windows.RoutedEventHandler
import DotNet.System.Windows.Controls.ContentControl

data Button = Button

class SubButton a

instance SubButton Button
instance SubObject Button
instance SubContentControl Button
instance SubFrameworkElement Button

instance Typeable Button where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Windows.Controls.Button.Button") []

newButton :: () -> IO Button
newButton = error "NotImplemented"

addClick :: SubButton w => RoutedEventHandler -> w -> IO ()
addClick _ = error "NotImplemented"

removeClick :: SubButton w => RoutedEventHandler -> w -> IO ()
removeClick _ = error "NotImplemented"

