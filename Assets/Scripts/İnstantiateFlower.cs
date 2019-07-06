using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class İnstantiateFlower : MonoBehaviour
{
    public GameObject myflowers = null;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myflowers,transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
