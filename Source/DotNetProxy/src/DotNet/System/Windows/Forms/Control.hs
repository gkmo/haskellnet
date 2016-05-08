-----------------------------------------------------------------------------
--
-- Module      :  System.Windows.Forms.Control
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

module DotNet.System.Windows.Forms.Control (
    Control,
    SubControl,
    newControl,
    setText,
    getText
) where

import Prelude
import Data.Typeable

import DotNet.System
import DotNet.System.Object
import DotNet.System.Windows.Forms

newtype Control = Control ()
class SubControl a
instance SubControl Control
instance SubObject Control

instance Typeable Control where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Windows.Forms.Form.Control") []

newControl :: IO Control
newControl = error "NotImplemented"

setText :: SubControl c => String -> c -> IO ()
setText _ _ = error "NotImplemented"

getText :: SubControl c => c -> IO String
getText control = error "NotImplemented"
