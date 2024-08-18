using System;
using System.Runtime.CompilerServices;

namespace ModelPratice
{
    class Computer
    {
        public int ComputerId { get; }
        public string MotherBoard { get; set; }
        public int CPUCores { get; set; }
        public bool HasWifi { get; set; }
        public bool HasLTE { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string VideoCard { get; set; }

        public Computer(string motherBoard, int cpuCores, bool hasWifi, bool hasLTE, DateTime releaseDate, decimal price, string videoCard)
        {
            MotherBoard = motherBoard;
            CPUCores = cpuCores;
            HasWifi = hasWifi;
            HasLTE = hasLTE;
            ReleaseDate = releaseDate;
            Price = price;
            VideoCard = videoCard;
        }
    }
}
