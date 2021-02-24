using System;
using UnityEngine;

namespace MiracleWorker
{
    public static class GameEvent
    {
        public static event Action<int> onSampleEvent;
        public static void SampleEvent(int id)
        {
            if (onSampleEvent != null)
            {
                onSampleEvent(id);                
            }

            Debug.Log("SampleEvent");
        }
    }
}
