using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour
{

    private void Awake()
    {
    ArrayList array = new ArrayList();
    array.Add(10);

    Debug.Log(array[0]);
    }
}
