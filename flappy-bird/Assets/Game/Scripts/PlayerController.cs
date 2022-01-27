using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class PlayerController : MonoBehaviour
{
    public GameObject gameEndUI;

    [SerializeField] TextMeshProUGUI scoreText;
    private Rigidbody2D _playerRB;
    private int _score = 0;
    private bool _isDead = false;

    // Start is called before the first frame update
    void Start()
    {
        _playerRB = transform.GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && !_isDead)
        {
            _playerRB.velocity = new Vector2(0, 8f);
        }
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("borderTrigger"))
        {
            _score++;
            scoreText.text = _score.ToString();
        }

        if (collision.gameObject.CompareTag("floorTrigger") || collision.gameObject.CompareTag("pipeTrigger"))
        {
            //SceneManager.LoadScene("GameOver");
            gameEndUI.SetActive(true);
        }
    }


   
}
