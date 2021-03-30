using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{

    [SerializeField]
    GameObject[] invasores;

    [SerializeField]
    int nrInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    [SerializeField]
    float yMin = -0.5f;

    [SerializeField]
    float xInc = 1f;

    [SerializeField]
    float yInc = 0.5f;


    void Awake()
    {
        /*
         * Pega num invader e cola nesta posição
         * Repete para os outros invaders
         */

     
        float y = yMin;

        for (int line = 0; line < invasores.Length; line++ )
        {

            float x = xMin;
            for (int i = 1; i <= nrInvasores; i++)
            {
                GameObject newInvader = Instantiate(invasores[line], transform);
                newInvader.transform.position = new Vector3(x, y, 0);
                x += xInc;

            }
            y += yInc;

        }

    }
        




     
}
