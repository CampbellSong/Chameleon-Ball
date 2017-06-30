using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System;
public class Change : MonoBehaviour {

    //用于鼠标显示的2D纹理图片 这里使用拖拽方法,也可以使用Resources资源Load加载方式实现初始化  
    public Texture2D cursorTexture;

    public Texture2D normalCursor;
    //这个变量 设置 光标是活跃的(true Or false)  
    public bool showCursor = false;
    //[DllImport("User32.DLL")]
    //public static extern IntPtr LoadCursorFromFile(string fileName);

    //[DllImport("User32.DLL")]
    //public static extern bool SetSystemCursor(IntPtr hcur, uint id);
    //public const uint OCR_NORMAL = 32512;
    //[DllImport("User32.DLL")]
    //public static extern bool SystemParametersInfo(uint uiAction, uint uiParam, IntPtr pvParam, uint fWinIni);
    //public const uint SPI_SETCURSORS = 87;
    //public const uint SPIF_SENDWININICHANGE = 2;
    //public string path;
    void Start()
    {
        Cursor.SetCursor(normalCursor, Vector2.one, CursorMode.Auto);
    }
    void OnMouseOver()
    {

        //将“cursorTexture”鼠标显示的2D纹理图片 替换为光标  
        Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
        //showCursor变量设置为true  
        this.showCursor = true;
    }
    void OnMouseExit()
    {
        //重置默认光标  
        Cursor.SetCursor(normalCursor, Vector2.one, CursorMode.Auto);
        //showCursor变量设置为false  
        this.showCursor = false;
    }
    //void Start()
    //{
    //    path = UnityEngine.Application.dataPath;
    //    int num = path.LastIndexOf("/");
    //    path = path.Substring(0, num);
    //}
    //void FixedUpdate()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        //鼠标点击图标  
    //        IntPtr hcur_click = LoadCursorFromFile(path + "/click.cur");
    //        SetSystemCursor(hcur_click, OCR_NORMAL);
    //    }

    //    if (Input.GetMouseButtonUp(0))
    //    {
    //        //正常状态图标  
    //        IntPtr hcur_normal = LoadCursorFromFile(path + "/normal.cur");
    //        SetSystemCursor(hcur_normal, OCR_NORMAL);
    //    }
    //}
    //void OnApplicationQuit()
    //{
    //    //恢复为系统默认图标  
    //    SystemParametersInfo(SPI_SETCURSORS, 0, IntPtr.Zero, SPIF_SENDWININICHANGE);
    //}
}