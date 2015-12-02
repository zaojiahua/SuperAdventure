require "LuaBehaviour";

--子类
GameLayer = class("GameLayer",LuaBehaviour);

function GameLayer:awake()

end

function GameLayer:start()
	print(self.gameObject.name);
end




