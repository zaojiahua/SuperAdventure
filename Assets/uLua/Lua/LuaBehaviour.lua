require "System.class"

print(LuaBehaviours.__index);
print(LuaBehaviours.__ctype);

LuaBehaviour = class("LuaBehaviour");

function LuaBehaviour:ctor(...)
  setmetatable(self,{__index = LuaBehaviours});

end