using UnityEngine;

public class hp : MonoBehaviour
{
    public float Hp;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Hp <= 0)
            Destroy(gameObject);
    }
}
