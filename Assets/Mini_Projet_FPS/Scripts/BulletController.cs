using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private const float LifeSpawn = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Coroutine coroutine = StartCoroutine(DestroyIn3Second());
    }

    // Update is called once per frame
    private IEnumerator DestroyIn3Second()
    {
        yield return new WaitForSeconds(LifeSpawn);
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {

        
        Debug.Log("Ball Triggered");
        if (Random.Range(0, 1) == 0)
        {
            Destroy(other.gameObject);
        }
        
    
}
}
