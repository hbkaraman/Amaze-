using UnityEngine;

public class CameraShake : MonoBehaviour
{
    private Vector3 pos;
    private float x, z;
    private float time;
    private bool isAnimationPlaying;
    private float timer;
    public Vector3 resetPos;
    
    void Start()
    {
        timer = time;
    }

    void Update()
    {
        if(isAnimationPlaying)
            iTween.ShakePosition(gameObject, iTween.Hash("amount", pos, "time", time));
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            gameObject.transform.position = resetPos;
            isAnimationPlaying = false;
        }
    }

    public void Shake()
    {
        x = Random.Range(0.03f, 0.07f);
        z = Random.Range(0.03f, 0.07f);
        pos = new Vector3(x,0,z);
        time = Random.Range(0.02f, 0.05f);
        isAnimationPlaying = true;
    }
}