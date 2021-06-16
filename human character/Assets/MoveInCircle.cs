using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInCircle : MonoBehaviour
{
    // Start is called before the first frame update
    private float speed;
    private float radius;
    private float timeCounter;
    
    void Start()
    {
        speed = 2;
        radius = 2;
        timeCounter = 0;

    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        float x = (float)Math.Cos(timeCounter)*radius;
        float z = (float)Math.Sin(timeCounter) *radius;
        float y = 0;
        transform.position = new Vector3(x,y,z);

    }
}
