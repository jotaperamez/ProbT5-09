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
            Application.LoadLevel(4);
        }


    }

    void OnMouseDown()
    {
        // this object was clicked - do something
        Debug.Log(Event.currentEval);
        Destroy(this.gameObject);
        Physics2D.gravity = new Vector2(Physics2D.gravity.x,Physics2D.gravity.y-6.5f);
        if (!Event.Evaluate(value))
        {
            Application.LoadLevel(4);
        }

         FallingNumbersMaganer.puntuador++;
        int aux = FallingNumbersMaganer.puntuador;
        ScreenMessagesController.instance.setScore(aux);

    }
}
