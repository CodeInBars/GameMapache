using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camaraGameOver;
    
    void Start()
    {
        NotificationCenter.DefaultCenter().AddObserver(this, "FinJuego");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FinJuego(){

        GetComponent<AudioSource>().Stop();
        camaraGameOver.SetActive(true);
        GameObject.Find("TextoPuntos").GetComponent<TextMesh>().text = GameObject.Find("Marcador").GetComponent<TextMesh>().text;
    }
}
