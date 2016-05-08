-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows.Forms.Application
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

module DotNet.System.Windows.Forms.Application (
    run
) where

import DotNet.System.Windows.Forms.Form

run :: SubForm f => f -> IO ()
run _ = error "NotImplemented"
