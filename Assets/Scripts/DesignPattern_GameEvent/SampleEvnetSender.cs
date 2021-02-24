using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker
{
    public class SampleEvnetSender : MonoBehaviour
    {
        private void Awake()
        {
            GameEvent.SampleEvent(5);            
        }
    }
}
