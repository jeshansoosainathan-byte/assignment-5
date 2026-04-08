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
        InvokeRepeating(nameof(Vanish), 0f, 1f);
        InvokeRepeating(nameof(ReAppear), 1f, 2f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Vanish()
    {
        int randomPeg = Random.Range(0, pegs.Length);

        pegs[randomPeg].SetActive(false);
        disabled.Add(randomPeg);

    }

    void ReAppear()
    {
        if (disabled.Count == 0) return;


        int randomPeg = Random.Range(0, disabled.Count);   
        int pegIndex = disabled[randomPeg];

        pegs[pegIndex].SetActive(true);
            disabled.RemoveAt(randomPeg);
        

    }

}
