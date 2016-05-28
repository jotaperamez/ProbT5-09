using UnityEngine;
using System.Collections;

public class FallingNumbers : MonoBehaviour {

    public int numero;

	// Use this for initialization
	void Start () {
      
    }
	

	// Update is called once per frame
	void Update () {

        transform.Translate(new Vector2(0, -10) * Time.deltaTime);

        if (Input.GetMouseButtonDown(0))
        {
            Destroy(this);
       }

    }
}
