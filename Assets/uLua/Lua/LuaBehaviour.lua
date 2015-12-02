require "System.class"

--luabehavio是所有lua的父类
LuaBehaviour = class("LuaBehaviour");

function LuaBehaviour:addToGameObject(gameObject)
	
	self.LuaBehaviours = gameObject:AddComponent(LuaBehaviours.GetClassType());
	self.LuaBehaviours.luaModule = self;
	
  --赋值
	if self.start then
		self.LuaBehaviours.onStart = self.start;
	end
	if self.update then
		self.LuaBehaviours.onUpdate = self.update;
	end
	
	self.gameObject = self.LuaBehaviours.gameObject;
	self.transform = self.LuaBehaviours.transform;
	
	--最后调用awake函数
	if self.awake then
		self:awake();
	end
  
end
