using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvaders : MonoBehaviour
{

    [SerializeField]
    GameObject[] invasores;

    [SerializeField]
    GameObject[] invasoresIndestrutiveis;

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

    [SerializeField]
    float probabilidadeDeIndestrutivel = 0.15f;

    //float speed = 0.5f;

    //float direction = 1f;


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
                GameObject normalOuIndestrutivel;
                if(Random.value <= probabilidadeDeIndestrutivel)
                {
                    normalOuIndestrutivel = invasoresIndestrutiveis[line];

                }else
                {
                    normalOuIndestrutivel = invasores[line];

                }
                GameObject newInvader = Instantiate(normalOuIndestrutivel, transform);
                newInvader.transform.position = new Vector3(x, y, 0);
                x += xInc;

            }
            y += yInc;

        }

    }

    //private void Update()
    //{
    //    transform.position += Time.deltaTime * speed * Vector3.right * direction;

    //    if (transform.position.x >= 0.5)
    //    {
    //        direction *= -1f;

    //    }
    //    if (transform.position.x <= -0.5)
    //    {
    //        direction *= -1f;
    //    }
    //}




}
