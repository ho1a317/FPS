using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    [SerializeField]
    private int health = 5;

    private void Start()
    {
        health = 5;
    }

    public void Hurt(int damage)
    {
        health -= damage;

        Debug.Log("Player health " + health);
    }
}
