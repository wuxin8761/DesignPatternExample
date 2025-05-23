// See https://aka.ms/new-console-template for more information

using _25.中介者模式;

var chatRoom = new ChatRoom();

var alice = new User("Alice", chatRoom);
var bob = new User("Bob", chatRoom);
var charlie = new User("Charlie", chatRoom);

alice.Send("Hello everyone!");
        
// 输出：
// [Alice]: Hello everyone!
// [Alice]: Hello everyone!