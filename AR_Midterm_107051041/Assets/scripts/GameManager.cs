using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("企鵝")]
    public Transform penguin;
    [Header("海獺")]
    public Transform mole;
    [Header("虛擬搖桿")]
    public FixedJoystick joystick;
    [Header("旋轉速度"), Range(0.1f, 20f)]
    public float turn = 1.5f;
    [Header("縮放") , Range(0f , 4f)]
    public float size = 0.3f;

    private void Start()
    {
        print("開始事件執行中");
    }


    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        penguin.Rotate(0, joystick.Horizontal  * turn, 0);
        mole.Rotate(0, joystick.Horizontal * turn, 0);

        penguin.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        mole.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
    }
}
