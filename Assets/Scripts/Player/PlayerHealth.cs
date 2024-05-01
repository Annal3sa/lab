using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
   
    public float health;
    public float maxHealth = 100;
    public Image healthbar;
    

    void Start()
    {
        maxHealth = health;
    }

    private void Update()
    {
        healthbar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
            SceneManager.LoadScene(40);
        }

        
    }

}
    
    

