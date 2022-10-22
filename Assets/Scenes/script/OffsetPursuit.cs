using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetPursuit : MonoBehaviour
{

    public Transform target;
    public float moveSpeed = 5.0f;
    private float minDistance = 0.05f;
    private float offsetDistance = 3.10f;

    void seek(Vector3 location){
        Vector3 dir = location - transform.position;
        Vector3 moveVector = dir.normalized * moveSpeed * Time.deltaTime; 
        if(dir.magnitude > minDistance)
        {       
            if(dir.magnitude < offsetDistance){
                transform.position -= moveVector + dir.normalized ;
            }
            transform.position += moveVector;
        }
    }


    void OffsetPurse()
    {

      // subtracting two vectors will result in the desired direction
      Vector3 dir = target.position - transform.position;

      Vector3 targetVelocity = moveSpeed * dir;

      float lookAhead = dir.magnitude / (moveSpeed + targetVelocity.magnitude);

      seek(target.position + targetVelocity * lookAhead);
    }

    // Update is called once per frame
    void Update()
    {
        OffsetPurse();
    }
}
