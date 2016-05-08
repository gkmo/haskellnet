-----------------------------------------------------------------------------
--
-- Module      :  Main
-- Copyright   :
-- License     :  AllRightsReserved
--
-- Maintainer  :
-- Stability   :
-- Portability :
--
-- |
--
-----------------------------------------------------------------------------

module Main (


) where

import GHC.IOBase
import Data.Typeable
import Data.Maybe

import DotNet.System
import DotNet.System.Object
import DotNet.System.EventArgs
import DotNet.System.EventHandler
import DotNet.System.Windows.Forms.Form
import DotNet.System.Windows.Forms.Control
import DotNet.System.Windows.Forms.Application

onLoad :: Object -> EventArgs -> IO ()
onLoad f arg = do case ((cast f) :: Maybe Form) of
                    Just x -> x # setText "Loaded"
                    Nothing -> return ()

main = do
    handler <- newEventHandler onLoad
    f <- newForm ()
    f # setText "Haskell.NET"
    f # addLoad handler
    run f
