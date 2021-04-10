using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour
{
    [SerializeField]
    GameObject fire = null;

    [SerializeField]
    float cadencia = 1.5f;

    [SerializeField]
    float intervaloDeCadencia = 1f;

    float tempoQuePassou = 0f;
    float tempoDeDisparo = 0f;

    float hitsNeeded = 10;

    float hitsTaken = 0;

    private void Start()
    {
        NovoTempoDeDisparo();
    }

    void NovoTempoDeDisparo()
    {
        tempoDeDisparo = Random.Range(cadencia - intervaloDeCadencia, cadencia + intervaloDeCadencia);
    }

    void Update()
    {
        //Mandar o fogo dos aliens 
        if(tag == "Destrutivel")
        {
            tempoQuePassou += Time.deltaTime;
            if (tempoQuePassou >= tempoDeDisparo)
            {
                Instantiate(fire, transform.position, transform.rotation);
                tempoQuePassou = 0f;
                NovoTempoDeDisparo();
            }
        }
        
    }

    //Quando ha uma colisao com os aliens
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (tag == "Destrutivel")
        {
       
            if (collision.gameObject.tag == "DisparoDaNave")
            {
                Destroy(gameObject); //Destruir-me
                Destroy(collision.gameObject); //Destruir o objeto que comigo colidiu
            }
        }

        if (tag == "Indestrutivel")
        {
            if(collision.gameObject.tag == "DisparoDaNave")
            {
                hitsTaken += 1f;
                Destroy(collision.gameObject);

                if (hitsTaken >= hitsNeeded)
                {
                    Destroy(gameObject);
                    
                }
            }
            
        }
    }
    
}
