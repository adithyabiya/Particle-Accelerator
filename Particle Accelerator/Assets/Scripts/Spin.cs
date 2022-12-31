using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public Transform Target;
    public float speed = 10f;
    
    // Update is called once per frame
    void Update()
    {
        speed = (speed + Time.deltaTime)*1.0002f ;
        transform.RotateAround(Target.position, Vector3.up, speed * Time.deltaTime);
    }
}
