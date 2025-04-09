using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHp : MonoBehaviour
{
    public int maxHealth;
    public int health;
    
    

    void OnCollisionEnter(Collision collision)
    {
        // Compara si el objeto colisionado es el que esperas
        if (collision.gameObject == LayerMask.NameToLayer("Bullet"))
        {
            health--;
            if (health <= 0)
            {
                Destroy(this.gameObject);  // Destruye el objeto que tiene este script
            }
            
        }
    }


}
