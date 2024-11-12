using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{

    public int numero = 6;
    public int vidas = 3;

    public float decimales = 5.14f;
    public bool fin = false;
    public string texto = "amogus";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        print("¿Qué tal?");

        if (fin){

            print("Algo");

        }
    }

    void OnMouseDown(){

        vidas --;

        if (vidas == 0){

            Destroy(gameObject);

        }

    }
}
