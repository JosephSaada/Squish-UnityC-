using UnityEngine;

public class enemy : MonoBehaviour

{
    public int health = 100;

    public GameObject deathEffect;
    public GameObject blood;

    private Shake shake;
    public void TakeDamage(int damage)
    {
        health -= damage;
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        shake.CamShake();

        if (health <= 0)
        {

            Instantiate(blood, transform.position, Quaternion.identity);
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            die();
        }
    }                
    void die ()
    {
        Destroy(gameObject);

    }
    void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Shake>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
