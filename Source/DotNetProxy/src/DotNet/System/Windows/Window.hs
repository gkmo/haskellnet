-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows.Window
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

module DotNet.System.Windows.Window (
    Window,
    SubWindow,
    newWindow,
    show,
    activate,
    close,
    setTitle,
    getTitle
) where

import Data.Typeable
import Prelude hiding (show)

import DotNet.System
import DotNet.System.Object
import DotNet.System.Windows.FrameworkElement

data Window = Window

class SubWindow a

instance SubWindow Window
instance SubObject Window
instance SubFrameworkElement Window

instance Typeable Window where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Windows.Window") []

newWindow :: () -> IO Window
newWindow = error "NotImplemented"

show :: SubWindow w => w -> IO ()
show _ = error "NotImplemented"

activate :: SubWindow w => w -> IO ()
activate _ = error "NotImplemented"

close :: SubWindow w => w -> IO ()
close _ = error "NotImplemented"

setTitle :: SubWindow w => String -> w -> IO ()
setTitle _ _ = error "NotImplemented"

getTitle :: SubWindow w => w -> IO String
getTitle _ = error "NotImplemented"


