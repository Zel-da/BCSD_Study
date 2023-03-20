using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise_10 : MonoBehaviour
{
    [SerializeField]
    private int x = 10;

    /*
    private void Awake()
    {
        int[] enemys = new int[5];

        Debug.Log($"배열의 타입 : {enemys.GetType()}");
        Debug.Log($" 배열의 기본 타입 : {enemys.GetType().BaseType}");

        Debug.Log("== 정렬 전 ==");

        for (int index = 0; index < enemys.Length; ++index)
        {
            enemys[index] = UnityEngine.Random.Range(0, 100);
            Debug.Log(enemys[index]);
        }
        Array.Sort(enemys);

        Debug.Log("== 정렬 후 ==");
        for (int index = 0; index < enemys.Length; ++index)
        {
            Debug.Log(enemys[index]);
        }

        Debug.Log($"Dimensions {enemys.Rank}");
    */

        private void Awake()
        {
            int[][] array = new int[3][];

            array[0] = new int[3] { 1, 2, 3 };
            array[1] = new int[] { 10, 20, 30, 40 };
            array[2] = new int[] { 100, 200, 300, 400, 500 };

            for (int i = 0; i < array.Length; ++i )
            {
            for (int j = 0; j < array[i].Length; ++j )
                {
                Debug.Log($" [{i}1[{j}] = {array[i][j]}");
            }
        }
    }
}
