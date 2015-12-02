require "System.class"

--luabehaviour是所有lua脚本的父类
LuaBehaviour = class("LuaBehaviour");

--将脚本绑定到gameobject上
function LuaBehaviour:addToGameObject(gameObject)
	
	--self.luabehaviours是csharp端传过来的自定义类型
	self.LuaBehaviours = gameObject:AddComponent(LuaBehaviours.GetClassType());
	--luamodule字段保持了对lua文件的引用
	self.LuaBehaviours.luaModule = self;
	
  --赋值
	if self.start then
		self.LuaBehaviours.onStart = self.start;
	end
	
	if self.update then
		self.LuaBehaviours.onUpdate = self.update;
	end
	if self.fixedUpdate then
		self.LuaBehaviours.onFixedUpdate = self.fixedUpdate;
	end
	if self.lateUpdate then
		self.LuaBehaviours.onLateUpdate = self.lateUpdate;
	end
	
	if self.onCollisionEnter then
		self.LuaBehaviours.onOnCollisionEnter = self.onCollisionEnter;
	end
	if self.onCollisionEnter2D then
		self.LuaBehaviours.onOnCollisionEnter2D = self.onCollisionEnter2D;
	end
	if self.onCollisionExit then
		self.LuaBehaviours.onOnCollisionExit = self.onCollisionExit;
	end
	if self.onCollisionExit2D then
		self.LuaBehaviours.onOnCollisionExit2D = self.onCollisionExit2D;
	end
	if self.onCollisionStay then
		self.LuaBehaviours.onOnCollisionStay = self.onCollisionStay;
	end
	if self.onCollisionStay2D then
		self.LuaBehaviours.onOnCollisionStay2D = self.onCollisionStay2D;
	end
	
	if self.onParticleCollision then
		self.LuaBehaviours.onOnParticleCollision = self.onParticleCollision;
	end
	if self.onTriggerEnter then
		self.LuaBehaviours.onOnTriggerEnter = self.onTriggerEnter;
	end
	if self.onTriggerEnter2D then
		self.LuaBehaviours.onOnTriggerEnter2D = self.onTriggerEnter2D;
	end
	if self.onTriggerExit then
		self.LuaBehaviours.onOnTriggerExit = self.onTriggerExit;
	end
	if self.onTriggerExit2D then
		self.LuaBehaviours.onOnTriggerExit2D = self.onTriggerExit2D;
	end
	if self.onTriggerStay then
		self.LuaBehaviours.onOnTriggerStay = self.onTriggerStay;
	end
	if self.onTriggerStay2D then
		self.LuaBehaviours.onOnTriggerStay2D = self.onTriggerStay2D;
	end
	
	if self.onApplicationFocus then
		self.LuaBehaviours.onOnApplicationFocus = self.onApplicationFocus;
	end
	if self.onApplicationPause then
		self.LuaBehaviours.onOnApplicationPause = self.onApplicationPause;
	end
	if self.onApplicationQuit then
		self.LuaBehaviours.onOnApplicationQuit = self.onApplicationQuit;
	end
	
	if self.onEnable then
		self.LuaBehaviours.onOnEnable = self.onEnable;
	end
	if self.onDisable then
		self.LuaBehaviours.onOnDisable = self.onDisable;
	end
	if self.onDestroy then
		self.LuaBehaviours.onOnDestroy = self.onDestroy;
	end
	
	self.gameObject = self.LuaBehaviours.gameObject;
	self.transform = self.LuaBehaviours.transform;
	
	--最后调用awake函数
	if self.awake then
		self:awake();
	end
  
end
