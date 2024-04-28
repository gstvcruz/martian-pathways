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
                throw new ArgumentOutOfRangeException("Coordinate X must be between 0.99999 and 0.00000.");
            x = value;
        }
    }

    public double Y
    {
        get => y;
        set
        {
            if (value < 0 || value > 1)
                throw new ArgumentOutOfRangeException("Coordinate Y must be between 0.99999 and 0.00000.");
            y = value;
        }
    }

    public void WriteData(StreamWriter file)
    {
        if (file != null)
            file.WriteLine(ToString());
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
        return CityName + X.ToString("0.00000") + Y.ToString("0.00000");
    }
}
