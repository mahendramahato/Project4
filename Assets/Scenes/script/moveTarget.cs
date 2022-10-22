using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTarget : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            UpdateTargetPosition();
        }
    }

    void UpdateTargetPosition()
    {
        if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hit, 100))
        {
            transform.position = hit.point;
        }
    }
}
