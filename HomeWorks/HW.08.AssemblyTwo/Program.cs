using System;
using HW._08.AssemblyOne;

namespace HW._08.AssemblyTwo
{
    class Program 
    {
        static void Main(string[] args)
        {
            MotorcyclePublic mt = new MotorcyclePublic();

            //Private call from another PUBLIC class in ANOTHER assembly
            //It's inaccessible due to its protection level (only accessible from code in the same class or context)
            /*
            Console.WriteLine(Motorcycle.MaxSpeedPrivate);
            mt.vinNumberPrivate = "vinNumberPrivate";
            mt.odometerPrivate = 26_000;
            mt.StartEnginePrivate();
            */

            //Public call from another PUBLIC class in ANOTHER assembly
            Console.WriteLine(MotorcyclePublic.MaxSpeedPublic);
            mt.vinNumberPublic = "vinNumberPublic";
            mt.odometerPublic = 25_000;
            mt.StartEnginePublic();

            //Protected call from another PUBLIC class in ANOTHER assembly
            //It's inaccessible due to its protection level (cause the class is not inherited)
            /*
            Console.WriteLine(Motorcycle.MaxSpeedProtected);
            mt.vinNumberProtected = "vinNumberProtected";
            mt.odometerProtected = 25_000;
            mt.StartEngineProtected();
            */

            //Internal call from another PUBLIC class in ANOTHER assembly
            //It's inaccessible due to its protection level (cause it's called from another assembly)
            /*
            Console.WriteLine(Motorcycle.MaxSpeedInternal);
            mt.vinNumberInternal = "vinNumberInternal";
            mt.odometerInternal = 25_000;
            mt.StartEngineInternal();
            */

            //Protected-Internal call from another PUBLIC class in ANOTHER assembly
            //It's inaccessible due to its protection level (cause it's called from another assembly and doesn't inherited)
            /*
            Console.WriteLine(Motorcycle.MaxSpeedProtectInternal);
            mt.vinNumberProtectInternal = "vinNumberProtectInternal";
            mt.odometerProtectInternal = 25_000;
            mt.StartEngineProtectInternal();
            */

            //Protected-Private call from another PUBLIC class in ANOTHER assembly
            //It's inaccessible due to its protection level (cause it's called from another assembly)
            /*
            Console.WriteLine(Motorcycle.MaxSpeedProtectPrivate);
            mt.vinNumberProtectPrivate = "vinNumberProtectPrivate";
            mt.odometerProtectPrivate = 25_000;
            mt.StartEngineProtectPrivate();
            */

            //It's inaccessible due to its protection level
            //Because INTEGRAL class available only in the assembly in which it's defined
            /*
            MotorcycleInternal mti = new MotorcycleInternal();
            */
        }
    }
}