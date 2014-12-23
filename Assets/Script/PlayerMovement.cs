using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
    {
    public float moveSpeed;
    public float maxSpeed = 5f;

    public GameObject deathParticles;

    private Vector3 spawn;

    private Vector3 input;

    void Start()
        {
        spawn = transform.position;
        }

    void Update()
        {
        input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        if (rigidbody.velocity.magnitude < maxSpeed)
            {
            rigidbody.AddForce(input * moveSpeed);
            
            }
        }

    void OnCollisionStay(Collision other)
        {
        if (other.transform.tag == "Enemy")
            {
            Instantiate(deathParticles, transform.position, Quaternion.identity);
            transform.position = spawn;
            }
        }
    }
