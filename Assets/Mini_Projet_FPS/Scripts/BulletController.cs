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
        Debug.Log("Layer: " + other.gameObject.layer);
        Debug.Log("Name: " + other.gameObject.name);
        if (other.gameObject.layer == 10)  // Ne detruit que le Layer 10 (Cible)
        {
            Destroy(other.gameObject);
        } 
        if (other.gameObject.layer == 11)  // Ne detruit que le Layer 11 (Cube)
        {
            other.gameObject.GetComponent<Renderer>().material.color=Color.HSVToRGB(Random.Range(0f,1f),Random.Range(0f,1f),Random.Range(0f,1f));
        } 
        
            
        
        
    
}
}
