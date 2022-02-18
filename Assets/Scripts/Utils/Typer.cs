using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class Typer : MonoBehaviour
{
    public float lettersDelay = .1f;

    private TextMeshProUGUI textMesh;
    private string _text;

    private void Awake()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        _text = textMesh.text;
    }

    private void OnEnable()
    { 
        textMesh.text = "";
        Write();
    }

    private void Write()
    {
        StartCoroutine(WriteController());
    }

    IEnumerator WriteController()
    {
        foreach(char c in _text.ToCharArray())
        {
            textMesh.text += c;
            yield return new WaitForSeconds(lettersDelay);
        }
    }
}
