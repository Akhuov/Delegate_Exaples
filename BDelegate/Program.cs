using BDelegate;
using static BDelegate.A_SimpleDelegete;

// WithParameters withParameters = new WithParameters(Methods.Sum);
// method bilan delegateni bog'lashning ya'na bitta usuli
NoPrameters noPrameter1 = Methods.Method_1;
noPrameter1 += Methods.Method_1;
noPrameter1 += Methods.Method_2;
noPrameter1 += Methods.Method_2;
noPrameter1 += Methods.Method_2;
noPrameter1 += Methods.Method_2;
noPrameter1 -= Methods.Method_2;

// Savol? Methods.Method_2 qay tartibda oladi, boshidanmi, oxiridanmi?

NoPrameters noPrameter2 = Methods.Method_1;
NoPrameters noPrameter3 = noPrameter1 + noPrameter2;

// Savol? noPrameter2 bilan noPrameter1 ni joyini almashtirsak?
// NoPrameters noPrameter3 = noPrameter2 + noPrameter1;

NoPrameters noPrameter4 = noPrameter1 - noPrameter2;

// Savol? noPrameter2 - noPrameter1 natija nima?

bool birinchiUsulmi = false;

if (birinchiUsulmi)
{
    noPrameter1();
}
else
{
    //noPrameter1.Invoke();
}


if (false)
{
    noPrameter3();
}
else
{
    noPrameter4();
}
