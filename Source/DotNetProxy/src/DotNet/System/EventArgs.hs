-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.EventArgs
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

module DotNet.System.EventArgs (
    EventArgs,
    SubEventArgs,
    newEventArgs
) where

import Prelude
import DotNet.System.Object

data EventArgs = EventArgs
class SubEventArgs a
instance SubEventArgs EventArgs
instance SubObject EventArgs

newEventArgs :: () -> IO EventArgs
newEventArgs _ = undefined
