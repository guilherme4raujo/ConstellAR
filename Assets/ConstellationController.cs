using UnityEngine;
using TMPro;

#if UNITY_ANDROID
using UnityEngine.Android;
#endif

public class ConstellationController : MonoBehaviour
{
    [Header("Referências")]
    public GameObject starPrefab;
    public TextMeshProUGUI orionText;

    [Header("Configurações")]
    public int totalStars = 5;

    private int interactionCount = 0;

    void Start()
    {
#if UNITY_ANDROID
        // Solicita permissão da câmera no Android
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }
#endif

        // Garante que o texto começa escondido
        if (orionText != null)
        {
            orionText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        // Clique no PC
        if (Input.GetMouseButtonDown(0))
        {
            HandleInteraction();
        }

        // Toque no Android
        if (Input.touchCount > 0 &&
            Input.GetTouch(0).phase == TouchPhase.Began)
        {
            HandleInteraction();
        }
    }

    void HandleInteraction()
    {
        interactionCount++;

        if (interactionCount == 1)
        {
            SpawnStars();
        }
        else if (interactionCount == 2)
        {
            ShowOrionText();
        }
    }

void SpawnStars()
{
    Camera cam = Camera.main;

    for (int i = 0; i < totalStars; i++)
    {
        // Posição relativa à câmera (garantido visível)
        Vector3 position = cam.transform.position + 
                           cam.transform.forward * 2f +
                           new Vector3(
                               Random.Range(-1.5f, 1.5f),
                               Random.Range(-1.0f, 1.0f),
                               0
                           );

        Instantiate(starPrefab, position, Quaternion.identity);
    }
}

    void ShowOrionText()
    {
        if (orionText != null)
        {
            orionText.gameObject.SetActive(true);
        }
    }
}