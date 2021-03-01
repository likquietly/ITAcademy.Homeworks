using System;
using HW._08.AssemblyOne;

namespace HW._08.AssemblyTwo
{
    //it is impossible to inherit, because it's available only in the assembly in which it's defined
    class SportBykeInternal //: MotorcycleInternal
    {
        public static void Meth()
        {
        }
    }
}