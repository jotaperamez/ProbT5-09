using UnityEngine;
using System.Collections;

public class Event : MonoBehaviour {

    
    public static int currentEval;
    private float change;
    private static int lastEval;

    // Use this for initialization
    void Start() {


        currentEval = 1 ;//((Random.Range(0,3)));

        foreach (int prim in primo)
            primos.Add(prim);
        change = Time.time;
        Debug.Log(currentEval.ToString());
    }

    public static bool Evaluate(int entrada)
    {
        switch (currentEval)
        {
            case 0: 
                    if(entrada % 2 == 0)
                {
                    return true;
                }else
                {
                    return false;
                }

            case 1:
                if (entrada%2 == 1)
                {
                    return true;
                }else
                {
                    return false;
                }
            case 2: return (Mathf.Sqrt(entrada) == (int)Mathf.Sqrt(entrada));
                
            case 3: return primos.Contains(entrada);
               
        }
        return false;
    }

    // Update is called once per frame
    void Update() {
        

    }


    public static void setState()
    {
     
            lastEval = currentEval;
            currentEval = Random.Range(0, 3);
            if (currentEval == lastEval)
                currentEval = (currentEval + 1) % 4;
            

    }

    public enum Eval
    {
       Raiz , Impar, Primo, Par
    }
    public int[] primo = { 1, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
    public static ArrayList primos = new ArrayList();
}
