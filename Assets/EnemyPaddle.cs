using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaddle : MonoBehaviour
{
    int hitpoints = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage()
    {
        hitpoints -= 1;
        if (hitpoints == 0)
        {
            Destroy(gameObject);
        }
    }
}
