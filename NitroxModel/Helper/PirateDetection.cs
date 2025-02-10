using System;

namespace NitroxModel.Helper
{
    public static class PirateDetection
    {
        public static bool HasTriggered { get; private set; }

        public static event EventHandler PirateDetected
        {
            add { pirateDetected += value; }
            remove { pirateDetected -= value; }
        }

        public static bool TriggerOnDirectory(string subnauticaRoot)
        {
            // Always return false, effectively disabling the detection.
            return false;
        }

        private static event EventHandler pirateDetected;

        private static bool IsPirateByDirectory(string subnauticaRoot)
        {
            // Always return false to disable piracy detection.
            return false;
        }

        private static void OnPirateDetected()
        {
            // Do nothing to prevent triggering the detection.
        }
    }
}