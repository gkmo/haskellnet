-----------------------------------------------------------------------------
--
-- Module      :  System.EventHandler
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

module DotNet.System.EventHandler (
    EventHandler,
    SubEventHandler,
    newEventHandler
) where

import Prelude
import Data.Typeable

import DotNet.System.Object
import DotNet.System.EventArgs

newtype EventHandler = EventHandler ()
class SubEventHandler a
instance SubEventHandler EventHandler
instance SubObject EventHandler

instance Typeable EventHandler where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.EventHandler.EventHandler") []

newEventHandler :: (Object -> EventArgs -> IO ()) -> (IO EventHandler)
newEventHandler = undefined
