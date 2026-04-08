using UnityEngine;
using UnityEngine.Windows;

public class MovingScript : MonoBehaviour
{

    int isFlipped = 1;

    public float moveSpeed = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
    }

    private void FixedUpdate()
    {
        Move();
    }

    void OnCollisionEnter2D(UnityEngine.Collision2D collision)
    {

        if (collision.gameObject.tag != "Wall")
        {
            return;
        } else
        {
            isFlipped *= -1;
        }
      
    }

    void Move()
    {

        GetComponent<Rigidbody2D>().linearVelocityX = moveSpeed * Time.deltaTime *  isFlipped;


    }

}
