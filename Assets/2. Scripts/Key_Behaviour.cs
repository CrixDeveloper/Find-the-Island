using UnityEngine;

public class Key_Behaviour : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(new Vector3(0f, 45f, 0f) * Time.deltaTime);
    }
}
