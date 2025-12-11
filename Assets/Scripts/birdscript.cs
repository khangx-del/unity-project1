using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flap;
    public LogicScript logic;
    public bool birdIsAlive = true ;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //gameObject.name = "bob";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); 
    }


    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space) == true)
        {
             myRigidbody.linearVelocity = Vector2.up * 15; 
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {       
        logic.gameOver();  
        birdIsAlive = false;        
    }
}
