-----------------------------------------------------------------------------
--
-- Module      :  DotNet.System.Xml.XmlReader
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

module DotNet.System.Xml.XmlReader (
    XmlReader,
    SubXmlReader,
    create,
    close
) where


import Prelude
import Data.Typeable

import DotNet.System
import DotNet.System.Object

data XmlReader = XmlReader

class SubXmlReader a

instance SubXmlReader XmlReader
instance SubObject XmlReader

instance Typeable XmlReader where
    typeOf x = mkTyConApp (mkTyCon "DotNet.System.Xml.XmlReader.XmlReader") []

create :: String -> IO XmlReader
create _ = error "NotImplemented"

close :: XmlReader -> IO ()
close _ = error "NotImplemented"

