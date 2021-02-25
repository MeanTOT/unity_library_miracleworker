using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker
{
    public class Sample_Player : Sample_GameActor
    {
        public Sample_Idle Idle = null;

        private StateMachine mSM = null;

        private void Start()
        {
            mSM = new StateMachine();

            Idle = new Sample_Idle(this, mSM);

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
