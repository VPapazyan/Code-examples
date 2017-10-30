using System;


namespace Switch_Statement___Lenovo_K920
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lenovo Vibe Z2 Pro characteristics
            Console.Write("Enter characteristics: ");
            string characteristics = Console.ReadLine();
            switch (characteristics)
            {
                case "model":
                    Console.WriteLine("Lenovo Vibe Z2 Pro");
                    break;
                case "network":
                    Console.WriteLine("GSM / HSPA / LTE");
                    break;
                case "launch":
                    Console.WriteLine("2014, August");
                    break;
                case "status":
                    Console.WriteLine("Available, Released 2014, September");
                    break;
                case "Dimensions":
                    Console.WriteLine("156 x 81.3 x 7.7mm");
                    break;
                case "Weight":
                    Console.WriteLine("179g");
                    break;
                case "display type":
                    Console.WriteLine("IPS LCD capacitive touchscreen, 16M colours");
                    break;
                case "display size":
                    Console.WriteLine("6.0 inches");
                    break;
                case "display resolution":
                    Console.WriteLine("1440 x 2560 pixels");
                    break;
                case "multitouch":
                    Console.WriteLine("Yes");
                    break;
                case "protection":
                    Console.WriteLine("Corning Gorilla Glass 3");
                    break;
                case "OS":
                    Console.WriteLine("Android 5.0.2 - Lolipop");
                    break;
                case "chipset":
                    Console.WriteLine("Qualcomm MSM8974AC Snapdragon 801");
                    break;
                case "CPU":
                    Console.WriteLine("Quad-core 2.5 GHz Krait 400");
                    break;
                case "GPU":
                    Console.WriteLine("Adreno 330");
                    break;
                case "card slot":
                    Console.WriteLine("No");
                    break;
                case "internal memory":
                    Console.WriteLine("32GB, 3GB RAM");
                    break;
                case "primary camera":
                    Console.WriteLine("16MP, f/2.2, OIS, autofocus, dual-LED flash");
                    break;
                case "camera features":
                    Console.WriteLine("Geo-tagging, touch focus, face detection, panorama, HDR");
                    break;
                case "secondary camera":
                    Console.WriteLine("5MP");
                    break;
                case "WLAN":
                    Console.WriteLine("Wi-Fi 802.11 a/b/g/n/ac, dual band, hotspot");
                    break;
                case "Bluetooth":
                    Console.WriteLine("4.0, A2DP");
                    break;
                case "GPS":
                    Console.WriteLine("with a-GPS, GLONASS");
                    break;
                case "radio":
                    Console.WriteLine("FM Radio");
                    break;
                case "USB":
                    Console.WriteLine("microUSB 2.0");
                    break;
                case "sensors":
                    Console.WriteLine("accelerometer, proximity, compass");
                    break;
                case "Messaging":
                    Console.WriteLine("SMS(threated view), MMS, Email, Push Mail, IM");
                    break;
                case "Browser":
                    Console.WriteLine("HTML5");
                    break;
                case "Java":
                    Console.WriteLine("No");
                    break;
                case "other features":
                    Console.WriteLine("-Air gestures" + Environment.NewLine + "-MP4/H.264 player" + Environment.NewLine + "-MP3/WAV/WMA/eAAZ+ player" + Environment.NewLine + "-Photo/video editor" + Environment.NewLine + "-Document viewer" + "Voice memo/dial");
                    break;
                case "battery":
                    Console.WriteLine("Non-removable Li-Po 4000 mAh battery");
                    break;
                case "stand-by":
                    Console.WriteLine("Up to 948h");
                    break;
                case "talk time":
                    Console.WriteLine("Up to 45h");
                    break;
                case "colours":
                    Console.WriteLine("Black, Gold, White");
                    break;
                case "price":
                    Console.WriteLine("About 430 Euro");
                    break;
                default:
                    Console.Write("You entered wrong data: ");
                    goto case "model";
            }

            Console.ReadLine();
        }
    }
}
