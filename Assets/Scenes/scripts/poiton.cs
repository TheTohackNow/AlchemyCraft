
using UnityEngine;

public class poiton : MonoBehaviour
{
    public float liveTime;
    public Transform t;
    public Rigidbody2D r;
    private float x, y, timer;
    
    public GameObject Effect;
    public float dmg;
    public float radius;
    public float expandSpeed;
    public float damageDelay;
    public float time;
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
        if (timer > liveTime) {
            Death();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        hp enemy = collision.GetComponent<hp>();
        if (!collision.CompareTag("Player"))
        {
            if (enemy != null)
            {
                enemy.Hp -= dmg;
            }

            Death();
        }
    }
    void Death()
    {
        GameObject e = Instantiate(Effect, transform.position, Quaternion.identity);
        effect Ee = e.GetComponent<effect>();
        Ee.radius = radius;
        Ee.dmg = dmg;
        Ee.time = time;
        Ee.expandSpeed = expandSpeed;
        Ee.damageDelay = damageDelay;
        Destroy(gameObject);
    }
}
