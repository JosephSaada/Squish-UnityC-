using UnityEngine;

public class Playermovement : MonoBehaviour
{                        
    private Rigidbody2D body;
    [SerializeField] private float speed;
    [SerializeField] private float jump;
    public Joystick joystick;
    public bool facingright;
        

                      

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();

    }
    void Start()
    { 
    }              
    private void flip()
    {
        facingright = !facingright;
        transform.Rotate(0f, 180f, 0f);
    } 
    void Update()
    {

        float verticalMove = joystick.Vertical;

          body.velocity = new Vector2(joystick.Horizontal * speed, body.velocity.y);
            if (joystick.Vertical >= 0.5f)
            {
                body.velocity = new Vector2(body.velocity.x, jump);
            }
            if(joystick.Horizontal < 0 && facingright)
            {
                flip();
            }
            if (joystick.Horizontal > 0 && !facingright)
            {
                flip();
            }
    }
}                                                                                  
