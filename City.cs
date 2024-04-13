using System;
using System.IO;

public class City : IRegistry<City>
{
    // Cities file lines mapping
    const int
      sizeName = 15,
      sizeX = 7,
      sizeY = 7,
      startName = 0,
      startX = startName + sizeName,
      startY = startX + sizeX;

    string cityName;

    double x, y;

    public string Key => CityName;

    public string CityName
    {
        get => cityName;
        set
        {
            cityName = value.PadRight(sizeName, ' ').Substring(0, sizeName);
        }
    }
    public double X
    {
        get => x;
        set
        {
            if (value < 0 || value > 1)
                throw new Exception("X out of 0 to 1 interval");
            x = value;
        }
    }

    public double Y
    {
        get => y;
        set
        {
            if (value < 0 || value > 1)
                throw new Exception("Y out of 0 to 1 interval");
            y = value;
        }
    }

    public void WriteData(StreamWriter file)
    {
        if (file != null)
            file.WriteLine($"{CityName}{X:7.5f}{Y:7.5f}");
    }

    public void ReadRegistry(StreamReader file)
    {
        if (file == null)
            return;

        if (!file.EndOfStream)
        {
            string line = file.ReadLine();
            // Get each field of line
            CityName = line.Substring(startName, sizeName);
            X = double.Parse(line.Substring(startX, sizeX));
            Y = double.Parse(line.Substring(startY, sizeY));
        }
    }

    public override string ToString()
    {
        return CityName + " " + X + " " + Y;
    }
}
