using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace MiracleWorker
{
    [Serializable]
    public class Sample_Data
    {
        public float Starving;
        public Transform BoneFirePos;
        public Transform AiPos;
    }

    public class Sample_EnemyAI : MonoBehaviour
    {
        [SerializeField] private Sample_Data mData;

        private Sample_IsNoHungry mIsNoHungry;
        private Sample_GotoBoneFire mGoToBoneFire;
        private Sample_DoHunting mDoHunting;

        private Sequence mRest;
        private Sequence mHunting;
        private Selector mTop;

        private void Awake()
        {
            mIsNoHungry = new Sample_IsNoHungry(mData);
            mGoToBoneFire = new Sample_GotoBoneFire(mData);
            mDoHunting = new Sample_DoHunting(mData);

            mRest = new Sequence(new List<Node> { mIsNoHungry, mGoToBoneFire });
            mHunting = new Sequence(new List<Node> { mDoHunting });

            mTop = new Selector(new List<Node> { mRest, mHunting });
        }

        private void Update()
        {
            mTop.Evaluate();

            mData.Starving -= Time.deltaTime * 8.0f;
        }
    }
}
