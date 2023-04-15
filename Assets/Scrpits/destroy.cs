using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(destroysound());
        this.gameObject.GetComponent<AudioSource>().pitch = 1f;
    }

    // Update is called once per frame
  IEnumerator destroysound()
    {
        yield return new WaitForSeconds(1f);
        Destroy(this.gameObject);
    }
    public void random_sound()
    {
        int temp = Random.Range(1, 3);
        switch (temp)
        {
            case 1:
                {
                    this.gameObject.GetComponent<AudioSource>().pitch = 1f;
                    break;
                }
            case 2:
                {
                    this.gameObject.GetComponent<AudioSource>().pitch = 1.3f;
                    break;
                }
            case 3:
                {
                    this.gameObject.GetComponent<AudioSource>().pitch = 1.6f;
                    break;
                }
        }
    }
}
