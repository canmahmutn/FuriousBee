using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashController : MonoBehaviour
{
    public GameObject uiobject;
    public GameObject uiobject2;
    private void Start() {
        uiobject.SetActive(false);
        uiobject2.SetActive(false);
    }
     private void OnTriggerEnter2D(Collider2D col1)
    {
        if (col1.gameObject.tag == "Player")
        {
            uiobject.SetActive(true);
            uiobject2.SetActive(true);
            Application.Quit();
        }
    }
}
