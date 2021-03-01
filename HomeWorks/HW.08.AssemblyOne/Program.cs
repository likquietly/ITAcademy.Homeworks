using System;

namespace HW._08.AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            SportBykePublic.Meth();

            MotorcyclePublic mt = new MotorcyclePublic();

            //Private call from another PUBLIC class in the SAME assembly
            //It's inaccessible due to its protection level (only accessible from code in the same class or context)
            /*
            Console.WriteLine(MotorcyclePublic.MaxSpeedPrivate);
            mt.vinNumberPrivate = "vinNumberPrivate";
            mt.odometerPrivate = 26_000;
            mt.StartEnginePrivate();
            */

            //Public call from another PUBLIC class in the SAME assembly
            Console.WriteLine(MotorcyclePublic.MaxSpeedPublic);
            mt.vinNumberPublic = "vinNumberPublic";
            mt.odometerPublic = 25_000;
            mt.StartEnginePublic();

            //Protected call from another PUBLIC class in the SAME assembly
            //It's inaccessible due to its protection level (cause the class is not inherited)
            /*
            Console.WriteLine(MotorcyclePublic.MaxSpeedProtected);
            mt.vinNumberProtected = "vinNumberProtected";
            mt.odometerProtected = 25_000;
            mt.StartEngineProtected();
            */

            //Internal call from another PUBLIC class in the SAME assembly
            Console.WriteLine(MotorcyclePublic.MaxSpeedInternal);
            mt.vinNumberInternal = "vinNumberInternal";
            mt.odometerInternal = 25_000;
            mt.StartEngineInternal();

            //Protected-Internal call from another PUBLIC class in the SAME assembly
            Console.WriteLine(MotorcyclePublic.MaxSpeedProtectInternal);
            mt.vinNumberProtectInternal = "vinNumberProtectInternal";
            mt.odometerProtectInternal = 25_000;
            mt.StartEngineProtectInternal();

            //Protected-Private call from another PUBLIC class in the SAME assembly
            //It's inaccessible due to its protection level (cause the class is not derived)
            /*
            Console.WriteLine(MotorcyclePublic.MaxSpeedProtectPrivate);
            mt.vinNumberProtectPrivate = "vinNumberProtectPrivate";
            mt.odometerProtectPrivate = 25_000;
            mt.StartEngineProtectPrivate();
            */

            MotorcycleInternal mti = new MotorcycleInternal();

            //Private call from another INTERNAL class in the SAME assembly
            //It's inaccessible due to its protection level (only accessible from code in the same class or context)
            /*
            Console.WriteLine(MotorcycleInternal.MaxSpeedPrivate);
            mti.vinNumberPrivate = "vinNumberPrivate";
            mti.odometerPrivate = 26_000;
            mti.StartEnginePrivate();
            */

            //Public call from another INTERNAL class in the SAME assembly
            Console.WriteLine(MotorcycleInternal.MaxSpeedPublic);
            mti.vinNumberPublic = "vinNumberPublic";
            mti.odometerPublic = 25_000;
            mti.StartEnginePublic();

            //Protected call from another INTERNAL class in the SAME assembly
            //It's inaccessible due to its protection level (cause the class is not inherited)
            /*
            Console.WriteLine(MotorcycleInternal.MaxSpeedProtected);
            mti.vinNumberProtected = "vinNumberProtected";
            mti.odometerProtected = 25_000;
            mti.StartEngineProtected();
            */

            //Internal call from another INTERNAL class in the SAME assembly
            Console.WriteLine(MotorcycleInternal.MaxSpeedInternal);
            mti.vinNumberInternal = "vinNumberInternal";
            mti.odometerInternal = 25_000;
            mti.StartEngineInternal();

            //Protected-Internal call from another INTERNAL class in the SAME assembly
            Console.WriteLine(MotorcycleInternal.MaxSpeedProtectInternal);
            mti.vinNumberProtectInternal = "vinNumberProtectInternal";
            mti.odometerProtectInternal = 25_000;
            mti.StartEngineProtectInternal();

            //Protected-Private call from another INTERNAL class in the SAME assembly
            //It's inaccessible due to its protection level (cause the class is not derived)
            /*
            Console.WriteLine(MotorcycleInternal.MaxSpeedProtectPrivate);
            mti.vinNumberProtectPrivate = "vinNumberProtectPrivate";
            mti.odometerProtectPrivate = 25_000;
            mti.StartEngineProtectPrivate();
            */
        }
    }
}