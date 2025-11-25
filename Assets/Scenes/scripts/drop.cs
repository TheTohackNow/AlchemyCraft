using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    public Transform t;
    public GameObject p;
    public bool spawned;
    public float defcd = 0.5f;
    public float cd = 0.5f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && !spawned)
        {
            GameObject proj = Instantiate(p, t);
            proj.gameObject.tag = "projectile";
            spawned = true;
        }

        /*------------------------------------------*/
        
        if (spawned)
        {
            cd -= Time.deltaTime;
            if (cd <= 0)
            {
                spawned = false;
                cd = defcd;
            }

        }
    }

    
}
