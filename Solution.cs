//a template for participating in programming contests using c#
//Developed using Microsoft Visual Studio Express 2012

using System;
using System.IO;
using System.Text;

public class Solution
{
    public static void Main(string[] args)
    {
        Stream inputStream = Console.OpenStandardInput();
        InputReader inp = new InputReader(inputStream);
        Stream outputStream = Console.OpenStandardOutput();
        OutputWriter outp = new OutputWriter(outputStream);
        Solver algorithm = new Solver();
        algorithm.solve(inp, outp);
        outp.close();
    }
}

class Solver
{
    public void solve(InputReader inp, OutputWriter outp)
    {
        //hello-world
        outp.println("hello-world");        
    }
}


class InputReader
{
    private Stream stream;
    private byte[] buf;
    private int curChar;
    private int numChars;
    private int size;

    public InputReader(Stream stream)
    {
        this.stream = stream;
        size = 1 << 10;
        buf = new byte[size];
    }

    public int read()
    {
        if (numChars == -1)
            throw new Exception("inputMismatch");

        if (curChar >= numChars)
        {
            curChar = 0;
            try
            {
                numChars = stream.Read(buf, 0, size);
            }
            catch (IOException e)
            {
                throw new IOException(e.StackTrace);
            }
            if (numChars <= 0)
                return -1;
        }
        return buf[curChar++];
    }

    public int nInt()
    {
        int c = read();
        while (isSpaceChar(c))
            c = read();
        int sgn = 1;
        if (c == '-')
        {
            sgn = -1;
            c = read();
        }
        int res = 0;
        do
        {
            if (c < '0' || c > '9')
                throw new Exception("inputMismatch");
            res *= 10;
            res += c - '0';
            c = read();
        } while (!isSpaceChar(c));
        return res * sgn;
    }

    public long nLong()
    {
        int c = read();
        while (isSpaceChar(c))
            c = read();
        int sgn = 1;
        if (c == '-')
        {
            sgn = -1;
            c = read();
        }
        long res = 0;
        do
        {
            if (c < '0' || c > '9')
                throw new Exception("inputMismatch");
            res *= 10;
            res += c - '0';
            c = read();
        } while (!isSpaceChar(c));
        return res * sgn;
    }

    public double nDouble()
    {
        int c = read();
        while (isSpaceChar(c))
            c = read();
        int sgn = 1;
        if (c == '-')
        {
            sgn = -1;
            c = read();
        }
        double res = 0;
        while (!isSpaceChar(c) && c != '.')
        {
            if (c < '0' || c > '9')
                throw new Exception("inputMismatch");
            res *= 10;
            res += c - '0';
            c = read();
        }
        if (c == '.')
        {
            c = read();
            double m = 1;
            while (!isSpaceChar(c))
            {
                if (c < '0' || c > '9')
                    throw new Exception("inputMismatch");
                m /= 10;
                res += (c - '0') * m;
                c = read();
            }
        }
        return res * sgn;
    }

    public char nCharacter()
    {
        int c = read();
        while (isSpaceChar(c))
            c = read();
        return (char)c;
    }

    public String nString()
    {
        int c = read();
        while (isSpaceChar(c))
            c = read();
        StringBuilder res = new StringBuilder();
        do
        {
            res.Append((char)c);
            c = read();
        } while (!isSpaceChar(c));
        return res.ToString();
    }

    public String nLine0()
    {
        StringBuilder buf = new StringBuilder();
        int c = read();
        while (c != '\n' && c != -1)
        {
            buf.Append((char)c);
            c = read();
        }
        return buf.ToString();
    }

    public String nLine()
    {
        String s = nLine0();
        while (s.Trim().Length == 0)
            s = nLine0();
        return s;
    }

    public String nLine(bool ignoreEmptyLines)
    {
        if (ignoreEmptyLines)
            return nLine();
        else
            return nLine0();
    }

    public static bool isSpaceChar(int c)
    {
        return c == ' ' || c == '\n' || c == '\r' || c == '\t' || c == -1;
    }
}

class OutputWriter
{
    private StreamWriter writer;

    public OutputWriter(Stream stream)
    {
        writer = new StreamWriter(new BufferedStream(stream));
    }

    public void print(params Object[] objects)
    {
        for (int i = 0; i < objects.Length; i++)
        {
            if (i != 0)
                writer.Write(' ');
            writer.Write(objects[i]);
        }
    }

    public void println(params Object[] objects)
    {
        print(objects);
        writer.WriteLine();
    }

    public void close()
    {
        writer.Close();
    }
}


