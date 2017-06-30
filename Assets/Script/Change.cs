using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour {

    //用于鼠标显示的2D纹理图片 这里使用拖拽方法,也可以使用Resources资源Load加载方式实现初始化  
    public Texture2D cursorTexture;
    //这个变量 设置 光标是活跃的(true Or false)  
    public bool showCursor = false;

    void OnMouseOver()
    {
        //将“cursorTexture”鼠标显示的2D纹理图片 替换为光标  
        Cursor.SetCursor(this.cursorTexture, Vector2.zero, CursorMode.Auto);
        //showCursor变量设置为true  
        this.showCursor = true;
    }
    void OnMouseExit()
    {
        //重置默认光标  
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        //showCursor变量设置为false  
        this.showCursor = false;
    }

    private void SetCustomCursor()
    {

    }
}