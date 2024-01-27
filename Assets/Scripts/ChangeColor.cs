using UnityEngine;

public class NewColor : MonoBehaviour
{
    [SerializeField] private Color _hoverColor;
    private Color _originalColor;

    private void Start()
    {
        _originalColor = GetComponent<Renderer>().material.color;
    }

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = _hoverColor;
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = _originalColor;
    }
}