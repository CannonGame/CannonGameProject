using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameDisplay : MonoBehaviour
{

    public GameObject[] Names;
    private GameObject placeHolderObject;
    Vector3[] namePosArray = new[] { new Vector3(40, 0, 0), new Vector3(40, -40, 0), new Vector3(40, -80, 0), new Vector3(40, -120, 0) };
    private Vector3 vectorPlaceHolder;
    int randomInt;

    // Calls 3 methods. First method shuffles our name into an array. Second method shuffles the coordinates of our names randomly.
    // Thrid Method puts a random name into a random coordinate and Instatiates it.
    void Start()
    {
        NameGenerator();
        NamePosRandomizer();
        NamePosSetter();
    }


    // Randomly sorts our names into an array.
    public void NameGenerator()
    {
        for (int i = Names.Length - 1; i >= 0; i--)
        {
            randomInt = Random.Range(0, i);
            placeHolderObject = Names[i];
            Names[i] = Names[randomInt];
            Names[randomInt] = placeHolderObject;
            Debug.Log(Names[i]);
        }
    }

    // Randomly sorts the coordinates of our names in an array.
    public void NamePosRandomizer()
    {
        for (int i = namePosArray.Length - 1; i >= 0; i--)
        {
            randomInt = Random.Range(0, i);
            vectorPlaceHolder = namePosArray[i];
            namePosArray[i] = namePosArray[randomInt];
            namePosArray[randomInt] = vectorPlaceHolder;
            Debug.Log(namePosArray[i]);
        }
    }

    // Places our names randomly in a random coordinate Then instantiates a clone of the prefab.
    public void NamePosSetter()
    {
        GameObject name1 = Instantiate(Names[0],namePosArray[0], Quaternion.identity) as GameObject;
        name1.transform.SetParent(GameObject.Find("Canvas").transform, false);
        GameObject name2 = Instantiate(Names[1], namePosArray[1], Quaternion.identity) as GameObject;
        name2.transform.SetParent(GameObject.Find("Canvas").transform, false);
        GameObject name3 = Instantiate(Names[2], namePosArray[2], Quaternion.identity) as GameObject;
        name3.transform.SetParent(GameObject.Find("Canvas").transform, false);
        GameObject name4 = Instantiate(Names[3], namePosArray[3], Quaternion.identity) as GameObject;
        name4.transform.SetParent(GameObject.Find("Canvas").transform, false);
    }
}
