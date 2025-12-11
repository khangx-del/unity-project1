using UnityEngine;
using UnityEngine.Video;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private float animationSpeed = 0.1f;
    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);
    }
}
