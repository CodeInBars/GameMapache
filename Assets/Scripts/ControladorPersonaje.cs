using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPersonaje : MonoBehaviour
{

    public GeneradorBloques gene1;
    public GeneradorBloques gene2;
    public GeneradorBloques gene3;
    public float fuerzaSalto = 100f;
    Rigidbody2D rigidbody;
    bool tocandoSuelo = true;
    public Transform comprobadorSuelo;
    float comprobadorRadio = 0.0f;
    public LayerMask mascaraSuelo;
    private bool corriendo = false;
    bool dobleSalto = false;
    public float velocidad = 5f;
    private Animator animacion;

    // Start is called before the first frame update

    void Awake(){

        rigidbody = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();
        
    }

    void Start()
    {
        
    }

    private void FixedUpdate(){

        tocandoSuelo = Physics2D.OverlapCircle(comprobadorSuelo.position, comprobadorRadio, mascaraSuelo);
        animacion.SetBool("enSuelo", tocandoSuelo);
        animacion.SetFloat("velX", rigidbody.velocity.x);
        //Animacion de correr sea proporcional a la velocidad del personaje

        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            rigidbody.velocity = new Vector2(velocidad, rigidbody.velocity.y);
            
            if(corriendo){
                if((tocandoSuelo) || (dobleSalto)){
                
                    GetComponent<AudioSource>().Play();
                    rigidbody.AddForce(Vector2.up*fuerzaSalto);
                    dobleSalto = false;
                    if(tocandoSuelo){
                        GetComponent<AudioSource>().Play();
                        dobleSalto=true;
                    }else{
                        
                    }
                } 
            }else{
                
                corriendo = true;
                //Avisar al generador de bloques
                NotificationCenter.DefaultCenter().PostNotification(this, "InicioJuego");
            }

        }
    }

    
}
