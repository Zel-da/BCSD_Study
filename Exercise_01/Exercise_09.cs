using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_09 : MonoBehaviour
{
    private void Awake()
    {
        //문제 01
        /*
        int answer = 0;
        for (int i = 1; i < 11; i++)
        {
            if (0 != i % 3)
            {
                Debug.Log("" + i);
                answer += i;
            }
        }
        Debug.Log("1~10중 3으로 나우어 떨어지지 않는 수의 합은 : " + answer);
        
        //02

        for (int y = 0; y < 5; ++y)
        {
            string sentence = "";
            for (int x = 0; x <= y; ++x)
            {
                sentence += "★";
            }
            for (int x = y + 1; x < 5; ++x)
            {
                sentence += "☆";
            }
            Debug.Log("" + sentence);
        }

        //03

        for (int y = 0; y < 5; ++y)
        {
            string sentence = "";
            for (int x = 5; x > y; --x)
            {
                sentence += "★";
            }
            for (int x = 1; x <= y; ++x)
            {
                sentence += "☆";
            }
            Debug.Log("" + sentence);
        }

        //04

        for (int y = 0; y < 5; ++y)
        {
            string sentence = "";
            for (int x = y + 1; x < 5; ++x)
            {
                sentence += "☆";
            }
            for (int x = 0; x <= y; ++x)
            {
                sentence += "★";
            }
            Debug.Log("" + sentence);
        }

        //05

        for (int y = 0; y < 5; ++y)
        {
            string sentence = "";
            for (int x = 1; x <= y; ++x)
            {
                sentence += "☆";
            }
            for (int x = 5; x > y; --x)
            {
                sentence += "★";
            }
            Debug.Log("" + sentence);
        }

        //06

        for (int y = 0; y < 5; ++y)
        {
            string sentence = "";
            for (int x = 0; x <= y; ++x)
            {
                sentence += "★";
            }
            for (int x = y + 1; x < 5; ++x)
            {
                sentence += "☆";
            }
            for (int z = 5; z > y; --z)
            {
                sentence += "★";
            }
            for (int z = 1; z <= y; ++z)
            {
                sentence += "☆";
            }
            Debug.Log("" + sentence);
        }
        for (int y = 0; y < 5; ++y)
        {
            string sentence = "";
            for (int x = y + 1; x < 5; ++x)
            {
                sentence += "☆";
            }
            for (int x = 0; x <= y; ++x)
            {
                sentence += "★";
            }
            for (int z = 1; z <= y; ++z)
            {
                sentence += "☆";
            }
            for (int z = 5; z > y; --z)
            {
                sentence += "★";
            }
            Debug.Log("" + sentence);
        }

        //07

        for (int y = 0; y < 5; ++y)
        {
            string sentence = "";
            for (int x = y + 1; x < 5; ++x)
            {
                sentence += "☆";
            }
            for (int x = 0; x <= y; ++x)
            {
                sentence += "★";
            }
            for (int z = 1; z <= y; ++z)
            {
                sentence += "★";
            }
            for (int z = y + 1; z < 5; ++z)
            {
                sentence += "☆";
            }
            Debug.Log("" + sentence);
        }
        
        //08

        for (int y = 0; y < 5; ++y)
        {
            string sentence = "";
            for (int x = y + 1; x < 5; ++x)
            {
                sentence += "☆";
            }
            for (int x = 0; x <= y; ++x)
            {
                sentence += "★";
            }
            for (int z = 1; z <= y; ++z)
            {
                sentence += "★";
            }
            for (int z = y + 1; z < 5; ++z)
            {
                sentence += "☆";
            }
            Debug.Log("" + sentence);
        }
        for (int y = 1; y < 5; ++y)
        {
            string sentence = "";
            for (int x = 1; x <= y; ++x)
            {
                sentence += "☆";
            }
            for (int x = 5; x > y; --x)
            {
                sentence += "★";
            }
            for (int z = 4; z > y; --z)
            {
                sentence += "★";
            }
            for (int z = 1; z <= y; ++z)
            {
                sentence += "☆";
            }
            Debug.Log("" + sentence);
        }
        
        //09

        for (int y = 0; y < 5; ++y)
        {
            string sentence = "";
            for (int x = 4; x > y; --x)
            {
                sentence += "★";
            }
            for (int x = 0; x <= y; ++x)
            {
                sentence += "☆";
            }
            for (int z = 1; z <= y; ++z)
            {
                sentence += "☆";
            }
            for (int z = 4; z > y; --z)
            {
                sentence += "★";
            }
            Debug.Log("" + sentence);
        }
        for (int y = 1; y < 5; ++y)
        {
            string sentence = "";
            for (int x = 1; x <= y; ++x)
            {
                sentence += "★";
            }
            for (int x = y; x < 5; ++x)
            {
                sentence += "☆";
            }
            for (int z = y + 1; z < 5; ++z)
            {
                sentence += "☆";
            }
            for (int z = 1; z <= y; ++z)
            {
                sentence += "★";
            }
            Debug.Log("" + sentence);
        }
        
        //10

        for (int y = 0; y < 26; ++y)
        {
            string sentence = "";
            for (int x = 0; x <= y; ++x)
            {
                sentence += (char)(65 + x);
            }
            Debug.Log(sentence);
        }

        //11

        int z = 0;
        for (int y = 0; y < 26; ++y)
        {
            string sentence = "";
            for (int x = 0; x <= y; ++x)
            {
                sentence += (char)(65 + z);
            }
            z++;
            Debug.Log(sentence);
        }
        
        //12

        for (int y = 0; y < 26; ++y)
        {
            string sentence = "";
            for (int x = 0; x <= y; ++x)
            {
                sentence += (char)(65 + x);
                sentence = sentence.Insert(0, "  ");
            }
            Debug.Log(sentence);
        }
        
        //13

        int z = 0;
        for (int y = 0; y < 26; ++y)
        {
            string sentence = "";
            sentence += (char)(65 + y) + "\t";
            for (int x = 0; x < y; ++x)
            {
                sentence += "   ";
            }
            for (int x = z; x <= 25; ++x)
            {
                sentence += (char)(65 + x);
            }
            z++;
            Debug.Log(sentence);
        }

        //14
        
        int z = 0;
        for (int y = 0; y < 26; ++y)
        {
            string sentence = "";
            sentence += (char)(65 + y) + "\t";
            sentence += "   ";
            for (int x = 0; x <= z; ++x)
            {
                sentence += (char)(65 + x);
            }
            z++;
            Debug.Log(sentence);
        }

        //15
        
        for (int y = 0; y < 26; ++y)
        {
            string sentence = "";
            sentence += (char)(65 + y) + "\t";
            sentence += "   ";
            for (int x = 0; x <= 25; ++x)
            {
                sentence += (char)(65 + x);
                if( x == y)
                {
                    sentence += (char)(65 + x);
                }
            }
            Debug.Log(sentence);
        }

        //16
        
        int z = 25;
        int i = 0;
        for (int y = 0; y < 26; ++y)
        {
            string sentence = "";
            sentence += (char)(65 + y) + "\t";
            for (int x = 0; x < y; ++x)
            {
                sentence += "  ";
            }
           
            for (int x = i ; x <= z; ++x)
            {
                sentence += (char)(65 + x);

            }
            i++;
            z--;
            Debug.Log(sentence);
        }

        //17
        
        for (int y = 0; y < 26; ++y)
        {
            string sentence = "";
            sentence += (char)(65 + y) + "\t";
            for (int x = 0; x < 26 - y; ++x)
            {
                sentence += (char)(65 + x / 3);
            }
            Debug.Log(sentence);
        }

        //18
        
        int z = 0;
        for (int y = 0; y < 26; ++y)
        {
            string sentence = "";
            sentence += (char)(65 + y) + "\t";
            for (int x = 0; x < 26 - y; ++x)
            {
                sentence += (char)(65 + x / 3);
            }
            sentence += " ";
            for (int x = 0; x < 26 - y; ++x)
            {
                sentence += (char)(65 + z + x);
            }
            z++;
            Debug.Log(sentence);
        }
        */
        //19

        int z = 0;
        for (int y = 0; y < 26; ++y)
        {
            string sentence = "";
            sentence += (char)(65 + y) + "\t";
            for (int x = 0; x < y; ++x)
            {
                sentence += "   ";
            }
            for (int x = 0; x < 26 - y; ++x)
            {
                sentence += (char)(65 + x / 3 + z);
            }
            z++;
            Debug.Log(sentence);
        }
    }
}
        
