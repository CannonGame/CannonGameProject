using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonDisplayDelay : MonoBehaviour
{
    public GameObject RetryButton;
    public GameObject HomeButton;
    public GameObject ExitButton;

    // Start is called before the first frame update
    void Start()
    {
        // Hides all buttons
        RetryButton.SetActive(false);
        HomeButton.SetActive(false);
        ExitButton.SetActive(false);

        // Starts Coroutine ButtonDelay that waits 3 seconds and displays all buttons.
        StartCoroutine(ButtonDelay());

    }

    // Method to activate buttons.
    public void ActivateButtons()
    {

        RetryButton.SetActive(true);
        HomeButton.SetActive(true);
        ExitButton.SetActive(true);

    }

    // Coroutine Method to wait 3 seconds and then display all buttons.
    public IEnumerator ButtonDelay()
    {

        yield return new WaitForSeconds(3);
        ActivateButtons();

    }

}
