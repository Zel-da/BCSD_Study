using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_09 : MonoBehaviour
{
    private void Awake()
    {
        int answer = 0;
        for (int i = 1; i < 11; i++)
        {
            if (i / 3 == 0)
            {
                Debug.Log("{i}");
                answer += i;
            }
        }
        Debug.Log("1~10중 3으로 나우어 떨어지지 않는 수의 합은: {answer}");
    }
}
