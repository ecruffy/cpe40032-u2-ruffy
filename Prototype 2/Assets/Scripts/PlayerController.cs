using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 0.8f;
    public float xrange = 24;
    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        // Keep player in bounds (x axis)
        if (transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }

        //launch food with spacebar
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //projectile launch
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        //player movement
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * speed);
    }
}
