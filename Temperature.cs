using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temperature : MonoBehaviour
{
    public Health health;
    public int damage = 1;
    public float current_temperature = 36.6f;
    public float normal_temperature = 36.6f;
    public float critical_temperature = 0f;
    public float damage_done = 1f;
    public float DamageTimer = 1;
    public float DamageDelay = 2;

    void Update()
    {
        current_temperature -= damage_done * Time.deltaTime;
        print(current_temperature);
        if (current_temperature <= critical_temperature) ;
        {
            if (DamageTimer <= 0)
            {
                health.TakeDamage(damage);
                DamageTimer += DamageDelay;
            }
            else
            {
                DamageTimer -= Time.deltaTime; 
            }
        }
            
     }
}
