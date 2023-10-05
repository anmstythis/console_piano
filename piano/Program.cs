using static System.Net.Mime.MediaTypeNames;

namespace piano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("F1 - первая октава, F2 - вторая, F3 - третья, F4 - четвертая, F5 - пятая, F6 - шестая, F7 - седьмая, F8 - восьмая, F9 - девятая.");
            Console.WriteLine();
            Console.WriteLine("Нажмите \"Z\" одновременно с клавишей для октавы, чтобы сменить её.");
            Console.WriteLine();
            Console.WriteLine("WETYU - чёрные клавиши.");
            Console.WriteLine("ASDFGH - белые клавиши.");

            char keyy = '1';

            ConsoleKeyInfo oct = Console.ReadKey();
            int[] octave = new int[] { };
            octave = OctaveChange(oct);

            while (keyy != (char)ConsoleKey.Escape)
            {
                keyy = Console.ReadKey(true).KeyChar;

                switch (keyy)
                {
                    case 'a':
                        {
                            sound(octave, 1);
                            break;
                        }
                    case 'w':
                        {
                            sound(octave, 2);
                            break;
                        }
                    case 's':
                        {
                            sound(octave, 3);
                            break;
                        }
                    case 'e':
                        {
                            sound(octave, 4);
                            break;
                        }
                    case 'd':
                        {
                            sound(octave, 5);
                            break;
                        }
                    case 'f':
                        {
                            sound(octave, 6);
                            break;
                        }
                    case 't':
                        {
                            sound(octave, 7);
                            break;
                        }
                    case 'g':
                        {
                            sound(octave, 8);
                            break;
                        }
                    case 'y':
                        {
                            sound(octave, 9);
                            break;
                        }
                    case 'h':
                        {
                            sound(octave, 10);
                            break;
                        }
                    case 'u':
                        {
                            sound(octave, 11);
                            break;
                        }
                    case 'z':
                        {
                            octave = OctaveChange(oct);
                            oct = Console.ReadKey();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
        static int[] OctaveChange(ConsoleKeyInfo act)
        {
            if (act.Key == ConsoleKey.F1)
            {
                int[] firstOctave = new int[] { 164, 173, 184, 195, 206, 218, 231, 245, 260, 275, 291, 309 };
                return firstOctave;

            }
            else if (act.Key == ConsoleKey.F2)
            {
                int[] secondOctave = new int[] { 327, 347, 367, 389, 412, 437, 463, 490, 519, 550, 583, 617 };
                return secondOctave;
            }
            else if (act.Key == ConsoleKey.F3)
            {
                int[] thirdOctave = new int[] { 654, 693, 734, 778, 824, 873, 925, 980, 104, 110, 117, 124 };
                return thirdOctave;
            }
            else if (act.Key == ConsoleKey.F4)
            {
                int[] fourthOctave = new int[] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };
                return fourthOctave;
            }
            else if (act.Key == ConsoleKey.F5)
            {
                int[] fifthOctave = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
                return fifthOctave;
            }
            else if (act.Key ==ConsoleKey.F6)
            {
                int[] sixthOctave = new int[] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
                return sixthOctave;
            }
            else if (act.Key == ConsoleKey.F7)
            {
                int[] seventhOctave = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                return seventhOctave;
            }
            else if (act.Key == ConsoleKey.F8)
            {
                int[] eightthOctave = new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 };
                return eightthOctave;
            }
            else if (act.Key == ConsoleKey.F9)
            {
                int[] ninthOctave = new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 };
                return ninthOctave;
            }
            else
                    return null;
            
        }

        static void sound(int[] oct, int num)
        {
            Console.Beep(oct[num], 250);
        }
    }
}
 

