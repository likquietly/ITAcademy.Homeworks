using System;

namespace HW._08.AssemblyOne
{
    class MotorcycleInternal
    {
        //Private
        const ushort MaxSpeedPrivate = 300;
        string vinNumberPrivate = "2CCC345345-34HFD8943-F435-JFW54645-F43856";
        int odometerPrivate = 20_000;

        void StartEnginePrivate()
        {
        }

        //Public
        public const ushort MaxSpeedPublic = 600;
        public string vinNumberPublic = "2CCC345345-34HFD1238943-F431235-H234589235";
        public int odometerPublic = 12_000;

        public void StartEnginePublic()
        {
        }

        //Protected
        protected const ushort MaxSpeedProtected = 700;
        protected string vinNumberProtected = "2CCC345345-34HFD82343-F435-H234589235";
        protected int odometerProtected = 13_000;

        protected void StartEngineProtected()
        {
        }

        //Internal
        internal const ushort MaxSpeedInternal = 800;
        internal string vinNumberInternal = "2CCC345345-34HFD8556943-F435-H234589235";
        internal int odometerInternal = 17_000;

        internal void StartEngineInternal()
        {
        }

        //Protected-Internal
        protected internal const ushort MaxSpeedProtectInternal = 500;
        protected internal string vinNumberProtectInternal = "2CCC345345-34HFD8556943-F435-H234589235";
        protected internal int odometerProtectInternal = 18_000;

        protected internal void StartEngineProtectInternal()
        {
        }

        //Protected-Private
        protected private const ushort MaxSpeedProtectPrivate = 900;
        protected private string vinNumberProtectPrivate = "2CCC345345-34HF943-F435-H234589235";
        protected private int odometerProtectPrivate = 24_000;

        protected private void StartEngineProtectPrivate()
        {
        }
    }
}