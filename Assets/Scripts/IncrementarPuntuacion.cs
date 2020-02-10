using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IncrementarPuntuacion : MonoBehaviour
{
    private bool increm = false;
    public int points = 0;

    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D elOtro){

        if(elOtro.tag=="Player"){
            
            NotificationCenter.DefaultCenter().PostNotification(this,"IncrementarPuntos", points);
            
            AudioSource.PlayClipAtPoint(clip, Camera.main.transform.position, 2f);
            Destroy(this.gameObject);
        }
        
        
        
    }

    private void OnCollisionEnter2D(Collision2D ot){

        if((ot.gameObject.tag == "Player") && (!increm)){
            increm = true;
            NotificationCenter.DefaultCenter().PostNotification(this,"IncrementarPuntos", points);
        }
    }
}
