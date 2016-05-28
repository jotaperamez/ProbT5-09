using UnityEngine;
using System.Collections;

public class FallingNumber : MonoBehaviour {

    public int value;
	// Use this for initialization
	void Start () {

        value = Random.Range(0, 100);

	}
	

    

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name=="floor")
        GameObject.Destroy(gameObject);

    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        Destroy(this.gameObject);
    }
}
