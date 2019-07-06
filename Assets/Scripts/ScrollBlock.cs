using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBlock : MonoBehaviour
{
    public float ScrollSpeed = -10f;
    Vector2 StartPos;
    public Transform obje;
//    public float counter = 0;

    void Start()
    {
        StartPos = obje.transform.position;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * ScrollSpeed, 23f);
        transform.position = StartPos + Vector2.right * newPos;
//        counter = counter + Time.deltaTime;
//       if (counter >=15)
//       {
//           ScrollSpeed += ScrollSpeed * Time.deltaTime/200;
//
//       }

    }



}
