using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise_04 : MonoBehaviour
{
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
    */

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
}
