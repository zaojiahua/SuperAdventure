require "System.class";
require "LuaBehaviour";

GameLayer = class("GameLayer",LuaBehaviour);

function GameLayer:ctor(...)
  LuaBehaviour:ctor(...);
  --setmetatable(self,{__index = LuaBehaviour});
end

function GameLayer.onAwake()
  print("awake...");
end

GameObject = UnityEngine.GameObject
local level = GameObject("Level01")
local gameLayer = GameLayer.New();
level.gameObject:AddComponent(gameLayer.GetClassType());


