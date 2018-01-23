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

    void UpdateHealth(int healthChange)
    {
        health += healthChange;
        health = (int)Mathf.Clamp(health, 0f, 12f);
    }

    void HealthRegen()
    {
        
        timeSinceRegen += Time.deltaTime; //reset timer to zero
        
        if ( timeSinceRegen > timer )
        {
            UpdateHealth(1);
            timeSinceRegen = 0f;
            healthText.text = "Health : " + health.ToString();
        }
    }

}
