using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashController : MonoBehaviour
{
    public GameObject uiobject;
    public GameObject uiobject2;
    public bool control = false;
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
            control = true;
        }
    }
    private void Update()
    {
        if (control)
        {
            if(Input.GetMouseButton(0))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

}
