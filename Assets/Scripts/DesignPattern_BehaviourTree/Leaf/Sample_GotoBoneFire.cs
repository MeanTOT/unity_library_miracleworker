using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker
{
    public class Sample_GotoBoneFire : Node
    {
        private Sample_Data mData;

        public Sample_GotoBoneFire(Sample_Data Data)
        {
            this.mData = Data;
        }

        public override EState Evaluate()
        {
            if (mData.BoneFirePos != null)
            {
                if (Vector3.Distance(mData.BoneFirePos.position, mData.AiPos.position) <= 2.0f)
                {
                    Debug.Log("������!");
                    return EState.Success;
                }
                else
                {
                    mData.AiPos.Translate((mData.BoneFirePos.position - mData.AiPos.position).normalized * Time.deltaTime * 5.0f);
                    Debug.Log("����������!");
                    return EState.Running;
                }
            }

            return EState.Failure;
        }
    }
}
