using UnityEngine;
using System.Collections;

public class FallingNumber : MonoBehaviour {

    
    public int value;
	// Use this for initialization
	void Start () {

	}

    public void setValue(int entrada)
    {
        this.value = entrada;
    }
	

    

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.name=="floor")
            GameObject.Destroy(gameObject);
        if (Event.Evaluate(value))
        {
            Application.LoadLevel(1);
        }


    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        Debug.Log(Event.currentEval);
        Destroy(this.gameObject);
        if (!Event.Evaluate(value))
        {
            Application.LoadLevel(1);
        }
    }
}
