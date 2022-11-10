using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Numerics;

namespace EncoderRSA
{
    public partial class Form1 : Form
    {
        long d;
        int[] cipher_text;
        uint p, q,n,l,phi_n;
        private static Random rnd = new Random((int)DateTime.Now.Ticks);

        public Form1()
        {
            InitializeComponent();
        }

        // получение длины числа
        public static int GetUintLength(uint n)     
        {
            string d = n.ToString();
            int length = d.Length;
            return length;
        }

        // расширенный алгоритм Евклида
        public static long gcdex(long a, long b, out long x, out long y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            long x1, y1;
            long d = gcdex(b % a, a, out x1, out y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        // взятие обратного по модулю
        public static long invmod(long a, long m)
        {
            long x, y;
            gcdex(a, m, out x, out y);
            x = (x % m + m) % m;
            return x;
        }

        // алгоритм Евклида (обычный), ищем наибольший общий делитель
        public static uint Evclid(uint a, uint b)			
        {
            while (b != 0)
                b = a % (a = b);
            return a;
        }

        // генерация числа e
        public static uint Generate_E(uint phi_n)
        {
            uint E;
            uint e = (uint)(rnd.NextDouble() * phi_n);
            if (Evclid(e, phi_n) == 1)
            {
                E = e;
            }
            else
            {
                while (Evclid(e, phi_n) != 1)
                {
                    e = (uint)(rnd.NextDouble() * phi_n);
                }
                E = e;
            }
            return E;
        }

        // тест Ферма на простоту для генерации p и q
        public static uint FermaTest()
        {
            uint n = (uint)rnd.Next(0, 65536);
            for (int a = 1; a < 10; a++)
            {
                while (BigInteger.ModPow(a, n - 1, n) != 1)
                {
                    n = (uint)rnd.Next(0, 65536);
                    if (BigInteger.ModPow(a, n - 1, n) == 1)
                    {
                        break;
                    }
                }
            }
            return n;
        }

        // генерация p и q (одинакового порядка)
        public static void GeneratePQ(out uint p, out uint q)
        {
            p = FermaTest();
            q = FermaTest();
            int t = GetUintLength(p);
            int y = GetUintLength(q);
            if (t > y)
            {
                while (t > y)
                {
                    q = FermaTest();
                    y = GetUintLength(q);

                }
            }
            if (y > t)
            {
                while (y > t)
                {
                    p = FermaTest();
                    t = GetUintLength(p);
                }
            }
        }

        // кнопка зашифровки
        private void Encode_Click(object sender, EventArgs e)
        {
            richTextBox_Cipher_Text.Clear();
            string text = richTextBox_Plain_Text.Text;
            byte[] CodingText = Encoding.Default.GetBytes(text);
            BigInteger exponent_to_cipher = l;
            BigInteger modulus = n;
            BigInteger[] number_text = new BigInteger[CodingText.Length];
            for (int i = 0; i < number_text.Length; i++)
            {
                number_text[i] = CodingText[i];
            }
            BigInteger[] number_Ciphertext = new BigInteger[number_text.Length];
            for (int i = 0; i < number_text.Length; i++)
            {
                number_Ciphertext[i] = BigInteger.ModPow(number_text[i], exponent_to_cipher, modulus);
            }
            cipher_text = new int[number_Ciphertext.Length];
            for (int i = 0; i < cipher_text.Length; i++)
            {
                cipher_text[i] = (int)number_Ciphertext[i];
            }

            for (int i = 0; i < cipher_text.Length; i++)
            {
                richTextBox_Cipher_Text.Text += " " + cipher_text[i]; ;
            }
            Decode.Enabled = true;
        }

        // кнопка расшифровки
        private void Decode_Click(object sender, EventArgs e)
        {
            richTextBox_Cipher_Text.Clear();
            BigInteger modulus = n;
            BigInteger exponent_to_encrypt = d;
            BigInteger[] number_encryptText = new BigInteger[cipher_text.Length];
            for (int i = 0; i < number_encryptText.Length; i++)
            {
                number_encryptText[i] = BigInteger.ModPow(cipher_text[i], exponent_to_encrypt, modulus);
            }
            byte[] encrypt_text = new byte[number_encryptText.Length];
            for (int i = 0; i < encrypt_text.Length; i++)
            {
                encrypt_text[i] = (byte)number_encryptText[i];
            }
            string New_Open_Text;
            New_Open_Text = Encoding.Default.GetString(encrypt_text);
            for (int i = 0; i < encrypt_text.Length; i++)
            {
                richTextBox_Cipher_Text.Text += New_Open_Text[i];
            }
        }

        // генерация закрытого и открытого ключей
        private void GeneratingKey_Click(object sender, EventArgs e)
        {
            // генерация чисел p и q
            GeneratePQ(out p, out q);        
            textBox_p.Text = p.ToString();
            textBox_q.Text = q.ToString();
            // модуль системы RSA
            n = p * q;                       
            textBox_n.Text = n.ToString();
            // значение функции Эйлера от модуля системы
            phi_n = (p - 1) * (q - 1);       
            textBox_phi.Text = phi_n.ToString();
            // Число e
            l = Generate_E(phi_n);      
            textBox_e.Text = l.ToString();
            // Число d
            d = invmod(l, phi_n);      
            textBox_d.Text = d.ToString();
            Encode.Enabled = true;
        }

        // кнопка загрузки открытого текста из файла
        private void Open_Of_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog read = new OpenFileDialog();
            if (read.ShowDialog() == DialogResult.OK)
            {
                string nameOpentext = read.FileName;
                richTextBox_Plain_Text.Clear();
                richTextBox_Plain_Text.Text = File.ReadAllText(nameOpentext);
            }
        }

        // кнопка выгрузки открытого текста из файла
        private void Open_In_Fail_Click(object sender, EventArgs e)
        {
            OpenFileDialog write = new OpenFileDialog();
            if (write.ShowDialog() == DialogResult.OK)
            {
                string nameOpentext = write.FileName;
                File.WriteAllText(nameOpentext, richTextBox_Plain_Text.Text);
            }
        }

        // кнопка загрузки закрытого текста в файл
        private void Close_Of_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog read = new OpenFileDialog();
            if (read.ShowDialog() == DialogResult.OK)
            {
                string nameCiphertext = read.FileName;
                richTextBox_Cipher_Text.Clear();
                richTextBox_Cipher_Text.Text = File.ReadAllText(nameCiphertext);
            }
        }

        // кнопка выгрузки закрытого текста из файла
        private void Close_In_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog write = new OpenFileDialog();
            if (write.ShowDialog() == DialogResult.OK)
            {
                string nameCiphertext = write.FileName;
                File.WriteAllText(nameCiphertext, richTextBox_Cipher_Text.Text);
            }
        }

        // кнопка копирования
        private void Copy_Click(object sender, EventArgs e)
        {
            richTextBox_Plain_Text.Text = richTextBox_Cipher_Text.Text;
        }
    }
}
