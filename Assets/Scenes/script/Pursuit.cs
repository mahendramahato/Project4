using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pursuit : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 5.0f;
    private float minDistance = 0.05f;

    void seek(Vector3 location){
        Vector3 dir = location - transform.position;

        if(dir.magnitude > minDistance)
        {
            Vector3 moveVector = dir.normalized * moveSpeed * Time.deltaTime;
            transform.position += moveVector;
        }
    }

    void Purse(){

        // subtracting two vectors will result in the desired direction
        Vector3 dir = target.position - transform.position;

        Vector3 targetVelocity = moveSpeed * dir;

        float lookAhead = dir.magnitude / (moveSpeed + targetVelocity.magnitude);

        seek(target.position + targetVelocity * lookAhead);

    }

    // Update is called once per frame
    void Update()
    {
        Purse();
    }
}
