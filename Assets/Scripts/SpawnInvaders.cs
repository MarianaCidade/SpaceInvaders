using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{
    [SerializeField]
    GameObject invasorA;

    [SerializeField]
    GameObject invasorB;

    [SerializeField]
    GameObject invasorC;

    [SerializeField]
    int nrInvasores = 7;

    [SerializeField]
    float xMin = -3f;

    void Awake()
    {
        /*
         * Pega num invader e cola nesta posição
         * Repete para os outros invaders
         */

        float x = xMin;
        for (int i = 1; i <= nrInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorA, transform);
            newInvader.transform.position = new Vector3(x, -0.5f, 0);
            x += 1f;

        }

        float x2 = xMin;
        for (int i = 1; i <= nrInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorA, transform);
            newInvader.transform.position = new Vector3(x2, 0f, 0);
            x2 += 1f;

        }

        float x3 = xMin;
        for (int i = 1; i <= nrInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorB, transform);
            newInvader.transform.position = new Vector3(x3, 0.5f, 0);
            x3 += 1f;
        }
        float x4 = xMin;

        for (int i = 1; i <= nrInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorB, transform);
            newInvader.transform.position = new Vector3(x4, 1f, 0);
            x4 += 1f;
        }

        float x5 = xMin;
        for (int i = 1; i <= nrInvasores; i++)
        {
            GameObject newInvader = Instantiate(invasorC, transform);
            newInvader.transform.position = new Vector3(x5, 1.5f, 0);
            x5 += 1f;
        }
    }
        




     
}
