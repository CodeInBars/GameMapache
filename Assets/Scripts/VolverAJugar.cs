using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VolverAJugar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown(){

        GetComponent<AudioSource>().Play();
        Invoke("reproducirSonido", GetComponent<AudioSource>().clip.length);
        
    }

    private void reproducirSonido(){
        SceneManager.LoadScene("SampleScene");
    }
}
