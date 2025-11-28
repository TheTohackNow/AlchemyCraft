using System.Collections;
using UnityEngine;

public class effect : MonoBehaviour
{
    public float radius;
    public float expandSpeed;
    public float damageDelay;
    public float dmg;
    public float time;

    private float timer;

    void Start()
    {
        StartCoroutine(CountDown());
    }

    void Update()
    {
        if (transform.localScale.x < radius)
        {
            transform.localScale += Vector3.one * expandSpeed * Time.deltaTime;
        }

        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            DealDamage();
            timer = damageDelay;
        }
    }

    void DealDamage()
    {
        
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, transform.localScale.x / 2f);

        foreach (Collider2D hit in hits)
        {
            hp enemy = hit.GetComponent<hp>();

            if (enemy != null)
            {
                enemy.Hp -= dmg;
            }
        }
    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
}
