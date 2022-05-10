using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationalObject : MonoBehaviour
{
    public float rollSpeed = 15f;
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rollSpeed * Time.deltaTime);
    }
}
