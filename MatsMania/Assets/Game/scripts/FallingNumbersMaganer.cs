using UnityEngine;
using System.Collections;

public class FallingNumbersMaganer : MonoBehaviour {


    public GameObject ficha;
    public Sprite sprite;

	// Use this for initialization
	void Start () {
       
            
                
    }
	
	// Update is called once per frame
	void Update () {

        ficha.AddComponent<Rigidbody2D>();
        ficha.transform.position = new Vector2(updateX(),10);
    }

    public int updateX()
    {
        return Random.Range(-10, 10);
    }
}
