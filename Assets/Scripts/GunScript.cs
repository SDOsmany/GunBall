using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    private PlayerMovement pm;

    [SerializeField] private GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        pm = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            Vector3 current = transform.position;
            current.x += 1.5f;
            Instantiate(Ball, current, pm.gameObject.transform.rotation);
        }
    }
}
