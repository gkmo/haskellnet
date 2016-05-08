-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows.Controls.ContentControl
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

module DotNet.System.Windows.Controls.ContentControl (
    ContentControl,
    SubContentControl,
    setContent,
    getContent
) where

import Data.Typeable

import DotNet.System.Object
import DotNet.System.Windows.FrameworkElement

data ContentControl = ContentControl

class SubContentControl a

instance SubContentControl ContentControl
instance SubObject ContentControl
instance SubFrameworkElement ContentControl

instance Typeable ContentControl where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Windows.Controls.ContentControl.ContentControl") []

setContent :: SubContentControl w => String -> w -> IO ()
setContent _ _ = error "NotImplemented"

getContent :: SubContentControl w => w -> IO String
getContent _ = error "NotImplemented"

