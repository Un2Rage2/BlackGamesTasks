using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ScoreBlue : MonoBehaviour
{
    public int score;
    [SerializeField] private Text scoreText2;
    private Rigidbody _rigidbody;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Blue"))
        {
            Destroy(other.gameObject);
            score++;
        }

        if (other.gameObject.tag.Equals("Red"))
        {
            other.gameObject.GetComponent<Controller>().isControlled = false;
            //other.gameObject.transform.position = Vector2.Reflect(other.gameObject.transform.position, Vector2.right*0.1f);
             other.gameObject.GetComponent<Rigidbody>().velocity = 
                 -Vector2.Reflect(other.gameObject.transform.position, Vector2.right*0.1f);
        }
    }
    void Update()
    {
        scoreText2.text = score.ToString();
    }

}
