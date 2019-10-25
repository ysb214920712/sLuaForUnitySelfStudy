import "UnityEngine"

function main()
    print("Lua创建了一个Cube")
    local cube = GameObject.CreatePrimitive(PrimitiveType.Cube)
    local slider = GameObject.Find("Canvas/Slider"):GetComponent(UI.Slider)
    slider.minValue = 1
    slider.maxValue = 10
    slider.onValueChanged:AddListener(
        function(v)
            cube.transform.localScale = Vector3(v, v, v)
            print("Lua改变了Cube大小")
        end
    )
    local btn = GameObject.Find("Canvas/Button"):GetComponent("Button")
    btn.onClick:AddListener(function()
        local colors={Color.red,Color.blue,Color.green,Color.cyan,Color.grey,
                Color.white,Color.yellow,Color.magenta,Color.black}
        local mat = cube:GetComponent(Renderer).material
        mat.color = colors[math.random(#colors)]
        print("Lua更改了Cube的颜色")
	end)
end

function Awake()
    print("Awake")
end

function Start()
    print("Start")
end

function FixedUpdate()
    print("FixedUpdate")
end

function Update()
    print("luaUpdate")
end

function LateUpdate()
    print("LateUpdate")
end

function OnDisable()
    print("OnDisable")
end

function OnDestroy()
    print("OnDestroy")
end