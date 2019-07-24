using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
    private float movement = 0f;
    public float movementSpeed = 10f;
    public GameObject restartButton,loseComparisonPosition,leftBoudary,RightBoundary;
    Rigidbody2D rb;
    
    // Use this for initialization
	void Start () {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
         movement = Input.GetAxis("Horizontal");
        if (transform.position.y < loseComparisonPosition.transform.position.y)
        {
            Time.timeScale = 0;
            restartButton.SetActive(true);
        }
        if (transform.position.x < leftBoudary.transform.position.x)
        {
            transform.position = new Vector3(-transform.position.x,transform.position.y,transform.position.z);
        }else if (transform.position.x>RightBoundary.transform.position.x)
        {
            transform.position = new Vector3(-transform.position.x, transform.position.y, transform.position.z);
        }
    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement * movementSpeed;
        rb.velocity = velocity;
    }
    public void Restart()
    {
        SceneManager.LoadScene("My Jumper");
    }
}
