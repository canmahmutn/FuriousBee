using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollBackGround : MonoBehaviour
{
    float ScrollSpeed = -5f;
    Vector2 StartPos;

    void Start()
    {
        StartPos = transform.position;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * ScrollSpeed, 21.7f);
        transform.position = StartPos + Vector2.right * newPos;
    }
}
