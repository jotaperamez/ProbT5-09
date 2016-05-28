using UnityEngine;
using System.Collections;

public class instantiation : MonoBehaviour {
    GameObject cube;
    // Use this for initialization
    void Start()
    {

        
        


    }
    // Update is called once per frame
    void Update () {

        cube = GameObject.c
        cube.AddComponent<Rigidbody>();
        
        cube.transform.position = new Vector2(updatePosition(), 0);
        
    }

    int updatePosition()
    {
        return Random.Range(-10, 10);
    }
}
