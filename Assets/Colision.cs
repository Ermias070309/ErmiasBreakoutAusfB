using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Jag tr�ffade n�gonting");
        Destroy(gameObject);
        if (collision.gameObject.name == "Enemy")
        {
            // h�r vill jag anropa TakeDamage-metoden
            GameObject enemyGameObject = collision.gameObject;
            EnemyPaddle enemyComponent = enemyGameObject.GetComponent<EnemyPaddle>();

            if (enemyComponent != null)
            {
                enemyComponent.TakeDamage();
            }
            Destroy(gameObject);
        }
    }
}
