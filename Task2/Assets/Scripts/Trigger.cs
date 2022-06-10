using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Trigger : MonoBehaviour
{
    public int score;
    [SerializeField] private Text scoreText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Red"))
        {
            Destroy(other.gameObject);
            score++;
        }
        if (other.gameObject.tag.Equals("Blue"))
        {
            other.gameObject.GetComponent<Controller>().isControlled = false;
            //other.gameObject.transform.position = Vector2.Reflect(other.gameObject.transform.position, Vector2.right*0.1f);
            other.gameObject.GetComponent<Rigidbody>().velocity = 
                -Vector2.Reflect(other.gameObject.transform.position, Vector2.right*0.1f);
        }
        
    }
    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
