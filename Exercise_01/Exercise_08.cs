using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_08 : MonoBehaviour
{
    [SerializeField]
    private int x = 10;

    private void Awake()
    {
        /*
        for (int index = 0; index < 10; ++index)
        {
            Debug.Log(index);
        }
        for (int x = 1; x < 10; ++×)
        {
            for (int y = 1; y < 10; ++y)
            {
                Debug.Log($" {x} × {y} = {x * y}");
            }
        }
        */

        int result = 0;
        int index = 1;

        while( index <= 100 )
        {
            result += index;
            index++;
        }

        Debug.Log($"1부터 100까지의 합 {result}");
    }
}
