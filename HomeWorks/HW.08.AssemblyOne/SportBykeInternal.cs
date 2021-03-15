using System;

namespace HW._08.AssemblyOne
{
    class SportBykeInternal : MotorcycleInternal
    {
        public static void Meth()
        {
            SportBykeInternal sp = new SportBykeInternal();

            //Private call from another class that inherits from MotorcycleInternal in the SAME assembly
            //It's inaccessible due to its protection level (only accessible from code in the same class or context)
            /*
            Console.WriteLine(MotorcycleInternal.MaxSpeedPrivate);
            sp.vinNumberPrivate = "vinNumberPrivate";
            sp.odometerPrivate = 26_000;
            sp.StartEnginePrivate();
            */

            //Public call from another class that inherits from MotorcycleInternal in the SAME assembly
            Console.WriteLine(MotorcycleInternal.MaxSpeedPublic);
            sp.vinNumberPublic = "vinNumberPublic";
            sp.odometerPublic = 25_000;
            sp.StartEnginePublic();

            //Protected call from another class that inherits from MotorcycleInternal in the SAME assembly
            Console.WriteLine(MotorcycleInternal.MaxSpeedProtected);
            sp.vinNumberProtected = "vinNumberProtected";
            sp.odometerProtected = 25_000;
            sp.StartEngineProtected();

            //Internal call from another class that inherits from MotorcycleInternal in the SAME assembly
            Console.WriteLine(MotorcycleInternal.MaxSpeedInternal);
            sp.vinNumberInternal = "vinNumberInternal";
            sp.odometerInternal = 25_000;
            sp.StartEngineInternal();

            //Protected-Internal call from another class that inherits from MotorcycleInternal in the SAME assembly
            Console.WriteLine(MotorcycleInternal.MaxSpeedProtectInternal);
            sp.vinNumberProtectInternal = "vinNumberProtectInternal";
            sp.odometerProtectInternal = 25_000;
            sp.StartEngineProtectInternal();

            //Protected-Private call from another class that inherits from MotorcycleInternal in the SAME assembly
            Console.WriteLine(MotorcycleInternal.MaxSpeedProtectPrivate);
            sp.vinNumberProtectPrivate = "vinNumberProtectPrivate";
            sp.odometerProtectPrivate = 25_000;
            sp.StartEngineProtectPrivate();
        }
    }
}