using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlowerRotation : MonoBehaviour
{
    public float ScrollSpeed = -10f;
    Vector2 StartPos;

    public float counter = 0;

    public void Start()
    {
        StartPos =  new Vector2(-8.758033f,3.55f);
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * ScrollSpeed, 30f);

        //transform.position = StartPos + Vector2.right * newPos;
        transform.position=new Vector2((transform.position.x +ScrollSpeed),transform.position.y);
        counter = counter + Time.deltaTime;
        transform.Rotate(0,0,500*Time.deltaTime);
    }

}
