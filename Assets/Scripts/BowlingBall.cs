
using UnityEngine;

public class BowlingBallController : MonoBehaviour
{
    private GameObject bowlingBall;

    public UnityEngine.UI.Slider aimer;

    void Start()
    {
        bowlingBall = gameObject;
    }

    void Update()
    {
        bowlingBall.transform.rotation = Quaternion.Euler(90f, aimer.value, 0f);
        print(bowlingBall.transform.rotation);
    }
}
