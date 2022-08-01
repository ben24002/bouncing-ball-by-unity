using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chec_point : MonoBehaviour
{

    float sum(float tmp1 ,float tmp2)
    {

        return tmp1 + tmp2;

    }

    float prod(float tmp1 ,float tmp2)
    {

        return tmp1 * tmp2;

    }

    float div(float tmp1 ,float tmp2)
    {

        if (tmp2 == 0)
        {
            Console.WriteLine("erreur, " + tmp2 + " need to be else than 0");
        }else 
        {
            return tmp1 / tmp2;
        }

    }

}