-----------------------------------------------------------------------------
--
-- Module      :  System.Windows.Forms.Form
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

module DotNet.System.Windows.Forms.Form (
    Form,
    SubForm,
    newForm,
    addLoad
) where

import Prelude
import Data.Typeable

import DotNet.System
import DotNet.System.Object
import DotNet.System.EventHandler
import DotNet.System.Windows.Forms
import DotNet.System.Windows.Forms.Control

data Form = Form

class SubForm a

instance SubForm Form
instance SubControl Form
instance SubObject Form

instance Typeable Form where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Windows.Forms.Form.Form") []

newForm :: () -> IO Form
newForm = error "NotImplemented"

addLoad :: SubForm f => EventHandler -> f -> IO ()
addLoad _ _ = error "NotImplemented"
