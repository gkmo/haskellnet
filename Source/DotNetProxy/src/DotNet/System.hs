-----------------------------------------------------------------------------
--
-- Module      :  System
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

module DotNet.System (
    (#),
    Object,
    SubObject,
    newObject,
    equals,
    Uri,
    SubUri,
    UriKind(..),
    newUri,
    EventHandler,
    SubEventHandler,
    newEventHandler
) where

import Prelude
import DotNet.System.Object
import DotNet.System.Uri
import DotNet.System.EventHandler

obj # method = method obj
