using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class moov : MonoBehaviour
{
    public float acceleration = 20f;
    public float deceleration = 15f;
    public float maxSpeed = 5f;

    private float x = 0;
    private float y = 0;

    private Rigidbody2D r;

    void Start()
    {
        r = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float targetX = 0;
        float targetY = 0;

        
        if (Input.GetKey(KeyCode.W))
            targetY = 1;
        if (Input.GetKey(KeyCode.S))
            targetY = -1;
        if (Input.GetKey(KeyCode.D))
            targetX = 1;
        if (Input.GetKey(KeyCode.A))
            targetX = -1;

        
        x = Mathf.MoveTowards(x, targetX * maxSpeed, acceleration * Time.fixedDeltaTime);
        y = Mathf.MoveTowards(y, targetY * maxSpeed, acceleration * Time.fixedDeltaTime);

        
        if (targetX == 0)
            x = Mathf.MoveTowards(x, 0, deceleration * Time.fixedDeltaTime);
        if (targetY == 0)
            y = Mathf.MoveTowards(y, 0, deceleration * Time.fixedDeltaTime);
        r.linearVelocity = new Vector2(x, y);
    }

}

