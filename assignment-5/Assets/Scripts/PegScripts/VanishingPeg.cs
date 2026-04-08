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
        InvokeRepeating(nameof(ReAppear), 2f, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Vanish()
    {
        int randomPeg = Random.Range(0, pegs.Length);

        pegs[randomPeg].SetActive(false);

        
    }

    void ReAppear()
    {
        int i = disabled.Count;

        int randomPeg = Random.Range(0, i);   

        if (i > 0)
        {
            pegs[disabled[randomPeg]].SetActive(true);
            disabled.RemoveAt(randomPeg);
        }

    }

}
