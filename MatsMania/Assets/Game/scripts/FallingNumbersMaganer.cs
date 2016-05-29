using UnityEngine;
using System.Collections;

public class FallingNumbersMaganer : MonoBehaviour
{

    int contador = 0;
    public static int puntuador;

    public GameObject ficha;
    public GameObject ev;
    public Sprite sprite;
    public Camera camara;

    private RaycastHit rHit;


    public Transform topLeft;
    public Transform topLRight;
    //public Transform bottom;


    // Use this for initialization
    void Start()
    {

        //INIT SCORE
        puntuador = 0;

        Event.setState();

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


            ScreenMessagesController.instance.SetMessageGameState(Event.currentEval);
            

            GameObject aux = GameObject.Instantiate(ficha) as GameObject;
            int aux2 = Random.Range(0, 100);

            aux.GetComponent<FallingNumber>().setValue(aux2);
            aux.GetComponent<TextMesh>().text = aux2.ToString();

            

            aux.transform.position = new Vector2(updateX(), 5);
            contador++;


            ///SET CONTADOR PARA CAMBIO DE REGLA
            if (contador >= 20)
            {
                yield return new WaitForSeconds(5F);
                contador = 0;
                Event.setState();
                ScreenMessagesController.instance.SetMessageGameState(Event.currentEval);
                Debug.Log(Event.currentEval);
            }
            Debug.Log(Event.currentEval);
            yield return new WaitForSeconds(1.5F);
            


        }

    }

    
}
