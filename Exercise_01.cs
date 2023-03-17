using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_01 : MonoBehaviour
{
    //1강 : 변수와 데이터
    private int value01;
    private int value02, value03, value04;
    private int value05 = 10;
    private int value06 = 10, value07 = 20, value08 = 30;
    private void Aake()
    {
        value01 = 1;
        value02 = 2;
        value03 = 3;
        value04 = 4;
    }
    private int currentHP = 10;
    private readonly int maxHP = 100; //읽기 전용 변수 
    private const int maxMP = 100; //상수

    public Exercise_01()
    {
        maxHP = 200; //읽기 전용 변수는 초기화, 생성자에서 데이터 수정 가능 
    }

    private void Awake()
    {
        int currentMP = 35; //지역 변수, 함수가 끝나면 소멸 

        currentHP = 35; //currentHP 변수에 100 저장 

        Debug.Log(currentHP);
        Debug.Log(currentMP);
        Debug.Log(maxHP);
    }
    private void Update()
    {

    }

    private void Awake()
    {
        Player player;

        player = GameObject.Find("PlayerObject").GetComponent<Player>();
        player.playerName = "안예준";
        player.TakeDamge(10);
    }
    //2강 기본 데이터 형식
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
    //3강 데이터의 형 변환

}