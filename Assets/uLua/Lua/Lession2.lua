

local function f1()
  print("hello")
  setfenv(f1,{});
  print("f end");
end
print("hha");

f1();

print("world");

