using UnityEngine;

public class TelePeg : MonoBehaviour
{

    public GameObject otherPeg;

    int lockout = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(LockOutDecrease), 0f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
         
    }

    void LockOutDecrease()
    {
        if (lockout > 0)
        {
            lockout--;
        }  

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       

                TelePeg otherScript = otherPeg.GetComponent<TelePeg>();

        if (otherScript.lockout == 0)
        {
            Transform pos = otherPeg.transform;
            pos.position = new Vector3(pos.position.x, pos.position.y, pos.position.z);
            collision.gameObject.transform.position = pos.position;

            lockout = 1;
        }
 

    }
}


