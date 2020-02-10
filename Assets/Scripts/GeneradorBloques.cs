using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorBloques : MonoBehaviour
{
    public GameObject[] objects;
    public float tiempoMin = 1f;
    public float tiempoMax = 2f;

    // Start is called before the first frame update
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "InicioJuego");

    }

    // Update is called once per frame
    void Update()
    {

    }

    void Generar(){
        
        
        Instantiate(objects[Random.Range(0,objects.Length)], transform.position, Quaternion.identity);
        Invoke("Generar", Random.Range(tiempoMin,tiempoMax)); 
        
        
    }

    void InicioJuego(){

        Debug.Log("Generar");
        Generar();

    }


}
