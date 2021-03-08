using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker
{
    public class Sample_DoHunting : Node
    {
        private Sample_Data mData;

        public Sample_DoHunting(Sample_Data Data)
        {
            this.mData = Data;
        }

        public override EState Evaluate()
        {
            Sample_Animal[] animals = GameObject.FindObjectsOfType<Sample_Animal>();

            if (animals.Length > 0)
            {
                if (Vector3.Distance(animals[0].transform.position, mData.AiPos.position) <= 2.0f)
                {
                    mData.Starving = 100.0f;
                    return EState.Success;
                }
                else
                {
                    mData.AiPos.Translate((animals[0].transform.position - mData.AiPos.position).normalized * Time.deltaTime * 5.0f);
                    Debug.Log("사냥하러가야지!");
                    return EState.Running;
                }                
            }

            return EState.Failure;
        }
    }
}
