using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarBloques : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D elOtro){
        
        if(elOtro.tag == "Player"){
            NotificationCenter.DefaultCenter().PostNotification(this, "FinJuego");
            
            Destroy(GameObject.Find("GeneradorDeBloques"));
            Destroy(GameObject.Find("GeneradorDeBloquesMedio"));
            Destroy(GameObject.Find("GeneradorDeBloquesAlto"));
            Destroy(GameObject.Find("GeneradorDeFrutas"));
            Destroy(GameObject.Find("Personaje"));
            
        }else{
            Destroy(elOtro.gameObject);
        }
        
        
        
        
    }

}
