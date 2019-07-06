using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public Sprite Bee;
    public Sprite Flame;
    //public float speedd;


    // Start is called before the first frame update
    public void ChangerFlame()
    {
        //speedd = gameObject.GetComponent<Yorunge>().speed;
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Flame;
    }
    public void ChangerBee()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Bee;
    }
}
