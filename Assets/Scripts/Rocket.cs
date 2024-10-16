using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D rb;
    private float fuel = 100f;
    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;

    int score = 0;

    [SerializeField] private TextMeshProUGUI CurrentScoreTxt;
    [SerializeField] private TextMeshProUGUI HighScoreTxt;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    public void Shoot()
    {
        if (fuel > FUELPERSHOOT)
        {
            rb.AddForce(Vector2.up * SPEED, ForceMode2D.Impulse);
            fuel -= FUELPERSHOOT;
        }

    }
}