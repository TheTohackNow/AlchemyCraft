
using UnityEngine;

public class poiton : MonoBehaviour
{
    public float live;
    public Transform t;
    public Rigidbody2D r;
    private float x, y, timer;
    public int dmg = 5;
    void Start()
    {
        Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPos.z = 0;
        x = mouseWorldPos.x - t.position.x;
        y = mouseWorldPos.y - t.position.y;
        float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
        t.rotation = Quaternion.Euler(0, 0, angle);
    }

    void Update()
    {
        r.linearVelocity = new Vector2(x*2, y*2);
        timer += Time.deltaTime;
        if (timer > live) {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hp enemy = collision.GetComponent<hp>();
        if (!collision.CompareTag("Player") && !collision.CompareTag("projectile"))
        {
            if (enemy != null)
            {
                enemy.Hp -= dmg;
            }

            Destroy(gameObject);
        }
    }
}
