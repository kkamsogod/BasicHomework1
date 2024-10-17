using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    private Rigidbody2D rb;
    private float fuel = 100f;
    
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;

    private float currentScore = 0f;
    private float highScore = 0f;

    [SerializeField] private TextMeshProUGUI currentScoreTxt;
    [SerializeField] private TextMeshProUGUI highScoreTxt;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        currentScore = transform.position.y;

        if (currentScore > highScore)
        {
            highScore = currentScore;
        }

        currentScoreTxt.text = $"{currentScore:F0} M";
        highScoreTxt.text = $"High : {highScore:F0} M";
    }

    public void Shoot()
    {
        if (fuel >= FUELPERSHOOT)
        {
            rb.AddForce(Vector2.up * SPEED, ForceMode2D.Impulse);
            fuel -= FUELPERSHOOT;
        }
    }

    public void RestartGame()
    {
        Destroy(gameObject);
        SceneManager.LoadScene("RocketLauncher");
    }
}