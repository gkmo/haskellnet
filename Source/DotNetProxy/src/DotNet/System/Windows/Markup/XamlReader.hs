-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Windows.Markup.XamlReader
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

module DotNet.System.Windows.Markup.XamlReader (
    XamlReader,
    SubXamlReader,
    load
) where

import Prelude
import Data.Typeable

import DotNet.System
import DotNet.System.Object
import DotNet.System.Xml.XmlReader

data XamlReader = XamlReader

class SubXamlReader a

instance SubXamlReader XamlReader
instance SubObject XamlReader

instance Typeable XamlReader where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Windows.Markup.XamlReader.XamlReader") []

load :: XmlReader -> IO Object
load _ = error "NotImplemented"
