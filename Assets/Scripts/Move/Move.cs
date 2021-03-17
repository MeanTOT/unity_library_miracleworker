using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MiracleWorker.Move
{
    public class Move
    {
        public void ExecuteToTargetWithTween(MonoBehaviour target, Vector3 dest, float duration)
        {
            target.StartCoroutine(Tween(target, dest, duration));
        }        

        IEnumerator Tween(MonoBehaviour target, Vector3 endPos, float duration)
        {
            var currentTime = 0.0f;
            var startPos = target.transform.position;
            while(currentTime < 1.0f)
            {
                currentTime += Time.deltaTime / duration;
                target.transform.position = Vector3.Lerp(startPos, endPos, currentTime);
                yield return null;
            }            
        }
    }
}
