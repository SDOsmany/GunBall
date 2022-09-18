using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField][Range(5f, 20f)] private float ballSpeed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up*Time.deltaTime*ballSpeed;
    }
}
