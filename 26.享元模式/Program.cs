// See https://aka.ms/new-console-template for more information

using _26.享元模式;

Forest forest = new Forest();

forest.PlantTree(10, 20, "Oak", "Green");
forest.PlantTree(15, 25, "Oak", "Green"); // 复用 Oak-Green
forest.PlantTree(20, 30, "Pine", "DarkGreen");

forest.Draw();