using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    // Fire interval
    public float fireInterval = 1.5f;
    // Fire switch
    private bool isFiring = false;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !isFiring)
        {
            StartCoroutine("FireFunction");
        }
    }

    IEnumerator FireFunction()
    {
        // Switch fire mode ON
        isFiring = true;
        // Shoot dogs
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        // Wait for Interval
        yield return new WaitForSeconds(fireInterval);
        // Swtich fire mode OFF
        isFiring = false;
    }
}
