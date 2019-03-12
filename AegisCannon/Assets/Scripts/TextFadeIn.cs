using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeIn : MonoBehaviour
{
    public float delay = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Starts Coroutine Method to fade in buttons based on specified delay.
        StartCoroutine(FadeTextIn(delay, GetComponent<Image>()));
    }

    // Coroutine Method to fade in the game over message.
    public IEnumerator FadeTextIn(float t, Image i)
    {
        i.color = new Color(i.color.r, i.color.g, i.color.b, 0);

        while (i.color.a < 1.0f)
        {
            i.color = new Color(i.color.r, i.color.g, i.color.b, i.color.a + (Time.deltaTime / t));
            yield return null;
        }
    }

}
