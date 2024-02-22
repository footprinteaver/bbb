using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWarp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        int layerMask = 1 << LayerMask.NameToLayer("Warp");
        if ((layerMask & (1 << other.gameObject.layer)) != 0)
        {
            SceneManager.LoadScene("WorldScene"); // "WorldScene"À¸·Î ¾À ÀüÈ¯
        }
    }
}
