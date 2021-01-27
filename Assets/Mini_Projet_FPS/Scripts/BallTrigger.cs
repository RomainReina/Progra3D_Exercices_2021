using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{
    [SerializeField] private float XCapsuleMovement = 1f;
    [SerializeField] private float YCapsuleMovement = 0f;

    [SerializeField] private float ZCapsuleMovement = 1f;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Layer: " + other.gameObject.layer);
        Debug.Log("Name: " + other.gameObject.name);
        if (other.gameObject.layer == 10) // Ne detruit que le Layer 10 (Cible)
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.layer == 11) // Ne change la couleur que du Layer 11 (Cube)
        {
            // Je vais modifier le material, je le set aleatoirement
            other.gameObject.GetComponent<Renderer>().material.color =
                Color.HSVToRGB(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }

        if (other.gameObject.layer == 12) // Ne change que la position du Layer 12 (Capsule)
        {
            // Je cree un vecteur pour set une legere modification dur le transforme de ma capsule
            Vector3 capsulePos = new Vector3(
                Random.Range(-XCapsuleMovement, XCapsuleMovement),
                Random.Range(-YCapsuleMovement, YCapsuleMovement),
                Random.Range(-ZCapsuleMovement, ZCapsuleMovement));

            // Je set la nouvelle transform de ma capsule
            other.gameObject.GetComponent<Transform>().position = new Vector3(
                other.gameObject.GetComponent<Transform>().position.x + capsulePos.x,
                other.gameObject.GetComponent<Transform>().position.y + capsulePos.y,
                other.gameObject.GetComponent<Transform>().position.z + capsulePos.z);


        }
    }
}
