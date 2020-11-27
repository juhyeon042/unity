using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class m_Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if (transform.position.y < 0)
        {
            Destroy(gameObject);
        }

    }
    public void OnTriggerEnter(Collider coll)
    {
        if (coll.tag == "Player")
        {
            m_player p = coll.GetComponent<m_player>();

            if(p != null)
            {
                p.Die();
            }
        }
    }
}
