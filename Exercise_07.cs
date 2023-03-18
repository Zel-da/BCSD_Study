using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_07 : MonoBehaviour
{
    [SerializeField]
    private int x = 10;

    private void Awake()
    {
        if ( x % 2 == 0 )
        {
            Debug.Log("x는 짝수다");
        }
        if (x > 5 && x < 10)
        {
            Debug.Log("x는5보다크고10보다작다");
        }
        if (x > 5)
        {
            if (x < 10)
            {
                Debug.Log("x는 5보다 크고 10보다 작다");
            }
        }
        Debug.Log($"x의 값음 {x}");

        if(x % 2 == 0)
        {
            Debug.Log("x는 짝수다");
        }
        else
        {
            Debug.Log("x는 홀수다");
        }

        if(x > 5 && x< 10)
        {
            Debug.Log("x는 5보다 크고 10보다 작다");
        }

        if (x > 5)
        {
            Debug.Log("x는 5보다 크다");
        }

        Debug.Log($"x의 값음 {x}");

        if(x >= 90)
        {
            Debug.Log("학점 : A+");
        }
        else if (x >= 80)
        {
            Debug.Log("학점 : B+");
        }
        else if (x >= 70)
        {
            Debug.Log("학점 : C+");
        }
        else if (x >= 60)
        {
            Debug.Log("학점 : D");
        }
        else
        {
            Debug.Log("학점 : F");
        }

        x /= 10;

        switch( x )
        {
            case 10:
                Debug.Log("학점 : A+");
                break;
            case 9:
                Debug.Log("학점 : A+");
                break;
            case 8:
                Debug.Log("학점 : B+");
                break;
            case 7:
                Debug.Log("학점 : C+");
                break;
            case 6:
                Debug.Log("학점 : D");
                break;
            default:
                Debug.Log("학점 : F");
                break;
        }

    }
}
