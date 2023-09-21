using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OtusHomework9
{
    public class GuessNumber : IGame
    {
        private readonly Settings _settings;
        private readonly INumberGenerator _generator;
        private readonly IInput _input;
        private readonly IOutput _output;
             

        public GuessNumber(Settings settings, INumberGenerator generator, IInput input, IOutput output)
        {
            _settings = settings;
            _generator = generator;
            _input = input;
            _output = output;
        }


        public void Start()
        {
            while (true)
            {
                int randomNumber = _generator.Generate(_settings.Min, _settings.Max);


                _input.Write ($"Задано число от {_settings.Min} до {_settings.Max}. " +
                    $"Отгадайте его за {_settings.Attempts} попыток");

                int attempts = 0;


                while (attempts < _settings.Attempts)
                {
                    attempts++;

                    int number = Convert.ToInt32(_output.Read());

                    if (attempts == _settings.Attempts)
                    {
                        _input.Write("Вы проиграли.");
                        break;
                    }
                    else if (number == randomNumber)
                    {
                        _input.Write("Поздравляем! Вы угадали!");
                        break;
                    }
                    else if (number < randomNumber)
                    {
                        _input.Write($"Выбранное число меньше загаданного. Осталось попыток: {_settings.Attempts - attempts}");
                    }
                    else if (number > randomNumber)
                    {
                        _input.Write($"Выбранное число больше загаданного. Осталось попыток: {_settings.Attempts - attempts}");
                    }
                }

                _input.Write("Еще раз сыграем?  да - y, нет - любая другая клавиша");

                string answer = _output.Read();

                if (answer != "y")
                {
                    return;
                }
            }

        }
    }
}
