using UnityEngine;

public class melee : MonoBehaviour
{
    public GameObject attack;
    public Transform t;
    float x, y;
    public float dmg = 5;
    public float cd = 0.2f;

    void Start()
    {
        
    }
    void Update()
    {

        attack.SetActive(false);
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0;

        if (Input.GetMouseButtonDown(0) && cd <= 0)
        {
            attack.SetActive(true);
            x = mouseWorldPos.x - t.position.x;
            y = mouseWorldPos.y - t.position.y;
            float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
            attack.transform.rotation = Quaternion.Euler(0, 0, angle);
            cd = 0.2f;
           

        }

        cd -= Time.deltaTime;
        
    }

  

}
