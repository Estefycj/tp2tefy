using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float speed = 5f;
    private Camera mainCamera;

    void Start()
    {
        // Obtener la cámara principal
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Obtener la entrada del teclado
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Calcular el vector de movimiento
        Vector3 movement = new Vector3(moveHorizontal, 0f) * speed * Time.deltaTime;

        // Obtener los límites del viewport
        Vector3 minViewportBounds = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, mainCamera.nearClipPlane));
        Vector3 maxViewportBounds = mainCamera.ViewportToWorldPoint(new Vector3(1, 1, mainCamera.nearClipPlane));

        // Restringir el movimiento dentro de los límites del viewport
        Vector3 newPosition = transform.position + movement;
        newPosition.x = Mathf.Clamp(newPosition.x, minViewportBounds.x, maxViewportBounds.x);
        newPosition.z = Mathf.Clamp(newPosition.z, minViewportBounds.z, maxViewportBounds.z);

        // Aplicar el movimiento al jugador
        transform.position = newPosition;
    }
    
}
