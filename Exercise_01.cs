using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise_01 : MonoBehaviour
{
    /*
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

        
        string stringValue = "안녕하세. 안예준입니.";
        bool boolValue = true;

        Debug.Log("string Data : " + stringValue);
        Debug.Log("bool Data : " + boolValue);

        
        float floatValue01 = 3.141592653589793238462643383279f;
        float floatValue02 = 31.141592653589793238462643383279f;
        double doubleValue = 3.141592653589793238462643383279;
        decimal decimalValue = 3.141592653589793238462643383279m;

        Debug.Log("float Data : " + floatValue01);
        Debug. Log("float Data : " + floatValue02);
        Debug.Log("double Data : " + doubleValue);
        Debug. Log("decimal Data : " + decimalValue);

        
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
        
    }
    

//3강 데이터의 형 변환
private void Awake()
    {
        
    sbyte sbyteValue = 10;
    int intValue = (int)sbyteValue;

    Debug.Log("sbyteValue : " + sbyteValue);
    Debug.Log("intValue : " + intValue);
    intValue = 130;
    sbyteValue = (sbyte)intValue;

    Debug.Log("sbyteValue : " + sbyteValue);
    Debug.Log("intValue : " + intValue);

    sbyte sbyteValue = 31;
    byte byteValue = (byte)sbyteValue;

    Debug.Log("sbyteValue : " + sbyteValue);
    Debug.Log("byteValue : " + byteValue);

    sbyteValue = -31;
    byteValue = (byte)sbyteValue;

    Debug.Log("sbyteValue : " + sbyteValue);
    Debug.Log("byteValue : " + byteValue);

    byteValue = 200;
    sbyteValue = (sbyte)byteValue;
    Debug.Log("sbyteValue : " + sbyteValue);
    Debug.Log("byteValue : " + byteValue);

    float floatValue = 69.6875f;
    double doubleValue = (double)floatValue;

    Debug.Log("floatValue : " + floatValue);
    Debug.Log("doubleValue : " + doubleValue);


    floatValue = 0.1f;
    doubleValue = (double)floatValue;

    Debug.Log("floatValue : " + floatValue);
    Debug.Log("doubleValue : " + doubleValue);

    int intValue = 10;
    float floatValue = 12.3456f;
    string stringValue = "33";

    Debug.Log("intValue : " + intValue);
    Debug.Log("floatValue : " + floatValue);
    Debug. Log("stringValue: " + stringValue);

    intValue = int.Parse(stringValue);
    stringValue = "33.4567";
    floatValue = float.Parse(stringValue);

    Debug.Log("intValue : " + intValue);
    Debug.Log("floatvalue : " + floatValue);
    Debug.Log("stringValue : " + stringValue);

    string stringValue = "숫자가 아닙니다.";
    int intValue = 10;
    bool isConversion = int.TryParse(stringValue, out intValue);
    if (isConversion == true)
    {
        Debug.Log("stringValue : " + stringValue);
        Debug.Log("intValue : " + intValue);
    }
    else
    {
        Debug.Log("stringValue 변수에 들어있는 내용이 숫자가 아니어서 형변환에 실패하였습니다.");
    }
    
        string stringValue = "초기홮";
        int intValue = 33;
        float floatValue = 12.3456f;


        Debug.Log("stringValue : " + stringValue);

        stringValue = intValue.ToString();
        Debug.Log("stringValue : " + stringValue);

        stringValue = floatValue.ToString();
        Debug.Log("stringValue : " + stringValue);
        
    }
    

    //4장 상수 열거형 Nullable var

   /*
    private void Awake()
    {
        const int PlayerIdle = 0;
        const int PlayerMove = 1;
        const int PlayerAttack = 2;

        int playerState = PlayerAttack;

        switch (playerState)
        {
            case PlayerIdle:
                Debug.Log("플레이어 상태 : 대기");
                break;
            case PlayerMove:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case PlayerAttack:
                Debug.Log("플레이어 상태 : 공격");
                break;
        }
    }
    
    enum PlayerState { Idle, Move, Attack }

    private void Awake()
    {
        PlayerState playerState = PlayerState.Idle;

        switch ( playerState )
        {
            case PlayerState.Idle:
                Debug.Log("플레이어 상태 : 대기");
                break;
            case PlayerState.Move:
                Debug.Log("플레이어 상태 : 이동");
                break;
            case PlayerState.Attack:
                Debug.Log("플레이어 상태 : 공격");
                break;
        }
    }
    

    private void Awake()
    {
        int? intValue;

        intValue = null;
        Debug.Log(intValue.HasValue);

        intValue = 30;
        Debug.Log(intValue.HasValue);
        Debug.Log(intValue.Value);

        var valueInt = 33;
        var valueFloat = 33.4567f;
        var valuestring = "문자열";

        Debug.Log("5/4 : " + valueInt);
        Debug.Log(" 실수 : " + valueFloat);
        Debug.Log("문자열 : " + valuestring);
    }
    

    //5장 문자열 다루기
    private void Awake()
    {

        int minutes = 1;
        int seconds = 15;
        
        Debug.Log(string.Format("기본 : {0){1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("왼쪽 맞춤 : {0, -5}{1}{2}", minutes, ":", seconds));
        Debug.Log(string.Format("오른쪽 맞춤 : {0, -5}{1}{2}", minutes, ":", seconds));

        Debug.Log(string.Format("1e진수 서식화 : {0:D}", 123));
        Debug.Log(string.Format("10진수 서식화(5자리) : {0:D5)", 123));

        Debug.Log(string.Format("16진수 서식화 : {0:X}", 0x00));
        Debug.Log(string.Format("16진수 서식화(10자리) : (0:X10)", 0X00));

        Debug.Log(string.Format("고정소수점 서식화 : {0:F)", 1.23));
        Debug.Log(string.Format("고정소수점 서식화(소수점 1자리) : {0:F1}", 1.23));

        Debug.Log(string.Format("콤마로 구분 : {0:N}", 1234567890));
        Debug.Log(string.Format("지수 : (0:E}", 1234567890));

        DateTime dt = new DateTime(2020, 2, 22, 13, 40, 0);
        string str = dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)");
        Debug.Log(str);

        str = dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)");
        Debug.Log(str);
      

        Debug.Log(string.Format("{0}{1}{2}", minutes, ":", seconds));

        Debug.Log($" {minutes} : {seconds}");

        Debug.Log(string.Format("{0, -10:D5}", minutes));

        Debug.Log($"{minutes, -10:D5}");

        string str = "Hello, World";
        Debug.Log(str);

        int numeric = str.IndexOf('o');
        Debug.Log($"o는 앞에서부터 { numeric + 1} 번째에 있습니다.");

        numeric = str.LastIndexOf('o');
        Debug.Log($"o는 뒤에서부터 {numeric} 번째에 있습니다.");

        bool isTrue = str.StartsWith("Hello");
        Debug.Log($"{str} 문장은 Hello부터 시작한다? {isTrue}");

        isTrue = str.StartsWith("World");
        Debug.Log($"{str} 문장은 World부터 시작한다? {isTrue}");

        isTrue = str.EndsWith("Hello");
        Debug.Log($"{str} 문장은 He110로 끝난다? {isTrue}");

        isTrue = str.EndsWith("World");
        Debug.Log($"(str) 문장은 World로 끝난다? {isTrue}");

        isTrue = str.Contains("Hell");
        Debug.Log($"{str} 문장에 He11이 포함되어 있다? {isTrue}");
        

        string str = "HELLO, WORLD";
        Debug.Log(str);

        str = str.ToLower();
        Debug.Log($"ToLower () - {str}");

        str = str.ToUpper();
        Debug.Log($"ToUpper () - {str}");

        str = str.Insert(0, "Hi~ ");
        Debug.Log($"Insert () - (str!");

        str = str.Remove(0, 4);
        Debug.Log($"Remove () - {str}");

        Debug.Log("== Trim ==");

        str = "     " + str + "     ";
        Debug.Log(str + "공백 체크");

        str = str.Trim();
        Debug.Log(str + "공백 체크");

        Debug.Log($"Before Replace: {str}");
        str = str.Replace("HELLO", "BYE");
        Debug.Log($"After Replace : {str}");

        

        string position = "3, 5, 6";
        string[] str = position.Split(',');
        Debug.Log($"{str[0]}, {str[1]}, {str[2]}");

        string str2 = "HELLO, WORLD";
        str2 = str2.Substring(7);
        Debug.Log(str2);
    }
    

    //6장 연산자
    private void Awake()
    {
        
        int a = 5 + 6;
        int b = a - 3;
        int c = a * b;
        int d = c / 8;
        int e = d % 4;

        Debug.Log($"{a} = 5 + 6");
        Debug.Log($"{b} = {a} - 3");
        Debug.Log($"{c} = {a} * {b}");
        Debug.Log($"{d} = {c} / 8");
        Debug.Log($"{e} = {d} % 4");
        
        int a = 10;
        Debug.Log($"a = 10 : {a}");

        a += 10;
        Debug.Log($"a += 10 : 결과 값 {a}");

        Debug.Log($"a -= 9 : 결과 값 {a -= 9}");
        Debug.Log($"a *= 8 : 결과 값 {a *= 8}");
        Debug.Log($"a /= 7 : 결과 값 {a /= 7}");
        Debug.Log($"a %= 6 : 결과 값 {a %= 6}");
        Debug.Log($"a &= 5 : 결과 값 {a &= 5}");
        Debug.Log($"a |= 4 : 결과 값 {a |= 4}");
        Debug.Log($"a ^= 3 : 결과 값 {a ^= 3}");
        Debug.Log($"a <<=2 : 결과 값 {a <<= 2}");
        Debug.Log($"a >>=1 : 결과 값 {a >>= 1}");

        int a = 10;
        Debug.Log(a);

        a++;
        Debug.Log(a);

        ++a;
        Debug.Log(a);

        Debug.Log(a++);
        Debug.Log(a);
        Debug.Log(++a);
        Debug.Log(a);

        int x = 5, y = 2;

        Debug.Log($" {x} > {y} = {x > y}");
        Debug.Log($" {x} < {y} = {x < y}");
        Debug.Log($" {x} >= {y} = {x >= y}");
        Debug.Log($" {x} <= {y} = {x <= y}");
        Debug.Log($" {x} == {y} = {x == y}");
        Debug.Log($" {x} != {y} = {x != y}");

        bool result = false;
        int x = 5, y = 2;

        result = x > 2 && y != 5;
        Debug.Log($" {x} > 2 && {y} != 5 = {result}");

        result = x < 4 || y == 3;
        Debug.Log($"{x} < 4 || {y} == 3 = {result}");

        Debug.Log(result);
        result = !result;
        Debug.Log(result);

        int hp = -10;
        hp = hp < 0 ? 0 : hp;
        Debug.Log("체력:" + hp);

        int a = 3;

        Debug.Log($"{a} << 1 = {a << 1}");
        Debug.Log($"{a} << 2 = {a << 2}");
        Debug.Log($"{a} << 3 = {a << 3}");
        Debug.Log($"{a} << 4 = {a << 4}");

        a = 255;
        Debug.Log($"{a} >> 1 = {a >> 1}");
        Debug.Log($"{a} >> 2 = {a >> 2}");
        Debug.Log($"{a} >> 3 = {a >> 3}");
        Debug.Log($"{a} >> 4 = {a >> 4}");

        a = -255;
        Debug.Log($"{a} >> 1 = {a >> 1}");
        Debug.Log($"{a} >> 2 = {a >> 2}");
        Debug.Log($"{a} >> 3 = {a >> 3}");
        Debug.Log($"{a} >> 4 = {a >> 4}");

        Debug.Log(Convert.ToString(a >> 4, 2));

        Debug.Log($"10 & 6 = {10 & 6}");

        Debug.Log($"10 | 6 = {10 | 6}");

        Debug.Log($"10 ^ 6 = {10 ^ 6}");

        Debug.Log($"~10 = {~10}");
    }
    

    //7장 조건문

    [SerializeField]
    private int x = 10;

    private void Awake()
    {
        if (x % 2 == 0)
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

        if (x % 2 == 0)
        {
            Debug.Log("x는 짝수다");
        }
        else
        {
            Debug.Log("x는 홀수다");
        }

        if (x > 5 && x < 10)
        {
            Debug.Log("x는 5보다 크고 10보다 작다");
        }

        if (x > 5)
        {
            Debug.Log("x는 5보다 크다");
        }

        Debug.Log($"x의 값음 {x}");

        if (x >= 90)
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

        switch (x)
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



    //8장 반복문

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
       

        int result = 0;
        int index = 1;

        while (index <= 100)
        {
            result += index;
            index++;
        }

        Debug.Log($"1부터 100까지의 합 {result}");
    }
    */

    //9장 반복문 문제

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
        Debug.Log("1~10중 3으로 나우어 떨어지지 않는 수의 합은 : {answer}");
    }

}