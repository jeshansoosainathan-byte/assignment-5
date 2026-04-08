using UnityEngine;

public class VanishingPeg : MonoBehaviour
{
    private GameObject[] pegs;

    void Start()
    {
        pegs = GameObject.FindGameObjectsWithTag("Peg");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
