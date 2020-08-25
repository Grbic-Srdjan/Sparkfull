using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput; 

public class PlayerController : MonoBehaviour
{
    public int Speed, ExtraJumps, JumpForce, NumberOfJumps;
    private float MoveInput;
    private Rigidbody2D RB;
    private Vector3 CurrentScale;
    private bool FacingLeft = true;
    public static bool OnGround = true;
    public static int Health = 5, Score = 0;
    public static float PlatformsSpeed;
    public GameObject LivesRemaning, CurrentScore; 

    private void Start()
    {
        ExtraJumps = NumberOfJumps;
        RB = GetComponent<Rigidbody2D>(); 
    }

    void flip()
    {
        FacingLeft = !FacingLeft;
        CurrentScale = transform.localScale;
        CurrentScale.x = CurrentScale.x * -1;
        transform.localScale = CurrentScale; 
    }

    private void Update()
    {
        MoveInput = CrossPlatformInputManager.GetAxis("Horizontal");
        RB.velocity = new Vector2(MoveInput * Speed, RB.velocity.y);
        if (!FacingLeft && MoveInput < 0) flip();
        else if (FacingLeft && MoveInput > 0) flip();
        if ((OnGround || ExtraJumps > 0) && CrossPlatformInputManager.GetButtonDown("Jump")) 
        {
            RB.velocity = new Vector2(RB.velocity.x, JumpForce);
            ExtraJumps--;
            OnGround = false; 
        }
        else if (OnGround) ExtraJumps = NumberOfJumps;
        if (PlatformsSpeed <= 4f) PlatformsSpeed += 0.01f * Time.deltaTime;
        if (Health <= 0) SceneManager.LoadScene("GameOver"); 
        LivesRemaning.GetComponent<Text>().text = "Lives: " + Health;
        CurrentScore.GetComponent<Text>().text = "Score: " + Score;
    }

}
