using UnityEngine;

public class MobileCameraBackground : MonoBehaviour
{
    private WebCamTexture camTexture;

    void Start()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            camTexture = new WebCamTexture();

            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.material.mainTexture = camTexture;
            }

            camTexture.Play();
        }
    }

    void OnDisable()
    {
        if (camTexture != null && camTexture.isPlaying)
        {
            camTexture.Stop();
        }
    }
}