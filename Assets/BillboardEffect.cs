using UnityEngine;

public class BillboardCanvas : MonoBehaviour
{
    [SerializeField]
    private Camera camaraPrincipal;

    void Start()
    {
        camaraPrincipal = Camera.main;
    }

    void LateUpdate()
    {
        if (camaraPrincipal == null) return;

        transform.LookAt(transform.position + camaraPrincipal.transform.forward);
    }
}
