using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Transform ballHolderTransform;
    [SerializeField] private Transform spawnPointTransform;
    [SerializeField] private Rigidbody playerRigidbody;

    [SerializeField] private float movementSpeed = 0.5f;
    [SerializeField] private float cameraSensibility = 10;
    [SerializeField] private float speedBullet = 1000;
    private float yawn = 0f;
    private float pitch = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        MoveCamera();
        Shoot();

    }

    private void MovePlayer()
    {
        // cache calcule des vecteurs avant et Droit
        Vector3 cameraRight = cameraTransform.right;
        Vector3 cameraForward = cameraTransform.forward;

        // Calcul du deplacement du joueur
        Vector3 deltaPosition =
            new Vector3(cameraRight.x, 0f, cameraRight.z) * Input.GetAxis("Horizontal")
            + new Vector3(cameraForward.x, 0f, cameraForward.z) * Input.GetAxis("Vertical");

        // deplacement du joueur
        playerRigidbody.MovePosition(playerRigidbody.position + deltaPosition * movementSpeed);
    }

    private void MoveCamera()
    {
        // Calcul du rotation de la camera
        yawn += Input.GetAxis("Mouse X") * cameraSensibility;
        pitch -= Input.GetAxis("Mouse Y") * cameraSensibility;
        pitch = Mathf.Clamp(pitch, -90f, 90f);

        //rotation de la camera
        cameraTransform.localEulerAngles = new Vector3(
            pitch,
            yawn,
            0f);
    }

    private void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject ball = (GameObject) Instantiate(Resources.Load("Bullet"), // quoi
                spawnPointTransform.position, // pos
                Quaternion.identity, // angle 
                ballHolderTransform); // parent
            
            ball.GetComponent<Rigidbody>()
                .AddForce(cameraTransform.forward * speedBullet);
        }
    }
    
    
    
}
