using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField]
    GameObject fire;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * Se o jogador permir o espaço
         * então criar um disparo
         */

        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fire, transform);

        }
    }
}
