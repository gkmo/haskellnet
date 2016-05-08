-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows.Controls.TextBox
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

module DotNet.System.Windows.Controls.TextBox (
    TextBox,
    SubTextBox,
    newTextBox,
    setText,
    getText
) where

import Data.Typeable

import DotNet.System.Object
import DotNet.System.Windows.FrameworkElement
import DotNet.System.Windows.RoutedEventHandler
import DotNet.System.Windows.Controls.ContentControl

data TextBox = TextBox

class SubTextBox a

instance SubTextBox TextBox
instance SubObject TextBox
instance SubFrameworkElement TextBox

instance Typeable TextBox where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Windows.Controls.TextBox.TextBox") []

newTextBox :: () -> IO TextBox
newTextBox = error "NotImplemented"

setText :: SubTextBox w => String -> w -> IO ()
setText _ _ = error "NotImplemented"

getText :: SubTextBox w => w -> IO String
getText _ = error "NotImplemented"

