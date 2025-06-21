using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Strs : MonoBehaviour
{
    public Player player;

    void Start()
    {
        player.Attack();
        player.Damage(10);
    }
}
