using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.AI;

public class Player_Controller : MonoBehaviour
{
    #region Variables to use: 

    [Header("References:")]
    public static int playerHealth = 100;
    public GameObject lifeIndicator;
    public NavMeshAgent enemyAgent;
    public GameObject instructions;
    
    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        instructions.SetActive(true);
        playerHealth = 100;
        lifeIndicator.GetComponent<GameObject>();
        Destroy(instructions, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerHealth();
    }

    #endregion

    #region Main Methods: 

    private void CheckPlayerHealth()
    {
        if (playerHealth < 100)
        {
            lifeIndicator.SetActive(true);
        }

        if (playerHealth == 0)
        {
            Invoke("RestartGame", 5f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Key")
        {
            Interlude.InterludeManager.KeyFound();
            enemyAgent.GetComponent<NavMeshAgent>().speed = 0;
        }
    }

    private void RestartGame()
    {
        playerHealth = 100;
        SceneManager.LoadScene("InterludeMenu");
    }
    #endregion
}
