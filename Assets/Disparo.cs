using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletSpeed = 10f;

    void Update()
    {
        if (Input.GetButtonDown("Spacebar")) // Cambia "Fire1" a la entrada de teclado que desees usar para disparar
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Crear una nueva bala en la posición del firePoint
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        // Obtener el componente Rigidbody de la bala
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();

        // Aplicar velocidad a la bala en la dirección del firePoint
        bulletRigidbody.velocity = firePoint.forward * bulletSpeed;
    }
}