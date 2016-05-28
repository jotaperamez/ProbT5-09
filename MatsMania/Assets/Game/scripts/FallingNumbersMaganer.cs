using UnityEngine;
using System.Collections;

public class FallingNumbersMaganer : MonoBehaviour
{


    public GameObject ficha;
    public Sprite sprite;
    public Camera camara;


    private RaycastHit rHit;


    public Transform topLeft;
    public Transform topLRight;
    //public Transform bottom;


    // Use this for initialization
    void Start()
    {

        StartCoroutine(createFicha());

    }

    // Update is called once per frame
    void Update()
    {


    }

   

    public float updateX()
    {

        float minx = camara.ViewportToWorldPoint(new Vector2(0, 1)).x;
        float maxx = camara.ViewportToWorldPoint(new Vector2(1, 0)).x;

        int rnd = Random.Range(0, 4);
        return minx +0.5F+ (maxx - minx) / 4 * rnd;
        //return Random.Range(minX, maxX);

        
    }

    //CO-RUTINA
    public IEnumerator createFicha()
    {
        while (true)
        {
            GameObject aux = GameObject.Instantiate(ficha) as GameObject;

            int aux2 = Random.Range(0, 100);



            aux.GetComponent<FallingNumber>().value = aux2;
            aux.GetComponent<TextMesh>().text = aux2.ToString();
            aux.transform.position = new Vector2(updateX(), 5);
            yield return new WaitForSeconds(0.75F);
        }

    }

    
}
