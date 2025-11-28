using UnityEngine;

public class checkDMG : MonoBehaviour
{
    public float dmg = 5;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("go");
        hp enemy = collision.GetComponent<hp>();
        if (!collision.CompareTag("Player"))
        {
            if (enemy != null)
            {
                enemy.Hp -= dmg;
            }


        }
    }
}
