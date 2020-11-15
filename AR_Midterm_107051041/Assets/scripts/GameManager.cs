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
    [Header("縮放"), Range(0f, 4f)]
    public float size = 0.3f;
    [Header("企鵝動畫元件")]
    public Animator anipenguin;
    [Header("海獺動畫元件")]
    public Animator animole;

    private void Start()
    {
        print("開始事件執行中");
    }

    public float test = 1;
    public float test2 = 1;
    

    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        penguin.Rotate(0, joystick.Horizontal * turn, 0);
        mole.Rotate(0, joystick.Horizontal * turn, 0);

        penguin.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;
        mole.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;

        penguin.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(penguin.localScale.x, 0.5f, 3.5f);
        mole.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(mole.localScale.x, 0.5f, 3.5f);



        test = Mathf.Clamp(test, 0.5f, 9.9f);

        print(Mathf.Clamp(test2, 0, 10));
    
    }

    public void walk()
    {
        print("走路");
        anipenguin.SetTrigger("Walk");
    }

    public void jump()
    {
        print("跳躍");
        anipenguin.SetTrigger("jump");
    }

    public void jumpjump()
    {
        print("跳跳躍");
        anipenguin.SetTrigger("jump2");
    }

    public void stun()
    {
        print("暈眩");
        anipenguin.SetTrigger("stun");
    }

    public void attack()
    {
        print("攻擊");
        animole.SetTrigger("attack");
    }
}
