using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonfire : MonoBehaviour
{
    public float Gorenje_kostar_time = 15;
    public float heat_transfer = 2f;

    void UpDate()
    {
        Gorenje_kostar_time -= Time.deltaTime;
        if (Gorenje_kostar_time <= 0)
        {
            gameObject.SetActive(false);
        }
        
    }
    void OnTriggerStray( Collider other)
    {
        if (other.GetComponent<Temperature>() != null) ;
        {
            Temperature temperatire = other.GetComponent<Temperature>();

            if(temperatire.current_temperature < temperatire.normal_temperature)
            {
                temperatire.current_temperature += heat_transfer * Time.deltaTime; 
            }
        }
    }
}
