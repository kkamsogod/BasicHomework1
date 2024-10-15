using Unity.VisualScripting;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D rb;
    private float fuel = 100f;
    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;
    
    void Awake()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
    }
    
    public void Shoot()
    {
        // TODO : fuel이 넉넉하면 윗 방향으로 SPEED만큼의 힘으로 점프, 모자라면 무시
        if (fuel > 0f)
        {
            rb.AddForce(transform.up * SPEED);
            fuel -= 10f;
        }

        else
        {
            return;
        }
    }
}
