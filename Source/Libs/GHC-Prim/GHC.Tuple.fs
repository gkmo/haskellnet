namespace GHC

module Tuple = 
    type Z2T<'aaxK, 'baxL> = 
        | Z2T of Lazy<('aaxK)> * Lazy<('baxL)>

    type Z3T<'aaxF, 'baxG, 'caxH> = 
        | Z3T of Lazy<('aaxF)> * Lazy<('baxG)> * Lazy<('caxH)>

    type Z4T<'aaxz, 'baxA, 'caxB, 'daxC> = 
        | Z4T of Lazy<('aaxz)> * Lazy<('baxA)> * Lazy<('caxB)> * Lazy<('daxC)>

    type Z5T<'aaxs, 'baxt, 'caxu, 'daxv, 'eaxw> = 
        | Z5T of Lazy<('aaxs)> * Lazy<('baxt)> * Lazy<('caxu)> * Lazy<('daxv)> * Lazy<('eaxw)>

    type Z6T<'aaxk, 'baxl, 'caxm, 'daxn, 'eaxo, 'faxp> = 
        | Z6T of Lazy<('aaxk)> * Lazy<('baxl)> * Lazy<('caxm)> * Lazy<('daxn)> * Lazy<('eaxo)> * Lazy<('faxp)>

//    type Z7T<'aaxb, 'baxc, 'caxd, 'daxe, 'eaxf, 'faxg, 'gaxh> = 
//        | Z7T of ('aaxb) * ('baxc) * ('caxd) * ('daxe) * ('eaxf) * ('faxg) * ('gaxh)
//
//    type Z8T<'aax1, 'bax2, 'cax3, 'dax4, 'eax5, 'fax6, 'gax7, 'hax8> = 
//        | Z8T of ('aax1) * ('bax2) * ('cax3) * ('dax4) * ('eax5) * ('fax6) * ('gax7) * ('hax8)
//
//    type Z9T<'aawQ, 'bawR, 'cawS, 'dawT, 'eawU, 'fawV, 'gawW, 'hawX, 'iawY> = 
//        | Z9T of ('aawQ) * ('bawR) * ('cawS) * ('dawT) * ('eawU) * ('fawV) * ('gawW) * ('hawX) * ('iawY)
//
//    type Z10T<'aawE, 'bawF, 'cawG, 'dawH, 'eawI, 'fawJ, 'gawK, 'hawL, 'iawM, 'jawN> = 
//        | Z10T of ('aawE) * ('bawF) * ('cawG) * ('dawH) * ('eawI) * ('fawJ) * ('gawK) * ('hawL) * ('iawM) * ('jawN)
//
//    type Z11T<'aawr, 'baws, 'cawt, 'dawu, 'eawv, 'faww, 'gawx, 'hawy, 'iawz, 'jawA, 'kawB> = 
//        | Z11T of ('aawr) * ('baws) * ('cawt) * ('dawu) * ('eawv) * ('faww) * ('gawx) * ('hawy) * ('iawz) * ('jawA) * ('kawB)
//
//    type Z12T<'aawd, 'bawe, 'cawf, 'dawg, 'eawh, 'fawi, 'gawj, 'hawk, 'iawl, 'jawm, 'kawn, 'lawo> = 
//        | Z12T of ('aawd) * ('bawe) * ('cawf) * ('dawg) * ('eawh) * ('fawi) * ('gawj) * ('hawk) * ('iawl) * ('jawm) * ('kawn) * ('lawo)
//
//    type Z13T<'aavY, 'bavZ, 'caw0, 'daw1, 'eaw2, 'faw3, 'gaw4, 'haw5, 'iaw6, 'jaw7, 'kaw8, 'law9, 'mawa> = 
//        | Z13T of ('aavY) * ('bavZ) * ('caw0) * ('daw1) * ('eaw2) * ('faw3) * ('gaw4) * ('haw5) * ('iaw6) * ('jaw7) * ('kaw8) * ('law9) * ('mawa)
//
//    type Z14T<'aavI, 'bavJ, 'cavK, 'davL, 'eavM, 'favN, 'gavO, 'havP, 'iavQ, 'javR, 'kavS, 'lavT, 'mavU, 'navV> = 
//        | Z14T of ('aavI) * ('bavJ) * ('cavK) * ('davL) * ('eavM) * ('favN) * ('gavO) * ('havP) * ('iavQ) * ('javR) * ('kavS) * ('lavT) * ('mavU) * ('navV)
//
//    type Z15T<'aavr, 'bavs, 'cavt, 'davu, 'eavv, 'favw, 'gavx, 'havy, 'iavz, 'javA, 'kavB, 'lavC, 'mavD, 'navE, 'oavF> = 
//        | Z15T of ('aavr) * ('bavs) * ('cavt) * ('davu) * ('eavv) * ('favw) * ('gavx) * ('havy) * ('iavz) * ('javA) * ('kavB) * ('lavC) * ('mavD) * ('navE) * ('oavF)
//
//    type Z16T<'aav9, 'bava, 'cavb, 'davc, 'eavd, 'fave, 'gavf, 'havg, 'iavh, 'javi, 'kavj, 'lavk, 'mavl, 'navm, 'oavn, 'pavo> = 
//        | Z16T of ('aav9) * ('bava) * ('cavb) * ('davc) * ('eavd) * ('fave) * ('gavf) * ('havg) * ('iavh) * ('javi) * ('kavj) * ('lavk) * ('mavl) * ('navm) * ('oavn) * ('pavo)
//
//    type Z17T<'aauQ, 'bauR, 'cauS, 'dauT, 'eauU, 'fauV, 'gauW, 'hauX, 'iauY, 'jauZ, 'kav0, 'lav1, 'mav2, 'nav3, 'oav4, 'pav5, 'qav6> = 
//        | Z17T of ('aauQ) * ('bauR) * ('cauS) * ('dauT) * ('eauU) * ('fauV) * ('gauW) * ('hauX) * ('iauY) * ('jauZ) * ('kav0) * ('lav1) * ('mav2) * ('nav3) * ('oav4) * ('pav5) * ('qav6)
//
//    type Z18T<'aauw, 'baux, 'cauy, 'dauz, 'eauA, 'fauB, 'gauC, 'hauD, 'iauE, 'jauF, 'kauG, 'lauH, 'mauI, 'nauJ, 'oauK, 'pauL, 'qauM, 'rauN> = 
//        | Z18T of ('aauw) * ('baux) * ('cauy) * ('dauz) * ('eauA) * ('fauB) * ('gauC) * ('hauD) * ('iauE) * ('jauF) * ('kauG) * ('lauH) * ('mauI) * ('nauJ) * ('oauK) * ('pauL) * ('qauM) * ('rauN)
//
//    type Z19T<'aaub, 'bauc, 'caud, 'daue, 'eauf, 'faug, 'gauh, 'haui, 'iauj, 'jauk, 'kaul, 'laum, 'maun, 'nauo, 'oaup, 'pauq, 'qaur, 'raus, 'saut> = 
//        | Z19T of ('aaub) * ('bauc) * ('caud) * ('daue) * ('eauf) * ('faug) * ('gauh) * ('haui) * ('iauj) * ('jauk) * ('kaul) * ('laum) * ('maun) * ('nauo) * ('oaup) * ('pauq) * ('qaur) * ('raus) * ('saut)
//
//    type Z20T<'aatP, 'batQ, 'catR, 'datS, 'eatT, 'fatU, 'gatV, 'hatW, 'iatX, 'jatY, 'katZ, 'lau0, 'mau1, 'nau2, 'oau3, 'pau4, 'qau5, 'rau6, 'sau7, 'tau8> = 
//        | Z20T of ('aatP) * ('batQ) * ('catR) * ('datS) * ('eatT) * ('fatU) * ('gatV) * ('hatW) * ('iatX) * ('jatY) * ('katZ) * ('lau0) * ('mau1) * ('nau2) * ('oau3) * ('pau4) * ('qau5) * ('rau6) * ('sau7) * ('tau8)

    let zdgtoZLz2cUZR<'ta8Nf, 't1a8Ng> : Lazy<GHC.Generics.ZCztZC<'ta8Nf, 't1a8Ng>> -> Lazy<Z2T<'ta8Nf, 't1a8Ng>> = 
        fun g3a18i ->
            lazy
            (
                let wildB1 = g3a18i in
                    match wildB1.Force() with
                    | GHC.Generics.ZCztZC (g1a18l, g2a18n)->
                        Z2T (g1a18l, g2a18n)
            )

    let zdgfromZLz2cUZR<'ta8Np, 't1a8Nq> : Lazy<Z2T<'ta8Np, 't1a8Nq>> -> Lazy<GHC.Generics.ZCztZC<'ta8Np, 't1a8Nq>> = 
        fun dsd9Oq ->
            lazy
            (
                let wildB1 = dsd9Oq in
                    match wildB1.Force() with
                    | Z2T (g1a13i, g2a13k)->
                        GHC.Generics.ZCztZC (g1a13i, g2a13k)
            )

