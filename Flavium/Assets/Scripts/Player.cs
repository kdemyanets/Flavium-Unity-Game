using UnityEngine;

public class Player : MonoBehaviour
{

    public float jumpForce;
    public Rigidbody2D rb;

    void Start()
    {
        Application.targetFrameRate = 60;
    }

    public AudioSource myFX;
    public AudioClip JumpFx;
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
            // transform.Translate(-transform.right * speed * Time.deltaTime);

            // myFX.PlayOneShot(JumpFx); pop-pop sonund :(
            SoundManager.snd.PlayPianoSounds();
        }



    }


    //public void JumpSound()
    //{
    //    myFX.PlayOneShot(JumpFx);
    //}


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("ColumnPart") || other.gameObject.CompareTag("Floor"))
        {
            GameManager.instance.End();

            // myFX.mute = true;
           
            SoundManager.snd.audio_.mute = true;
        }
    
    }

}
