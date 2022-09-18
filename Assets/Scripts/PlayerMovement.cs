using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Allows the player to move
/// 
/// player speed
/// </summary>

public class PlayerMovement : MonoBehaviour
{
    float horizontal;
    float vertical;
    private Rigidbody2D rb2d;
    [SerializeField][Range(1f,15f)] private float playerSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (rb2d != null)
        {
            Debug.Log("Attached! wohoo!");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        //Debug.Log("Horizontal " + horizontal);
        //Debug.Log("Vertical " + vertical);

    }

    void FixedUpdate() 
    {
        rb2d.velocity = new Vector2(horizontal * playerSpeed, vertical * playerSpeed);
        PlayerRotation();
    }

    void PlayerRotation() 
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        angle -= 90;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, playerSpeed * Time.deltaTime);
       
    }
    
}
