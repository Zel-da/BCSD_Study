using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Exercise_05 : MonoBehaviour
{
    private void Awake()
    {

        int minutes = 1;
        int seconds = 15;
        /*
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

        */

        string position = "3, 5, 6";
        string[] str = position.Split(',');
        Debug.Log($"{str[0]}, {str[1]}, {str[2]}");

        string str2 = "HELLO, WORLD";
        str2 = str2.Substring(7);
        Debug.Log(str2);
    }
}
