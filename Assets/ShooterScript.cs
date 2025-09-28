using UnityEngine;
using UnityEngine.InputSystem; // required for new Input System

public class Shooter : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform shootPoint;
    public float shootForce = 10f;

    void Update()
    {
        // Use new Input System
        if (Keyboard.current.spaceKey.wasPressedThisFrame || Mouse.current.leftButton.wasPressedThisFrame)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, shootPoint.position, shootPoint.rotation);

        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.AddForce(shootPoint.forward * shootForce, ForceMode.Impulse);

        Destroy(projectile, 5f);
    }
}
