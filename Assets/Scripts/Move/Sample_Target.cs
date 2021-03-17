using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker.Move
{
    public class Sample_Target : MonoBehaviour
    {
        Move move;

        private void Awake()
        {
            move = new Move();
        }

        void Start()
        {
            move.ExecuteToTargetWithTween(this, new Vector3(10.0f, 0.0f, 0.0f), 10.0f);
        }

        // Update is called once per frame
        void Update()
        {

            //Debug.Log(Time.deltaTime);
        }

        private void FixedUpdate()
        {
            
        }
    }
}
