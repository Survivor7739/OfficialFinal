using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Health : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 200;
    private bool isDead;
    GameManagerscript gameManager;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0 && !isDead)
        {

            
            isDead = true;
            gameObject.SetActive(false);
            
            Debug.Log("Dead");
            
        }
    }
    
}
