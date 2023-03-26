using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamecontroller : MonoBehaviour
{
    /*
    public Player player01; public Player player02;
    private void Awake()
    {
        player01 = new Player();
        player01.TakeDamage(100);
        player02.TakeDamage(200);
    }
    */
    //얕은 복사
    private Player player01;
    private Player player02;

    private void Awake()
    {
        player01 = new Player("안예준", 1000);
        player02 = player01;
        player02.ID = "유니티";

        Debug.Log($"ID: (player01.ID)");
        Debug.Log($"ID : (player02.ID]");
    }

    //깊은 복사

}

public class Player
{
    public Player DeepCopy()
    {
        Player clone = new Player();
        clone.ID = ID;
        clone.currentHP = currentHP;

        return clone;
        }
}