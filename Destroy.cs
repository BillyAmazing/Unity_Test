using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Destroys the gameobject where the script is attached to
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
