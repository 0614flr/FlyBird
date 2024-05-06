using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleConturoller : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    public float moveSpeed=0.05f;
    public float jumpHeight=0.05f;
    public float downSpeed=0.02f;
    public int Health = 1;

    private float horizontalInput;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 30;//帧率修改为10
        rigidbody2d = GetComponent<Rigidbody2D>();//定义一个容器获取右边的值，getcomponent是获取组件，填名字或类型
        //含义是调用方法的
    }
    /// <summary>
    /// 11111111
    /// </summary>
    
    // Update is called once per frame
    void Update()
    {
        //获取水平输入值
        horizontalInput = Input.GetAxis("Horizontal");
        //获取玩家垂直轴向输入值
        //移动一般放在update中
        Vector2 pos = transform.position;
        pos.y = pos.y + moveSpeed*Time.deltaTime;
        pos.x = pos.x + horizontalInput * Time.deltaTime;
        rigidbody2d.MovePosition(pos);
    }
}
