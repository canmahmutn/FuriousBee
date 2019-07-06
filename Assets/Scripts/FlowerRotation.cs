using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerRotation : MonoBehaviour
{
    public float ScrollSpeed = -10f;
    Vector2 StartPos;

    public float counter = 0;

    void Start()
    {
        StartPos = transform.position *1.7f;
    }

    void Update()
    {
        float newPos = Mathf.Repeat(Time.time * ScrollSpeed, 30f);
        transform.position = StartPos + Vector2.right * newPos;
        counter = counter + Time.deltaTime;
        transform.Rotate(0,0,500*Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D col1)
    {
        if (col1.gameObject.tag == "Player")
        {

        }
    }
}
