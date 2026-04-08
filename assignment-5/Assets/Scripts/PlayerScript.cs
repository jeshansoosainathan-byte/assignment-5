using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float moveSpeed = 5f;
    public GameObject discPrefab;
    private GameObject currentDisc = null;
    public Camera camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        //Move horiziontaly
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;

        transform.position = new Vector3(transform.position.x + x, transform.position.y, transform.position.z);

        //drop disc
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentDisc = Instantiate(discPrefab, transform.position, Quaternion.identity);
             
        }


    }
}
