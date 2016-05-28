using UnityEngine;
using System.Collections;

public class instantiation : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        for (int y = -5; y <0; y++)
        {
            for (int x = 0; x < 2; x++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.AddComponent<Rigidbody>();
                cube.transform.position = new Vector2(x, y);
            }
        }
    }

    // Update is called once per frame
    void Update () {
	
	}
}
