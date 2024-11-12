using UnityEngine;

public class Movimiento : MonoBehaviour
{

    public GameObject destino;
    Vector3 posicionDestino;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        posicionDestino = destino.transform.position;

        transform.position = Vector3.MoveTowards(transform.position, posicionDestino, Time.deltaTime);

        transform.Rotate(Vector3.up * Time.deltaTime * 1000);

    }
}
