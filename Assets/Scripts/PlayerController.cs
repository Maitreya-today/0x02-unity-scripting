using System.Collections;
using System.Collections.Generic;
using ScriptableObjectArchitecture;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private int score = 0;
    [SerializeField]
    private IntGameEvent scoreUpdateEvent;
    [SerializeField]
    private GameEvent victoryEvent;
    public int health = 5;

    private Rigidbody playerRigidBody;
    private void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        playerRigidBody.velocity = movement * speed;
    }

    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Pickup"))
        {
            score++;
            scoreUpdateEvent.Raise(score);
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("Trap"))
        {
            health--;
            Debug.Log("Health: " + health);

            if (health <= 0)
            {
                GameOver();
            }
        }
        else if (other.CompareTag("Goal"))
        {
            victoryEvent.Raise();
            Debug.Log("You win!");
        }
    }
    private void Update()
    {
        if (health <=0 )
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        Debug.Log("Game Over!");
        score = 0;
        health = 5;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}