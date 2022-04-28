using System.Collections;
using System.IO;

namespace FileCompression
{
















    /// <summary>
    /// Summary description for lzwHelper.
    /// </summary>
    public class Helper
    {
        public Helper()
        {
        }

        public class Compress
        {

            public Compress()
            {
            }

            private static readonly int MAX_CODES = 4096;
            private static readonly int BYTE_SIZE = 8;
            private static readonly byte EXCESS = 4;
            private static readonly int ALPHA = 256;
            private static readonly byte MASK1 = 255;
            private static readonly byte MASK2 = 15;
            private static int leftOver;
            private static bool bitsLeftOver;
            private static BufferedStream in1;
            private static BufferedStream out1;

            private static void setFiles(string args)
            {
                string inputFile, outputFile;
                if (args.Length >= 1)
                {
                    inputFile = args;
                    in1 = new BufferedStream(new FileStream(inputFile, FileMode.Open));
                    outputFile = inputFile + ".zip";
                    out1 = new BufferedStream(new FileStream(outputFile, FileMode.CreateNew));
                }
            }

            private static void output(int pcode)
            {
                int c, d;
                if (bitsLeftOver)
                {
                    d = pcode & MASK1;
                    c = (leftOver << EXCESS) + (pcode >> BYTE_SIZE);
                    out1.WriteByte((byte)c);
                    out1.WriteByte((byte)d);
                    bitsLeftOver = false;
                }
                else
                {
                    leftOver = pcode & MASK2;
                    c = pcode >> EXCESS;
                    //out1.write(c);
                    bitsLeftOver = true;
                }
            }

            private static void compress()
            {
                try
                {
                    Hashtable table = new Hashtable();
                    for (int i = 0; i < ALPHA; i++)
                    {
                        table.Add(i, i);
                    }

                    int codeUsed = ALPHA;

                    int c = in1.ReadByte();
                    if (c != -1)
                    {
                        int pcode = c;
                        c = in1.ReadByte();
                        while (c != -1)
                        {
                            int k = (pcode << BYTE_SIZE) + c;
                            int e = c;
                            try
                            {
                                e = (int)table[k];
                            }
                            catch
                            {
                                output(pcode);
                                if (codeUsed < MAX_CODES)
                                {
                                    table.Add(((pcode << BYTE_SIZE) + c), (codeUsed++));
                                }

                                pcode = c;
                            }

                            pcode = e;

                            c = in1.ReadByte();
                        }

                        output(pcode);
                        if (bitsLeftOver)
                        {
                            out1.WriteByte((byte)(leftOver << EXCESS));
                        }
                    }
                    in1.Close();
                    out1.Close();
                }
                catch
                {
                    in1.Close();
                    out1.Close();
                    throw;
                }
            }

            public static void main1(string args)
            {
                setFiles(args);
                compress();
            }
        }

        public class Decompress
        {
            private static readonly int MAX_CODES = 4096;
            private static readonly int BYTE_SIZE = 8;
            private static readonly int EXCESS = 4;
            private static readonly int ALPHA = 256;
            private static readonly int MASK = 15;
            private static readonly int[] s = new int[100000];
            private static int size;
            private static int leftOver;
            private static bool bitsLeftOver;
            private static BufferedStream in1;
            private static BufferedStream out1;

            private static bool setFiles(string args)
            {
                string inputFile, outputFile;
                if (args.Length >= 1)
                {
                    inputFile = args;
                    if (!inputFile.EndsWith(".zip"))
                    {
                        System.Windows.Forms.MessageBox.Show("This is not a valid zip file");
                        return false;
                    }
                    in1 = new BufferedStream(new FileStream(inputFile, FileMode.Open));
                    outputFile = inputFile.Substring(0, inputFile.Length - 4);
                    out1 = new BufferedStream(new FileStream(outputFile, FileMode.CreateNew));
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("This is not a valid data");
                    return false;
                }
                return true;
            }

            private static void output(int code, Hashtable table)
            {
                size = 0;
                while (code >= ALPHA)
                {
                    s[++size] = (int)(table[code]);
                    code = (int)(table[code]);
                }
                s[++size] = code;
                for (int i = size; i >= 0; i--)
                {
                    out1.WriteByte((byte)s[i]);
                }
            }

            private static int getCode()
            {
                int c = in1.ReadByte();
                if (c == -1)
                {
                    return -1;
                }

                int code;
                if (bitsLeftOver)
                {
                    code = (leftOver << BYTE_SIZE) + c;
                }
                else
                {
                    int d = in1.ReadByte();
                    code = (c << EXCESS) + (d >> EXCESS);
                    leftOver = d & MASK;
                }
                bitsLeftOver = !bitsLeftOver;
                return code;
            }

            private static void decompress()
            {
                try
                {
                    Hashtable table = new Hashtable();
                    int codeUsed = ALPHA;
                    for (int i = 0; i < ALPHA; i++)
                    {
                        table.Add(i, i);
                    }

                    int pcode = getCode(), ccode;
                    if (pcode >= 0)
                    {
                        s[0] = pcode;
                        out1.WriteByte((byte)s[0]);
                        size = 0;

                        do
                        {
                            ccode = getCode();
                            if (ccode < 0)
                            {
                                break;
                            }

                            if (ccode < codeUsed)
                            {
                                output(ccode, table);
                                if (codeUsed < MAX_CODES)
                                {
                                    table.Add(codeUsed++, pcode);
                                }
                            }
                            else
                            {
                                table.Add(codeUsed++, pcode);
                                output(ccode, table);
                            }
                            pcode = ccode;
                        } while (true);
                    }
                    out1.Close();
                    in1.Close();
                }
                catch
                {
                    out1.Close();
                    in1.Close();
                    throw;
                }
            }

            public static void main2(string args)
            {
                if (setFiles(args) == true)
                {
                    decompress();
                }
            }

        }
    }
}
