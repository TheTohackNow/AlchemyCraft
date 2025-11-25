using UnityEngine;

public class hp : MonoBehaviour
{
    public int Hp;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Hp <= 0)
            Destroy(gameObject);
    }
}
