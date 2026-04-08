using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VanishingPeg : MonoBehaviour
{
    private GameObject[] pegs;
    List<int> disabled = new List<int>();

    void Start()
    {
        pegs = GameObject.FindGameObjectsWithTag("Peg");
        InvokeRepeating(nameof(Vanish), 0f, 3f);
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Vanish()
    {
        int randomPeg = Random.Range(0, pegs.Length);

        pegs[randomPeg].SetActive(false);

        Invoke(nameof(ReAppear), 3f);

    }

    void ReAppear()
    {
        foreach (int i in disabled)
        {
            pegs[i].SetActive(true);
        }
    }

}
