using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberGenerator : MonoBehaviour
{
    void Start()
    {
        while (true)
        {
            int intRandom = Random.Range(1, 21);
            if (intRandom == 5)
            {
                continue;
            }
            if (intRandom == 15)
            {
                Debug.Log(intRandom);
                break;
            }
            Debug.Log(intRandom);
        }
    }
}

