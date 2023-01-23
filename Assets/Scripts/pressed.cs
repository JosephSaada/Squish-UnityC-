using UnityEngine;
using UnityEngine.EventSystems;


public class pressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{

    public bool buttonPressed;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float fireRate = 1.0f;
    private float lastShot = 0.0f;
  

    public void OnPointerDown(PointerEventData eventData)
    {
        buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        buttonPressed = false;
    }           

    void start()
    {
    }
    void Update()
    {
            if (buttonPressed)
            {
                Shoot();
            }
    }
    void Shoot()
    {
        if (Time.time > fireRate + lastShot)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            lastShot = Time.time;
        }                  
    }
}