// See https://aka.ms/new-console-template for more information


using OtusHomework9;

Settings settings = new () { Attempts = 5, Min = 1, Max = 10 };
INumberGenerator generator = new RandomNumberGenerator();
IInput input = new ConsoleInput();
IOutput output = new ConsoleOutput();


IGame game = new GuessNumber(settings, generator, input, output);

game.Start();

