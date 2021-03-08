using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker
{
    public class Sample_IsNoHungry : Node
    {
        private Sample_Data mData;

        public Sample_IsNoHungry(Sample_Data data)
        {
            mData = data;
        }

        public override EState Evaluate()
        {
            if (mData.Starving >= 50.0f)
            {
                return EState.Success;
            }

            Debug.Log("¹è°íÆÄ!");

            return EState.Failure;
        }
    }
}
