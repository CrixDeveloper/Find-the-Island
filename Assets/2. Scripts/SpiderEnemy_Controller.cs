using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderEnemy_Controller : MonoBehaviour
{
    #region Variables to use: 

    // Private Variables: 
    protected AudioSource spiderAS;
    private bool audioPlaying;

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
        audioPlaying = false;
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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player") && audioPlaying == false)
        {
            spiderAS.PlayOneShot(playerHurt);
            audioPlaying = true;
        }
    }

    #endregion
}
