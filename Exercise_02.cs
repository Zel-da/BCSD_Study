using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_02 : MonoBehaviour
{
    private void Awake()
    {
        object valueInt = 31;
        object valueFloat = 3.14159265358979f;
        object valueString = "객체지향 프로그래밍";
        object valueBool = false;

        Debug.Log("7/4 : " + valueInt);
        Debug.Log("실수 : " + valueFloat);
        Debug.Log("문자열 : " + valueString);
        Debug.Log("논리 : " + valueBool);

        /*
        string stringValue = "안녕하세. 안예준입니.";
        bool boolValue = true;

        Debug.Log("string Data : " + stringValue);
        Debug.Log("bool Data : " + boolValue);

        /*
        float floatValue01 = 3.141592653589793238462643383279f;
        float floatValue02 = 31.141592653589793238462643383279f;
        double doubleValue = 3.141592653589793238462643383279;
        decimal decimalValue = 3.141592653589793238462643383279m;

        Debug.Log("float Data : " + floatValue01);
        Debug. Log("float Data : " + floatValue02);
        Debug.Log("double Data : " + doubleValue);
        Debug. Log("decimal Data : " + decimalValue);

        /*
        sbyte byteValue = -128;
        byte ubyteValue = 255;
        short shortValue = -32768;
        ushort ushortValue = 65535;
        int intValue = -2147483648;
        uint uintValue = 4294967295;
        long longValue = -922337203685477588;
        ulong ulongValue = 18446744073709551615;
        char charValue = 'K';

        Debug.Log("byte Data : " + byteValue);
        Debug.Log("ubyte Data : " + ubyteValue);
        Debug.Log("short Data : " + shortValue);
        Debug.Log("ushort Data : " + ushortValue);
        Debug.Log("int Data : " + intValue);
        Debug.Log("uint Data : " + uintValue);
        Debug.Log("long Data : " + longValue);
        Debug.Log("ulong Data : " + ulongValue);
        Debug.Log("char Data : " + charValue);
        */
    }
}
