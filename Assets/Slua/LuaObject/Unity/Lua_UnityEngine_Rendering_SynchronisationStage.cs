﻿using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_UnityEngine_Rendering_SynchronisationStage : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"UnityEngine.Rendering.SynchronisationStage");
		addMember(l,0,"VertexProcessing");
		addMember(l,1,"PixelProcessing");
		LuaDLL.lua_pop(l, 1);
	}
}
