using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    /*
    private string ID = "안예준";
    private int currentHP = 1000;

    private void Awake()
    {
        TakeDamage(100);
    }

    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
    */
    public string ID;
    private int currentHP;

    void RecoveryHP(int hp)
    {
        currentHP += hp;
    }
    public void TakeDamage(int damage)
    {
        if (currentHP > damage)
        {
            currentHP -= damage;
        }
    }
}

public class Enemy
{
    private Player player;
    public void AttackToTarget(Player target)
    {
        target.TakeDamage(100);
    }
}