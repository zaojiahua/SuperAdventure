require "GameLayer";

LuaManger = {};

function LuaManger.bindLuaComponent(gameObject,luaComponent)
  local component = luaComponent.New();
  component:addToGameObject(gameObject.gameObject);
end

for i=1,10,1 do
	local testui = GameObject("TestUI"..i)
  LuaManger.bindLuaComponent(testui,GameLayer);
end




