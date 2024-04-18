using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_akhir__part_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                string db = "peminatan";/*nama db*/
                SqlConnection conn = null;
                string strKoneksi = "Data Source = DESKTOP-JO96DR8\\RIZKI_RAMADAN;" +
                    "Initial Catalog = {0};" +
                    "User ID = sa; Password = indonesia";
                conn = new SqlConnection(string.Format(strKoneksi, db));
                conn.Open();
                Console.Clear();
                while (true) 
                {
                    try
                    {
                        Console.WriteLine("\nMENU");
                        Console.WriteLine("1. Data Barang ");
                        Console.WriteLine("2. Data Suplier/Distributor ");
                        Console.WriteLine("3. Data Padi/Beras ");
                        Console.WriteLine("4. Data Transaksi ");
                        Console.WriteLine("5. exit ");
                        Console.WriteLine("\n enter your choice (1-3): ");
                        char ch = Convert.ToChar(Console.ReadLine());
                        
                        switch (ch) 
                        {
                            /*Data Barang*/
                            case '1':
                                {
                                    Console.WriteLine("\nData Barang");
                                    Console.WriteLine("1. Melihat data barang");
                                    Console.WriteLine("2. Tambah data barang");
                                    Console.WriteLine("3. Hapus data barang");
                                    Console.WriteLine("4. Update data barang");
                                    Console.WriteLine("5. exit");
                                    Console.WriteLine("\n enter your choice (1-5): ");
                                    char chB = Convert.ToChar(Console.ReadLine());

                                    switch (chB)
                                    {
                                        case '1':
                                            Console.WriteLine("read data barang");
                                            break;
                                        case '2':
                                            Console.WriteLine("add data barang");
                                            break;
                                        case '3':
                                            Console.WriteLine("delete data barang");
                                            break;
                                        case '4':
                                            Console.WriteLine("update data barang");
                                            break;
                                        case '5':
                                            conn.Close();
                                            Console.Clear();
                                            Main(new string[0]);
                                            return;
                                        default:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\n invalid options");
                                            }
                                            break;
                                    }
                                }
                                break;
                            /* End Data Barang*/

                            /*Data Suplier/Distributor*/
                            case '2':
                                {
                                    Console.WriteLine("\nData Suplier/Distributor");
                                    Console.WriteLine("1. Melihat data Suplier/Distributor");
                                    Console.WriteLine("2. Tambah data Suplier/Distributor");
                                    Console.WriteLine("3. Hapus data Suplier/Distributor");
                                    Console.WriteLine("4. Update data Suplier/Distributor");
                                    Console.WriteLine("5. exit");
                                    Console.WriteLine("\n enter your choice (1-5): ");
                                    char chSD = Convert.ToChar(Console.ReadLine());

                                    switch (chSD)
                                    {
                                        case '1':
                                            Console.WriteLine("read data Suplier/Distributor");
                                            break;
                                        case '2':
                                            Console.WriteLine("add data Suplier/Distributor");
                                            break;
                                        case '3':
                                            Console.WriteLine("delete data Suplier/Distributor");
                                            break;
                                        case '4':
                                            Console.WriteLine("update data Suplier/Distributor");
                                            break;
                                        case '5':
                                            conn.Close();
                                            Console.Clear();
                                            Main(new string[0]);
                                            return;
                                        default:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\n invalid options");
                                            }
                                            break;
                                    }
                                }
                                break;
                            /*End Data Suplier/Distributor*/

                            /*Data Padi/Beras*/
                            case '3':
                                {
                                    Console.WriteLine("\nData Padi/Beras");
                                    Console.WriteLine("1. Melihat data Padi/Beras");
                                    Console.WriteLine("2. Tambah data Padi/Beras");
                                    Console.WriteLine("3. Hapus data Padi/Beras");
                                    Console.WriteLine("4. Update data Padi/Beras");
                                    Console.WriteLine("5. exit");
                                    Console.WriteLine("\n enter your choice (1-5): ");
                                    char chPB = Convert.ToChar(Console.ReadLine());

                                    switch (chPB)
                                    {
                                        case '1':
                                            Console.WriteLine("read data Padi/Beras");
                                            break;
                                        case '2':
                                            Console.WriteLine("add data Padi/Beras");
                                            break;
                                        case '3':
                                            Console.WriteLine("delete data Padi/Beras");
                                            break;
                                        case '4':
                                            Console.WriteLine("update data Padi/Beras");
                                            break;
                                        case '5':
                                            conn.Close();
                                            Console.Clear();
                                            Main(new string[0]);
                                            return;
                                        default:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\n invalid options");
                                            }
                                            break;
                                    }
                                }
                                break;
                            /*End Data Padi/Beras*/

                            /*Data Transaksi*/
                            case '4':
                                {
                                    Console.WriteLine("\nData Transaksi");
                                    Console.WriteLine("1. Melihat data Transaksi");
                                    Console.WriteLine("2. Tambah data Transaksi");
                                    Console.WriteLine("3. Hapus data Transaksi");
                                    Console.WriteLine("4. Update data Transaksi");
                                    Console.WriteLine("5. exit");
                                    Console.WriteLine("\n enter your choice (1-5): ");
                                    char chT = Convert.ToChar(Console.ReadLine());

                                    switch (chT)
                                    {
                                        case '1':
                                            Console.WriteLine("read data Transaksi");
                                            break;
                                        case '2':
                                            Console.WriteLine("add data Transaksi");
                                            break;
                                        case '3':
                                            Console.WriteLine("delete data Transaksi");
                                            break;
                                        case '4':
                                            Console.WriteLine("update data Transaksi");
                                            break;
                                        case '5':
                                            conn.Close();
                                            Console.Clear();
                                            Main(new string[0]);
                                            return;
                                        default:
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\n invalid options");
                                            }
                                            break;
                                    }
                                }
                                break;
                            /*End Data Transaksi*/

                            case '5':
                                conn.Close();
                                Console.Clear();
                                Main(new string[0]);
                                return;
                            default:
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n invalid options");
                                }
                                break;

                        }
                    }
                    catch {
                        Console.Clear();
                        Console.WriteLine("\n check for the value entered");
                    }
                }
            }
        }
        /*funtion*/

    }
}
