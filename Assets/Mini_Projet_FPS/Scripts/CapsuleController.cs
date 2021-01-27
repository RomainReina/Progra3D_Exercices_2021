using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleController : MonoBehaviour
{
    [SerializeField] private Transform spawnPointTransform;
    [SerializeField] private Transform CibleHolderTransform;


    private float y = 0f;
    private float z = 0f;

    // Update is called once per frame
    void Start()
    {

        Vector3 posGO = spawnPointTransform.position;


        // Permet de cree des cibles en haut ou en bas alternativement espacées de 6m
        Instantiate(Resources.Load("Capsule"),
            posGO,
            Quaternion.identity,
            CibleHolderTransform);
        
    }
}
