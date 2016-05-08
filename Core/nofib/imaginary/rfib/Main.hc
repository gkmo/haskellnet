/* GHC_PACKAGES base integer ghc-prim rts
*/
#include "Stg.h"
EI_(base_SystemziIO_print_closure);
EI_(base_GHCziShow_zdf16_closure);
static StgWord rvC_srt[] = {
(W_)&base_SystemziIO_print_closure, (W_)&base_GHCziShow_zdf16_closure
};

II_(rvC_info);
static StgWord rvC_closure[] = {
(W_)&rvC_info, 0x0, 0x0, 0x0
};

static StgWord rvC_info[] = {
((W_)&rvC_srt+0), 0x0, 0x30016U
};

EI_(base_SystemziIO_print_closure);
EI_(base_GHCziShow_zdf16_closure);
IF_(rvC_entry) {
FB_
if ((W_)(((W_)Sp - 0xcU) < (W_)SpLim)) goto _cwf;
Hp=Hp+2;
if ((W_)((W_)Hp > (W_)HpLim)) goto _cwf;
Hp[-1] = (W_)&stg_CAF_BLACKHOLE_info;
;EF_(newCAF);
{void (*ghcFunPtr)(void *);
ghcFunPtr = ((void (*)(void *))(W_)&newCAF);
ghcFunPtr((void *)R1.w);;}
R1.p[1] = (W_)Hp-4;
*R1.p = (W_)&stg_IND_STATIC_info;
Sp[-2] = (W_)&stg_upd_frame_info;
Sp[-1] = (W_)Hp-4;
R1.w = (W_)&base_SystemziIO_print_closure;
Sp[-3] = (W_)&base_GHCziShow_zdf16_closure;
Sp=Sp-3;
JMP_((W_)&stg_ap_p_fast);
_cwf:
HpAlloc = 0x8U;
JMP_(stg_gc_enter_1);
FE_
}
EI_(base_GHCziBase_zdf1_closure);
EI_(base_GHCziNum_zdf6_closure);
II_(rfo_closure);
static StgWord rfo_srt[] = {
(W_)&base_GHCziBase_zdf1_closure, (W_)&base_GHCziNum_zdf6_closure, (W_)&rfo_closure
};

II_(rfo_info);
static StgWord rfo_closure[] = {
(W_)&rfo_info, 0x0
};

static StgWord svU_info[] = {
((W_)&rfo_srt+4), 0x1U, 0x10011U
};

EI_(base_GHCziNum_zm_info);
EI_(base_GHCziNum_zdf6_closure);
IF_(svU_entry) {
FB_
if ((W_)(((W_)Sp - 0x18U) < (W_)SpLim)) goto _cwB;
Sp[-2] = (W_)&stg_upd_frame_info;
Sp[-1] = R1.w;
Sp[-3] = (W_)&stg_INTLIKE_closure+145;
Sp[-4] = R1.p[2];
Sp[-5] = (W_)&stg_ap_pp_info;
Sp[-6] = (W_)&base_GHCziNum_zdf6_closure;
Sp=Sp-6;
JMP_((W_)&base_GHCziNum_zm_info);
_cwB:
JMP_(stg_gc_enter_1);
FE_
}

static StgWord svW_info[] = {
((W_)&rfo_srt+4), 0x1U, 0x30011U
};

II_(rfo_info);
II_(svU_info);
IF_(svW_entry) {
FB_
if ((W_)(((W_)Sp - 0xcU) < (W_)SpLim)) goto _cwE;
Hp=Hp+3;
if ((W_)((W_)Hp > (W_)HpLim)) goto _cwE;
Sp[-2] = (W_)&stg_upd_frame_info;
Sp[-1] = R1.w;
Hp[-2] = (W_)&svU_info;
*Hp = R1.p[2];
Sp[-3] = (W_)Hp-8;
Sp=Sp-3;
JMP_((W_)&rfo_info);
_cwE:
HpAlloc = 0xcU;
JMP_(stg_gc_enter_1);
FE_
}

static StgWord svO_info[] = {
((W_)&rfo_srt+4), 0x1U, 0x10011U
};

EI_(base_GHCziNum_zm_info);
EI_(base_GHCziNum_zdf6_closure);
IF_(svO_entry) {
FB_
if ((W_)(((W_)Sp - 0x18U) < (W_)SpLim)) goto _cwL;
Sp[-2] = (W_)&stg_upd_frame_info;
Sp[-1] = R1.w;
Sp[-3] = (W_)&stg_INTLIKE_closure+137;
Sp[-4] = R1.p[2];
Sp[-5] = (W_)&stg_ap_pp_info;
Sp[-6] = (W_)&base_GHCziNum_zdf6_closure;
Sp=Sp-6;
JMP_((W_)&base_GHCziNum_zm_info);
_cwL:
JMP_(stg_gc_enter_1);
FE_
}

static StgWord svQ_info[] = {
((W_)&rfo_srt+4), 0x1U, 0x30011U
};

II_(rfo_info);
II_(svO_info);
IF_(svQ_entry) {
FB_
if ((W_)(((W_)Sp - 0xcU) < (W_)SpLim)) goto _cwO;
Hp=Hp+3;
if ((W_)((W_)Hp > (W_)HpLim)) goto _cwO;
Sp[-2] = (W_)&stg_upd_frame_info;
Sp[-1] = R1.w;
Hp[-2] = (W_)&svO_info;
*Hp = R1.p[2];
Sp[-3] = (W_)Hp-8;
Sp=Sp-3;
JMP_((W_)&rfo_info);
_cwO:
HpAlloc = 0xcU;
JMP_(stg_gc_enter_1);
FE_
}

static StgWord svY_info[] = {
((W_)&rfo_srt+4), 0x1U, 0x30011U
};

EI_(base_GHCziNum_zp_info);
EI_(base_GHCziNum_zdf6_closure);
II_(svQ_info);
II_(svW_info);
IF_(svY_entry) {
FB_
if ((W_)(((W_)Sp - 0x18U) < (W_)SpLim)) goto _cwR;
Hp=Hp+6;
if ((W_)((W_)Hp > (W_)HpLim)) goto _cwR;
Sp[-2] = (W_)&stg_upd_frame_info;
Sp[-1] = R1.w;
Hp[-5] = (W_)&svW_info;
Hp[-3] = R1.p[2];
Hp[-2] = (W_)&svQ_info;
*Hp = R1.p[2];
Sp[-3] = (W_)Hp-20;
Sp[-4] = (W_)Hp-8;
Sp[-5] = (W_)&stg_ap_pp_info;
Sp[-6] = (W_)&base_GHCziNum_zdf6_closure;
Sp=Sp-6;
JMP_((W_)&base_GHCziNum_zp_info);
_cwR:
HpAlloc = 0x18U;
JMP_(stg_gc_enter_1);
FE_
}

static StgWord swi_info[] = {
((W_)&rfo_srt+4), 0x1U, 0x30022U
};

EI_(base_GHCziNum_zp_info);
EI_(base_GHCziNum_zdf6_closure);
II_(svY_info);
IF_(swi_ret) {
W_ _cwU;
FB_
_cwU = R1.w & 0x3U;
if ((W_)(_cwU >= 0x2U)) goto _cwW;
Hp=Hp+3;
if ((W_)((W_)Hp > (W_)HpLim)) goto _cwY;
Hp[-2] = (W_)&svY_info;
*Hp = Sp[1];
Sp[1] = (W_)&stg_INTLIKE_closure+137;
*Sp = (W_)Hp-8;
Sp[-1] = (W_)&stg_ap_pp_info;
Sp[-2] = (W_)&base_GHCziNum_zdf6_closure;
Sp=Sp-2;
JMP_((W_)&base_GHCziNum_zp_info);
_cwW:
R1.w = (W_)&stg_INTLIKE_closure+137;
Sp=Sp+2;
JMP_(*Sp);
_cwY:
HpAlloc = 0xcU;
JMP_(stg_gc_enter_1);
FE_
}

static StgWord rfo_info[] = {
((W_)&rfo_srt+0), 0x10005U, 0x0, 0x7000fU
};

EI_(base_GHCziClasses_zlze_info);
EI_(base_GHCziBase_zdf1_closure);
II_(rfo_closure);
II_(swi_info);
IF_(rfo_entry) {
FB_
if ((W_)(((W_)Sp - 0x14U) < (W_)SpLim)) goto _cx1;
Sp[-2] = (W_)&stg_INTLIKE_closure+137;
Sp[-3] = *Sp;
Sp[-4] = (W_)&stg_ap_pp_info;
Sp[-5] = (W_)&base_GHCziBase_zdf1_closure;
Sp[-1] = (W_)&swi_info;
Sp=Sp-5;
JMP_((W_)&base_GHCziClasses_zlze_info);
_cx1:
R1.w = (W_)&rfo_closure;
JMP_(stg_gc_fun);
FE_
}
II_(rfo_closure);
static StgWord sw5_srt[] = {
(W_)&rfo_closure
};

II_(sw5_info);
static StgWord sw5_closure[] = {
(W_)&sw5_info, 0x0, 0x0, 0x0
};

static StgWord sw5_info[] = {
((W_)&sw5_srt+0), 0x0, 0x10016U
};

EI_(ghczmprim_GHCziTypes_Izh_con_info);
II_(rfo_info);
IF_(sw5_entry) {
FB_
if ((W_)(((W_)Sp - 0xcU) < (W_)SpLim)) goto _cxb;
Hp=Hp+4;
if ((W_)((W_)Hp > (W_)HpLim)) goto _cxb;
Hp[-3] = (W_)&stg_CAF_BLACKHOLE_info;
;EF_(newCAF);
{void (*ghcFunPtr)(void *);
ghcFunPtr = ((void (*)(void *))(W_)&newCAF);
ghcFunPtr((void *)R1.w);;}
R1.p[1] = (W_)Hp-12;
*R1.p = (W_)&stg_IND_STATIC_info;
Sp[-2] = (W_)&stg_upd_frame_info;
Sp[-1] = (W_)Hp-12;
Hp[-1] = (W_)&ghczmprim_GHCziTypes_Izh_con_info;
*Hp = 0x1eU;
Sp[-3] = (W_)Hp-3;
Sp=Sp-3;
JMP_((W_)&rfo_info);
_cxb:
HpAlloc = 0x10U;
JMP_(stg_gc_enter_1);
FE_
}
II_(rvC_closure);
II_(sw5_closure);
static StgWord Main_main_srt[] = {
(W_)&rvC_closure, (W_)&sw5_closure
};

EI_(Main_main_info);
StgWord Main_main_closure[] = {
(W_)&Main_main_info, 0x0, 0x0, 0x0
};

StgWord Main_main_info[] = {
((W_)&Main_main_srt+0), 0x0, 0x30016U
};

II_(rvC_closure);
II_(sw5_closure);
FN_(Main_main_entry) {
FB_
if ((W_)(((W_)Sp - 0xcU) < (W_)SpLim)) goto _cxl;
Hp=Hp+2;
if ((W_)((W_)Hp > (W_)HpLim)) goto _cxl;
Hp[-1] = (W_)&stg_CAF_BLACKHOLE_info;
;EF_(newCAF);
{void (*ghcFunPtr)(void *);
ghcFunPtr = ((void (*)(void *))(W_)&newCAF);
ghcFunPtr((void *)R1.w);;}
R1.p[1] = (W_)Hp-4;
*R1.p = (W_)&stg_IND_STATIC_info;
Sp[-2] = (W_)&stg_upd_frame_info;
Sp[-1] = (W_)Hp-4;
R1.w = (W_)&rvC_closure;
Sp[-3] = (W_)&sw5_closure;
Sp=Sp-3;
JMP_((W_)&stg_ap_p_fast);
_cxl:
HpAlloc = 0x8U;
JMP_(stg_gc_enter_1);
FE_
}
EI_(base_GHCziTopHandler_runMainIO_closure);
EI_(Main_main_closure);
static StgWord ZCMain_main_srt[] = {
(W_)&base_GHCziTopHandler_runMainIO_closure, (W_)&Main_main_closure
};

EI_(ZCMain_main_info);
StgWord ZCMain_main_closure[] = {
(W_)&ZCMain_main_info, 0x0, 0x0, 0x0
};

StgWord ZCMain_main_info[] = {
((W_)&ZCMain_main_srt+0), 0x0, 0x30016U
};

EI_(base_GHCziTopHandler_runMainIO_closure);
EI_(Main_main_closure);
FN_(ZCMain_main_entry) {
FB_
if ((W_)(((W_)Sp - 0xcU) < (W_)SpLim)) goto _cxv;
Hp=Hp+2;
if ((W_)((W_)Hp > (W_)HpLim)) goto _cxv;
Hp[-1] = (W_)&stg_CAF_BLACKHOLE_info;
;EF_(newCAF);
{void (*ghcFunPtr)(void *);
ghcFunPtr = ((void (*)(void *))(W_)&newCAF);
ghcFunPtr((void *)R1.w);;}
R1.p[1] = (W_)Hp-4;
*R1.p = (W_)&stg_IND_STATIC_info;
Sp[-2] = (W_)&stg_upd_frame_info;
Sp[-1] = (W_)Hp-4;
R1.w = (W_)&base_GHCziTopHandler_runMainIO_closure;
Sp[-3] = (W_)&Main_main_closure;
Sp=Sp-3;
JMP_((W_)&stg_ap_p_fast);
_cxv:
HpAlloc = 0x8U;
JMP_(stg_gc_enter_1);
FE_
}
static StgWord _module_registered[] = {
0x0
};


EF_(__stginit_base_Prelude_);
EF_(__stginit_base_GHCziTopHandler_);
FN_(__stginit_Main_) {
FB_
if ((W_)(0x0 != (*((P_)(W_)&_module_registered)))) goto _cxB;
goto _cxD;
_cxB:
Sp=Sp+1;
JMP_(Sp[-1]);
_cxD:
*((P_)(W_)&_module_registered) = 0x1U;
Sp=Sp-1;
*Sp = (W_)&__stginit_base_Prelude_;
Sp=Sp-1;
*Sp = (W_)&__stginit_base_GHCziTopHandler_;
goto _cxB;
FE_
}


EF_(__stginit_Main_);
FN_(__stginit_Main) {
FB_
JMP_((W_)&__stginit_Main_);
FE_
}


FN_(__stginit_ZCMain) {
FB_
Sp=Sp+1;
JMP_(Sp[-1]);
FE_
}
