using UnityEngine;
using System.Collections;

public class Str : MonoBehaviour
{
    public Player player;

    void Start()
    {
        player.Attack();
        player.Damage(10);
    }
}
