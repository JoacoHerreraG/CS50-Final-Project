using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

    public float movementSpeed = 6;
    public float jumpForce = 300;
    public float timeBeforeNextJump = 1.2f;
    private float canJump = 0f;
    Animator anim;
    Rigidbody rb;
    public static float score = 0f;
    float scoreIncrement = 10f;
    public AudioSource backgroundMusic;
    public AudioSource jumpingSound;
    public AudioSource pickupCoin;
    public AudioSource collisionSound;
    public float gameOverTimer = 1f;
    
    void Start() {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    void Update() {
        ControlPlayer();

        if(transform.position.x > 5.5f) {
            transform.position = new Vector3(5.5f, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -5.5f) {
            transform.position = new Vector3(-5.5f, transform.position.y, transform.position.z);
        }

        if (ObstacleSpawner.playing) {
            score += scoreIncrement * Time.deltaTime;
        }
    }

    void ControlPlayer() {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, 0.0f);

        transform.Translate(movement * movementSpeed * Time.deltaTime, Space.World);

        if (Input.GetButtonDown("Jump") && Time.time > canJump) {
                rb.AddForce(0, jumpForce, 0);
                canJump = Time.time + timeBeforeNextJump;
                anim.SetTrigger("jump");
                jumpingSound.Play();
        }
    }

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.tag == "Obstacle") {
            ObstacleSpawner.speed = 0f;
            ObstacleSpawner.playing = false;
            CoinSpawner.playing = false;
            backgroundMusic.Stop();
            collisionSound.Play();
            Invoke("GameOver", gameOverTimer);
        }
        if (collisionInfo.collider.tag == "Coin") {
            score += 50;
            pickupCoin.Play();
            Destroy(collisionInfo.gameObject);
        }
    }

    void GameOver(){
        SceneManager.LoadScene("GameOverScene");        
    }
}