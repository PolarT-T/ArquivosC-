using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothing;

    public Vector2 maxPos;
    public Vector2 minPos;

    private void FixedUpdate()
    {
      if(transform.position != target.position)
        {
            Vector2 targetPos = new Vector2(target.position.x, target.position.y);

            targetPos.x = Mathf.Clamp(target.position.x, minPos.x, maxPos.x);
            targetPos.x = Mathf.Clamp(target.position.x, minPos.x, maxPos.x);

            transform.position = Vector2.Lerp(transform.position, targetPos, smoothing);
        }
    }

}
