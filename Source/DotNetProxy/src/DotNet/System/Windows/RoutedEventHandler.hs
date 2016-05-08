-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows.RoutedEventHandler
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

module DotNet.System.Windows.RoutedEventHandler (
    RoutedEventHandler,
    SubRoutedEventHandler,
    newRoutedEventHandler
) where

import Data.Typeable

import DotNet.System.Object
import DotNet.System.Windows.RoutedEventArgs

data RoutedEventHandler = RoutedEventHandler
class SubRoutedEventHandler a
instance SubRoutedEventHandler RoutedEventHandler
instance SubObject RoutedEventHandler

instance Typeable RoutedEventHandler where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Windows.RoutedEventHandler.RoutedEventHandler") []

newRoutedEventHandler :: (Object -> RoutedEventArgs -> IO ()) -> (IO RoutedEventHandler)
newRoutedEventHandler = undefined
