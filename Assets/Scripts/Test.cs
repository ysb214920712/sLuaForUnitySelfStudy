using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SLua;

public class Test : MonoBehaviour{

    LuaSvr svr = null;

    void Start () {
		svr = new LuaSvr();// 如果不先进行某个LuaSvr的初始化的话,下面的mianState会爆一个为null的错误..
        LuaSvr.mainState.loaderDelegate += LuasLoader;
		svr.init(null, () => // 如果不用init方法初始化的话,在Lua中是不能import的
		{
            svr.start("createCube");
		});
	}

    // SLua Loader代理方法
    public static byte[] LuasLoader( string fn, ref string absoluteFn )
    {
        fn = fn.Replace(".","/");
        string bytefn = fn.Replace("/", "+");

        string filePath = System.IO.Path.Combine(Application.dataPath, string.Format(Application.dataPath + "/Scripts/Lua/{0}.lua", fn));

        System.IO.FileStream fs = System.IO.File.OpenRead(filePath);
        int len = (int)fs.Length;
        byte[] buffer = new byte[len];
        fs.Read(buffer, 0, len);
        fs.Close();

        return buffer;
    }
}
