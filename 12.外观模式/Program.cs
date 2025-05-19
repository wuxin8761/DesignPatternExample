// See https://aka.ms/new-console-template for more information

using _12.外观模式;

var lights = new TheaterLights();
var projector = new Projector();
var sound = new SoundSystem();
var dvdPlayer = new DvdPlayer();

var homeTheater = new HomeTheaterFacade(lights, projector, sound, dvdPlayer);

// 观看电影
homeTheater.WatchMovie("阿凡达");

// 结束电影
homeTheater.EndMovie();