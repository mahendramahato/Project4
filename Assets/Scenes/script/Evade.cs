using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evade : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 3.0f;
    private float maxDistance = 5.0f;

    void Flee(Vector3 location){
        Vector3 dir = location - transform.position;

        if (dir.magnitude < maxDistance)
        {
            Vector3 moveVector = dir.normalized * moveSpeed * Time.deltaTime;

            transform.position -= moveVector;
        }
    }

    void Evades()
    {
        // subtracting two vectors will result in the desired direction
        Vector3 dir = target.position - transform.position;

        Vector3 targetVelocity = moveSpeed * dir;

        float lookAhead = dir.magnitude / (moveSpeed + targetVelocity.magnitude);

        Flee(target.position + targetVelocity * lookAhead);
    }

    // Update is called once per frame
    void Update()
    {
        Evades();
    }
}
