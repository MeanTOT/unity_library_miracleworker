using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker
{
    public class Sample_GameActor : MonoBehaviour
    {
        private StateMachine mSM;
        public Sample_Idle Idle;
        public Sample_Move Move;

        private void Start()
        {
            mSM = new StateMachine();

            Idle = new Sample_Idle(this, mSM);
            Move = new Sample_Move(this, mSM);

            mSM.Init(Idle);
        }

        private void Update()
        {
            mSM.State.LogicUpdate();
        }

        private void FixedUpdate()
        {
            mSM.State.PhysicsUpdate();
        }
    }
}
