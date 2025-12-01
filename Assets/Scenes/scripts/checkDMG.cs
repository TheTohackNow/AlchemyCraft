using UnityEngine;

public class checkDMG : MonoBehaviour
{
    public float dmg = 5;
    private float timer;
    public float liveTime = 3.0f;
    void Update()
    {
        if(gameObject.tag == "projectile")
        {
            timer += Time.deltaTime;
            if (timer > liveTime)
            {
                Destroy(gameObject);
            }
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
            if(gameObject.tag == "projectile")
            {
                Destroy(gameObject);
            }

        }
    }
}
