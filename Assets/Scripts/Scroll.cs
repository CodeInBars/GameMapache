using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour
{
    public float velocidad = 0f;
    float tiempoInicio;
    public bool enMovimiento = false;
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "InicioJuego");
        NotificationCenter.DefaultCenter().AddObserver(this, "FinJuego");
    }

    // Update is called once per frame
    void Update()
    {
        
        if(enMovimiento){
            GetComponent<Renderer>().material.mainTextureOffset = new Vector2((Time.time-tiempoInicio) * velocidad, 0);
        }
        
    }

    void InicioJuego(){
        
        enMovimiento = true;
        tiempoInicio = Time.time;
    }

    void FinJuego(){
        
        enMovimiento = false;
        
    }
}
