using UnityEngine;

public class range : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float speed = 5f;
    public float dmg = 5f;
    

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0;

            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.Euler(0,0,0));
            bullet.tag = "projectile";
            Vector2 direction = (mouseWorldPos - bullet.transform.position).normalized;

            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0, 0, angle);

            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            rb.linearVelocity = direction * speed;
        }
        
    }
    
}