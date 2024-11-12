using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlPlayer : MonoBehaviour
{

    public int speed = 5;

    int CONTADOR = 6 ;

    public GameObject itemFinal;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        itemFinal.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A)){

            transform.Translate(Vector3.left * Time.deltaTime * speed);

        }

        if (Input.GetKey(KeyCode.D)){

            transform.Translate(Vector3.right * Time.deltaTime * speed);

        }

        if (Input.GetKey(KeyCode.W)){

            transform.Translate(Vector3.forward * Time.deltaTime * speed);

        }

        if (Input.GetKey(KeyCode.S)){

            transform.Translate(Vector3.back * Time.deltaTime * speed);

        }

    }

    void OnTriggerEnter(Collider other){

        if (other.CompareTag("Item")){

            Destroy(other.gameObject);

            CONTADOR --;

            if (CONTADOR == 0){

                itemFinal.SetActive(true);

            }

        }

        if (other.CompareTag("Finish")){

            Destroy(other.gameObject);

            SceneManager.LoadScene("SampleScene");

        }

    }
}