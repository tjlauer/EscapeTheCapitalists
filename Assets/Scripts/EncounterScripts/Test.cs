using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Test : MonoBehaviour
{

    public TextMeshProUGUI TestText;
    public GameObject StatZone;

    private void Start()
    {
        //TestText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateText()
    {
        TestText.text = ("Goodbye!");
        TextMeshProUGUI enemyCard = Instantiate(TestText, new Vector2(TestText.transform.position.x, TestText.transform.position.y), Quaternion.identity);
        enemyCard.transform.SetParent(StatZone.transform, false);
    }

}
