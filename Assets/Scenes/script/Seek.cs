using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{

    public Transform target;
    public float moveSpeed = 5.0f;
    private float minDistance = 0.05f;

    // Update is called once per frame
    void Update()
    {
        // call to the function every frame
        SeekTarget();  
    }

    void SeekTarget()
    {
        // subtracting two vectors will result in the desired direction
        Vector3 dir = target.position - transform.position;

        //Simple check to see if we continue seeking the target or if we are already at our desired distance from target
        //If the case check true, we continue moving towards our target
        if(dir.magnitude > minDistance)
        {
            Vector3 moveVector = dir.normalized * moveSpeed * Time.deltaTime;

            transform.position += moveVector;
        }
    }
}
