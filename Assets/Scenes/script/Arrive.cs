using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrive : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 6.0f;
    public float minDistance = 0.05f;
    private float speedFactor = 1.0f;

    // Update is called once per frame
    void Update()
    {
        ArriveAtTarget();   
    }

    void ArriveAtTarget()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        if (distance > 10.0f) speedFactor = 1.0f;
        else if (distance < 3.0f) speedFactor = 5.0f;
        else speedFactor = 3.0f;

        //Subtracting two vectors by each will result in the desired direction
        Vector3 dir = target.position - transform.position;

        //Simple check to see if we continue seeking the target or if we are
        //already at our desired distance from target
        if (dir.magnitude > minDistance)
        {
        Vector3 moveVector = (dir.normalized * moveSpeed * Time.deltaTime)/speedFactor;

        //If the case check true, we continue moving towards our target
        transform.position += moveVector;
        }
    }

}
