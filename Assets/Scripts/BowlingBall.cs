
using UnityEngine;

public class BowlingBallController : MonoBehaviour
{
    private GameObject bowlingBallBody;

    public UnityEngine.UI.Slider aimer;

    void Start()
    {
        bowlingBallBody = gameObject;
    }

    void Update()
    {
        bowlingBallBody.transform.rotation = Quaternion.Euler(90f, aimer.value, 0f);
    }
}
