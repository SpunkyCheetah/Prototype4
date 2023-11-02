using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    public GameObject cannonball;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Shoot(5);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            StartCoroutine(SteadyShot(6, 0.25f));
        }
    }

    public void Shoot(int numberOfShots)
    {
        for (int i = 0; i < numberOfShots; i++)
        {
            Instantiate(cannonball, transform.position, transform.rotation);
        }
    }

    IEnumerator SteadyShot(int numberOfShots, float delay)
    {
        for (int i = 0; i < numberOfShots; i++)
        {
            Instantiate(cannonball, transform.position, transform.rotation);
            yield return new WaitForSeconds(delay);
        }
    }
}
