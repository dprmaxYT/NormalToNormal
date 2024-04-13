using System;

class Program
{
    static void ConvertToNormals(byte[] data)
    {
        for (int i = 0; i < data.Length; i += 4)
        {
            float r = data[i] / 255f;
            float g = data[i + 1] / 255f;

            float x = (r * 2) - 1;
            float y = (g * 2) - 1;
            float z = (float)Math.Sqrt(1 - x * x - y * y);

            float length = (float)Math.Sqrt(x * x + y * y + z * z);
            x /= length;
            y /= length;
            z /= length;

            data[i] = (byte)((x + 1) / 2 * 255);
            data[i + 1] = (byte)((y + 1) / 2 * 255);
            data[i + 2] = (byte)((z + 1) / 2 * 255);
        }
    }

    static void Main(string[] args)
    {
        // Aquí se supone que tienes una variable "data" que contiene los datos de la imagen
        // ConvertToNormals(data);
    }
}
