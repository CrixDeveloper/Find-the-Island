using UnityEngine;
using UnityEngine.AI;

public class SpiderEnemy_Controller : MonoBehaviour
{
    #region Variables to use: 

    // Private Variables: 
    protected AudioSource spiderAS;

    [Header("References:")]
    public NavMeshAgent spiderAgent;
    public Transform playerTarget;
    public AudioClip playerHurt;

    #endregion

    #region Frame Dependent Methods: 

    // Start is called before the first frame update
    void Start()
    {
        spiderAS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        FollowPlayer();
    }

    #endregion

    #region Main Methods: 

    private void FollowPlayer()
    {
        spiderAgent.GetComponent<NavMeshAgent>();
        playerTarget.GetComponent<Transform>();

        spiderAgent.destination = playerTarget.transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            spiderAS.PlayOneShot(playerHurt);
        }
    }

    #endregion
}
