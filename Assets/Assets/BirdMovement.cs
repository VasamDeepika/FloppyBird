using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement : MonoBehaviour
{

    Rigidbody2D birdRB;
    [SerializeField]
    float birdSpeed;

    int angle;
    int minAngle=-20;
    int maxAngle=20;
    public ScoreManager score;
    bool touchedGround;
    public GameManager gameManager;
    Animator anim;
    float timer = 0;

    // Start is called before the first frame update
    void Awake()
    {
        birdRB = GetComponent<Rigidbody2D>();
        score = FindObjectOfType<ScoreManager>();
        anim = GetComponent<Animator>();
        birdRB.gravityScale = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3f)
        {
            if (Input.GetMouseButtonDown(0) && GameManager.gameOver == false && GameManager.gameIsPaused == false)
            {
                birdRB.velocity = Vector2.zero;
                birdRB.velocity = new Vector2(birdRB.velocity.x, birdSpeed);
                birdRB.gravityScale = 1;
            }
            BirdRotation();
        }
        else
        {
            birdRB.gravityScale = 0;
        }
    }

    void BirdRotation()
    {
        if (birdRB.velocity.y > 0)
        {
            if (angle <= maxAngle)
            {
                angle = angle + 5;
            }
        }
        else if (birdRB.velocity.y < 0)
        {
            if (angle >= minAngle)
            {
                angle = angle - 5;
            }
        }
        if(touchedGround == false)
        {

        }
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Column")
        {
            score.ScoreIncrement();
        }
        else if(collision.gameObject.tag == "Pipe")
        {
            Debug.Log("game over");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            if(GameManager.gameOver==false)
            {
                gameManager.GameOver();
                BirdDied();
            }
            else
            {
                touchedGround = true;
            }
        }
    }
    void BirdDied()
    {
        touchedGround = true;
        anim.enabled = false;
    }
}
