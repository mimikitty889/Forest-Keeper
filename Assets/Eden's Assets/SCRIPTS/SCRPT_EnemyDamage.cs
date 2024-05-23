using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SCRPT_EnemyDamage : MonoBehaviour
{
    // Code rédigé par Eden

    public int damage;
    public Player_Health playerHealth;
    private void OnCollisionEnter2D(Collision2D collision)
    {

        playerHealth.TakeDamage(damage);
    }
}
