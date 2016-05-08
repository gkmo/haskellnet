-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows.Application
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

module DotNet.System.Windows.Application (
    Application,
    SubApplication,
    newApplication,
    run,
    getStartupUri,
    setStartupUri
) where

import Data.Typeable

import DotNet.System.Object
import DotNet.System.Uri
import DotNet.System.Windows.Window

data Application = Application

class SubApplication a

instance SubApplication Application
instance SubObject Application

instance Typeable Application where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Windows.Application.Application") []

newApplication :: () -> IO Application
newApplication = error "Application.new NotImplemented"

run :: (SubWindow w, SubApplication a) => w -> a -> IO ()
run _ _ = error "Application.run NotImplemented"

getStartupUri :: SubApplication w => w -> IO Uri
getStartupUri _ = error "Application.getStartupUri NotImplemented"

setStartupUri :: SubApplication w => Uri -> w -> IO ()
setStartupUri _ _ = error "Application.setStartupUri NotImplemented"
