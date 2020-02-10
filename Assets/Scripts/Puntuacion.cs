using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Puntuacion : MonoBehaviour
{
    private int points = -1;
    public TextMesh textoPuntuacion;

    // Start is called before the first frame update
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this,"IncrementarPuntos");   
    }

    void IncrementarPuntos(Notification notification){
        
        points += (int) notification.data;
        textoPuntuacion.text = points+"";
        //Debug.Log("Puntos:" + points);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    
}
