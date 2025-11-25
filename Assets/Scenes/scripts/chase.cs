using UnityEngine;

public class chase : MonoBehaviour
{
    GameObject p;
    public Transform t;
    public Rigidbody2D r;
    float x, y;
    public int dmg;
    void Start()
    {
        p = GameObject.FindWithTag("Player");
    }

    
    void Update()
    {
        Transform pt = p.transform;
        x = pt.position.x - t.position.x;
        y = pt.position.y - t.position.y;
        float angle = Mathf.Atan2(y, x) * Mathf.Rad2Deg;
        t.rotation = Quaternion.Euler(0, 0, angle);
        r.linearVelocity = new Vector2(x * 4, y * 4);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            hp enemy = collision.gameObject.GetComponent<hp>();

            if (enemy != null) 
            {
                enemy.Hp -= dmg;
            }

            Destroy(gameObject);
        }
    }
}
