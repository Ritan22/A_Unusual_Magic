using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;            // Velocità di movimento
    public float mouseSensitivity = 100f;  // Sensibilità del mouse
    public Transform playerCamera;         // Riferimento alla camera del player

    private Rigidbody rb;
    private float cameraRotationX = 0f;    // Rotazione verticale accumulata della camera
    private Vector3 movement;              // Movimento del player

    void Start()
    {
        // Ottieni il componente Rigidbody
        rb = GetComponent<Rigidbody>();

        // Blocca il cursore al centro dello schermo
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        // Movimento WSAD
        float moveHorizontal = Input.GetAxis("Horizontal"); // Movimento laterale (A/D)
        float moveVertical = Input.GetAxis("Vertical");     // Movimento avanti/indietro (W/S)

        // Calcola il movimento in base alla direzione del player
        movement = (transform.forward * moveVertical + transform.right * moveHorizontal) * moveSpeed * Time.fixedDeltaTime;

        // Applica il movimento al Rigidbody
        rb.MovePosition(rb.position + movement);
    }

    void Update()
    {
        // Movimento del mouse
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Rotazione orizzontale del player (asse Y)
        float rotationY = mouseX * mouseSensitivity * Time.deltaTime;
        transform.Rotate(0f, rotationY, 0f);

        // Rotazione verticale della camera (asse X)
        cameraRotationX -= mouseY * mouseSensitivity * Time.deltaTime;
        playerCamera.localRotation = Quaternion.Euler(cameraRotationX, 0f, 0f);
    }

    void LateUpdate()
    {
        // Aggiorna la posizione del player per evitare jittering
        transform.position = rb.position;
    }
}