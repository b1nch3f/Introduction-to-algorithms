//FEB13 Long Contest - EFFPAINT
import java.io.*;
import java.math.*;
import java.util.*;
import java.lang.*;
 
public class Main {
    static int MOD = 1000000007;
    static char[][] board = new char[50][50];
    static List<String> con = new ArrayList<String>();
    static int res = 0;
 
    static void solve() {
        int size = nInt();
        for(int i = 0; i < size; ++i)
            for(int j = 0; j < size; ++j) {
                board[i][j] = nCharacter();
                if(board[i][j] == 'B') {
                    con.add(i+" "+j+" "+i+" "+j+" "+"B");
                    res++;
                }
            }
        out.println(res);
        for(String temp : con)
            out.println(temp);
 
    }
 
    static InputStream in;
    static PrintWriter out;
    static byte[] buf = new byte[1024];
    static int curChar, numChars;
 
    static int read() {
        if (numChars == -1)
            throw new InputMismatchException();
        if (curChar >= numChars) {
            curChar = 0;
            try {
                numChars = in.read(buf);
            } catch (IOException e) {
                throw new InputMismatchException();
            }
            if (numChars <= 0)
                return -1;
        }
        return buf[curChar++];
    }
 
    static int nInt() {
        int c = read();
        while (isSpaceChar(c))
            c = read();
        int sgn = 1;
        if (c == '-') {
            sgn = -1;
            c = read();
        }
        int res = 0;
        do {
            if (c < '0' || c > '9')
                throw new InputMismatchException();
            res *= 10;
            res += c - '0';
            c = read();
        } while (!isSpaceChar(c));
        return res * sgn;
    }
 
    static long nLong() {
        int c = read();
        while (isSpaceChar(c))
            c = read();
        int sgn = 1;
        if (c == '-') {
            sgn = -1;
            c = read();
        }
        long res = 0;
        do {
            if (c < '0' || c > '9')
                throw new InputMismatchException();
            res *= 10;
            res += c - '0';
            c = read();
        } while (!isSpaceChar(c));
        return res * sgn;
    }
 
    static double nDouble() {
        int c = read();
        while (isSpaceChar(c))
            c = read();
        int sgn = 1;
        if (c == '-') {
            sgn = -1;
            c = read();
        }
        double res = 0;
        while (!isSpaceChar(c) && c != '.') {
            if (c < '0' || c > '9')
                throw new InputMismatchException();
            res *= 10;
            res += c - '0';
            c = read();
        }
        if (c == '.') {
            c = read();
            double m = 1;
            while (!isSpaceChar(c)) {
                if (c < '0' || c > '9')
                    throw new InputMismatchException();
                m /= 10;
                res += (c - '0') * m;
                c = read();
            }
        }
        return res * sgn;
    }
 
    static char nCharacter() {
        int c = read();
        while (isSpaceChar(c))
            c = read();
        return (char) c;
    }
 
    static String nString() {
        int c = read();
        while (isSpaceChar(c))
            c = read();
        StringBuilder res = new StringBuilder();
        do {
            res.appendCodePoint(c);
            c = read();
        } while (!isSpaceChar(c));
        return res.toString();
    }
 
    static String nLine0() {
        StringBuilder buf = new StringBuilder();
        int c = read();
        while (c != '\n' && c != -1) {
            buf.appendCodePoint(c);
            c = read();
        }
        return buf.toString();
    }
 
    static String nLine() {
        String s = nLine0();
        while (s.trim().length() == 0)
            s = nLine0();
        return s;
    }
 
    static boolean isSpaceChar(int c) {
        return c == ' ' || c == '\n' || c == '\r' || c == '\t' || c == -1;
    }
 
    public static void main(String[] args) {
        try {
            in = System.in;
            out = new PrintWriter(System.out);
            solve();
            out.close();
        } catch (Exception e) {
            throw new RuntimeException(e);
        }
    }
}