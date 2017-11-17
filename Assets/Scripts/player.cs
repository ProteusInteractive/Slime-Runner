using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour {

    public int health;
    public Text healthText;

    float timer = 3f;
    float timeSinceRegen = 0f;

    void Start ()
    {
        reset();
	}
	
	void Update ()
    {
        HealthRegen();
	}

    void reset()
    {
        health = 12;
        //gameObject.transform = Vector3.zero;
        //TODO reset the player to origin
    }

    void UpdateHealth(int damage)
    {
        Mathf.Clamp(health, 0, 12);
    }

    void HealthRegen()
    {
        Mathf.Clamp(health, 0, 12); //ensure health doesnt exceed 12
        timeSinceRegen += Time.deltaTime; //reset timer to zero
        
        if ( timeSinceRegen > timer )
        {
            health += 1;
            timeSinceRegen = 0f;
            //health = healthText;
        }
    }

}
