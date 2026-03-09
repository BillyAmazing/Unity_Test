using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    // Define the variables: level and lives
    public int level = 2;
    public int lives = 3;
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {// Add the amount of lives to level to get a new number for the lives varibale
        lives += level;
        print(lives);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
