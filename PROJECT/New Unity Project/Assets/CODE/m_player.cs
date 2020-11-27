using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class m_player : MonoBehaviour
{

    int speed = 7;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float deltaMove = speed * Time.deltaTime;
        float keyForward = Input.GetAxis("Vertical");
        float keySide = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * deltaMove * keyForward);
        transform.Translate(Vector3.right * deltaMove * keySide);
        
    }
    public void Die()
    {
        gameObject.SetActive(false);

        GameManager gameManager = FindObjectOfType<GameManager>();
        gameManager.EndGame();
    }
}
